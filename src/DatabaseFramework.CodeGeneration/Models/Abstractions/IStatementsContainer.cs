namespace DatabaseFramework.CodeGeneration.Models.Abstractions;

internal interface IStatementsContainer
{
    [Required][ValidateObject] IReadOnlyCollection<ISqlStatementBase> Statements { get; }
}
