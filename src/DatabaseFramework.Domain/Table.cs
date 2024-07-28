namespace DatabaseFramework.Domain;

public partial record Table
{
    IDatabaseObjectBuilder IDatabaseObject.ToBuilder()
    {
        return ToBuilder();
    }
}
