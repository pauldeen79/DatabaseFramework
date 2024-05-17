namespace DatabaseFramework.TemplateFramework;

public sealed class DatabaseSchemaGenerator : DatabaseSchemaGeneratorBase<DatabaseSchemaGeneratorViewModel>, IMultipleContentBuilderTemplate, IStringBuilderTemplate
{
    public async Task Render(IMultipleContentBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);
        Guard.IsNotNull(Context);

        IGenerationEnvironment generationEnvironment = new MultipleContentBuilderEnvironment(builder);

        if (!Model.Settings.GenerateMultipleFiles)
        {
            // Generate a single generation environment, so we create only a single file in the multiple content builder environment.
            var singleStringBuilder = builder.AddContent(Context.DefaultFilename, Model.Settings.SkipWhenFileExists).Builder;
            generationEnvironment = new StringBuilderEnvironment(singleStringBuilder);
        }

        await RenderSchemaHierarchy(generationEnvironment, cancellationToken).ConfigureAwait(false);
    }

    public async Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        if (Model.Settings.GenerateMultipleFiles)
        {
            throw new NotSupportedException("Can't generate multiple files, because the generation environment has a single StringBuilder instance");
        }

        await RenderSchemaHierarchy(new StringBuilderEnvironment(builder), cancellationToken).ConfigureAwait(false);
    }

    private async Task RenderSchemaHierarchy(IGenerationEnvironment generationEnvironment, CancellationToken cancellationToken)
    {
        foreach (var schema in Model!.Schemas)
        {
            await RenderChildTemplatesByModel(Model.GetDatabaseObjects(schema), generationEnvironment, cancellationToken);
        }
    }}
