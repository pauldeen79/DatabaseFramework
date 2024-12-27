namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsBuildersExtensions : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsBuildersExtensions(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModel(CancellationToken cancellationToken) => GetBuilderExtensions(GetAbstractionsInterfaces(), "DatabaseFramework.Domain.Builders.Abstractions", "DatabaseFramework.Domain.Abstractions", "DatabaseFramework.Domain.Builders.Extensions");

    public override string Path => "DatabaseFramework.Domain/Builders/Extensions";

    protected override bool EnableEntityInheritance => true;
}
