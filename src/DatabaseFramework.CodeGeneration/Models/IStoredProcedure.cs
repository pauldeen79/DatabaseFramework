namespace DatabaseFramework.CodeGeneration.Models;

internal interface IStoredProcedure : IDatabaseObject, IStatementsContainer
{
    [Required][ValidateObject] IReadOnlyCollection<IStoredProcedureParameter> Parameters { get; }
}
