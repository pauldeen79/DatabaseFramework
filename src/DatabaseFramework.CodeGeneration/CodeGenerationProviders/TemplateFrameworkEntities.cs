namespace DatabaseFramework.CodeGeneration.CodeGenerationProviders;

[ExcludeFromCodeCoverage]
public class TemplateFrameworkEntities : DatabaseFrameworkCSharpClassBase
{
    public TemplateFrameworkEntities(ICsharpExpressionDumper csharpExpressionDumper, IPipeline<IConcreteTypeBuilder, BuilderContext> builderPipeline, IPipeline<IConcreteTypeBuilder, BuilderExtensionContext> builderExtensionPipeline, IPipeline<IConcreteTypeBuilder, EntityContext> entityPipeline, IPipeline<TypeBaseBuilder, ReflectionContext> reflectionPipeline, IPipeline<InterfaceBuilder, InterfaceContext> interfacePipeline) : base(csharpExpressionDumper, builderPipeline, builderExtensionPipeline, entityPipeline, reflectionPipeline, interfacePipeline)
    {
    }

    public override IEnumerable<TypeBase> Model => GetEntities(GetTemplateFrameworkModels(), "DatabaseFramework.TemplateFramework");

    public override string Path => "DatabaseFramework.TemplateFramework";
}
