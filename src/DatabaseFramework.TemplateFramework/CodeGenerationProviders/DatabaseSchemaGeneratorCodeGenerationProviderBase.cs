namespace DatabaseFramework.TemplateFramework.CodeGenerationProviders;

public abstract class DatabaseSchemaGeneratorCodeGenerationProviderBase : ICodeGenerationProvider
{
    public abstract string Path { get; }
    public abstract bool RecurseOnDeleteGeneratedFiles { get; }
    public abstract string LastGeneratedFilesFilename { get; }
    public abstract Encoding Encoding { get; }

    public Task<object?> CreateAdditionalParameters() => Task.FromResult(default(object?));

    public Type GetGeneratorType() => typeof(DatabaseSchemaGenerator);

    public abstract Task<IEnumerable<IDatabaseObject>> GetModel();

    public abstract DatabaseSchemaGeneratorSettings Settings { get; }

    public async Task<object?> CreateModel()
        => new DatabaseSchemaGeneratorViewModel
        {
            Model = await GetModel(),
            Settings = Settings
            //Context is filled in base class, on the property setter of Context (propagated to Model)
        };
}
