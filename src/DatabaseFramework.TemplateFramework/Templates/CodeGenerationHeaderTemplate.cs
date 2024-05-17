namespace DatabaseFramework.TemplateFramework.Templates;

public sealed class CodeGenerationHeaderTemplate : DatabaseSchemaGeneratorBase<CodeGenerationHeaderViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        if (!Model.CreateCodeGenerationHeader)
        {
            return Task.CompletedTask;
        }

        if (Model.Schema is not null)
        {
            builder.AppendLine($"/****** Object:  {Model.ObjectType} [{Model.Schema}].[{Model.Name}] ******/");
        }
        else
        {
            builder.AppendLine($"/****** Object:  {Model.ObjectType} [{Model.Name}] ******/");
        }

        return Task.CompletedTask;
    }
}
