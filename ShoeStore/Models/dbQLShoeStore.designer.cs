#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoeStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBANGIAY")]
	public partial class dbQLShoeStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void UpdateCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void DeleteCHITIETDONTHANG(CHITIETDONTHANG instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertGIAY(GIAY instance);
    partial void UpdateGIAY(GIAY instance);
    partial void DeleteGIAY(GIAY instance);
    partial void InsertHANGGIAY(HANGGIAY instance);
    partial void UpdateHANGGIAY(HANGGIAY instance);
    partial void DeleteHANGGIAY(HANGGIAY instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertLOAIGIAY(LOAIGIAY instance);
    partial void UpdateLOAIGIAY(LOAIGIAY instance);
    partial void DeleteLOAIGIAY(LOAIGIAY instance);
    #endregion
		
		public dbQLShoeStoreDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBANGIAYConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLShoeStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLShoeStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLShoeStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLShoeStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHITIETDONTHANG> CHITIETDONTHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONTHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<GIAY> GIAYs
		{
			get
			{
				return this.GetTable<GIAY>();
			}
		}
		
		public System.Data.Linq.Table<HANGGIAY> HANGGIAYs
		{
			get
			{
				return this.GetTable<HANGGIAY>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAIGIAY> LOAIGIAYs
		{
			get
			{
				return this.GetTable<LOAIGIAY>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONTHANG")]
	public partial class CHITIETDONTHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private int _Magiay;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnMagiayChanging(int value);
    partial void OnMagiayChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDongiaChanging(System.Nullable<decimal> value);
    partial void OnDongiaChanged();
    #endregion
		
		public CHITIETDONTHANG()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magiay", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Magiay
		{
			get
			{
				return this._Magiay;
			}
			set
			{
				if ((this._Magiay != value))
				{
					this.OnMagiayChanging(value);
					this.SendPropertyChanging();
					this._Magiay = value;
					this.SendPropertyChanged("Magiay");
					this.OnMagiayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongia
		{
			get
			{
				return this._Dongia;
			}
			set
			{
				if ((this._Dongia != value))
				{
					this.OnDongiaChanging(value);
					this.SendPropertyChanging();
					this._Dongia = value;
					this.SendPropertyChanged("Dongia");
					this.OnDongiaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<bool> _Dathanhtoan;
		
		private System.Nullable<bool> _Tinhtranggiaohang;
		
		private System.Nullable<System.DateTime> _Ngaydat;
		
		private System.Nullable<System.DateTime> _Ngaygiao;
		
		private System.Nullable<int> _MaKH;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnDathanhtoanChanging(System.Nullable<bool> value);
    partial void OnDathanhtoanChanged();
    partial void OnTinhtranggiaohangChanging(System.Nullable<bool> value);
    partial void OnTinhtranggiaohangChanged();
    partial void OnNgaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaydatChanged();
    partial void OnNgaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaoChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dathanhtoan", DbType="Bit")]
		public System.Nullable<bool> Dathanhtoan
		{
			get
			{
				return this._Dathanhtoan;
			}
			set
			{
				if ((this._Dathanhtoan != value))
				{
					this.OnDathanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Dathanhtoan = value;
					this.SendPropertyChanged("Dathanhtoan");
					this.OnDathanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinhtranggiaohang", DbType="Bit")]
		public System.Nullable<bool> Tinhtranggiaohang
		{
			get
			{
				return this._Tinhtranggiaohang;
			}
			set
			{
				if ((this._Tinhtranggiaohang != value))
				{
					this.OnTinhtranggiaohangChanging(value);
					this.SendPropertyChanging();
					this._Tinhtranggiaohang = value;
					this.SendPropertyChanged("Tinhtranggiaohang");
					this.OnTinhtranggiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaydat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaydat
		{
			get
			{
				return this._Ngaydat;
			}
			set
			{
				if ((this._Ngaydat != value))
				{
					this.OnNgaydatChanging(value);
					this.SendPropertyChanging();
					this._Ngaydat = value;
					this.SendPropertyChanged("Ngaydat");
					this.OnNgaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaygiao
		{
			get
			{
				return this._Ngaygiao;
			}
			set
			{
				if ((this._Ngaygiao != value))
				{
					this.OnNgaygiaoChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiao = value;
					this.SendPropertyChanged("Ngaygiao");
					this.OnNgaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GIAY")]
	public partial class GIAY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Magiay;
		
		private string _Tengiay;
		
		private System.Nullable<decimal> _Giaban;
		
		private string _Mota;
		
		private string _Anhbia;
		
		private System.Nullable<System.DateTime> _Ngaycapnhat;
		
		private System.Nullable<int> _Soluongton;
		
		private System.Nullable<int> _MaLG;
		
		private System.Nullable<int> _MaHG;
		
		private EntityRef<HANGGIAY> _HANGGIAY;
		
		private EntityRef<LOAIGIAY> _LOAIGIAY;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMagiayChanging(int value);
    partial void OnMagiayChanged();
    partial void OnTengiayChanging(string value);
    partial void OnTengiayChanged();
    partial void OnGiabanChanging(System.Nullable<decimal> value);
    partial void OnGiabanChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnAnhbiaChanging(string value);
    partial void OnAnhbiaChanged();
    partial void OnNgaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaycapnhatChanged();
    partial void OnSoluongtonChanging(System.Nullable<int> value);
    partial void OnSoluongtonChanged();
    partial void OnMaLGChanging(System.Nullable<int> value);
    partial void OnMaLGChanged();
    partial void OnMaHGChanging(System.Nullable<int> value);
    partial void OnMaHGChanged();
    #endregion
		
		public GIAY()
		{
			this._HANGGIAY = default(EntityRef<HANGGIAY>);
			this._LOAIGIAY = default(EntityRef<LOAIGIAY>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magiay", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Magiay
		{
			get
			{
				return this._Magiay;
			}
			set
			{
				if ((this._Magiay != value))
				{
					this.OnMagiayChanging(value);
					this.SendPropertyChanging();
					this._Magiay = value;
					this.SendPropertyChanged("Magiay");
					this.OnMagiayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tengiay", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Tengiay
		{
			get
			{
				return this._Tengiay;
			}
			set
			{
				if ((this._Tengiay != value))
				{
					this.OnTengiayChanging(value);
					this.SendPropertyChanging();
					this._Tengiay = value;
					this.SendPropertyChanged("Tengiay");
					this.OnTengiayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Giaban
		{
			get
			{
				return this._Giaban;
			}
			set
			{
				if ((this._Giaban != value))
				{
					this.OnGiabanChanging(value);
					this.SendPropertyChanging();
					this._Giaban = value;
					this.SendPropertyChanged("Giaban");
					this.OnGiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NVarChar(MAX)")]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anhbia", DbType="VarChar(50)")]
		public string Anhbia
		{
			get
			{
				return this._Anhbia;
			}
			set
			{
				if ((this._Anhbia != value))
				{
					this.OnAnhbiaChanging(value);
					this.SendPropertyChanging();
					this._Anhbia = value;
					this.SendPropertyChanged("Anhbia");
					this.OnAnhbiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaycapnhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaycapnhat
		{
			get
			{
				return this._Ngaycapnhat;
			}
			set
			{
				if ((this._Ngaycapnhat != value))
				{
					this.OnNgaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._Ngaycapnhat = value;
					this.SendPropertyChanged("Ngaycapnhat");
					this.OnNgaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluongton", DbType="Int")]
		public System.Nullable<int> Soluongton
		{
			get
			{
				return this._Soluongton;
			}
			set
			{
				if ((this._Soluongton != value))
				{
					this.OnSoluongtonChanging(value);
					this.SendPropertyChanging();
					this._Soluongton = value;
					this.SendPropertyChanged("Soluongton");
					this.OnSoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLG", DbType="Int")]
		public System.Nullable<int> MaLG
		{
			get
			{
				return this._MaLG;
			}
			set
			{
				if ((this._MaLG != value))
				{
					if (this._LOAIGIAY.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLGChanging(value);
					this.SendPropertyChanging();
					this._MaLG = value;
					this.SendPropertyChanged("MaLG");
					this.OnMaLGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHG", DbType="Int")]
		public System.Nullable<int> MaHG
		{
			get
			{
				return this._MaHG;
			}
			set
			{
				if ((this._MaHG != value))
				{
					if (this._HANGGIAY.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHGChanging(value);
					this.SendPropertyChanging();
					this._MaHG = value;
					this.SendPropertyChanged("MaHG");
					this.OnMaHGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HANGGIAY_GIAY", Storage="_HANGGIAY", ThisKey="MaHG", OtherKey="MaHG", IsForeignKey=true)]
		public HANGGIAY HANGGIAY
		{
			get
			{
				return this._HANGGIAY.Entity;
			}
			set
			{
				HANGGIAY previousValue = this._HANGGIAY.Entity;
				if (((previousValue != value) 
							|| (this._HANGGIAY.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HANGGIAY.Entity = null;
						previousValue.GIAYs.Remove(this);
					}
					this._HANGGIAY.Entity = value;
					if ((value != null))
					{
						value.GIAYs.Add(this);
						this._MaHG = value.MaHG;
					}
					else
					{
						this._MaHG = default(Nullable<int>);
					}
					this.SendPropertyChanged("HANGGIAY");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIGIAY_GIAY", Storage="_LOAIGIAY", ThisKey="MaLG", OtherKey="MaLG", IsForeignKey=true)]
		public LOAIGIAY LOAIGIAY
		{
			get
			{
				return this._LOAIGIAY.Entity;
			}
			set
			{
				LOAIGIAY previousValue = this._LOAIGIAY.Entity;
				if (((previousValue != value) 
							|| (this._LOAIGIAY.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAIGIAY.Entity = null;
						previousValue.GIAYs.Remove(this);
					}
					this._LOAIGIAY.Entity = value;
					if ((value != null))
					{
						value.GIAYs.Add(this);
						this._MaLG = value.MaLG;
					}
					else
					{
						this._MaLG = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAIGIAY");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HANGGIAY")]
	public partial class HANGGIAY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHG;
		
		private string _TenHangGiay;
		
		private EntitySet<GIAY> _GIAYs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHGChanging(int value);
    partial void OnMaHGChanged();
    partial void OnTenHangGiayChanging(string value);
    partial void OnTenHangGiayChanged();
    #endregion
		
		public HANGGIAY()
		{
			this._GIAYs = new EntitySet<GIAY>(new Action<GIAY>(this.attach_GIAYs), new Action<GIAY>(this.detach_GIAYs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHG", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHG
		{
			get
			{
				return this._MaHG;
			}
			set
			{
				if ((this._MaHG != value))
				{
					this.OnMaHGChanging(value);
					this.SendPropertyChanging();
					this._MaHG = value;
					this.SendPropertyChanged("MaHG");
					this.OnMaHGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHangGiay", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenHangGiay
		{
			get
			{
				return this._TenHangGiay;
			}
			set
			{
				if ((this._TenHangGiay != value))
				{
					this.OnTenHangGiayChanging(value);
					this.SendPropertyChanging();
					this._TenHangGiay = value;
					this.SendPropertyChanged("TenHangGiay");
					this.OnTenHangGiayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HANGGIAY_GIAY", Storage="_GIAYs", ThisKey="MaHG", OtherKey="MaHG")]
		public EntitySet<GIAY> GIAYs
		{
			get
			{
				return this._GIAYs;
			}
			set
			{
				this._GIAYs.Assign(value);
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
		
		private void attach_GIAYs(GIAY entity)
		{
			this.SendPropertyChanging();
			entity.HANGGIAY = this;
		}
		
		private void detach_GIAYs(GIAY entity)
		{
			this.SendPropertyChanging();
			entity.HANGGIAY = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
		private string _Email;
		
		private string _DiachiKH;
		
		private string _DienthoaiKH;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiachiKHChanging(string value);
    partial void OnDiachiKHChanged();
    partial void OnDienthoaiKHChanging(string value);
    partial void OnDienthoaiKHChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="VarChar(50)")]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiachiKH", DbType="NVarChar(200)")]
		public string DiachiKH
		{
			get
			{
				return this._DiachiKH;
			}
			set
			{
				if ((this._DiachiKH != value))
				{
					this.OnDiachiKHChanging(value);
					this.SendPropertyChanging();
					this._DiachiKH = value;
					this.SendPropertyChanged("DiachiKH");
					this.OnDiachiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienthoaiKH", DbType="VarChar(50)")]
		public string DienthoaiKH
		{
			get
			{
				return this._DienthoaiKH;
			}
			set
			{
				if ((this._DienthoaiKH != value))
				{
					this.OnDienthoaiKHChanging(value);
					this.SendPropertyChanging();
					this._DienthoaiKH = value;
					this.SendPropertyChanged("DienthoaiKH");
					this.OnDienthoaiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAIGIAY")]
	public partial class LOAIGIAY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLG;
		
		private string _TenLoaigiay;
		
		private EntitySet<GIAY> _GIAYs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLGChanging(int value);
    partial void OnMaLGChanged();
    partial void OnTenLoaigiayChanging(string value);
    partial void OnTenLoaigiayChanged();
    #endregion
		
		public LOAIGIAY()
		{
			this._GIAYs = new EntitySet<GIAY>(new Action<GIAY>(this.attach_GIAYs), new Action<GIAY>(this.detach_GIAYs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLG", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLG
		{
			get
			{
				return this._MaLG;
			}
			set
			{
				if ((this._MaLG != value))
				{
					this.OnMaLGChanging(value);
					this.SendPropertyChanging();
					this._MaLG = value;
					this.SendPropertyChanged("MaLG");
					this.OnMaLGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaigiay", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenLoaigiay
		{
			get
			{
				return this._TenLoaigiay;
			}
			set
			{
				if ((this._TenLoaigiay != value))
				{
					this.OnTenLoaigiayChanging(value);
					this.SendPropertyChanging();
					this._TenLoaigiay = value;
					this.SendPropertyChanged("TenLoaigiay");
					this.OnTenLoaigiayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAIGIAY_GIAY", Storage="_GIAYs", ThisKey="MaLG", OtherKey="MaLG")]
		public EntitySet<GIAY> GIAYs
		{
			get
			{
				return this._GIAYs;
			}
			set
			{
				this._GIAYs.Assign(value);
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
		
		private void attach_GIAYs(GIAY entity)
		{
			this.SendPropertyChanging();
			entity.LOAIGIAY = this;
		}
		
		private void detach_GIAYs(GIAY entity)
		{
			this.SendPropertyChanging();
			entity.LOAIGIAY = null;
		}
	}
}
#pragma warning restore 1591
