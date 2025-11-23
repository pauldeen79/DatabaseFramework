namespace DatabaseFramework.TemplateFramework.ViewModels;

public abstract class DatabaseSchemaGeneratorViewModelBase : IDatabaseSchemaGeneratorSettingsContainer, IViewModel
{
    public DatabaseSchemaGeneratorSettings Settings { get; set; } = default!; // will always be injected in CreateModel (root viewmodel) or OnSetContext (child viewmodels) method

    protected DatabaseSchemaGeneratorSettings GetSettings()
    {
        Guard.IsNotNull(Settings);

        return Settings;
    }

    public string FilenamePrefix
        => string.IsNullOrEmpty(GetSettings().Path)
            ? string.Empty
            : $"{Settings.Path}{Path.DirectorySeparatorChar}";
}

public abstract class DatabaseSchemaGeneratorViewModelBase<TModel> : DatabaseSchemaGeneratorViewModelBase, IModelContainer<TModel>, ITemplateContextContainer
{
    public TModel Model { get; set; } = default!;
    public ITemplateContext Context { get; set; } = default!; // will always be injected in OnSetContext method

    protected object? GetParentModel() => Context?.ParentContext?.Model;
}
