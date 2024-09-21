namespace DatabaseFramework.TemplateFramework.Templates;

public class TableFieldTemplate : DatabaseSchemaGeneratorBase<TableFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] ");
        
        var result = await RenderChildTemplateByModel(Model.NonViewField, builder, cancellationToken).ConfigureAwait(false);
        if (!result.IsSuccessful())
        {
            return result;
        }

        builder.Append($"{Model.Identity} {Model.NullOrNotNull}");

        if (Model.HasCheckConstraints)
        {
            builder.AppendLine();
        }

        return (await RenderChildTemplatesByModel(Model.CheckConstraints, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                if (!Model.IsLastTableField)
                {
                    builder.Append(",");
                }

                builder.AppendLine();
            });
    }
}
