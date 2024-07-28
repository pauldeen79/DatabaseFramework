namespace DatabaseFramework.Domain;

public partial record StoredProcedure
{
    IDatabaseObjectBuilder IDatabaseObject.ToBuilder()
    {
        return ToBuilder();
    }
}
