namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementEntities : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementEntities(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override string Path => "DatabaseFramework.Domain/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override async Task<TypeBase?> GetBaseClass() => await CreateBaseClass(typeof(ISqlStatementBase), Constants.Namespaces.Entities);

    public override async Task<IEnumerable<TypeBase>> GetModel()
        => await GetEntities(await GetOverrideModels(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.SqlStatements");
}
