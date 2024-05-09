namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class TemplateFrameworkBuilders : DatabaseFrameworkCSharpClassBase
{
    public TemplateFrameworkBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetBuilders(await GetTemplateFrameworkModels(), "DatabaseFramework.TemplateFramework.Builders", "DatabaseFramework.TemplateFramework");

    public override string Path => "DatabaseFramework.TemplateFramework/Builders";

    protected override bool CreateAsObservable => true;
}
