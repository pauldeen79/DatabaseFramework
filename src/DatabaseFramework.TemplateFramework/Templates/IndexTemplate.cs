namespace DatabaseFramework.TemplateFramework.Templates;

public class IndexTemplate : DatabaseSchemaGeneratorBase<IndexViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"CREATE {Model.Unique}NONCLUSTERED INDEX [{Model.Name}] ON [{Model.Schema}].[{Model.TableEntityName}]");
        builder.AppendLine("(");

        await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine($") ON [{Model.FileGroupName}]");
        builder.AppendLine("GO");
    }
}
