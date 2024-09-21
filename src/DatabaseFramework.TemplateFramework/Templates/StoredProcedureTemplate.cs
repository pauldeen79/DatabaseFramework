namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureTemplate : DatabaseObjectTemplateBase<StoredProcedureViewModel>
{
    protected override async Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        var result = await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false);
        if (!result.IsSuccessful())
        {
            return result;
        }

        builder.AppendLine(@$"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [{Model.Schema}].[{Model.Name}]");

        result = await RenderChildTemplatesByModel(Model.Parameters, builder, cancellationToken).ConfigureAwait(false);
        if (!result.IsSuccessful())
        {
            return result;
        }
        builder.AppendLine(@"AS
BEGIN");

        return (await RenderChildTemplatesByModel(Model.Statements, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                builder.AppendLine(@"END
GO");
            });
    }
}
