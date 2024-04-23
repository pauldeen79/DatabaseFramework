namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementEntities : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementEntities(ICsharpExpressionDumper csharpExpressionDumper, IPipeline<IConcreteTypeBuilder, BuilderContext> builderPipeline, IPipeline<IConcreteTypeBuilder, BuilderExtensionContext> builderExtensionPipeline, IPipeline<IConcreteTypeBuilder, EntityContext> entityPipeline, IPipeline<TypeBaseBuilder, ReflectionContext> reflectionPipeline, IPipeline<InterfaceBuilder, InterfaceContext> interfacePipeline) : base(csharpExpressionDumper, builderPipeline, builderExtensionPipeline, entityPipeline, reflectionPipeline, interfacePipeline)
    {
    }

    public override string Path => "DatabaseFramework.Domain/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override async Task<Class?> GetBaseClass() => await CreateBaseClass(typeof(ISqlStatementBase), "DatabaseFramework.Domain");

    public override async Task<IEnumerable<TypeBase>> GetModel()
        => await GetEntities(await GetOverrideModels(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.SqlStatements");
}
