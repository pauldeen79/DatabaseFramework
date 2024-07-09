namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class CoreBuilders : DatabaseFrameworkCSharpClassBase
{
    public CoreBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetBuilders(await GetCoreModels(), Constants.Namespaces.Builders, Constants.Namespaces.Entities);

    public override string Path => "DatabaseFramework.Domain/Builders";

    protected override bool CreateAsObservable => true;
}
