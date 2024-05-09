namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public abstract class DatabaseFrameworkCSharpClassBase : CsharpClassGeneratorPipelineCodeGenerationProviderBase
{
    protected DatabaseFrameworkCSharpClassBase(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override bool RecurseOnDeleteGeneratedFiles => false;
    public override string LastGeneratedFilesFilename => string.Empty;
    public override Encoding Encoding => Encoding.UTF8;

    protected override Type EntityCollectionType => typeof(IReadOnlyCollection<>);
    protected override Type EntityConcreteCollectionType => typeof(ReadOnlyValueCollection<>);
    protected override Type BuilderCollectionType => typeof(ObservableCollection<>);

    protected override string ProjectName => "DatabaseFramework";
    protected override string CoreNamespace => "DatabaseFramework.Domain";
    protected override bool CopyAttributes => true;
    protected override bool CopyInterfaces => true;
    protected override bool CreateRecord => true;
    protected override bool GenerateMultipleFiles => false;

    protected async Task<TypeBase[]> GetTemplateFrameworkModels()
        => await GetNonCoreModels($"{CodeGenerationRootNamespace}.Models.TemplateFramework");
}
