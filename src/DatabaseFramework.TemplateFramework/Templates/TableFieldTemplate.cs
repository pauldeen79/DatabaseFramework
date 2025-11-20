namespace DatabaseFramework.TemplateFramework.Templates;

public class TableFieldTemplate : DatabaseSchemaGeneratorBase<TableFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] ");

        return await (await RenderChildTemplateByModel(Model.NonViewField, builder, token).ConfigureAwait(false))
            .OnSuccessAsync(async () =>
            {
                builder.Append($"{Model.Identity} {Model.NullOrNotNull}");

                if (Model.HasCheckConstraints)
                {
                    builder.AppendLine();
                }

                return await (await RenderChildTemplatesByModel(Model.CheckConstraints, builder, token).ConfigureAwait(false))
                    .OnSuccessAsync(() =>
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
