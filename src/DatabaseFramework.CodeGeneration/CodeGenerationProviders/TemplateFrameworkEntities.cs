namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class TemplateFrameworkEntities : DatabaseFrameworkCSharpClassBase
{
    public TemplateFrameworkEntities(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken cancellationToken) => GetEntitiesAsync(GetTemplateFrameworkModelsAsync(), "DatabaseFramework.TemplateFramework");

    public override string Path => "DatabaseFramework.TemplateFramework";
}
