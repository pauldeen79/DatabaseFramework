namespace DatabaseFramework.TemplateFramework.Templates.SqlStatements;

public class StringSqlStatementTemplate : DatabaseSchemaGeneratorBase<StringSqlStatementViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> RenderAsync(StringBuilder builder, CancellationToken token)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"    {Model.Statement}");

        return Task.FromResult(Result.Success());
    }
}
