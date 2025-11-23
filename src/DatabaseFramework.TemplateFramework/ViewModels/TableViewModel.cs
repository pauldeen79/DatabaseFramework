namespace DatabaseFramework.TemplateFramework.ViewModels;

public class TableViewModel : DatabaseSchemaGeneratorViewModelBase<Table>, INameContainer
{
    public string Schema
        => Model.Schema.FormatAsDatabaseIdentifier();

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string FileGroupName
        => Model.FileGroupName.WhenNullOrEmpty("PRIMARY").FormatAsDatabaseIdentifier();

    public IReadOnlyCollection<TableField> Fields
        => Model.Fields;

    public IReadOnlyCollection<PrimaryKeyConstraint> PrimaryKeyConstraints
        => Model.PrimaryKeyConstraints;

    public IReadOnlyCollection<UniqueConstraint> UniqueConstraints
        => Model.UniqueConstraints;

    public IReadOnlyCollection<CheckConstraint> CheckConstraints
        => Model.CheckConstraints;

    public IReadOnlyCollection<Domain.Index> Indexes
        => Model.Indexes;

    public IReadOnlyCollection<DefaultValueConstraint> DefaultValueConstraints
        => Model.DefaultValueConstraints;

    public CodeGenerationHeaderModel CodeGenerationHeaders
        => new CodeGenerationHeaderModel(Model, Settings.CreateCodeGenerationHeader);

    public INameContainerBuilder ToBuilder()
        => Model.ToBuilder();
}
