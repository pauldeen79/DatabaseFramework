namespace DatabaseFramework.TemplateFramework.ViewModels;

public class StoredProcedureViewModel : DatabaseSchemaGeneratorViewModelBase<StoredProcedure>, INameContainer
{
    public string Schema
        => Model.Schema.FormatAsDatabaseIdentifier();

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public CodeGenerationHeaderModel CodeGenerationHeaders
        => new CodeGenerationHeaderModel(Model, Settings.CreateCodeGenerationHeader);

    public IReadOnlyCollection<StoredProcedureParameter> Parameters
        => Model.Parameters;

    public IReadOnlyCollection<SqlStatementBase> Statements
        => Model.Statements;

    public INameContainerBuilder ToBuilder()
        => Model.ToBuilder();
}
