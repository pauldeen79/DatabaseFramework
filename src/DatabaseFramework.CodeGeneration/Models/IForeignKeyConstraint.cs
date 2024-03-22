namespace DatabaseFramework.CodeGeneration.Models;

internal interface IForeignKeyConstraint : INameContainer
{
    [Required][ValidateObject][MinCount(1)] IReadOnlyCollection<IForeignKeyConstraintField> LocalFields { get; }
    [Required][ValidateObject][MinCount(1)] IReadOnlyCollection<IForeignKeyConstraintField> ForeignFields { get; }
    [Required] string ForeignTableName { get; }
    [Required] CascadeAction CascadeUpdate { get; }
    [Required] CascadeAction CascadeDelete { get; }
}
