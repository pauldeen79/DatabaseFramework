namespace DatabaseFramework.Domain.Builders;

public partial class TableBuilder
{
    IDatabaseObject IDatabaseObjectBuilder.Build()
    {
        return Build();
    }
}
