namespace DatabaseFramework.TemplateFramework.ViewModels;

public class PrimaryKeyConstraintViewModel : DatabaseSchemaGeneratorViewModelBase<PrimaryKeyConstraint>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string FileGroupName
        => Model.FileGroupName.WhenNullOrEmpty("PRIMARY").FormatAsDatabaseIdentifier();

    public IReadOnlyCollection<PrimaryKeyConstraintField> Fields
        => Model.Fields;
}
