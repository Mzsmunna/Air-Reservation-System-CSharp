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

namespace Air_Reservation_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Airline_Reservation_System")]
	public partial class Airline_Reservation_SystemDBCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCustomer_Info(Customer_Info instance);
    partial void UpdateCustomer_Info(Customer_Info instance);
    partial void DeleteCustomer_Info(Customer_Info instance);
    partial void InsertFlight_Detail(Flight_Detail instance);
    partial void UpdateFlight_Detail(Flight_Detail instance);
    partial void DeleteFlight_Detail(Flight_Detail instance);
    partial void InsertTicketBooked_Info(TicketBooked_Info instance);
    partial void UpdateTicketBooked_Info(TicketBooked_Info instance);
    partial void DeleteTicketBooked_Info(TicketBooked_Info instance);
    #endregion
		
		public Airline_Reservation_SystemDBCDataContext() : 
				base(global::Air_Reservation_System.Properties.Settings.Default.Airline_Reservation_SystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Airline_Reservation_SystemDBCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Airline_Reservation_SystemDBCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Airline_Reservation_SystemDBCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Airline_Reservation_SystemDBCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Customer_Info> Customer_Infos
		{
			get
			{
				return this.GetTable<Customer_Info>();
			}
		}
		
		public System.Data.Linq.Table<Flight_Detail> Flight_Details
		{
			get
			{
				return this.GetTable<Flight_Detail>();
			}
		}
		
		public System.Data.Linq.Table<TicketBooked_Info> TicketBooked_Infos
		{
			get
			{
				return this.GetTable<TicketBooked_Info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Admin_ID;
		
		private string _Admin_Name;
		
		private string _Admin_Email;
		
		private string _Admin_Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdmin_IDChanging(int value);
    partial void OnAdmin_IDChanged();
    partial void OnAdmin_NameChanging(string value);
    partial void OnAdmin_NameChanged();
    partial void OnAdmin_EmailChanging(string value);
    partial void OnAdmin_EmailChanged();
    partial void OnAdmin_PasswordChanging(string value);
    partial void OnAdmin_PasswordChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Admin_ID
		{
			get
			{
				return this._Admin_ID;
			}
			set
			{
				if ((this._Admin_ID != value))
				{
					this.OnAdmin_IDChanging(value);
					this.SendPropertyChanging();
					this._Admin_ID = value;
					this.SendPropertyChanged("Admin_ID");
					this.OnAdmin_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Admin_Name
		{
			get
			{
				return this._Admin_Name;
			}
			set
			{
				if ((this._Admin_Name != value))
				{
					this.OnAdmin_NameChanging(value);
					this.SendPropertyChanging();
					this._Admin_Name = value;
					this.SendPropertyChanged("Admin_Name");
					this.OnAdmin_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Admin_Email
		{
			get
			{
				return this._Admin_Email;
			}
			set
			{
				if ((this._Admin_Email != value))
				{
					this.OnAdmin_EmailChanging(value);
					this.SendPropertyChanging();
					this._Admin_Email = value;
					this.SendPropertyChanged("Admin_Email");
					this.OnAdmin_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Admin_Password
		{
			get
			{
				return this._Admin_Password;
			}
			set
			{
				if ((this._Admin_Password != value))
				{
					this.OnAdmin_PasswordChanging(value);
					this.SendPropertyChanging();
					this._Admin_Password = value;
					this.SendPropertyChanged("Admin_Password");
					this.OnAdmin_PasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Info")]
	public partial class Customer_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CID;
		
		private string _CName;
		
		private string _CGender;
		
		private string _CDOB;
		
		private string _CPhone_Num;
		
		private string _CEmail;
		
		private string _CPassport_No;
		
		private string _CNationality;
		
		private string _Card_Holder_Name;
		
		private System.Nullable<int> _Credit_Card_No;
		
		private string _Card_Expire_Date;
		
		private string _CPassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCIDChanging(int value);
    partial void OnCIDChanged();
    partial void OnCNameChanging(string value);
    partial void OnCNameChanged();
    partial void OnCGenderChanging(string value);
    partial void OnCGenderChanged();
    partial void OnCDOBChanging(string value);
    partial void OnCDOBChanged();
    partial void OnCPhone_NumChanging(string value);
    partial void OnCPhone_NumChanged();
    partial void OnCEmailChanging(string value);
    partial void OnCEmailChanged();
    partial void OnCPassport_NoChanging(string value);
    partial void OnCPassport_NoChanged();
    partial void OnCNationalityChanging(string value);
    partial void OnCNationalityChanged();
    partial void OnCard_Holder_NameChanging(string value);
    partial void OnCard_Holder_NameChanged();
    partial void OnCredit_Card_NoChanging(System.Nullable<int> value);
    partial void OnCredit_Card_NoChanged();
    partial void OnCard_Expire_DateChanging(string value);
    partial void OnCard_Expire_DateChanged();
    partial void OnCPasswordChanging(string value);
    partial void OnCPasswordChanged();
    #endregion
		
		public Customer_Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CID
		{
			get
			{
				return this._CID;
			}
			set
			{
				if ((this._CID != value))
				{
					this.OnCIDChanging(value);
					this.SendPropertyChanging();
					this._CID = value;
					this.SendPropertyChanged("CID");
					this.OnCIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string CName
		{
			get
			{
				return this._CName;
			}
			set
			{
				if ((this._CName != value))
				{
					this.OnCNameChanging(value);
					this.SendPropertyChanging();
					this._CName = value;
					this.SendPropertyChanged("CName");
					this.OnCNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CGender", DbType="NVarChar(6) NOT NULL", CanBeNull=false)]
		public string CGender
		{
			get
			{
				return this._CGender;
			}
			set
			{
				if ((this._CGender != value))
				{
					this.OnCGenderChanging(value);
					this.SendPropertyChanging();
					this._CGender = value;
					this.SendPropertyChanged("CGender");
					this.OnCGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDOB", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CDOB
		{
			get
			{
				return this._CDOB;
			}
			set
			{
				if ((this._CDOB != value))
				{
					this.OnCDOBChanging(value);
					this.SendPropertyChanging();
					this._CDOB = value;
					this.SendPropertyChanged("CDOB");
					this.OnCDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPhone_Num", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CPhone_Num
		{
			get
			{
				return this._CPhone_Num;
			}
			set
			{
				if ((this._CPhone_Num != value))
				{
					this.OnCPhone_NumChanging(value);
					this.SendPropertyChanging();
					this._CPhone_Num = value;
					this.SendPropertyChanged("CPhone_Num");
					this.OnCPhone_NumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEmail", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CEmail
		{
			get
			{
				return this._CEmail;
			}
			set
			{
				if ((this._CEmail != value))
				{
					this.OnCEmailChanging(value);
					this.SendPropertyChanging();
					this._CEmail = value;
					this.SendPropertyChanged("CEmail");
					this.OnCEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPassport_No", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string CPassport_No
		{
			get
			{
				return this._CPassport_No;
			}
			set
			{
				if ((this._CPassport_No != value))
				{
					this.OnCPassport_NoChanging(value);
					this.SendPropertyChanging();
					this._CPassport_No = value;
					this.SendPropertyChanged("CPassport_No");
					this.OnCPassport_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNationality", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string CNationality
		{
			get
			{
				return this._CNationality;
			}
			set
			{
				if ((this._CNationality != value))
				{
					this.OnCNationalityChanging(value);
					this.SendPropertyChanging();
					this._CNationality = value;
					this.SendPropertyChanged("CNationality");
					this.OnCNationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Card_Holder_Name", DbType="NVarChar(30)")]
		public string Card_Holder_Name
		{
			get
			{
				return this._Card_Holder_Name;
			}
			set
			{
				if ((this._Card_Holder_Name != value))
				{
					this.OnCard_Holder_NameChanging(value);
					this.SendPropertyChanging();
					this._Card_Holder_Name = value;
					this.SendPropertyChanged("Card_Holder_Name");
					this.OnCard_Holder_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credit_Card_No", DbType="Int")]
		public System.Nullable<int> Credit_Card_No
		{
			get
			{
				return this._Credit_Card_No;
			}
			set
			{
				if ((this._Credit_Card_No != value))
				{
					this.OnCredit_Card_NoChanging(value);
					this.SendPropertyChanging();
					this._Credit_Card_No = value;
					this.SendPropertyChanged("Credit_Card_No");
					this.OnCredit_Card_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Card_Expire_Date", DbType="NVarChar(20)")]
		public string Card_Expire_Date
		{
			get
			{
				return this._Card_Expire_Date;
			}
			set
			{
				if ((this._Card_Expire_Date != value))
				{
					this.OnCard_Expire_DateChanging(value);
					this.SendPropertyChanging();
					this._Card_Expire_Date = value;
					this.SendPropertyChanged("Card_Expire_Date");
					this.OnCard_Expire_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPassword", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string CPassword
		{
			get
			{
				return this._CPassword;
			}
			set
			{
				if ((this._CPassword != value))
				{
					this.OnCPasswordChanging(value);
					this.SendPropertyChanging();
					this._CPassword = value;
					this.SendPropertyChanged("CPassword");
					this.OnCPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Flight_Details")]
	public partial class Flight_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Flight_ID;
		
		private string _Flight_Name;
		
		private string _Destination;
		
		private string _Departure;
		
		private string _Date;
		
		private string _Time;
		
		private System.Nullable<int> _Available_Seat_E_;
		
		private System.Nullable<int> _Available_Seat_B_;
		
		private int _Economy_Cost_BDT_;
		
		private int _Business_Cost_BDT_;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFlight_IDChanging(int value);
    partial void OnFlight_IDChanged();
    partial void OnFlight_NameChanging(string value);
    partial void OnFlight_NameChanged();
    partial void OnDestinationChanging(string value);
    partial void OnDestinationChanged();
    partial void OnDepartureChanging(string value);
    partial void OnDepartureChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnTimeChanging(string value);
    partial void OnTimeChanged();
    partial void OnAvailable_Seat_E_Changing(System.Nullable<int> value);
    partial void OnAvailable_Seat_E_Changed();
    partial void OnAvailable_Seat_B_Changing(System.Nullable<int> value);
    partial void OnAvailable_Seat_B_Changed();
    partial void OnEconomy_Cost_BDT_Changing(int value);
    partial void OnEconomy_Cost_BDT_Changed();
    partial void OnBusiness_Cost_BDT_Changing(int value);
    partial void OnBusiness_Cost_BDT_Changed();
    #endregion
		
		public Flight_Detail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flight_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Flight_ID
		{
			get
			{
				return this._Flight_ID;
			}
			set
			{
				if ((this._Flight_ID != value))
				{
					this.OnFlight_IDChanging(value);
					this.SendPropertyChanging();
					this._Flight_ID = value;
					this.SendPropertyChanged("Flight_ID");
					this.OnFlight_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flight_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Flight_Name
		{
			get
			{
				return this._Flight_Name;
			}
			set
			{
				if ((this._Flight_Name != value))
				{
					this.OnFlight_NameChanging(value);
					this.SendPropertyChanging();
					this._Flight_Name = value;
					this.SendPropertyChanged("Flight_Name");
					this.OnFlight_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destination", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Destination
		{
			get
			{
				return this._Destination;
			}
			set
			{
				if ((this._Destination != value))
				{
					this.OnDestinationChanging(value);
					this.SendPropertyChanging();
					this._Destination = value;
					this.SendPropertyChanged("Destination");
					this.OnDestinationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departure", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Departure
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Available_Seat(E)]", Storage="_Available_Seat_E_", DbType="Int")]
		public System.Nullable<int> Available_Seat_E_
		{
			get
			{
				return this._Available_Seat_E_;
			}
			set
			{
				if ((this._Available_Seat_E_ != value))
				{
					this.OnAvailable_Seat_E_Changing(value);
					this.SendPropertyChanging();
					this._Available_Seat_E_ = value;
					this.SendPropertyChanged("Available_Seat_E_");
					this.OnAvailable_Seat_E_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Available_Seat(B)]", Storage="_Available_Seat_B_", DbType="Int")]
		public System.Nullable<int> Available_Seat_B_
		{
			get
			{
				return this._Available_Seat_B_;
			}
			set
			{
				if ((this._Available_Seat_B_ != value))
				{
					this.OnAvailable_Seat_B_Changing(value);
					this.SendPropertyChanging();
					this._Available_Seat_B_ = value;
					this.SendPropertyChanged("Available_Seat_B_");
					this.OnAvailable_Seat_B_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Economy_Cost(BDT)]", Storage="_Economy_Cost_BDT_", DbType="Int NOT NULL")]
		public int Economy_Cost_BDT_
		{
			get
			{
				return this._Economy_Cost_BDT_;
			}
			set
			{
				if ((this._Economy_Cost_BDT_ != value))
				{
					this.OnEconomy_Cost_BDT_Changing(value);
					this.SendPropertyChanging();
					this._Economy_Cost_BDT_ = value;
					this.SendPropertyChanged("Economy_Cost_BDT_");
					this.OnEconomy_Cost_BDT_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Business_Cost(BDT)]", Storage="_Business_Cost_BDT_", DbType="Int NOT NULL")]
		public int Business_Cost_BDT_
		{
			get
			{
				return this._Business_Cost_BDT_;
			}
			set
			{
				if ((this._Business_Cost_BDT_ != value))
				{
					this.OnBusiness_Cost_BDT_Changing(value);
					this.SendPropertyChanging();
					this._Business_Cost_BDT_ = value;
					this.SendPropertyChanged("Business_Cost_BDT_");
					this.OnBusiness_Cost_BDT_Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TicketBooked_Info")]
	public partial class TicketBooked_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CID;
		
		private int _Flight_ID;
		
		private string _CName;
		
		private string _Flight_Name;
		
		private int _Economy_Seat_Taken;
		
		private int _Business_Seat_Taken;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCIDChanging(int value);
    partial void OnCIDChanged();
    partial void OnFlight_IDChanging(int value);
    partial void OnFlight_IDChanged();
    partial void OnCNameChanging(string value);
    partial void OnCNameChanged();
    partial void OnFlight_NameChanging(string value);
    partial void OnFlight_NameChanged();
    partial void OnEconomy_Seat_TakenChanging(int value);
    partial void OnEconomy_Seat_TakenChanged();
    partial void OnBusiness_Seat_TakenChanging(int value);
    partial void OnBusiness_Seat_TakenChanged();
    #endregion
		
		public TicketBooked_Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CID
		{
			get
			{
				return this._CID;
			}
			set
			{
				if ((this._CID != value))
				{
					this.OnCIDChanging(value);
					this.SendPropertyChanging();
					this._CID = value;
					this.SendPropertyChanged("CID");
					this.OnCIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flight_ID", DbType="Int NOT NULL")]
		public int Flight_ID
		{
			get
			{
				return this._Flight_ID;
			}
			set
			{
				if ((this._Flight_ID != value))
				{
					this.OnFlight_IDChanging(value);
					this.SendPropertyChanging();
					this._Flight_ID = value;
					this.SendPropertyChanged("Flight_ID");
					this.OnFlight_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string CName
		{
			get
			{
				return this._CName;
			}
			set
			{
				if ((this._CName != value))
				{
					this.OnCNameChanging(value);
					this.SendPropertyChanging();
					this._CName = value;
					this.SendPropertyChanged("CName");
					this.OnCNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flight_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Flight_Name
		{
			get
			{
				return this._Flight_Name;
			}
			set
			{
				if ((this._Flight_Name != value))
				{
					this.OnFlight_NameChanging(value);
					this.SendPropertyChanging();
					this._Flight_Name = value;
					this.SendPropertyChanged("Flight_Name");
					this.OnFlight_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Economy Seat Taken]", Storage="_Economy_Seat_Taken", DbType="Int NOT NULL")]
		public int Economy_Seat_Taken
		{
			get
			{
				return this._Economy_Seat_Taken;
			}
			set
			{
				if ((this._Economy_Seat_Taken != value))
				{
					this.OnEconomy_Seat_TakenChanging(value);
					this.SendPropertyChanging();
					this._Economy_Seat_Taken = value;
					this.SendPropertyChanged("Economy_Seat_Taken");
					this.OnEconomy_Seat_TakenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Business Seat Taken]", Storage="_Business_Seat_Taken", DbType="Int NOT NULL")]
		public int Business_Seat_Taken
		{
			get
			{
				return this._Business_Seat_Taken;
			}
			set
			{
				if ((this._Business_Seat_Taken != value))
				{
					this.OnBusiness_Seat_TakenChanging(value);
					this.SendPropertyChanging();
					this._Business_Seat_Taken = value;
					this.SendPropertyChanged("Business_Seat_Taken");
					this.OnBusiness_Seat_TakenChanged();
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
