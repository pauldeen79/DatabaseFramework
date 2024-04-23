namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsBuildersInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsBuildersInterfaces(ICsharpExpressionDumper csharpExpressionDumper, IPipeline<IConcreteTypeBuilder, BuilderContext> builderPipeline, IPipeline<IConcreteTypeBuilder, BuilderExtensionContext> builderExtensionPipeline, IPipeline<IConcreteTypeBuilder, EntityContext> entityPipeline, IPipeline<TypeBaseBuilder, ReflectionContext> reflectionPipeline, IPipeline<InterfaceBuilder, InterfaceContext> interfacePipeline) : base(csharpExpressionDumper, builderPipeline, builderExtensionPipeline, entityPipeline, reflectionPipeline, interfacePipeline)
    {
    }

    public override async Task<IEnumerable<TypeBase>> GetModel() => await GetBuilderInterfaces(await GetAbstractionsInterfaces(), "DatabaseFramework.Domain.Builders.Abstractions", "DatabaseFramework.Domain.Abstractions", "DatabaseFramework.Domain.Builders.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Builders/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
