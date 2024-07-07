namespace DatabaseFramework.CodeGeneration.PipelineComponents;

public class DatabaseObjectBuilderComponentBuilder : IBuilderComponentBuilder
{
    public IPipelineComponent<BuilderContext> Build()
        => new DatabaseObjectBuilderComponent();
}

public class DatabaseObjectBuilderComponent : IPipelineComponent<BuilderContext>
{
    public Task<Result> Process(PipelineContext<BuilderContext> context, CancellationToken token)
    {
        context = context.IsNotNull(nameof(context));

        if (context.Request.SourceModel.Interfaces.Any(x => x.EndsWith(nameof(IDatabaseObject))))
        {
            context.Request.Builder.AddMethods(new MethodBuilder().WithName("Build").WithExplicitInterfaceName($"{nameof(IDatabaseObject)}Builder").WithReturnTypeName(nameof(IDatabaseObject)).AddStringCodeStatements("return Build();"));
        }

        return Task.FromResult(Result.Continue());
    }
}
