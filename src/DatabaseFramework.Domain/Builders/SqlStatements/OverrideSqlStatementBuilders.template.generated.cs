﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 9.0.6
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable
namespace DatabaseFramework.Domain.Builders.SqlStatements
{
    public partial class StringSqlStatementBuilder : SqlStatementBaseBuilder<StringSqlStatementBuilder, DatabaseFramework.Domain.SqlStatements.StringSqlStatement>
    {
        private string _statement;

        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        public string Statement
        {
            get
            {
                return _statement;
            }
            set
            {
                bool hasChanged = !System.Collections.Generic.EqualityComparer<System.String>.Default.Equals(_statement!, value!);
                _statement = value ?? throw new System.ArgumentNullException(nameof(value));
                if (hasChanged) HandlePropertyChanged(nameof(Statement));
            }
        }

        public StringSqlStatementBuilder(DatabaseFramework.Domain.SqlStatements.StringSqlStatement source) : base(source)
        {
            if (source is null) throw new System.ArgumentNullException(nameof(source));
            _statement = source.Statement;
        }

        public StringSqlStatementBuilder() : base()
        {
            _statement = string.Empty;
            SetDefaultValues();
        }

        public override DatabaseFramework.Domain.SqlStatements.StringSqlStatement BuildTyped()
        {
            return new DatabaseFramework.Domain.SqlStatements.StringSqlStatement(Statement);
        }

        partial void SetDefaultValues();

        public DatabaseFramework.Domain.Builders.SqlStatements.StringSqlStatementBuilder WithStatement(string statement)
        {
            if (statement is null) throw new System.ArgumentNullException(nameof(statement));
            Statement = statement;
            return this;
        }

        public static implicit operator DatabaseFramework.Domain.SqlStatements.StringSqlStatement(StringSqlStatementBuilder entity)
        {
            return entity.BuildTyped();
        }
    }
}
#nullable disable
