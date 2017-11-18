﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RIFF.Framework.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RIFF")]
	public partial class RFFrameworkDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMirroredFile(MirroredFile instance);
    partial void UpdateMirroredFile(MirroredFile instance);
    partial void DeleteMirroredFile(MirroredFile instance);
    #endregion
		
		public RFFrameworkDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RFFrameworkDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RFFrameworkDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RFFrameworkDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MirroredFile> MirroredFiles
		{
			get
			{
				return this.GetTable<MirroredFile>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="RIFF.MirroredFile")]
	public partial class MirroredFile : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MirroredFileID;
		
		private string _SourceSite;
		
		private int _FileSize;
		
		private string _FileName;
		
		private string _SourcePath;
		
		private System.DateTime _ModifiedTime;
		
		private System.DateTime _ReceivedTime;
		
		private bool _IsExtracted;
		
		private string _MirrorPath;
		
		private string _NamedFileKey;
		
		private System.Nullable<bool> _Processed;
		
		private string _Message;
		
		private System.Nullable<System.DateTime> _ValueDate;
		
		private System.Nullable<int> _NumRows;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMirroredFileIDChanging(int value);
    partial void OnMirroredFileIDChanged();
    partial void OnSourceSiteChanging(string value);
    partial void OnSourceSiteChanged();
    partial void OnFileSizeChanging(int value);
    partial void OnFileSizeChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnSourcePathChanging(string value);
    partial void OnSourcePathChanged();
    partial void OnModifiedTimeChanging(System.DateTime value);
    partial void OnModifiedTimeChanged();
    partial void OnReceivedTimeChanging(System.DateTime value);
    partial void OnReceivedTimeChanged();
    partial void OnIsExtractedChanging(bool value);
    partial void OnIsExtractedChanged();
    partial void OnMirrorPathChanging(string value);
    partial void OnMirrorPathChanged();
    partial void OnNamedFileKeyChanging(string value);
    partial void OnNamedFileKeyChanged();
    partial void OnProcessedChanging(System.Nullable<bool> value);
    partial void OnProcessedChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    partial void OnValueDateChanging(System.Nullable<System.DateTime> value);
    partial void OnValueDateChanged();
    partial void OnNumRowsChanging(System.Nullable<int> value);
    partial void OnNumRowsChanged();
    #endregion
		
		public MirroredFile()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MirroredFileID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MirroredFileID
		{
			get
			{
				return this._MirroredFileID;
			}
			set
			{
				if ((this._MirroredFileID != value))
				{
					this.OnMirroredFileIDChanging(value);
					this.SendPropertyChanging();
					this._MirroredFileID = value;
					this.SendPropertyChanged("MirroredFileID");
					this.OnMirroredFileIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceSite", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SourceSite
		{
			get
			{
				return this._SourceSite;
			}
			set
			{
				if ((this._SourceSite != value))
				{
					this.OnSourceSiteChanging(value);
					this.SendPropertyChanging();
					this._SourceSite = value;
					this.SendPropertyChanged("SourceSite");
					this.OnSourceSiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileSize", DbType="Int NOT NULL")]
		public int FileSize
		{
			get
			{
				return this._FileSize;
			}
			set
			{
				if ((this._FileSize != value))
				{
					this.OnFileSizeChanging(value);
					this.SendPropertyChanging();
					this._FileSize = value;
					this.SendPropertyChanged("FileSize");
					this.OnFileSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourcePath", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string SourcePath
		{
			get
			{
				return this._SourcePath;
			}
			set
			{
				if ((this._SourcePath != value))
				{
					this.OnSourcePathChanging(value);
					this.SendPropertyChanging();
					this._SourcePath = value;
					this.SendPropertyChanged("SourcePath");
					this.OnSourcePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedTime", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedTime
		{
			get
			{
				return this._ModifiedTime;
			}
			set
			{
				if ((this._ModifiedTime != value))
				{
					this.OnModifiedTimeChanging(value);
					this.SendPropertyChanging();
					this._ModifiedTime = value;
					this.SendPropertyChanged("ModifiedTime");
					this.OnModifiedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceivedTime", DbType="DateTime NOT NULL")]
		public System.DateTime ReceivedTime
		{
			get
			{
				return this._ReceivedTime;
			}
			set
			{
				if ((this._ReceivedTime != value))
				{
					this.OnReceivedTimeChanging(value);
					this.SendPropertyChanging();
					this._ReceivedTime = value;
					this.SendPropertyChanged("ReceivedTime");
					this.OnReceivedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsExtracted", DbType="Bit NOT NULL")]
		public bool IsExtracted
		{
			get
			{
				return this._IsExtracted;
			}
			set
			{
				if ((this._IsExtracted != value))
				{
					this.OnIsExtractedChanging(value);
					this.SendPropertyChanging();
					this._IsExtracted = value;
					this.SendPropertyChanged("IsExtracted");
					this.OnIsExtractedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MirrorPath", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string MirrorPath
		{
			get
			{
				return this._MirrorPath;
			}
			set
			{
				if ((this._MirrorPath != value))
				{
					this.OnMirrorPathChanging(value);
					this.SendPropertyChanging();
					this._MirrorPath = value;
					this.SendPropertyChanged("MirrorPath");
					this.OnMirrorPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamedFileKey", DbType="VarChar(100)")]
		public string NamedFileKey
		{
			get
			{
				return this._NamedFileKey;
			}
			set
			{
				if ((this._NamedFileKey != value))
				{
					this.OnNamedFileKeyChanging(value);
					this.SendPropertyChanging();
					this._NamedFileKey = value;
					this.SendPropertyChanged("NamedFileKey");
					this.OnNamedFileKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Processed", DbType="Bit")]
		public System.Nullable<bool> Processed
		{
			get
			{
				return this._Processed;
			}
			set
			{
				if ((this._Processed != value))
				{
					this.OnProcessedChanging(value);
					this.SendPropertyChanging();
					this._Processed = value;
					this.SendPropertyChanged("Processed");
					this.OnProcessedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(100)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValueDate", DbType="Date")]
		public System.Nullable<System.DateTime> ValueDate
		{
			get
			{
				return this._ValueDate;
			}
			set
			{
				if ((this._ValueDate != value))
				{
					this.OnValueDateChanging(value);
					this.SendPropertyChanging();
					this._ValueDate = value;
					this.SendPropertyChanged("ValueDate");
					this.OnValueDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumRows", DbType="Int")]
		public System.Nullable<int> NumRows
		{
			get
			{
				return this._NumRows;
			}
			set
			{
				if ((this._NumRows != value))
				{
					this.OnNumRowsChanging(value);
					this.SendPropertyChanging();
					this._NumRows = value;
					this.SendPropertyChanged("NumRows");
					this.OnNumRowsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591