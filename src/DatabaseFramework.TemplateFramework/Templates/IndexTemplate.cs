namespace DatabaseFramework.TemplateFramework.Templates;

public class IndexTemplate : DatabaseSchemaGeneratorBase<IndexViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"CREATE {Model.Unique}NONCLUSTERED INDEX [{Model.Name}] ON [{Model.Schema}].[{Model.TableEntityName}]");
        builder.AppendLine("(");

        return (await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                builder.AppendLine($") ON [{Model.FileGroupName}]");
                builder.AppendLine("GO");
            });
    }
}
