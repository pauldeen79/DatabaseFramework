namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureParameterTemplate : DatabaseSchemaGeneratorBase<StoredProcedureParameterViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t@{Model.Name} ");

        return (await RenderChildTemplateByModel(Model.NonViewField, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                if (Model.HasDefaultValue)
                {
                    builder.Append($" = {Model.DefaultValue}");
                }

                if (!Model.IsLastParameter)
                {
                    builder.Append(",");
                }

                builder.AppendLine();
            });
    }
}
