namespace DatabaseFramework.TemplateFramework.Templates.SqlStatements;

public class StringSqlStatementTemplate : DatabaseSchemaGeneratorBase<StringSqlStatementViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"    {Model.Statement}");

        return Task.FromResult(Result.Success());
    }
}
