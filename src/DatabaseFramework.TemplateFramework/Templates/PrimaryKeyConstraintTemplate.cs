namespace DatabaseFramework.TemplateFramework.Templates;

public class PrimaryKeyConstraintTemplate : DatabaseSchemaGeneratorBase<PrimaryKeyConstraintViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($" CONSTRAINT [{Model.Name}] PRIMARY KEY CLUSTERED");
        builder.AppendLine("(");
        return (await RenderChildTemplatesByModel(Model.Fields, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>  builder.AppendLine($") ON [{Model.FileGroupName}]"));
    }
}
