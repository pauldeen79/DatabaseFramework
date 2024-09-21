namespace DatabaseFramework.TemplateFramework.Templates;

public class UniqueConstraintFieldTemplate : DatabaseSchemaGeneratorBase<UniqueConstraintFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}]");

        if (!Model.IsLastUniqueConstraintField)
        {
            builder.Append(",");
        }

        builder.AppendLine();

        return Task.FromResult(Result.Success());
    }
}
