namespace DatabaseFramework.Domain.Abstractions;

public partial interface IDatabaseObject
{
    IDatabaseObjectBuilder ToBuilder();
}
