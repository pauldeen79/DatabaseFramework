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

        public static implicit operator DatabaseFramework.Domain.SqlStatementBase(SqlStatementBaseBuilder<TBuilder, TEntity> entity)
        {
            return entity.BuildTyped();
        }
    }
}
#nullable disable
