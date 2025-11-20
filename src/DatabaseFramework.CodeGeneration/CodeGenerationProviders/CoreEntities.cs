namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class CoreEntities : DatabaseFrameworkCSharpClassBase
{
    public CoreEntities(ICommandService commandService) : base(commandService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken token)
    => GetEntitiesAsync(GetCoreModelsAsync(), Constants.Namespaces.Entities);

    public override string Path => "DatabaseFramework.Domain";
}
