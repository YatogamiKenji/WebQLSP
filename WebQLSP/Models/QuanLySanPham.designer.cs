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

namespace WebQLSP.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLySanPham")]
	public partial class QuanLySanPhamDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTL(CTL instance);
    partial void UpdateCTL(CTL instance);
    partial void DeleteCTL(CTL instance);
    partial void InsertPD(PD instance);
    partial void UpdatePD(PD instance);
    partial void DeletePD(PD instance);
    #endregion
		
		public QuanLySanPhamDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLySanPhamDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CTL> CTLs
		{
			get
			{
				return this.GetTable<CTL>();
			}
		}
		
		public System.Data.Linq.Table<PD> PDs
		{
			get
			{
				return this.GetTable<PD>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTL")]
	public partial class CTL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CatalogCode;
		
		private string _CatalogName;
		
		private EntitySet<PD> _PDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCatalogCodeChanging(string value);
    partial void OnCatalogCodeChanged();
    partial void OnCatalogNameChanging(string value);
    partial void OnCatalogNameChanged();
    #endregion
		
		public CTL()
		{
			this._PDs = new EntitySet<PD>(new Action<PD>(this.attach_PDs), new Action<PD>(this.detach_PDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogCode", DbType="NVarChar(50)")]
		public string CatalogCode
		{
			get
			{
				return this._CatalogCode;
			}
			set
			{
				if ((this._CatalogCode != value))
				{
					this.OnCatalogCodeChanging(value);
					this.SendPropertyChanging();
					this._CatalogCode = value;
					this.SendPropertyChanged("CatalogCode");
					this.OnCatalogCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogName", DbType="NVarChar(250)")]
		public string CatalogName
		{
			get
			{
				return this._CatalogName;
			}
			set
			{
				if ((this._CatalogName != value))
				{
					this.OnCatalogNameChanging(value);
					this.SendPropertyChanging();
					this._CatalogName = value;
					this.SendPropertyChanged("CatalogName");
					this.OnCatalogNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTL_PD", Storage="_PDs", ThisKey="Id", OtherKey="CatalogID")]
		public EntitySet<PD> PDs
		{
			get
			{
				return this._PDs;
			}
			set
			{
				this._PDs.Assign(value);
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
		
		private void attach_PDs(PD entity)
		{
			this.SendPropertyChanging();
			entity.CTL = this;
		}
		
		private void detach_PDs(PD entity)
		{
			this.SendPropertyChanging();
			entity.CTL = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PD")]
	public partial class PD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _CatalogID;
		
		private string _ProductCode;
		
		private string _ProductName;
		
		private string _Picture;
		
		private System.Nullable<double> _UnitPrice;
		
		private EntityRef<CTL> _CTL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCatalogIDChanging(System.Nullable<int> value);
    partial void OnCatalogIDChanged();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    partial void OnUnitPriceChanging(System.Nullable<double> value);
    partial void OnUnitPriceChanged();
    #endregion
		
		public PD()
		{
			this._CTL = default(EntityRef<CTL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogID", DbType="Int")]
		public System.Nullable<int> CatalogID
		{
			get
			{
				return this._CatalogID;
			}
			set
			{
				if ((this._CatalogID != value))
				{
					if (this._CTL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCatalogIDChanging(value);
					this.SendPropertyChanging();
					this._CatalogID = value;
					this.SendPropertyChanged("CatalogID");
					this.OnCatalogIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="NVarChar(50)")]
		public string ProductCode
		{
			get
			{
				return this._ProductCode;
			}
			set
			{
				if ((this._ProductCode != value))
				{
					this.OnProductCodeChanging(value);
					this.SendPropertyChanging();
					this._ProductCode = value;
					this.SendPropertyChanged("ProductCode");
					this.OnProductCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(250)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="NVarChar(MAX)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Float")]
		public System.Nullable<double> UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CTL_PD", Storage="_CTL", ThisKey="CatalogID", OtherKey="Id", IsForeignKey=true)]
		public CTL CTL
		{
			get
			{
				return this._CTL.Entity;
			}
			set
			{
				CTL previousValue = this._CTL.Entity;
				if (((previousValue != value) 
							|| (this._CTL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CTL.Entity = null;
						previousValue.PDs.Remove(this);
					}
					this._CTL.Entity = value;
					if ((value != null))
					{
						value.PDs.Add(this);
						this._CatalogID = value.Id;
					}
					else
					{
						this._CatalogID = default(Nullable<int>);
					}
					this.SendPropertyChanged("CTL");
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
