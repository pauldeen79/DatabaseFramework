namespace DatabaseFramework.TemplateFramework.ViewModels;

public class UniqueConstraintViewModel : DatabaseSchemaGeneratorViewModelBase<UniqueConstraint>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string FileGroupName
        => Model.FileGroupName.WhenNullOrEmpty("PRIMARY").FormatAsDatabaseIdentifier();

    public IReadOnlyCollection<UniqueConstraintField> Fields
        => Model.Fields;
}
