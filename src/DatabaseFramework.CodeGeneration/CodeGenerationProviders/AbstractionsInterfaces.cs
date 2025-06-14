namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsInterfaces(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken cancellationToken) => GetEntityInterfacesAsync(GetAbstractionsInterfacesAsync(), "DatabaseFramework.Domain", "DatabaseFramework.Domain.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
