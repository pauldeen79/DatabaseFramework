﻿namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractEntities : DatabaseFrameworkCSharpClassBase
{
    public AbstractEntities(IPipelineService pipelineService) : base(pipelineService)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetEntities(await GetAbstractModels(), Constants.Namespaces.Entities);

    public override string Path => "DatabaseFramework.Domain";

    protected override bool AddNullChecks => false; // not needed for abstract entities, because each derived class will do its own validation

    protected override bool EnableEntityInheritance => true;
    protected override bool IsAbstract => true;
}
