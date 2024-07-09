namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementBuilders : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override string Path => "DatabaseFramework.Domain/Builders/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override bool CreateAsObservable => true;
    protected override async Task<TypeBase?> GetBaseClass() => await CreateBaseClass(typeof(ISqlStatementBase), Constants.Namespaces.Entities);

    public override async Task<IEnumerable<TypeBase>> GetModel()
        => await GetBuilders(await GetOverrideModels(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.Builders.SqlStatements", "DatabaseFramework.Domain.SqlStatements");
}
