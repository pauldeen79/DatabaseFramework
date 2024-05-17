namespace DatabaseFramework.TemplateFramework.Templates;

public abstract class DatabaseObjectTemplateBase<T> : DatabaseSchemaGeneratorBase<T>, IMultipleContentBuilderTemplate, IStringBuilderTemplate
    where T : DatabaseSchemaGeneratorViewModelBase, INameContainer
{
    public async Task Render(IMultipleContentBuilder builder, CancellationToken cancellationToken)
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

        await RenderDatabaseObject(generationEnvironment.Builder, cancellationToken);
    }

    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        await RenderDatabaseObject(builder, cancellationToken);
    }

    protected abstract Task RenderDatabaseObject(StringBuilder builder, CancellationToken cancellationToken);
}
