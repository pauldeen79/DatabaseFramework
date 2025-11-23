namespace DatabaseFramework.TemplateFramework.ViewModels;

public class StoredProcedureParameterViewModel : DatabaseSchemaGeneratorViewModelBase<StoredProcedureParameter>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public bool HasDefaultValue
        => !string.IsNullOrEmpty(Model.DefaultValue);

    public string DefaultValue
        => Model.DefaultValue;

    public bool IsLastParameter
        => Context.IsLastIteration
            ?? throw new InvalidOperationException("Can only render stored procedure parameters as part of a stored procedure. There is no context with hierarchy.");

    public NonViewFieldModel NonViewField
        => new NonViewFieldModel(Model);
}
