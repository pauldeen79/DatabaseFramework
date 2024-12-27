namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsBuildersInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsBuildersInterfaces(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModel(CancellationToken cancellationToken) => GetBuilderInterfaces(GetAbstractionsInterfaces(), "DatabaseFramework.Domain.Builders.Abstractions", "DatabaseFramework.Domain.Abstractions", "DatabaseFramework.Domain.Builders.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Builders/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
