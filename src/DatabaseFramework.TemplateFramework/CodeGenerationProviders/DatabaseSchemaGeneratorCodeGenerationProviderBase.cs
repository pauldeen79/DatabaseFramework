namespace DatabaseFramework.TemplateFramework.CodeGenerationProviders;

public abstract class DatabaseSchemaGeneratorCodeGenerationProviderBase : ICodeGenerationProvider
{
    public abstract string Path { get; }
    public abstract bool RecurseOnDeleteGeneratedFiles { get; }
    public abstract string LastGeneratedFilesFilename { get; }
    public abstract Encoding Encoding { get; }

    public Task<Result<object?>> CreateAdditionalParametersAsync(CancellationToken cancellationToken) => Task.FromResult(Result.Success(default(object?)));

    public Type GetGeneratorType() => typeof(DatabaseSchemaGenerator);

    public abstract Task<Result<IEnumerable<IDatabaseObject>>> GetModelAsync(CancellationToken cancellationToken);

    public abstract DatabaseSchemaGeneratorSettings Settings { get; }

    public async Task<Result<object?>> CreateModelAsync(CancellationToken cancellationToken)
    {
        var modelResult = await GetModelAsync(cancellationToken).ConfigureAwait(false);
        if (!modelResult.IsSuccessful())
        {
            return modelResult.TryCast<object?>();
        }
        return Result.Success<object?>(new DatabaseSchemaGeneratorViewModel
        {
            Model = modelResult.Value,
            Settings = Settings
            //Context is filled in base class, on the property setter of Context (propagated to Model)
        });
    }
}
