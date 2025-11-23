namespace DatabaseFramework.TemplateFramework.ViewModels;

public class CodeGenerationHeaderViewModel : DatabaseSchemaGeneratorViewModelBase<CodeGenerationHeaderModel>
{
    public bool CreateCodeGenerationHeader
        => Model.CreateCodeGenerationHeader;

    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string? Schema
        => Model.Schema?.FormatAsDatabaseIdentifier();

    public string ObjectType
        => Model.ObjectType;
}
