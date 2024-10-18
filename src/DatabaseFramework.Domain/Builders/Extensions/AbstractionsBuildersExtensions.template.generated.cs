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
namespace DatabaseFramework.Domain.Builders.Extensions
{
    public static partial class CheckConstraintContainerBuilderExtensions
    {
        public static T AddCheckConstraints<T>(this T instance, System.Collections.Generic.IEnumerable<DatabaseFramework.Domain.Builders.CheckConstraintBuilder> checkConstraints)
            where T : DatabaseFramework.Domain.Builders.Abstractions.ICheckConstraintContainerBuilder
        {
            if (checkConstraints is null) throw new System.ArgumentNullException(nameof(checkConstraints));
            return instance.AddCheckConstraints<T>(checkConstraints.ToArray());
        }

        public static T AddCheckConstraints<T>(this T instance, params DatabaseFramework.Domain.Builders.CheckConstraintBuilder[] checkConstraints)
            where T : DatabaseFramework.Domain.Builders.Abstractions.ICheckConstraintContainerBuilder
        {
            if (checkConstraints is null) throw new System.ArgumentNullException(nameof(checkConstraints));
            foreach (var item in checkConstraints) instance.CheckConstraints.Add(item);
            return instance;
        }
    }
    public static partial class DatabaseObjectBuilderExtensions
    {
    }
    public static partial class FileGroupNameContainerBuilderExtensions
    {
        public static T WithFileGroupName<T>(this T instance, string fileGroupName)
            where T : DatabaseFramework.Domain.Builders.Abstractions.IFileGroupNameContainerBuilder
        {
            if (fileGroupName is null) throw new System.ArgumentNullException(nameof(fileGroupName));
            instance.FileGroupName = fileGroupName;
            return instance;
        }
    }
    public static partial class NameContainerBuilderExtensions
    {
        public static T WithName<T>(this T instance, string name)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INameContainerBuilder
        {
            if (name is null) throw new System.ArgumentNullException(nameof(name));
            instance.Name = name;
            return instance;
        }
    }
    public static partial class NonViewFieldBuilderExtensions
    {
        public static T WithType<T>(this T instance, DatabaseFramework.Domain.Domains.SqlFieldType type)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            instance.Type = type;
            return instance;
        }

        public static T WithNumericPrecision<T>(this T instance, System.Nullable<byte> numericPrecision)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            instance.NumericPrecision = numericPrecision;
            return instance;
        }

        public static T WithNumericScale<T>(this T instance, System.Nullable<byte> numericScale)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            instance.NumericScale = numericScale;
            return instance;
        }

        public static T WithStringLength<T>(this T instance, System.Nullable<int> stringLength)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            instance.StringLength = stringLength;
            return instance;
        }

        public static T WithStringCollation<T>(this T instance, string stringCollation)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            if (stringCollation is null) throw new System.ArgumentNullException(nameof(stringCollation));
            instance.StringCollation = stringCollation;
            return instance;
        }

        public static T WithIsStringMaxLength<T>(this T instance, System.Nullable<bool> isStringMaxLength)
            where T : DatabaseFramework.Domain.Builders.Abstractions.INonViewFieldBuilder
        {
            instance.IsStringMaxLength = isStringMaxLength;
            return instance;
        }
    }
    public static partial class SchemaContainerBuilderExtensions
    {
        public static T WithSchema<T>(this T instance, string schema)
            where T : DatabaseFramework.Domain.Builders.Abstractions.ISchemaContainerBuilder
        {
            if (schema is null) throw new System.ArgumentNullException(nameof(schema));
            instance.Schema = schema;
            return instance;
        }
    }
}
#nullable disable
