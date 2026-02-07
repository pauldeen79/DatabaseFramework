namespace DatabaseFramework.CodeGeneration.Models;

internal interface ITrigger : IDatabaseObject, IStatementsContainer
{
    DatabaseOperation DatabaseOperation { get; }
    [Required] string TableName { get;}
}
