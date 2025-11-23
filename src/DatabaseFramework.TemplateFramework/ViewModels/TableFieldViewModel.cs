namespace DatabaseFramework.TemplateFramework.ViewModels;

public class TableFieldViewModel : DatabaseSchemaGeneratorViewModelBase<TableField>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string Identity
        => Model.IsIdentity
            ? " IDENTITY(1, 1)"
            : string.Empty;

    public string NullOrNotNull
        => Model.IsRequired
            ? "NOT NULL"
            : "NULL";

    public bool HasCheckConstraints
        => Model.CheckConstraints.Count > 0;

    public bool IsLastTableField
        => Context.IsLastIteration
            ?? throw new InvalidOperationException("Can only render table fields as part of a table. There is no context with hierarchy.");

    public IReadOnlyCollection<CheckConstraint> CheckConstraints
        => Model.CheckConstraints;

    public NonViewFieldModel NonViewField
        => new NonViewFieldModel(Model);
}
