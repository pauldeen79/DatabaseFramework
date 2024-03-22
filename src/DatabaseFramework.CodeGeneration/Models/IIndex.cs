namespace DatabaseFramework.CodeGeneration.Models;

internal interface IIndex : INameContainer, IFileGroupNameContainer
{
    [Required][MinCount(1)][ValidateObject] IReadOnlyCollection<IIndexField> Fields { get; }
    bool Unique { get; }
}
