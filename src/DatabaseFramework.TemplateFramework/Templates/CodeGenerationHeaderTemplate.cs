namespace DatabaseFramework.TemplateFramework.Templates;

public sealed class CodeGenerationHeaderTemplate : DatabaseSchemaGeneratorBase<CodeGenerationHeaderViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        if (!Model.CreateCodeGenerationHeader)
        {
            return Task.FromResult(Result.Success());
        }

        if (Model.Schema is not null)
        {
            builder.AppendLine($"/****** Object:  {Model.ObjectType} [{Model.Schema}].[{Model.Name}] ******/");
        }
        else
        {
            builder.AppendLine($"/****** Object:  {Model.ObjectType} [{Model.Name}] ******/");
        }

        return Task.FromResult(Result.Success());
    }
}
