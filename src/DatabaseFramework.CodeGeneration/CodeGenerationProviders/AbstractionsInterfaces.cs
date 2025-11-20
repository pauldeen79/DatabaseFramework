namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsInterfaces(ICommandService commandService) : base(commandService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken token)
        => GetEntityInterfacesAsync(GetAbstractionsInterfacesAsync(), "DatabaseFramework.Domain", "DatabaseFramework.Domain.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
