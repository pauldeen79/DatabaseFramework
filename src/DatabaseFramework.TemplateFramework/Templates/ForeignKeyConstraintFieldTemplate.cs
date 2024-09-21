namespace DatabaseFramework.TemplateFramework.Templates;

public class ForeignKeyConstraintFieldTemplate : DatabaseSchemaGeneratorBase<ForeignKeyConstraintFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"[{Model.Name}]");

        if (!Model.IsLastForeignKeyConstraintField)
        {
            builder.Append(",");
        }

        return Task.FromResult(Result.Success());
    }
}
