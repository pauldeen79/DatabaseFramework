namespace DatabaseFramework.TemplateFramework.Templates;

public class PrimaryKeyConstraintFieldTemplate : DatabaseSchemaGeneratorBase<PrimaryKeyConstraintFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> RenderAsync(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] {Model.Direction}");

        if (!Model.IsLastPrimaryKeyConstraintField)
        {
            builder.Append(",");
        }

        builder.AppendLine();

        return Task.FromResult(Result.Success());
    }
}
