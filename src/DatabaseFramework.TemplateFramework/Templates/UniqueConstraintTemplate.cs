namespace DatabaseFramework.TemplateFramework.Templates;

public class UniqueConstraintTemplate : DatabaseSchemaGeneratorBase<UniqueConstraintViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine(@$" CONSTRAINT [{Model.Name}] UNIQUE NONCLUSTERED
(");

        return (await RenderChildTemplatesByModel(Model.Fields, builder, token).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                builder.AppendLine($") ON [{Model.FileGroupName}]");
            });
    }
}
