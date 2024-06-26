﻿namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsInterfaces(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetEntityInterfaces(await GetAbstractionsInterfaces(), "DatabaseFramework.Domain", "DatabaseFramework.Domain.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
