namespace DatabaseFramework.Domain.Builders;

public partial class ViewBuilder
{
    IDatabaseObject IDatabaseObjectBuilder.Build()
    {
        return Build();
    }
}
