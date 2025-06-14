namespace DatabaseFramework.TemplateFramework.Templates;

public class TableFieldTemplate : DatabaseSchemaGeneratorBase<TableFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] ");

        return await (await RenderChildTemplateByModel(Model.NonViewField, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(async () =>
            {
                builder.Append($"{Model.Identity} {Model.NullOrNotNull}");

                if (Model.HasCheckConstraints)
                {
                    builder.AppendLine();
                }

                return await (await RenderChildTemplatesByModel(Model.CheckConstraints, builder, cancellationToken).ConfigureAwait(false))
                    .OnSuccess(() =>
                    {
                        if (!Model.IsLastTableField)
                        {
                            builder.Append(",");
                        }

                        builder.AppendLine();

                        return Task.FromResult(Result.Success());
                    }).ConfigureAwait(false);
            }).ConfigureAwait(false);
    }
}
