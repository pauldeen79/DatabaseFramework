namespace DatabaseFramework.Domain;

public partial record View
{
    IDatabaseObjectBuilder IDatabaseObject.ToBuilder()
    {
        return ToBuilder();
    }
}
