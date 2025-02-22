namespace DatabaseFramework.Domain.Tests.Builders;

public class IndexBuilderTests
{
    private static IndexBuilder CreateSut() => new IndexBuilder();

    [Fact]
    public void Can_Validate_Recursively()
    {
        // Arrange
        var sut = CreateSut().AddFields(new IndexFieldBuilder());

        // Act
        var validationResults = new List<ValidationResult>();
        var success = sut.TryValidate(validationResults);

        // Assert
        success.ShouldBeFalse();
        validationResults.Count.ShouldBe(2); //both the validation errors in Index and IndexField
    }
}
