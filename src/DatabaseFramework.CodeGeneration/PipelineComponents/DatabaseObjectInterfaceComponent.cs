namespace DatabaseFramework.CodeGeneration.PipelineComponents;

[ExcludeFromCodeCoverage]
public class DatabaseObjectInterfaceComponentBuilder : IInterfaceComponentBuilder
{
    public IPipelineComponent<InterfaceContext> Build()
        => new DatabaseOBjectInterfaceComponent();
}

[ExcludeFromCodeCoverage]
public class DatabaseOBjectInterfaceComponent : IPipelineComponent<InterfaceContext>
{
    public Task<Result> Process(PipelineContext<InterfaceContext> context, CancellationToken token)
    {
        context = context.IsNotNull(nameof(context));

        if (context.Request.SourceModel.Name == typeof(IDatabaseObject).WithoutInterfacePrefix())
        {
            context.Request.Builder.AddMethods
            (
                new MethodBuilder()
                    .WithName("ToBuilder")
                    .WithReturnTypeName($"{Constants.Namespaces.Builders}.Abstractions.IDatabaseObjectBuilder")
            );
        }

        if (context.Request.SourceModel.Name == $"{typeof(IDatabaseObject).WithoutInterfacePrefix()}Builder")
        {
            context.Request.Builder.AddMethods
            (
                new MethodBuilder()
                    .WithName("Build")
                    .WithReturnTypeName($"{Constants.Namespaces.Entities}.Abstractions.IDatabaseObject")
            );
        }

        return Task.FromResult(Result.Continue());
    }
}
