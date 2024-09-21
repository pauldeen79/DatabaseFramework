namespace DatabaseFramework.TemplateFramework.Templates;

public class ViewTemplate : DatabaseObjectTemplateBase<ViewViewModel>
{
    protected override async Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return (await RenderChildTemplateByModel(Model.CodeGenerationHeaders, builder, cancellationToken).ConfigureAwait(false))
            .OnSuccess(() =>
            {
                builder.AppendLine(@$"SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [{Model.Schema}].[{Model.Name}]
AS");

                builder.AppendLine(Model.Definition);
                builder.AppendLine("GO");
            });
    }
}
