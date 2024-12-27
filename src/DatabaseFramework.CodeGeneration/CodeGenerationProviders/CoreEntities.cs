namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class CoreEntities : DatabaseFrameworkCSharpClassBase
{
    public CoreEntities(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModel(CancellationToken cancellationToken) => GetEntities(GetCoreModels(), Constants.Namespaces.Entities);

    public override string Path => "DatabaseFramework.Domain";
}
