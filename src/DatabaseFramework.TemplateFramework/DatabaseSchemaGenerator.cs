namespace DatabaseFramework.TemplateFramework;

public sealed class DatabaseSchemaGenerator : DatabaseSchemaGeneratorBase<DatabaseSchemaGeneratorViewModel>, IMultipleContentBuilderTemplate, IBuilderTemplate<StringBuilder>
{
    public async Task<Result> RenderAsync(IMultipleContentBuilder<StringBuilder> builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);
        Guard.IsNotNull(Context);

        IGenerationEnvironment generationEnvironment = new MultipleStringContentBuilderEnvironment(builder);

        if (!Model.Settings.GenerateMultipleFiles)
        {
            // Generate a single generation environment, so we create only a single file in the multiple content builder environment.
            var singleStringBuilder = builder.AddContent(Context.DefaultFilename, Model.Settings.SkipWhenFileExists).Builder;
            generationEnvironment = new StringBuilderEnvironment(singleStringBuilder);
        }

        return await RenderSchemaHierarchyAsync(generationEnvironment, token).ConfigureAwait(false);
    }

    public async Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        if (Model.Settings.GenerateMultipleFiles)
        {
            return Result.NotSupported("Can't generate multiple files, because the generation environment has a single StringBuilder instance");
        }

        return await RenderSchemaHierarchyAsync(new StringBuilderEnvironment(builder), token).ConfigureAwait(false);
    }

    private async Task<Result> RenderSchemaHierarchyAsync(IGenerationEnvironment generationEnvironment, CancellationToken token)
    {
        foreach (var schema in Model!.Schemas)
        {
            var result = await RenderChildTemplatesByModel(Model.GetDatabaseObjects(schema), generationEnvironment, token);
            if (!result.IsSuccessful())
            {
                return result;
            }
        }

        return Result.Success();
    }}
