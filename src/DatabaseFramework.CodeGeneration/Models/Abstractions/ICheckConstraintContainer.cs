namespace DatabaseFramework.CodeGeneration.Models.Abstractions;

internal interface ICheckConstraintContainer
{
    [Required][ValidateObject] IReadOnlyCollection<ICheckConstraint> CheckConstraints { get; }
}
