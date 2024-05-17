namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureParameterTemplate : DatabaseSchemaGeneratorBase<StoredProcedureParameterViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t@{Model.Name} ");

        await RenderChildTemplateByModel(Model.NonViewField, builder, cancellationToken).ConfigureAwait(false);

        if (Model.HasDefaultValue)
        {
            builder.Append($" = {Model.DefaultValue}");
        }

        if (!Model.IsLastParameter)
        {
            builder.Append(",");
        }

        builder.AppendLine();
    }
}
