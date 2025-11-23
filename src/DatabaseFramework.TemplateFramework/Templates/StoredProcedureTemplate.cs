namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureTemplate : DatabaseObjectTemplateBase<StoredProcedureViewModel>
{
    protected override async Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, token).ConfigureAwait(false))
            .OnSuccessAsync(async () =>
            {
                builder.AppendLine(@$"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [{Model.Schema}].[{Model.Name}]");

                return await (await RenderChildTemplatesByModel(Model.Parameters, builder, token).ConfigureAwait(false))
                    .OnSuccessAsync(async () =>
                    {
                        builder.AppendLine(@"AS
BEGIN");

                        return await (await RenderChildTemplatesByModel(Model.Statements, builder, token).ConfigureAwait(false))
                        .OnSuccessAsync(() =>
                        {
                            builder.AppendLine(@"END
GO");
                            return Task.FromResult(Result.Success());
                        }).ConfigureAwait(false);
                    }).ConfigureAwait(false);
            }).ConfigureAwait(false);
    }
}
