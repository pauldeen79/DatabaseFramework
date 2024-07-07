namespace DatabaseFramework.CodeGeneration.PipelineComponents;

public class DatabaseObjectInterfaceComponentBuilder : IInterfaceComponentBuilder
{
    public IPipelineComponent<InterfaceContext> Build()
        => new InterfaceSetPartialComponent();
}

public class InterfaceSetPartialComponent : IPipelineComponent<InterfaceContext>
{
    public Task<Result> Process(PipelineContext<InterfaceContext> context, CancellationToken token)
    {
        context = context.IsNotNull(nameof(context));

        context.Request.Builder.WithPartial();

        return Task.FromResult(Result.Continue());
    }
}
