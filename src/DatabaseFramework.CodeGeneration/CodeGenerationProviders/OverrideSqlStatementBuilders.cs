namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class OverrideSqlStatementBuilders : DatabaseFrameworkCSharpClassBase
{
    public OverrideSqlStatementBuilders(ICsharpExpressionDumper csharpExpressionDumper, IPipeline<IConcreteTypeBuilder, BuilderContext> builderPipeline, IPipeline<IConcreteTypeBuilder, BuilderExtensionContext> builderExtensionPipeline, IPipeline<IConcreteTypeBuilder, EntityContext> entityPipeline, IPipeline<TypeBaseBuilder, ReflectionContext> reflectionPipeline, IPipeline<InterfaceBuilder, InterfaceContext> interfacePipeline) : base(csharpExpressionDumper, builderPipeline, builderExtensionPipeline, entityPipeline, reflectionPipeline, interfacePipeline)
    {
    }

    public override string Path => "DatabaseFramework.Domain/Builders/SqlStatements";

    protected override bool EnableEntityInheritance => true;
    protected override bool CreateAsObservable => true;
    protected override async Task<Class?> GetBaseClass() => await CreateBaseClass(typeof(ISqlStatementBase), "DatabaseFramework.Domain");

    public override async Task<IEnumerable<TypeBase>> GetModel()
        => await GetBuilders(await GetOverrideModels(typeof(ISqlStatementBase)), "DatabaseFramework.Domain.Builders.SqlStatements", "DatabaseFramework.Domain.SqlStatements");
}
