namespace DatabaseFramework.Domain.Tests;

public class TableTests
{
    [Fact]
    public void Cannot_Construct_Without_Any_Fields()
    {
        // Arrange
        var tableBuilder = new TableBuilder().WithName("MyTable");

        // Act & Assert
        Action a = () => tableBuilder.Build();
        a.ShouldThrow<ValidationException>()
         .Message.ShouldBe("The field Fields must be a collection type with a minimum length of '1'.");
    }

    [Fact]
    public void Can_Construct()
    {
        // Arrange
        var builder = new TableBuilder()
            .WithName("MyTable")
            .AddFields(new TableFieldBuilder().WithName("MyField").WithType(SqlFieldType.VarChar).WithStringLength(32));

        // Act
        var table = builder.Build();

        // Asert
        table.Name.ShouldBe("MyTable");
    }
}
