namespace DatabaseFramework.TemplateFramework.Templates;

public class ForeignKeyConstraintTemplate : DatabaseSchemaGeneratorBase<ForeignKeyConstraintViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(async () =>
            {
                builder.Append($"ALTER TABLE [{Model.Schema}].[{Model.TableEntityName}]  WITH CHECK ADD  CONSTRAINT [{Model.Name}] FOREIGN KEY(");

                return await (await RenderChildTemplatesByModel(Model.LocalFields, builder, cancellationToken).ConfigureAwait(false))
                    .OnSuccess(async () =>
                    {
                        builder.AppendLine(")");
                        builder.Append($"REFERENCES [{Model.Schema}].[{Model.ForeignTableName}] (");

                        return (await RenderChildTemplatesByModel(Model.ForeignFields, builder, cancellationToken).ConfigureAwait(false))
                            .OnSuccess(() =>
                            {
                                builder.AppendLine(")");
                                builder.AppendLine($"ON UPDATE {Model.CascadeUpdate}");
                                builder.AppendLine($"ON DELETE {Model.CascadeDelete}");
                                builder.AppendLine("GO");
                                builder.AppendLine($"ALTER TABLE [{Model.Schema}].[{Model.TableEntityName}] CHECK CONSTRAINT [{Model.Name}]");
                                builder.AppendLine("GO");
                            });
                    }).ConfigureAwait(false);
            }).ConfigureAwait(false);
    }
}
