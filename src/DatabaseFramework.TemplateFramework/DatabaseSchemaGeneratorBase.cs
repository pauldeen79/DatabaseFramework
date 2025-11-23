namespace DatabaseFramework.TemplateFramework;

public abstract class DatabaseSchemaGeneratorBase<TModel> : TemplateBase, IModelContainer<TModel>
    where TModel : IDatabaseSchemaGeneratorSettingsContainer
{
    protected override void OnSetContext(ITemplateContext value)
    {
        if (Model is ITemplateContextContainer container)
        {
            // Copy Context from template context to ViewModel
            container.Context = value;
        }

        if (Model is not null && Model.Settings is null)
        {
            // Copy Settings from template context to ViewModel
            Model.Settings = value.GetDatabaseSchemaGeneratorSettings()
                ?? throw new InvalidOperationException("Could not get Settings from context");
        }
    }

    public TModel Model { get; set; } = default!;

    protected async Task<Result> RenderChildTemplateByModel(object model, StringBuilder builder, CancellationToken token)
        => await RenderChildTemplateByModel(model, new StringBuilderEnvironment(builder), token).ConfigureAwait(false);

    protected async Task<Result> RenderChildTemplateByModel(object model, IGenerationEnvironment generationEnvironment, CancellationToken token)
    {
        Guard.IsNotNull(Context);
        return await Context.Engine.RenderChildTemplateAsync(model, generationEnvironment, Context, new TemplateByModelIdentifier(model), token).ConfigureAwait(false);
    }

    protected Task<Result> RenderChildTemplatesByModel(IEnumerable models, StringBuilder builder, CancellationToken token)
        => RenderChildTemplatesByModel(models, new StringBuilderEnvironment(builder), token);

    protected async Task<Result> RenderChildTemplatesByModel(IEnumerable models, IGenerationEnvironment generationEnvironment, CancellationToken token)
    {
        Guard.IsNotNull(Context);
        return await Context.Engine.RenderChildTemplatesAsync(models, generationEnvironment, Context, model => new TemplateByModelIdentifier(model), token).ConfigureAwait(false);
    }
}
