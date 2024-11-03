namespace DatabaseFramework.TemplateFramework.ViewModels;

public class DatabaseSchemaGeneratorViewModel : DatabaseSchemaGeneratorViewModelBase<IEnumerable<IDatabaseObject>>
{
    public IOrderedEnumerable<IGrouping<string, IDatabaseObject>> Schemas
        => GetModel().GroupBy(x => x.Schema).OrderBy(x => x.Key);

#pragma warning disable S2325 // Methods and properties that don't access instance data should be static
    public IEnumerable<INameContainer> GetDatabaseObjects(IEnumerable<INameContainer> objects)
#pragma warning restore S2325 // Methods and properties that don't access instance data should be static
        => objects.SelectMany(GetItemsWithForeignKeyConstraints).OrderBy(GetOrder).ThenBy(item => item.Name);

    private static IEnumerable<INameContainer> GetItemsWithForeignKeyConstraints(INameContainer item)
    {
        yield return item;

        if (item is Table table)
        {
            foreach (var fk in table.ForeignKeyConstraints)
            {
                yield return new ForeignKeyConstraintModel(fk, table);
            }
        }
    }

    private static int GetOrder(INameContainer item)
        => item switch
        {
            Table => 1,
            ForeignKeyConstraint => 2,
            StoredProcedure => 3,
            View => 4,
            _ => 99
        }; // note that this order is backwards compatible with ModelFramework.Database :-)
}
