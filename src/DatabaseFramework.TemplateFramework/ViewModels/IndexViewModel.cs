namespace DatabaseFramework.TemplateFramework.ViewModels;

public class IndexViewModel : DatabaseSchemaGeneratorViewModelBase<Domain.Index>
{
    public string Unique
        => Model.Unique
            ? "UNIQUE "
            : string.Empty;

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string TableEntityName
        => (Context.GetModelFromContextByType<Table>() ?? throw new InvalidOperationException("Can only render indexes as part of a table. There is no context with a Table entity."))
            .Name.FormatAsDatabaseIdentifier();

    public string Schema
        => (Context.GetModelFromContextByType<Table>() ?? throw new InvalidOperationException("Can only render indexes as part of a table. There is no context with a Table entity."))
            .Schema.FormatAsDatabaseIdentifier();

    public string FileGroupName
        => Model.FileGroupName.WhenNullOrEmpty("PRIMARY").FormatAsDatabaseIdentifier();

    public IReadOnlyCollection<IndexField> Fields
        => Model.Fields;
}
