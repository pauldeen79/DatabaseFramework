namespace DatabaseFramework.TemplateFramework.Templates;

public class ForeignKeyConstraintTemplate : DatabaseSchemaGeneratorBase<ForeignKeyConstraintViewModel>, IStringBuilderTemplate
{
    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false);

        builder.Append($"ALTER TABLE [{Model.Schema}].[{Model.TableEntityName}]  WITH CHECK ADD  CONSTRAINT [{Model.Name}] FOREIGN KEY(");

        await RenderChildTemplatesByModel(Model.LocalFields, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine(")");
        builder.Append($"REFERENCES [{Model.Schema}].[{Model.ForeignTableName}] (");

        await RenderChildTemplatesByModel(Model.ForeignFields, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine(")");
        builder.AppendLine($"ON UPDATE {Model.CascadeUpdate}");
        builder.AppendLine($"ON DELETE {Model.CascadeDelete}");
        builder.AppendLine("GO");
        builder.AppendLine($"ALTER TABLE [{Model.Schema}].[{Model.TableEntityName}] CHECK CONSTRAINT [{Model.Name}]");
        builder.AppendLine("GO");
    }
}
