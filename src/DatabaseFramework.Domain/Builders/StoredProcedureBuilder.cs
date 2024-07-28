namespace DatabaseFramework.Domain.Builders;

public partial class StoredProcedureBuilder
{
    IDatabaseObject IDatabaseObjectBuilder.Build()
    {
        return Build();
    }
}
