namespace DatabaseFramework.TemplateFramework.Templates;

public class ForeignKeyConstraintFieldTemplate : DatabaseSchemaGeneratorBase<ForeignKeyConstraintFieldViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"[{Model.Name}]");

        if (!Model.IsLastForeignKeyConstraintField)
        {
            builder.Append(",");
        }

        return Task.CompletedTask;
    }
}
