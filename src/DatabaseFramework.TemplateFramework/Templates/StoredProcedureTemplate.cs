namespace DatabaseFramework.TemplateFramework.Templates;

public class StoredProcedureTemplate : DatabaseObjectTemplateBase<StoredProcedureViewModel>
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
CREATE PROCEDURE [{Model.Schema}].[{Model.Name}]");

        await RenderChildTemplatesByModel(Model.Parameters, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine(@"AS
BEGIN");
        
        await RenderChildTemplatesByModel(Model.Statements, builder, cancellationToken).ConfigureAwait(false);

        builder.AppendLine(@"END
GO");
    }
}
