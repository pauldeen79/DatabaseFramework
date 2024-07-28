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
namespace DatabaseFramework.TemplateFramework.Builders
{
    public partial class DatabaseSchemaGeneratorSettingsBuilder : System.ComponentModel.INotifyPropertyChanged
    {
        private bool _recurseOnDeleteGeneratedFiles;

        private string _lastGeneratedFilesFilename;

        private System.Text.Encoding _encoding;

        private string _path;

        private System.Globalization.CultureInfo _cultureInfo;

        private bool _generateMultipleFiles;

        private bool _skipWhenFileExists;

        private bool _createCodeGenerationHeader;

        private string _filenameSuffix;

        public event System.ComponentModel.PropertyChangedEventHandler? PropertyChanged;

        public bool RecurseOnDeleteGeneratedFiles
        {
            get
            {
                return _recurseOnDeleteGeneratedFiles;
            }
            set
            {
                _recurseOnDeleteGeneratedFiles = value;
                HandlePropertyChanged(nameof(RecurseOnDeleteGeneratedFiles));
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        public string LastGeneratedFilesFilename
        {
            get
            {
                return _lastGeneratedFilesFilename;
            }
            set
            {
                _lastGeneratedFilesFilename = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(LastGeneratedFilesFilename));
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        public System.Text.Encoding Encoding
        {
            get
            {
                return _encoding;
            }
            set
            {
                _encoding = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(Encoding));
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(Path));
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute]
        public System.Globalization.CultureInfo CultureInfo
        {
            get
            {
                return _cultureInfo;
            }
            set
            {
                _cultureInfo = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(CultureInfo));
            }
        }

        public bool GenerateMultipleFiles
        {
            get
            {
                return _generateMultipleFiles;
            }
            set
            {
                _generateMultipleFiles = value;
                HandlePropertyChanged(nameof(GenerateMultipleFiles));
            }
        }

        public bool SkipWhenFileExists
        {
            get
            {
                return _skipWhenFileExists;
            }
            set
            {
                _skipWhenFileExists = value;
                HandlePropertyChanged(nameof(SkipWhenFileExists));
            }
        }

        public bool CreateCodeGenerationHeader
        {
            get
            {
                return _createCodeGenerationHeader;
            }
            set
            {
                _createCodeGenerationHeader = value;
                HandlePropertyChanged(nameof(CreateCodeGenerationHeader));
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
        public string FilenameSuffix
        {
            get
            {
                return _filenameSuffix;
            }
            set
            {
                _filenameSuffix = value ?? throw new System.ArgumentNullException(nameof(value));
                HandlePropertyChanged(nameof(FilenameSuffix));
            }
        }

        public DatabaseSchemaGeneratorSettingsBuilder(DatabaseFramework.TemplateFramework.DatabaseSchemaGeneratorSettings source)
        {
            if (source is null) throw new System.ArgumentNullException(nameof(source));
            _recurseOnDeleteGeneratedFiles = source.RecurseOnDeleteGeneratedFiles;
            _lastGeneratedFilesFilename = source.LastGeneratedFilesFilename;
            _encoding = source.Encoding;
            _path = source.Path;
            _cultureInfo = source.CultureInfo;
            _generateMultipleFiles = source.GenerateMultipleFiles;
            _skipWhenFileExists = source.SkipWhenFileExists;
            _createCodeGenerationHeader = source.CreateCodeGenerationHeader;
            _filenameSuffix = source.FilenameSuffix;
        }

        public DatabaseSchemaGeneratorSettingsBuilder()
        {
            _lastGeneratedFilesFilename = string.Empty;
            _encoding = default(System.Text.Encoding)!;
            _path = string.Empty;
            _cultureInfo = default(System.Globalization.CultureInfo)!;
            _filenameSuffix = string.Empty;
            SetDefaultValues();
        }

        public DatabaseFramework.TemplateFramework.DatabaseSchemaGeneratorSettings Build()
        {
            return new DatabaseFramework.TemplateFramework.DatabaseSchemaGeneratorSettings(RecurseOnDeleteGeneratedFiles, LastGeneratedFilesFilename, Encoding, Path, CultureInfo, GenerateMultipleFiles, SkipWhenFileExists, CreateCodeGenerationHeader, FilenameSuffix);
        }

        partial void SetDefaultValues();

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithRecurseOnDeleteGeneratedFiles(bool recurseOnDeleteGeneratedFiles = true)
        {
            RecurseOnDeleteGeneratedFiles = recurseOnDeleteGeneratedFiles;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithLastGeneratedFilesFilename(string lastGeneratedFilesFilename)
        {
            if (lastGeneratedFilesFilename is null) throw new System.ArgumentNullException(nameof(lastGeneratedFilesFilename));
            LastGeneratedFilesFilename = lastGeneratedFilesFilename;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithEncoding(System.Text.Encoding encoding)
        {
            if (encoding is null) throw new System.ArgumentNullException(nameof(encoding));
            Encoding = encoding;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithPath(string path)
        {
            if (path is null) throw new System.ArgumentNullException(nameof(path));
            Path = path;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithCultureInfo(System.Globalization.CultureInfo cultureInfo)
        {
            if (cultureInfo is null) throw new System.ArgumentNullException(nameof(cultureInfo));
            CultureInfo = cultureInfo;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithGenerateMultipleFiles(bool generateMultipleFiles = true)
        {
            GenerateMultipleFiles = generateMultipleFiles;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithSkipWhenFileExists(bool skipWhenFileExists = true)
        {
            SkipWhenFileExists = skipWhenFileExists;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithCreateCodeGenerationHeader(bool createCodeGenerationHeader = true)
        {
            CreateCodeGenerationHeader = createCodeGenerationHeader;
            return this;
        }

        public DatabaseFramework.TemplateFramework.Builders.DatabaseSchemaGeneratorSettingsBuilder WithFilenameSuffix(string filenameSuffix)
        {
            if (filenameSuffix is null) throw new System.ArgumentNullException(nameof(filenameSuffix));
            FilenameSuffix = filenameSuffix;
            return this;
        }

        protected void HandlePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
#nullable disable
