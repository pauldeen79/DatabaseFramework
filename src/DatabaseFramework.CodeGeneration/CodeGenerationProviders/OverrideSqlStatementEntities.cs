﻿namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementEntities : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementEntities(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override string Path => "DatabaseFramework.Domain/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override Task<Result<TypeBase>> GetBaseClass() => CreateBaseClass(typeof(ISqlStatementBase), Constants.Namespaces.Entities);

    public override Task<Result<IEnumerable<TypeBase>>> GetModel(CancellationToken cancellationToken)
        => GetEntities(GetOverrideModels(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.SqlStatements");
}
