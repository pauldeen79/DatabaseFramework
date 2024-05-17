namespace DatabaseFramework.TemplateFramework.Templates;

public class ViewTemplate : DatabaseObjectTemplateBase<ViewViewModel>
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
CREATE VIEW [{Model.Schema}].[{Model.Name}]
AS");

        builder.AppendLine(Model.Definition);
        builder.AppendLine("GO");
    }
}
