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
namespace DatabaseFramework.Domain.SqlStatements
{
    public partial record StringSqlStatement : DatabaseFramework.Domain.SqlStatementBase
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        public string Statement
        {
            get;
        }

        public StringSqlStatement(string statement) : base()
        {
            this.Statement = statement;
            System.ComponentModel.DataAnnotations.Validator.ValidateObject(this, new System.ComponentModel.DataAnnotations.ValidationContext(this, null, null), true);
        }

        public override DatabaseFramework.Domain.Builders.SqlStatementBaseBuilder ToBuilder()
        {
            return ToTypedBuilder();
        }

        public DatabaseFramework.Domain.Builders.SqlStatements.StringSqlStatementBuilder ToTypedBuilder()
        {
            return new DatabaseFramework.Domain.Builders.SqlStatements.StringSqlStatementBuilder(this);
        }
    }
}
#nullable disable
