namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class CoreBuilders : DatabaseFrameworkCSharpClassBase
{
    public CoreBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken cancellationToken) => GetBuildersAsync(GetCoreModelsAsync(), Constants.Namespaces.Builders, Constants.Namespaces.Entities);

    public override string Path => "DatabaseFramework.Domain/Builders";

    protected override bool CreateAsObservable => true;
}
