This project is a model for database objects like tables, views and stored procedures.

It can be used to generate DDL from a model.

For example:
```C#
new TableBuilder()
    .WithName("MyTable")
    .AddFields(new TableFieldBuilder().WithName("MyField").WithType(SqlFieldType.VarChar).WithStringLength(32))
    .Build()
```

You can then use the templates or code generation providers to convert this into DDL files. (either one file per object, or one file with all objects.
