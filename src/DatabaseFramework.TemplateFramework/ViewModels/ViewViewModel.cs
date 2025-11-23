namespace DatabaseFramework.TemplateFramework.ViewModels;

public class ViewViewModel : DatabaseSchemaGeneratorViewModelBase<View>, INameContainer
{
    public string Schema
        => Model.Schema.FormatAsDatabaseIdentifier();

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string Definition
        => Model.Definition;

    public CodeGenerationHeaderModel CodeGenerationHeaders
        => new CodeGenerationHeaderModel(Model, Settings.CreateCodeGenerationHeader);

    public INameContainerBuilder ToBuilder()
        => Model.ToBuilder();
}
