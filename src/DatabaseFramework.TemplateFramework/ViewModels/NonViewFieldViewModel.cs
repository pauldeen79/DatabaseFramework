namespace DatabaseFramework.TemplateFramework.ViewModels;

public class NonViewFieldViewModel : DatabaseSchemaGeneratorViewModelBase<NonViewFieldModel>
{
    public string Type
        => Model.Value.Type.ToString().ToUpper(Settings.CultureInfo);

    public bool IsDatabaseStringType
        => Model.Value.Type.IsDatabaseStringType();

    public bool IsNumeric
    {
        get
        {
            var model = Model.Value;
            return model.NumericPrecision is not null
                || model.NumericScale is not null;
        }
    }

    public string? NumericPrecision
        => Model.Value.NumericPrecision?.ToString(Settings.CultureInfo);

    public string? NumericScale
        => Model.Value.NumericScale?.ToString(Settings.CultureInfo);

    public string StringLength
        => Model.Value.StringLength.GetValueOrDefault(32).ToString(Settings.CultureInfo);

    public bool HasStringCollation
        => !string.IsNullOrEmpty(Model.Value.StringCollation);

    public string StringCollation
        => Model.Value.StringCollation;

    public bool IsStringMaxLength
        => Model.Value.IsStringMaxLength.GetValueOrDefault();
}
