namespace DatabaseFramework.TemplateFramework.ViewModels;

public class CheckConstraintViewModel : DatabaseSchemaGeneratorViewModelBase<CheckConstraint>
{
    public string Name
        => Model.Name.FormatAsDatabaseIdentifier();

    public string Expression
        => Model.Expression;

    public bool IsLastCheckConstraint
        => Context.IsLastIteration
            ?? throw new InvalidOperationException("Can only render check constraints as part of a table. There is no context with hierarchy.");
}
