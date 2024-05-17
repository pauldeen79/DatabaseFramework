namespace DatabaseFramework.TemplateFramework.Templates;

public class TableFieldTemplate : DatabaseSchemaGeneratorBase<TableFieldViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] ");
        
        await RenderChildTemplateByModel(Model.NonViewField, builder, cancellationToken).ConfigureAwait(false);
        
        builder.Append($"{Model.Identity} {Model.NullOrNotNull}");

        if (Model.HasCheckConstraints)
        {
            builder.AppendLine();
        }

        await RenderChildTemplatesByModel(Model.CheckConstraints, builder, cancellationToken).ConfigureAwait(false);

        if (!Model.IsLastTableField)
        {
            builder.Append(",");
        }

        builder.AppendLine();
    }
}
