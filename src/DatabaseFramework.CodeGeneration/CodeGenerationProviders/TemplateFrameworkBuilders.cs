namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class TemplateFrameworkBuilders : DatabaseFrameworkCSharpClassBase
{
    public TemplateFrameworkBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override Task<Result<IEnumerable<TypeBase>>> GetModel(CancellationToken cancellationToken) => GetBuilders(GetTemplateFrameworkModels(), "DatabaseFramework.TemplateFramework.Builders", "DatabaseFramework.TemplateFramework");

    public override string Path => "DatabaseFramework.TemplateFramework/Builders";

    protected override bool CreateAsObservable => true;
}
