namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class AbstractionsInterfaces : DatabaseFrameworkCSharpClassBase
{
    public AbstractionsInterfaces(ICsharpExpressionDumper csharpExpressionDumper, IPipeline<IConcreteTypeBuilder, BuilderContext> builderPipeline, IPipeline<IConcreteTypeBuilder, BuilderExtensionContext> builderExtensionPipeline, IPipeline<IConcreteTypeBuilder, EntityContext> entityPipeline, IPipeline<TypeBaseBuilder, ReflectionContext> reflectionPipeline, IPipeline<InterfaceBuilder, InterfaceContext> interfacePipeline) : base(csharpExpressionDumper, builderPipeline, builderExtensionPipeline, entityPipeline, reflectionPipeline, interfacePipeline)
    {
    }

    public override IEnumerable<TypeBase> Model => GetEntityInterfaces(GetAbstractionsInterfaces(), "DatabaseFramework.Domain", "DatabaseFramework.Domain.Abstractions");

    public override string Path => "DatabaseFramework.Domain/Abstractions";

    protected override bool EnableEntityInheritance => true;
}
