namespace DatabaseFramework.CodeGeneration.PipelineComponents;

[ExcludeFromCodeCoverage]
public class DatabaseObjectEntityComponentBuilder : IEntityComponentBuilder
{
    public IPipelineComponent<EntityContext> Build()
        => new DatabaseObjectEntityComponent();
}

[ExcludeFromCodeCoverage]
public class DatabaseObjectEntityComponent : IPipelineComponent<EntityContext>
{
    public Task<Result> Process(PipelineContext<EntityContext> context, CancellationToken token)
    {
        context = context.IsNotNull(nameof(context));

        if (context.Request.SourceModel.Interfaces.Any(x => x.EndsWith(nameof(IDatabaseObject))))
        {
            context.Request.Builder.AddMethods(new MethodBuilder().WithName("ToBuilder").WithExplicitInterfaceName(nameof(IDatabaseObject)).WithReturnTypeName($"{nameof(IDatabaseObject)}Builder").AddStringCodeStatements("return ToBuilder();"));
        }

        return Task.FromResult(Result.Continue());
    }
}
