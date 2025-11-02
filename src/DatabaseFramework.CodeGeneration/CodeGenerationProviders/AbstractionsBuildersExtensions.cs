namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsBuildersExtensions : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsBuildersExtensions(ICommandService commandService) : base(commandService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken cancellationToken) => GetBuilderExtensionsAsync(GetAbstractionsInterfacesAsync(), "DatabaseFramework.Domain.Builders.Abstractions", "DatabaseFramework.Domain.Abstractions", "DatabaseFramework.Domain.Builders.Extensions");

    public override string Path => "DatabaseFramework.Domain/Builders/Extensions";

    protected override bool EnableEntityInheritance => true;
}
