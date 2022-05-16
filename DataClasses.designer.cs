﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="C:\\USERS\\ГЕОРГИЙ\\SOURCE\\REPOS\\KURSOVAYA\\KURSOVAYA\\DATABASE1.MDF")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCargo(Cargo instance);
    partial void UpdateCargo(Cargo instance);
    partial void DeleteCargo(Cargo instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertSchedule(Schedule instance);
    partial void UpdateSchedule(Schedule instance);
    partial void DeleteSchedule(Schedule instance);
    partial void InsertTRAINS(TRAINS instance);
    partial void UpdateTRAINS(TRAINS instance);
    partial void DeleteTRAINS(TRAINS instance);
    partial void InsertPassanger(Passanger instance);
    partial void UpdatePassanger(Passanger instance);
    partial void DeletePassanger(Passanger instance);
    partial void InsertTicket(Ticket instance);
    partial void UpdateTicket(Ticket instance);
    partial void DeleteTicket(Ticket instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::WindowsFormsApp2.Properties.Settings.Default.C__USERS_ГЕОРГИЙ_SOURCE_REPOS_KURSOVAYA_KURSOVAYA_DATABASE1_MDFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cargo> Cargo
		{
			get
			{
				return this.GetTable<Cargo>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customer
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Schedule> Schedule
		{
			get
			{
				return this.GetTable<Schedule>();
			}
		}
		
		public System.Data.Linq.Table<TRAINS> TRAINS
		{
			get
			{
				return this.GetTable<TRAINS>();
			}
		}
		
		public System.Data.Linq.Table<Passanger> Passanger
		{
			get
			{
				return this.GetTable<Passanger>();
			}
		}
		
		public System.Data.Linq.Table<Ticket> Ticket
		{
			get
			{
				return this.GetTable<Ticket>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cargo")]
	public partial class Cargo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<short> _Weight;
		
		private System.Nullable<short> _CargoPlace;
		
		private System.Nullable<int> _FlightNumber;
		
		private System.Nullable<int> _Schedule_Id;
		
		private string _CargoName;
		
		private System.Nullable<int> _Customer_Id;
		
		private System.Nullable<int> _Wagon;
		
		private EntityRef<Schedule> _Schedule;
		
		private EntityRef<Customer> _Customer;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWeightChanging(System.Nullable<short> value);
    partial void OnWeightChanged();
    partial void OnCargoPlaceChanging(System.Nullable<short> value);
    partial void OnCargoPlaceChanged();
    partial void OnFlightNumberChanging(System.Nullable<int> value);
    partial void OnFlightNumberChanged();
    partial void OnSchedule_IdChanging(System.Nullable<int> value);
    partial void OnSchedule_IdChanged();
    partial void OnCargoNameChanging(string value);
    partial void OnCargoNameChanged();
    partial void OnCustomer_IdChanging(System.Nullable<int> value);
    partial void OnCustomer_IdChanged();
    partial void OnWagonChanging(System.Nullable<int> value);
    partial void OnWagonChanged();
    #endregion
		
		public Cargo()
		{
			this._Schedule = default(EntityRef<Schedule>);
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="SmallInt")]
		public System.Nullable<short> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoPlace", DbType="SmallInt")]
		public System.Nullable<short> CargoPlace
		{
			get
			{
				return this._CargoPlace;
			}
			set
			{
				if ((this._CargoPlace != value))
				{
					this.OnCargoPlaceChanging(value);
					this.SendPropertyChanging();
					this._CargoPlace = value;
					this.SendPropertyChanged("CargoPlace");
					this.OnCargoPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlightNumber", DbType="Int")]
		public System.Nullable<int> FlightNumber
		{
			get
			{
				return this._FlightNumber;
			}
			set
			{
				if ((this._FlightNumber != value))
				{
					this.OnFlightNumberChanging(value);
					this.SendPropertyChanging();
					this._FlightNumber = value;
					this.SendPropertyChanged("FlightNumber");
					this.OnFlightNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Schedule_Id", DbType="Int")]
		public System.Nullable<int> Schedule_Id
		{
			get
			{
				return this._Schedule_Id;
			}
			set
			{
				if ((this._Schedule_Id != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSchedule_IdChanging(value);
					this.SendPropertyChanging();
					this._Schedule_Id = value;
					this.SendPropertyChanged("Schedule_Id");
					this.OnSchedule_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoName", DbType="NChar(50)")]
		public string CargoName
		{
			get
			{
				return this._CargoName;
			}
			set
			{
				if ((this._CargoName != value))
				{
					this.OnCargoNameChanging(value);
					this.SendPropertyChanging();
					this._CargoName = value;
					this.SendPropertyChanged("CargoName");
					this.OnCargoNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", DbType="Int")]
		public System.Nullable<int> Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wagon", DbType="Int")]
		public System.Nullable<int> Wagon
		{
			get
			{
				return this._Wagon;
			}
			set
			{
				if ((this._Wagon != value))
				{
					this.OnWagonChanging(value);
					this.SendPropertyChanging();
					this._Wagon = value;
					this.SendPropertyChanged("Wagon");
					this.OnWagonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Cargo", Storage="_Schedule", ThisKey="Schedule_Id", OtherKey="Id", IsForeignKey=true)]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Cargo.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Cargo.Add(this);
						this._Schedule_Id = value.Id;
					}
					else
					{
						this._Schedule_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Schedule");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Cargo", Storage="_Customer", ThisKey="Customer_Id", OtherKey="Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Cargo.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Cargo.Add(this);
						this._Customer_Id = value.Id;
					}
					else
					{
						this._Customer_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FIO;
		
		private string _Product;
		
		private System.Nullable<bool> _Payment;
		
		private EntitySet<Cargo> _Cargo;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFIOChanging(string value);
    partial void OnFIOChanged();
    partial void OnProductChanging(string value);
    partial void OnProductChanged();
    partial void OnPaymentChanging(System.Nullable<bool> value);
    partial void OnPaymentChanged();
    #endregion
		
		public Customer()
		{
			this._Cargo = new EntitySet<Cargo>(new Action<Cargo>(this.attach_Cargo), new Action<Cargo>(this.detach_Cargo));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="NChar(50)")]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this.OnFIOChanging(value);
					this.SendPropertyChanging();
					this._FIO = value;
					this.SendPropertyChanged("FIO");
					this.OnFIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product", DbType="NChar(50)")]
		public string Product
		{
			get
			{
				return this._Product;
			}
			set
			{
				if ((this._Product != value))
				{
					this.OnProductChanging(value);
					this.SendPropertyChanging();
					this._Product = value;
					this.SendPropertyChanged("Product");
					this.OnProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payment", DbType="Bit")]
		public System.Nullable<bool> Payment
		{
			get
			{
				return this._Payment;
			}
			set
			{
				if ((this._Payment != value))
				{
					this.OnPaymentChanging(value);
					this.SendPropertyChanging();
					this._Payment = value;
					this.SendPropertyChanged("Payment");
					this.OnPaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Cargo", Storage="_Cargo", ThisKey="Id", OtherKey="Customer_Id")]
		public EntitySet<Cargo> Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				this._Cargo.Assign(value);
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
		
		private void attach_Cargo(Cargo entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Cargo(Cargo entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedule")]
	public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Train_Id;
		
		private string _WhereFrom;
		
		private string _Whiter;
		
		private System.Nullable<System.DateTime> _Departure;
		
		private System.Nullable<System.DateTime> _ArrivalTime;
		
		private EntitySet<Cargo> _Cargo;
		
		private EntitySet<Ticket> _Ticket;
		
		private EntityRef<TRAINS> _TRAINS;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTrain_IdChanging(System.Nullable<int> value);
    partial void OnTrain_IdChanged();
    partial void OnWhereFromChanging(string value);
    partial void OnWhereFromChanged();
    partial void OnWhiterChanging(string value);
    partial void OnWhiterChanged();
    partial void OnDepartureChanging(System.Nullable<System.DateTime> value);
    partial void OnDepartureChanged();
    partial void OnArrivalTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnArrivalTimeChanged();
    #endregion
		
		public Schedule()
		{
			this._Cargo = new EntitySet<Cargo>(new Action<Cargo>(this.attach_Cargo), new Action<Cargo>(this.detach_Cargo));
			this._Ticket = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Ticket), new Action<Ticket>(this.detach_Ticket));
			this._TRAINS = default(EntityRef<TRAINS>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Train_Id", DbType="Int")]
		public System.Nullable<int> Train_Id
		{
			get
			{
				return this._Train_Id;
			}
			set
			{
				if ((this._Train_Id != value))
				{
					if (this._TRAINS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTrain_IdChanging(value);
					this.SendPropertyChanging();
					this._Train_Id = value;
					this.SendPropertyChanged("Train_Id");
					this.OnTrain_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhereFrom", DbType="NChar(30)")]
		public string WhereFrom
		{
			get
			{
				return this._WhereFrom;
			}
			set
			{
				if ((this._WhereFrom != value))
				{
					this.OnWhereFromChanging(value);
					this.SendPropertyChanging();
					this._WhereFrom = value;
					this.SendPropertyChanged("WhereFrom");
					this.OnWhereFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Whiter", DbType="NChar(30)")]
		public string Whiter
		{
			get
			{
				return this._Whiter;
			}
			set
			{
				if ((this._Whiter != value))
				{
					this.OnWhiterChanging(value);
					this.SendPropertyChanging();
					this._Whiter = value;
					this.SendPropertyChanged("Whiter");
					this.OnWhiterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departure", DbType="DateTime")]
		public System.Nullable<System.DateTime> Departure
		{
			get
			{
				return this._Departure;
			}
			set
			{
				if ((this._Departure != value))
				{
					this.OnDepartureChanging(value);
					this.SendPropertyChanging();
					this._Departure = value;
					this.SendPropertyChanged("Departure");
					this.OnDepartureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArrivalTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> ArrivalTime
		{
			get
			{
				return this._ArrivalTime;
			}
			set
			{
				if ((this._ArrivalTime != value))
				{
					this.OnArrivalTimeChanging(value);
					this.SendPropertyChanging();
					this._ArrivalTime = value;
					this.SendPropertyChanged("ArrivalTime");
					this.OnArrivalTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Cargo", Storage="_Cargo", ThisKey="Id", OtherKey="Schedule_Id")]
		public EntitySet<Cargo> Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				this._Cargo.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Ticket", ThisKey="Id", OtherKey="Schedule_Id")]
		public EntitySet<Ticket> Ticket
		{
			get
			{
				return this._Ticket;
			}
			set
			{
				this._Ticket.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TRAINS_Schedule", Storage="_TRAINS", ThisKey="Train_Id", OtherKey="Id", IsForeignKey=true)]
		public TRAINS TRAINS
		{
			get
			{
				return this._TRAINS.Entity;
			}
			set
			{
				TRAINS previousValue = this._TRAINS.Entity;
				if (((previousValue != value) 
							|| (this._TRAINS.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TRAINS.Entity = null;
						previousValue.Schedule.Remove(this);
					}
					this._TRAINS.Entity = value;
					if ((value != null))
					{
						value.Schedule.Add(this);
						this._Train_Id = value.Id;
					}
					else
					{
						this._Train_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("TRAINS");
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
		
		private void attach_Cargo(Cargo entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Cargo(Cargo entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
		
		private void attach_Ticket(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Ticket(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRAINS")]
	public partial class TRAINS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private System.Nullable<int> _AllPlaces;
		
		private EntitySet<Schedule> _Schedule;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnAllPlacesChanging(System.Nullable<int> value);
    partial void OnAllPlacesChanged();
    #endregion
		
		public TRAINS()
		{
			this._Schedule = new EntitySet<Schedule>(new Action<Schedule>(this.attach_Schedule), new Action<Schedule>(this.detach_Schedule));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NChar(14)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllPlaces", DbType="Int")]
		public System.Nullable<int> AllPlaces
		{
			get
			{
				return this._AllPlaces;
			}
			set
			{
				if ((this._AllPlaces != value))
				{
					this.OnAllPlacesChanging(value);
					this.SendPropertyChanging();
					this._AllPlaces = value;
					this.SendPropertyChanged("AllPlaces");
					this.OnAllPlacesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TRAINS_Schedule", Storage="_Schedule", ThisKey="Id", OtherKey="Train_Id")]
		public EntitySet<Schedule> Schedule
		{
			get
			{
				return this._Schedule;
			}
			set
			{
				this._Schedule.Assign(value);
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
		
		private void attach_Schedule(Schedule entity)
		{
			this.SendPropertyChanging();
			entity.TRAINS = this;
		}
		
		private void detach_Schedule(Schedule entity)
		{
			this.SendPropertyChanging();
			entity.TRAINS = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Passanger")]
	public partial class Passanger : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FIO;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private string _Passport;
		
		private string _Phone;
		
		private EntitySet<Ticket> _Ticket;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFIOChanging(string value);
    partial void OnFIOChanged();
    partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfBirthChanged();
    partial void OnPassportChanging(string value);
    partial void OnPassportChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Passanger()
		{
			this._Ticket = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Ticket), new Action<Ticket>(this.detach_Ticket));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="NChar(50)")]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this.OnFIOChanging(value);
					this.SendPropertyChanging();
					this._FIO = value;
					this.SendPropertyChanged("FIO");
					this.OnFIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passport", DbType="NChar(12)")]
		public string Passport
		{
			get
			{
				return this._Passport;
			}
			set
			{
				if ((this._Passport != value))
				{
					this.OnPassportChanging(value);
					this.SendPropertyChanging();
					this._Passport = value;
					this.SendPropertyChanged("Passport");
					this.OnPassportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(11)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Passanger_Ticket", Storage="_Ticket", ThisKey="Id", OtherKey="Passanger_Id")]
		public EntitySet<Ticket> Ticket
		{
			get
			{
				return this._Ticket;
			}
			set
			{
				this._Ticket.Assign(value);
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
		
		private void attach_Ticket(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Passanger = this;
		}
		
		private void detach_Ticket(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Passanger = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ticket")]
	public partial class Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _FlightNumber;
		
		private System.Nullable<int> _Place;
		
		private System.Nullable<int> _Schedule_Id;
		
		private int _Passanger_Id;
		
		private EntityRef<Schedule> _Schedule;
		
		private EntityRef<Passanger> _Passanger;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFlightNumberChanging(System.Nullable<int> value);
    partial void OnFlightNumberChanged();
    partial void OnPlaceChanging(System.Nullable<int> value);
    partial void OnPlaceChanged();
    partial void OnSchedule_IdChanging(System.Nullable<int> value);
    partial void OnSchedule_IdChanged();
    partial void OnPassanger_IdChanging(int value);
    partial void OnPassanger_IdChanged();
    #endregion
		
		public Ticket()
		{
			this._Schedule = default(EntityRef<Schedule>);
			this._Passanger = default(EntityRef<Passanger>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlightNumber", DbType="Int")]
		public System.Nullable<int> FlightNumber
		{
			get
			{
				return this._FlightNumber;
			}
			set
			{
				if ((this._FlightNumber != value))
				{
					this.OnFlightNumberChanging(value);
					this.SendPropertyChanging();
					this._FlightNumber = value;
					this.SendPropertyChanged("FlightNumber");
					this.OnFlightNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Place", DbType="Int")]
		public System.Nullable<int> Place
		{
			get
			{
				return this._Place;
			}
			set
			{
				if ((this._Place != value))
				{
					this.OnPlaceChanging(value);
					this.SendPropertyChanging();
					this._Place = value;
					this.SendPropertyChanged("Place");
					this.OnPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Schedule_Id", DbType="Int")]
		public System.Nullable<int> Schedule_Id
		{
			get
			{
				return this._Schedule_Id;
			}
			set
			{
				if ((this._Schedule_Id != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSchedule_IdChanging(value);
					this.SendPropertyChanging();
					this._Schedule_Id = value;
					this.SendPropertyChanged("Schedule_Id");
					this.OnSchedule_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passanger_Id", DbType="Int NOT NULL")]
		public int Passanger_Id
		{
			get
			{
				return this._Passanger_Id;
			}
			set
			{
				if ((this._Passanger_Id != value))
				{
					if (this._Passanger.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPassanger_IdChanging(value);
					this.SendPropertyChanging();
					this._Passanger_Id = value;
					this.SendPropertyChanged("Passanger_Id");
					this.OnPassanger_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Schedule", ThisKey="Schedule_Id", OtherKey="Id", IsForeignKey=true)]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Ticket.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Ticket.Add(this);
						this._Schedule_Id = value.Id;
					}
					else
					{
						this._Schedule_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Schedule");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Passanger_Ticket", Storage="_Passanger", ThisKey="Passanger_Id", OtherKey="Id", IsForeignKey=true)]
		public Passanger Passanger
		{
			get
			{
				return this._Passanger.Entity;
			}
			set
			{
				Passanger previousValue = this._Passanger.Entity;
				if (((previousValue != value) 
							|| (this._Passanger.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Passanger.Entity = null;
						previousValue.Ticket.Remove(this);
					}
					this._Passanger.Entity = value;
					if ((value != null))
					{
						value.Ticket.Add(this);
						this._Passanger_Id = value.Id;
					}
					else
					{
						this._Passanger_Id = default(int);
					}
					this.SendPropertyChanged("Passanger");
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
