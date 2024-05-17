namespace DatabaseFramework.TemplateFramework.Templates;

public class DefaultValueConstraintTemplate : DatabaseSchemaGeneratorBase<DefaultValueConstraintViewModel>, IStringBuilderTemplate
{
    public Task Render(StringBuilder builder, CancellationToken cancellationToken)
    {
        Guard.IsNotNull(builder);
        Guard.IsNotNull(Model);

        builder.AppendLine($"ALTER TABLE [{Model.TableEntityName}] ADD CONSTRAINT [{Model.Name}] DEFAULT ({Model.DefaultValue}) FOR [{Model.FieldName}]");
        builder.AppendLine("GO");

        return Task.CompletedTask;
    }
}
