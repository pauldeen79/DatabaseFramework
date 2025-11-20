namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class TemplateFrameworkEntities : DatabaseFrameworkCSharpClassBase
{
    public TemplateFrameworkEntities(ICommandService commandService) : base(commandService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken token)
        => GetEntitiesAsync(GetTemplateFrameworkModelsAsync(), "DatabaseFramework.TemplateFramework");

    public override string Path => "DatabaseFramework.TemplateFramework";
}
