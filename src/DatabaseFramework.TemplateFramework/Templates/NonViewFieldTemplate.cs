namespace DatabaseFramework.TemplateFramework.Templates;

public class NonViewFieldTemplate : DatabaseSchemaGeneratorBase<NonViewFieldViewModel>, IBuilderTemplate<StringBuilder>
{
    public Task<Result> Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.Append($"{Model.Type}");

        if (Model.IsDatabaseStringType)
        {
            builder.Append("(");

            if (Model.IsStringMaxLength)
            {
                builder.Append("max");
            }
            else
            {
                builder.Append(Model.StringLength);
            }

            builder.Append(")");

            if (Model.HasStringCollation)
            {
                builder.Append($" COLLATE {Model.StringCollation}");
            }
        }
        else if (Model.IsNumeric)
        {
            builder.Append($"({Model.NumericPrecision},{Model.NumericScale})");
        }

        return Task.FromResult(Result.Success());
    }
}
