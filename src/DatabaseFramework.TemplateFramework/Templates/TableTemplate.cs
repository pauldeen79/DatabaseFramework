namespace DatabaseFramework.TemplateFramework.Templates;

public sealed class TableTemplate : DatabaseObjectTemplateBase<TableViewModel>
{
    protected override async Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccessAsync(async () =>
            {
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

                return await (await RenderChildTemplatesByModel(fieldsAndPrimaryKeyConstraints, builder, cancellationToken).ConfigureAwait(false))
                    .OnSuccessAsync(async () =>
                    {
                        builder.AppendLine(@$") ON [{Model.FileGroupName}]
GO
SET ANSI_PADDING OFF
GO");

                        return await (await RenderChildTemplatesByModel(Model.Indexes, builder, cancellationToken).ConfigureAwait(false))
                            .OnSuccessAsync(async () =>
                            {
                                return await RenderChildTemplatesByModel(Model.DefaultValueConstraints, builder, cancellationToken).ConfigureAwait(false);
                            }).ConfigureAwait(false);
                    }).ConfigureAwait(false);
            }).ConfigureAwait(false);
    }
}
