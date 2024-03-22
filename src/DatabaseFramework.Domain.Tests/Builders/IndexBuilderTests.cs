namespace DatabaseFramework.Domain.Tests.Builders;

public class IndexBuilderTests
{
    private IndexBuilder CreateSut() => new IndexBuilder();

    [Fact]
    public void Can_Validate_Recursively()
    {
        // Arrange
        var sut = CreateSut().AddFields(new IndexFieldBuilder());

        // Act
        var validationResults = new List<ValidationResult>();
        var success = sut.TryValidate(validationResults);

        // Assert
        success.Should().BeFalse();
        validationResults.Should().HaveCount(2); //both the validation errors in Index and IndexField
    }
}
