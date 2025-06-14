﻿namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementBuilders : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementBuilders(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override string Path => "DatabaseFramework.Domain/Builders/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override bool CreateAsObservable => true;
    protected override Task<Result<TypeBase>> GetBaseClassAsync() => CreateBaseClassAsync(typeof(ISqlStatementBase), Constants.Namespaces.Entities);

    public override Task<Result<IEnumerable<TypeBase>>> GetModelAsync(CancellationToken cancellationToken)
        => GetBuildersAsync(GetOverrideModelsAsync(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.Builders.SqlStatements", "DatabaseFramework.Domain.SqlStatements");
}
