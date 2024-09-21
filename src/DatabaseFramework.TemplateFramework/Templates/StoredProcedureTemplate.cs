namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureTemplate : DatabaseObjectTemplateBase<StoredProcedureViewModel>
{
    protected override async Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(async () =>
            {
                builder.AppendLine(@$"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [{Model.Schema}].[{Model.Name}]");

                return await (await RenderChildTemplatesByModel(Model.Parameters, builder, cancellationToken).ConfigureAwait(false))
                    .OnSuccess(async () =>
                    {
                        builder.AppendLine(@"AS
BEGIN");

                        return await (await RenderChildTemplatesByModel(Model.Statements, builder, cancellationToken).ConfigureAwait(false))
                        .OnSuccess(() =>
                        {
                            builder.AppendLine(@"END
GO");
                            return Task.FromResult(Result.Success());
                        }).ConfigureAwait(false);
                    }).ConfigureAwait(false);
            }).ConfigureAwait(false);
    }
}
