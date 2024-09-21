namespace DatabaseFramework.TemplateFramework.Templates;

public class UniqueConstraintTemplate : DatabaseSchemaGeneratorBase<UniqueConstraintViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine(@$" CONSTRAINT [{Model.Name}] UNIQUE NONCLUSTERED
(");

        return (await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                builder.AppendLine($") ON [{Model.FileGroupName}]");
            });
    }
}
