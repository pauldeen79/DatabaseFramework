namespace DatabaseFramework.TemplateFramework.ViewModels;

public class TriggerViewModel : DatabaseSchemaGeneratorViewModelBase<Trigger>, INameContainer
{
    public string Schema
        => Model.Schema.FormatAsDatabaseIdentifier();

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string TableName
        => Model.TableName.FormatAsDatabaseIdentifier();

    public CodeGenerationHeaderModel CodeGenerationHeaders
        => new CodeGenerationHeaderModel(Model, Settings.CreateCodeGenerationHeader);

    public string DatabaseOperation
        => Model.DatabaseOperation.ToString().ToUpperInvariant();

    public IReadOnlyCollection<SqlStatementBase> Statements
        => Model.Statements;

    public INameContainerBuilder ToBuilder()
        => Model.ToBuilder();
}
