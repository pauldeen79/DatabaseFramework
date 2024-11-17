﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 9.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable
namespace DatabaseFramework.Domain.Abstractions
{
    public partial interface ICheckConstraintContainer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        [CrossCutting.Common.DataAnnotations.ValidateObjectAttribute]
        System.Collections.Generic.IReadOnlyCollection<DatabaseFramework.Domain.CheckConstraint> CheckConstraints
        {
            get;
        }
    }
    public partial interface IDatabaseObject : DatabaseFramework.Domain.Abstractions.ISchemaContainer, DatabaseFramework.Domain.Abstractions.INameContainer
    {
        DatabaseFramework.Domain.Builders.Abstractions.IDatabaseObjectBuilder ToBuilder();
    }
    public partial interface IFileGroupNameContainer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        string FileGroupName
        {
            get;
        }
    }
    public partial interface INameContainer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        string Name
        {
            get;
        }
    }
    public partial interface INonViewField : DatabaseFramework.Domain.Abstractions.INameContainer
    {
        DatabaseFramework.Domain.Domains.SqlFieldType Type
        {
            get;
        }

        System.Nullable<byte> NumericPrecision
        {
            get;
        }

        System.Nullable<byte> NumericScale
        {
            get;
        }

        System.Nullable<int> StringLength
        {
            get;
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        string StringCollation
        {
            get;
        }

        System.Nullable<bool> IsStringMaxLength
        {
            get;
        }
    }
    public partial interface ISchemaContainer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        [System.ComponentModel.DefaultValueAttribute(@"dbo")]
        string Schema
        {
            get;
        }
    }
}
#nullable disable
