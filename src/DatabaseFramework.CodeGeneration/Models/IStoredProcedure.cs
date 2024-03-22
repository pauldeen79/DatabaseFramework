namespace DatabaseFramework.CodeGeneration.Models;

internal interface IStoredProcedure : IDatabaseObject
{
    [Required][ValidateObject] IReadOnlyCollection<ISqlStatementBase> Statements { get; }
    [Required][ValidateObject] IReadOnlyCollection<IStoredProcedureParameter> Parameters { get; }
}
