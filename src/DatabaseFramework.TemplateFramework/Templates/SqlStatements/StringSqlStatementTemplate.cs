namespace DatabaseFramework.TemplateFramework.Templates.SqlStatements;

public class StringSqlStatementTemplate : DatabaseSchemaGeneratorBase<StringSqlStatementViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"    {Model.Statement}");

        return Task.CompletedTask;
    }
}
