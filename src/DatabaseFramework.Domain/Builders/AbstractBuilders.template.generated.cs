﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 8.0.10
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
namespace DatabaseFramework.Domain.Builders
{
    public abstract partial class SqlStatementBaseBuilder<TBuilder, TEntity> : SqlStatementBaseBuilder
        where TEntity : DatabaseFramework.Domain.SqlStatementBase
        where TBuilder : SqlStatementBaseBuilder<TBuilder, TEntity>
    {
        protected SqlStatementBaseBuilder(DatabaseFramework.Domain.SqlStatementBase source) : base(source)
        {
        }

        protected SqlStatementBaseBuilder() : base()
        {
        }

        public override DatabaseFramework.Domain.SqlStatementBase Build()
        {
            return BuildTyped();
        }

        public abstract TEntity BuildTyped();
    }
}
#nullable disable
