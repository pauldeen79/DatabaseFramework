namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class CoreBuilders : DatabaseFrameworkCSharpClassBase
{
    public CoreBuilders(IMediator mediator, ICsharpExpressionDumper csharpExpressionDumper) : base(mediator, csharpExpressionDumper)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetBuilders(await GetCoreModels(), "DatabaseFramework.Domain.Builders", "DatabaseFramework.Domain");

    public override string Path => "DatabaseFramework.Domain/Builders";

    protected override bool CreateAsObservable => true;
}
