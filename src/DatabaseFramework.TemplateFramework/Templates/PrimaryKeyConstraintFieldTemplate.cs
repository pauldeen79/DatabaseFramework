namespace DatabaseFramework.TemplateFramework.Templates;

public class PrimaryKeyConstraintFieldTemplate : DatabaseSchemaGeneratorBase<PrimaryKeyConstraintFieldViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] {Model.Direction}");

        if (!Model.IsLastPrimaryKeyConstraintField)
        {
            builder.Append(",");
        }

        builder.AppendLine();

        return Task.CompletedTask;
    }
}
