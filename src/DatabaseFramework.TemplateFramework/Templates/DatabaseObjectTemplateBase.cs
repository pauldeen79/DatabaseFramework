namespace DatabaseFramework.TemplateFramework.Templates;

public abstract class DatabaseObjectTemplateBase<T> : DatabaseSchemaGeneratorBase<T>, IMultipleContentBuilderTemplate, IBuilderTemplate<StringBuilder>
    where T : DatabaseSchemaGeneratorViewModelBase, INameContainer
{
    public async Task<Result> RenderAsync(IMultipleContentBuilder<StringBuilder> builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);
        Guard.IsNotNull(Context);

        StringBuilderEnvironment generationEnvironment;

        if (!Model.Settings.GenerateMultipleFiles)
        {
            if (!builder.Contents.Any())
            {
                builder.AddContent(Context.DefaultFilename, Model.Settings.SkipWhenFileExists);
            }

            generationEnvironment = new StringBuilderEnvironment(builder.Contents.Last().Builder);
        }
        else
        {
            var filename = $"{Model.FilenamePrefix}{Model.Name}{Model.Settings.FilenameSuffix}.cs";
            var contentBuilder = builder.AddContent(filename, Model.Settings.SkipWhenFileExists);
            generationEnvironment = new StringBuilderEnvironment(contentBuilder.Builder);
        }

        return await RenderDatabaseObject(generationEnvironment.Builder, cancellationToken);
    }

    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        return await RenderDatabaseObject(builder, cancellationToken);
    }

    protected abstract Task<Result> RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken);
}
