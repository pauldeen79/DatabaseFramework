namespace DatabaseFramework.TemplateFramework.Templates;

public class ForeignKeyConstraintTemplate : DatabaseSchemaGeneratorBase<ForeignKeyConstraintViewModel>, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, token).ConfigureAwait(false))
            .OnSuccessAsync(async () =>
            {
                builder.Append($"ALTER TABLE [{Model.Schema}].[{Model.TableEntityName}]  WITH CHECK ADD  CONSTRAINT [{Model.Name}] FOREIGN KEY(");

                return await (await RenderChildTemplatesByModel(Model.LocalFields, builder, token).ConfigureAwait(false))
                    .OnSuccessAsync(async () =>
                    {
                        builder.AppendLine(")");
                        builder.Append($"REFERENCES [{Model.Schema}].[{Model.ForeignTableName}] (");

                        return (await RenderChildTemplatesByModel(Model.ForeignFields, builder, token).ConfigureAwait(false))
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
