﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 8.0.6
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
namespace DatabaseFramework.Domain.Builders.Abstractions
{
    public interface ICheckConstraintContainerBuilder
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        [CrossCutting.Common.DataAnnotations.ValidateObjectAttribute]
        System.Collections.ObjectModel.ObservableCollection<DatabaseFramework.Domain.Builders.CheckConstraintBuilder> CheckConstraints
        {
            get;
            set;
        }
    }
    public interface IDatabaseObjectBuilder : DatabaseFramework.Domain.Builders.Abstractions.ISchemaContainerBuilder, DatabaseFramework.Domain.Builders.Abstractions.INameContainerBuilder
    {
        DatabaseFramework.Domain.Abstractions.IDatabaseObject Build();
    }
    public interface IFileGroupNameContainerBuilder
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        string FileGroupName
        {
            get;
            set;
        }
    }
    public interface INameContainerBuilder
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        string Name
        {
            get;
            set;
        }
    }
    public interface INonViewFieldBuilder : DatabaseFramework.Domain.Builders.Abstractions.INameContainerBuilder
    {
        DatabaseFramework.Domain.Domains.SqlFieldType Type
        {
            get;
            set;
        }

        System.Nullable<byte> NumericPrecision
        {
            get;
            set;
        }

        System.Nullable<byte> NumericScale
        {
            get;
            set;
        }

        System.Nullable<int> StringLength
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        string StringCollation
        {
            get;
            set;
        }

        System.Nullable<bool> IsStringMaxLength
        {
            get;
            set;
        }
    }
    public interface ISchemaContainerBuilder
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        [System.ComponentModel.DefaultValueAttribute(@"dbo")]
        string Schema
        {
            get;
            set;
        }
    }
}
#nullable disable
