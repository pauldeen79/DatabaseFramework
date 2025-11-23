namespace DatabaseFramework.TemplateFramework.ViewModels;

public class ForeignKeyConstraintViewModel : DatabaseSchemaGeneratorViewModelBase<ForeignKeyConstraintModel>
{
    public string Name
        => Model.ForeignKeyConstraint.Name.FormatAsDatabaseIdentifier();

    public string ForeignTableName
        => Model.ForeignKeyConstraint.ForeignTableName.FormatAsDatabaseIdentifier();

    public string CascadeUpdate
        => Model.ForeignKeyConstraint.CascadeUpdate.ToSql();

    public string CascadeDelete
        => Model.ForeignKeyConstraint.CascadeDelete.ToSql();

    public IReadOnlyCollection<ForeignKeyConstraintField> LocalFields
        => Model.ForeignKeyConstraint.LocalFields;

    public IReadOnlyCollection<ForeignKeyConstraintField> ForeignFields
        => Model.ForeignKeyConstraint.ForeignFields;

    public string TableEntityName
        => Model.Table.Name.FormatAsDatabaseIdentifier();

    public string Schema
        => Model.Table.Schema.FormatAsDatabaseIdentifier();

    public CodeGenerationHeaderModel CodeGenerationHeaders
        => new CodeGenerationHeaderModel(Model.ForeignKeyConstraint, Settings.CreateCodeGenerationHeader);
}
