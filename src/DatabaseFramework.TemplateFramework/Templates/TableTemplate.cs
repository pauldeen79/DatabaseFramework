namespace DatabaseFramework.TemplateFramework.Templates;

public sealed class TableTemplate : DatabaseObjectTemplateBase<TableViewModel>
{
    protected override async Task RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false);
        builder.AppendLine(@$"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [{Model.Schema}].[{Model.Name}](");

        var fieldsAndPrimaryKeyConstraints = Model.Fields.Cast<object>()
            .Concat(Model.PrimaryKeyConstraints.Cast<object>())
            .Concat(Model.UniqueConstraints.Cast<object>())
            .Concat(Model.CheckConstraints.Cast<object>());

        await RenderChildTemplatesByModel(fieldsAndPrimaryKeyConstraints, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine(@$") ON [{Model.FileGroupName}]
GO
SET ANSI_PADDING OFF
GO");

        await RenderChildTemplatesByModel(Model.Indexes, builder, cancellationToken).ConfigureAwait(false);
        await RenderChildTemplatesByModel(Model.DefaultValueConstraints, builder, cancellationToken).ConfigureAwait(false);
    }
}
