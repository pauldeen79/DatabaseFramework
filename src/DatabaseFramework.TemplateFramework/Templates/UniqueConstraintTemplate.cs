namespace DatabaseFramework.TemplateFramework.Templates;

public class UniqueConstraintTemplate : DatabaseSchemaGeneratorBase<UniqueConstraintViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine(@$" CONSTRAINT [{Model.Name}] UNIQUE NONCLUSTERED
(");

        await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine($") ON [{Model.FileGroupName}]");
    }
}
