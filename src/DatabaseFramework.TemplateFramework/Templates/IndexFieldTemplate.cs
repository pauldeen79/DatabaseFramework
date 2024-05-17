namespace DatabaseFramework.TemplateFramework.Templates;

public class IndexFieldTemplate : DatabaseSchemaGeneratorBase<IndexFieldViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] {Model.Direction}");

        if (!Model.IsLastIndexField)
        {
            builder.Append(",");
        }

        builder.AppendLine();

        return Task.CompletedTask;
    }
}
