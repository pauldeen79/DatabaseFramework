namespace DatabaseFramework.CodeGeneration.Models;

internal interface ITable : IDatabaseObject, IFileGroupNameContainer, ICheckConstraintContainer
{
    [Required][ValidateObject] IReadOnlyCollection<IPrimaryKeyConstraint> PrimaryKeyConstraints { get; }
    [Required][ValidateObject] IReadOnlyCollection<IUniqueConstraint> UniqueConstraints { get; }
    [Required][ValidateObject] IReadOnlyCollection<IDefaultValueConstraint> DefaultValueConstraints { get; }
    [Required][ValidateObject] IReadOnlyCollection<IForeignKeyConstraint> ForeignKeyConstraints { get; }
    [Required][ValidateObject] IReadOnlyCollection<IIndex> Indexes { get; }
    [Required][ValidateObject][MinCount(1)] IReadOnlyCollection<ITableField> Fields { get; }
}
