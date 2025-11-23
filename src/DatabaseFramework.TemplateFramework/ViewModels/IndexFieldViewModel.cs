namespace DatabaseFramework.TemplateFramework.ViewModels;

public class IndexFieldViewModel : DatabaseSchemaGeneratorViewModelBase<IndexField>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string Direction
        => Model.IsDescending
            ? "DESC"
            : "ASC";

    public bool IsLastIndexField
        => Context.IsLastIteration
            ?? throw new InvalidOperationException("Can only render index fields as part of an index. There is no context with hierarchy.");
}
