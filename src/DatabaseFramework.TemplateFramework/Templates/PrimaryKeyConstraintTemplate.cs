namespace DatabaseFramework.TemplateFramework.Templates;

public class PrimaryKeyConstraintTemplate : DatabaseSchemaGeneratorBase<PrimaryKeyConstraintViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($" CONSTRAINT [{Model.Name}] PRIMARY KEY CLUSTERED");
        builder.AppendLine("(");
        await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false);
        builder.AppendLine($") ON [{Model.FileGroupName}]");
    }
}
