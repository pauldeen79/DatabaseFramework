﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 8.0.7
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                _statement = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(Statement));
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
    }
}
#nullable disable
