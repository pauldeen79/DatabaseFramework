namespace DatabaseFramework.TemplateFramework.Templates;

public class IndexFieldTemplate : DatabaseSchemaGeneratorBase<IndexFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"\t[{Model.Name}] {Model.Direction}");

        if (!Model.IsLastIndexField)
        {
            builder.Append(",");
        }

        builder.AppendLine();

        return Task.FromResult(Result.Success());
    }
}
