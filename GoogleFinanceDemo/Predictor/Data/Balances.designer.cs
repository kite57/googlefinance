﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceAI.Data
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="FinancialData")]
	public partial class BalancesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBalance(Balance instance);
    partial void UpdateBalance(Balance instance);
    partial void DeleteBalance(Balance instance);
    #endregion
		
		public BalancesDataContext() : 
				base(global::FinanceAI.Properties.Settings.Default.FinancialDataConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public BalancesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BalancesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BalancesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BalancesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Balance> Balances
		{
			get
			{
				return this.GetTable<Balance>();
			}
		}
	}
	
	[Table(Name="dbo.Balances")]
	public partial class Balance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Ticker;
		
		private System.DateTime _Date;
		
		private char _Period;
		
		private System.Nullable<decimal> _Cash___Equivalents;
		
		private System.Nullable<decimal> _Short_Term_Investments;
		
		private System.Nullable<decimal> _Cash_and_Short_Term_Investments;
		
		private System.Nullable<decimal> _Accounts_Receivable___Trade__Net;
		
		private System.Nullable<decimal> _Receivables___Other;
		
		private System.Nullable<decimal> _Total_Receivables__Net;
		
		private System.Nullable<decimal> _Total_Inventory;
		
		private System.Nullable<decimal> _Prepaid_Expenses;
		
		private System.Nullable<decimal> _Other_Current_Assets__Total;
		
		private System.Nullable<decimal> _Total_Current_Assets;
		
		private System.Nullable<decimal> _Property_Plant_Equipment__Total___Gross;
		
		private System.Nullable<decimal> _Goodwill__Net;
		
		private System.Nullable<decimal> _Intangibles__Net;
		
		private System.Nullable<decimal> _Long_Term_Investments;
		
		private System.Nullable<decimal> _Other_Long_Term_Assets__Total;
		
		private System.Nullable<decimal> _Total_Assets;
		
		private System.Nullable<decimal> _Accounts_Payable;
		
		private System.Nullable<decimal> _Accrued_Expenses;
		
		private System.Nullable<decimal> _Notes_Payable_Short_Term_Debt;
		
		private System.Nullable<decimal> _Current_Port__of_LT_Debt_Capital_Leases;
		
		private System.Nullable<decimal> _Other_Current_liabilities__Total;
		
		private System.Nullable<decimal> _Total_Current_Liabilities;
		
		private System.Nullable<decimal> _Long_Term_Debt;
		
		private System.Nullable<decimal> _Capital_Lease_Obligations;
		
		private System.Nullable<decimal> _Total_Long_Term_Debt;
		
		private System.Nullable<decimal> _Total_Debt;
		
		private System.Nullable<decimal> _Deferred_Income_Tax;
		
		private System.Nullable<decimal> _Minority_Interest;
		
		private System.Nullable<decimal> _Other_Liabilities__Total;
		
		private System.Nullable<decimal> _Total_Liabilities;
		
		private System.Nullable<decimal> _Redeemable_Preferred_Stock__Total;
		
		private System.Nullable<decimal> _Preferred_Stock___Non_Redeemable__Net;
		
		private System.Nullable<decimal> _Common_Stock__Total;
		
		private System.Nullable<decimal> _Additional_Paid_In_Capital;
		
		private System.Nullable<decimal> _Retained_Earnings__Accumulated_Deficit_;
		
		private System.Nullable<decimal> _Treasury_Stock___Common;
		
		private System.Nullable<decimal> _Other_Equity__Total;
		
		private System.Nullable<decimal> _Total_Equity;
		
		private System.Nullable<decimal> _Total_Liabilities___Shareholders__Equity;
		
		private System.Nullable<decimal> _Shares_Outs___Common_Stock_Primary_Issue;
		
		private System.Nullable<decimal> _Total_Common_Shares_Outstanding;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTickerChanging(string value);
    partial void OnTickerChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnPeriodChanging(char value);
    partial void OnPeriodChanged();
    partial void OnCash___EquivalentsChanging(System.Nullable<decimal> value);
    partial void OnCash___EquivalentsChanged();
    partial void OnShort_Term_InvestmentsChanging(System.Nullable<decimal> value);
    partial void OnShort_Term_InvestmentsChanged();
    partial void OnCash_and_Short_Term_InvestmentsChanging(System.Nullable<decimal> value);
    partial void OnCash_and_Short_Term_InvestmentsChanged();
    partial void OnAccounts_Receivable___Trade__NetChanging(System.Nullable<decimal> value);
    partial void OnAccounts_Receivable___Trade__NetChanged();
    partial void OnReceivables___OtherChanging(System.Nullable<decimal> value);
    partial void OnReceivables___OtherChanged();
    partial void OnTotal_Receivables__NetChanging(System.Nullable<decimal> value);
    partial void OnTotal_Receivables__NetChanged();
    partial void OnTotal_InventoryChanging(System.Nullable<decimal> value);
    partial void OnTotal_InventoryChanged();
    partial void OnPrepaid_ExpensesChanging(System.Nullable<decimal> value);
    partial void OnPrepaid_ExpensesChanged();
    partial void OnOther_Current_Assets__TotalChanging(System.Nullable<decimal> value);
    partial void OnOther_Current_Assets__TotalChanged();
    partial void OnTotal_Current_AssetsChanging(System.Nullable<decimal> value);
    partial void OnTotal_Current_AssetsChanged();
    partial void OnProperty_Plant_Equipment__Total___GrossChanging(System.Nullable<decimal> value);
    partial void OnProperty_Plant_Equipment__Total___GrossChanged();
    partial void OnGoodwill__NetChanging(System.Nullable<decimal> value);
    partial void OnGoodwill__NetChanged();
    partial void OnIntangibles__NetChanging(System.Nullable<decimal> value);
    partial void OnIntangibles__NetChanged();
    partial void OnLong_Term_InvestmentsChanging(System.Nullable<decimal> value);
    partial void OnLong_Term_InvestmentsChanged();
    partial void OnOther_Long_Term_Assets__TotalChanging(System.Nullable<decimal> value);
    partial void OnOther_Long_Term_Assets__TotalChanged();
    partial void OnTotal_AssetsChanging(System.Nullable<decimal> value);
    partial void OnTotal_AssetsChanged();
    partial void OnAccounts_PayableChanging(System.Nullable<decimal> value);
    partial void OnAccounts_PayableChanged();
    partial void OnAccrued_ExpensesChanging(System.Nullable<decimal> value);
    partial void OnAccrued_ExpensesChanged();
    partial void OnNotes_Payable_Short_Term_DebtChanging(System.Nullable<decimal> value);
    partial void OnNotes_Payable_Short_Term_DebtChanged();
    partial void OnCurrent_Port__of_LT_Debt_Capital_LeasesChanging(System.Nullable<decimal> value);
    partial void OnCurrent_Port__of_LT_Debt_Capital_LeasesChanged();
    partial void OnOther_Current_liabilities__TotalChanging(System.Nullable<decimal> value);
    partial void OnOther_Current_liabilities__TotalChanged();
    partial void OnTotal_Current_LiabilitiesChanging(System.Nullable<decimal> value);
    partial void OnTotal_Current_LiabilitiesChanged();
    partial void OnLong_Term_DebtChanging(System.Nullable<decimal> value);
    partial void OnLong_Term_DebtChanged();
    partial void OnCapital_Lease_ObligationsChanging(System.Nullable<decimal> value);
    partial void OnCapital_Lease_ObligationsChanged();
    partial void OnTotal_Long_Term_DebtChanging(System.Nullable<decimal> value);
    partial void OnTotal_Long_Term_DebtChanged();
    partial void OnTotal_DebtChanging(System.Nullable<decimal> value);
    partial void OnTotal_DebtChanged();
    partial void OnDeferred_Income_TaxChanging(System.Nullable<decimal> value);
    partial void OnDeferred_Income_TaxChanged();
    partial void OnMinority_InterestChanging(System.Nullable<decimal> value);
    partial void OnMinority_InterestChanged();
    partial void OnOther_Liabilities__TotalChanging(System.Nullable<decimal> value);
    partial void OnOther_Liabilities__TotalChanged();
    partial void OnTotal_LiabilitiesChanging(System.Nullable<decimal> value);
    partial void OnTotal_LiabilitiesChanged();
    partial void OnRedeemable_Preferred_Stock__TotalChanging(System.Nullable<decimal> value);
    partial void OnRedeemable_Preferred_Stock__TotalChanged();
    partial void OnPreferred_Stock___Non_Redeemable__NetChanging(System.Nullable<decimal> value);
    partial void OnPreferred_Stock___Non_Redeemable__NetChanged();
    partial void OnCommon_Stock__TotalChanging(System.Nullable<decimal> value);
    partial void OnCommon_Stock__TotalChanged();
    partial void OnAdditional_Paid_In_CapitalChanging(System.Nullable<decimal> value);
    partial void OnAdditional_Paid_In_CapitalChanged();
    partial void OnRetained_Earnings__Accumulated_Deficit_Changing(System.Nullable<decimal> value);
    partial void OnRetained_Earnings__Accumulated_Deficit_Changed();
    partial void OnTreasury_Stock___CommonChanging(System.Nullable<decimal> value);
    partial void OnTreasury_Stock___CommonChanged();
    partial void OnOther_Equity__TotalChanging(System.Nullable<decimal> value);
    partial void OnOther_Equity__TotalChanged();
    partial void OnTotal_EquityChanging(System.Nullable<decimal> value);
    partial void OnTotal_EquityChanged();
    partial void OnTotal_Liabilities___Shareholders__EquityChanging(System.Nullable<decimal> value);
    partial void OnTotal_Liabilities___Shareholders__EquityChanged();
    partial void OnShares_Outs___Common_Stock_Primary_IssueChanging(System.Nullable<decimal> value);
    partial void OnShares_Outs___Common_Stock_Primary_IssueChanged();
    partial void OnTotal_Common_Shares_OutstandingChanging(System.Nullable<decimal> value);
    partial void OnTotal_Common_Shares_OutstandingChanged();
    #endregion
		
		public Balance()
		{
			OnCreated();
		}
		
		[Column(Storage="_Ticker", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Ticker
		{
			get
			{
				return this._Ticker;
			}
			set
			{
				if ((this._Ticker != value))
				{
					this.OnTickerChanging(value);
					this.SendPropertyChanging();
					this._Ticker = value;
					this.SendPropertyChanged("Ticker");
					this.OnTickerChanged();
				}
			}
		}
		
		[Column(Storage="_Date", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime Date
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
		
		[Column(Storage="_Period", DbType="Char(1) NOT NULL", IsPrimaryKey=true)]
		public char Period
		{
			get
			{
				return this._Period;
			}
			set
			{
				if ((this._Period != value))
				{
					this.OnPeriodChanging(value);
					this.SendPropertyChanging();
					this._Period = value;
					this.SendPropertyChanged("Period");
					this.OnPeriodChanged();
				}
			}
		}
		
		[Column(Name="[Cash & Equivalents]", Storage="_Cash___Equivalents", DbType="Money")]
		public System.Nullable<decimal> Cash___Equivalents
		{
			get
			{
				return this._Cash___Equivalents;
			}
			set
			{
				if ((this._Cash___Equivalents != value))
				{
					this.OnCash___EquivalentsChanging(value);
					this.SendPropertyChanging();
					this._Cash___Equivalents = value;
					this.SendPropertyChanged("Cash___Equivalents");
					this.OnCash___EquivalentsChanged();
				}
			}
		}
		
		[Column(Name="[Short Term Investments]", Storage="_Short_Term_Investments", DbType="Money")]
		public System.Nullable<decimal> Short_Term_Investments
		{
			get
			{
				return this._Short_Term_Investments;
			}
			set
			{
				if ((this._Short_Term_Investments != value))
				{
					this.OnShort_Term_InvestmentsChanging(value);
					this.SendPropertyChanging();
					this._Short_Term_Investments = value;
					this.SendPropertyChanged("Short_Term_Investments");
					this.OnShort_Term_InvestmentsChanged();
				}
			}
		}
		
		[Column(Name="[Cash and Short Term Investments]", Storage="_Cash_and_Short_Term_Investments", DbType="Money")]
		public System.Nullable<decimal> Cash_and_Short_Term_Investments
		{
			get
			{
				return this._Cash_and_Short_Term_Investments;
			}
			set
			{
				if ((this._Cash_and_Short_Term_Investments != value))
				{
					this.OnCash_and_Short_Term_InvestmentsChanging(value);
					this.SendPropertyChanging();
					this._Cash_and_Short_Term_Investments = value;
					this.SendPropertyChanged("Cash_and_Short_Term_Investments");
					this.OnCash_and_Short_Term_InvestmentsChanged();
				}
			}
		}
		
		[Column(Name="[Accounts Receivable - Trade, Net]", Storage="_Accounts_Receivable___Trade__Net", DbType="Money")]
		public System.Nullable<decimal> Accounts_Receivable___Trade__Net
		{
			get
			{
				return this._Accounts_Receivable___Trade__Net;
			}
			set
			{
				if ((this._Accounts_Receivable___Trade__Net != value))
				{
					this.OnAccounts_Receivable___Trade__NetChanging(value);
					this.SendPropertyChanging();
					this._Accounts_Receivable___Trade__Net = value;
					this.SendPropertyChanged("Accounts_Receivable___Trade__Net");
					this.OnAccounts_Receivable___Trade__NetChanged();
				}
			}
		}
		
		[Column(Name="[Receivables - Other]", Storage="_Receivables___Other", DbType="Money")]
		public System.Nullable<decimal> Receivables___Other
		{
			get
			{
				return this._Receivables___Other;
			}
			set
			{
				if ((this._Receivables___Other != value))
				{
					this.OnReceivables___OtherChanging(value);
					this.SendPropertyChanging();
					this._Receivables___Other = value;
					this.SendPropertyChanged("Receivables___Other");
					this.OnReceivables___OtherChanged();
				}
			}
		}
		
		[Column(Name="[Total Receivables, Net]", Storage="_Total_Receivables__Net", DbType="Money")]
		public System.Nullable<decimal> Total_Receivables__Net
		{
			get
			{
				return this._Total_Receivables__Net;
			}
			set
			{
				if ((this._Total_Receivables__Net != value))
				{
					this.OnTotal_Receivables__NetChanging(value);
					this.SendPropertyChanging();
					this._Total_Receivables__Net = value;
					this.SendPropertyChanged("Total_Receivables__Net");
					this.OnTotal_Receivables__NetChanged();
				}
			}
		}
		
		[Column(Name="[Total Inventory]", Storage="_Total_Inventory", DbType="Money")]
		public System.Nullable<decimal> Total_Inventory
		{
			get
			{
				return this._Total_Inventory;
			}
			set
			{
				if ((this._Total_Inventory != value))
				{
					this.OnTotal_InventoryChanging(value);
					this.SendPropertyChanging();
					this._Total_Inventory = value;
					this.SendPropertyChanged("Total_Inventory");
					this.OnTotal_InventoryChanged();
				}
			}
		}
		
		[Column(Name="[Prepaid Expenses]", Storage="_Prepaid_Expenses", DbType="Money")]
		public System.Nullable<decimal> Prepaid_Expenses
		{
			get
			{
				return this._Prepaid_Expenses;
			}
			set
			{
				if ((this._Prepaid_Expenses != value))
				{
					this.OnPrepaid_ExpensesChanging(value);
					this.SendPropertyChanging();
					this._Prepaid_Expenses = value;
					this.SendPropertyChanged("Prepaid_Expenses");
					this.OnPrepaid_ExpensesChanged();
				}
			}
		}
		
		[Column(Name="[Other Current Assets, Total]", Storage="_Other_Current_Assets__Total", DbType="Money")]
		public System.Nullable<decimal> Other_Current_Assets__Total
		{
			get
			{
				return this._Other_Current_Assets__Total;
			}
			set
			{
				if ((this._Other_Current_Assets__Total != value))
				{
					this.OnOther_Current_Assets__TotalChanging(value);
					this.SendPropertyChanging();
					this._Other_Current_Assets__Total = value;
					this.SendPropertyChanged("Other_Current_Assets__Total");
					this.OnOther_Current_Assets__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Total Current Assets]", Storage="_Total_Current_Assets", DbType="Money")]
		public System.Nullable<decimal> Total_Current_Assets
		{
			get
			{
				return this._Total_Current_Assets;
			}
			set
			{
				if ((this._Total_Current_Assets != value))
				{
					this.OnTotal_Current_AssetsChanging(value);
					this.SendPropertyChanging();
					this._Total_Current_Assets = value;
					this.SendPropertyChanged("Total_Current_Assets");
					this.OnTotal_Current_AssetsChanged();
				}
			}
		}
		
		[Column(Name="[Property/Plant/Equipment, Total - Gross]", Storage="_Property_Plant_Equipment__Total___Gross", DbType="Money")]
		public System.Nullable<decimal> Property_Plant_Equipment__Total___Gross
		{
			get
			{
				return this._Property_Plant_Equipment__Total___Gross;
			}
			set
			{
				if ((this._Property_Plant_Equipment__Total___Gross != value))
				{
					this.OnProperty_Plant_Equipment__Total___GrossChanging(value);
					this.SendPropertyChanging();
					this._Property_Plant_Equipment__Total___Gross = value;
					this.SendPropertyChanged("Property_Plant_Equipment__Total___Gross");
					this.OnProperty_Plant_Equipment__Total___GrossChanged();
				}
			}
		}
		
		[Column(Name="[Goodwill, Net]", Storage="_Goodwill__Net", DbType="Money")]
		public System.Nullable<decimal> Goodwill__Net
		{
			get
			{
				return this._Goodwill__Net;
			}
			set
			{
				if ((this._Goodwill__Net != value))
				{
					this.OnGoodwill__NetChanging(value);
					this.SendPropertyChanging();
					this._Goodwill__Net = value;
					this.SendPropertyChanged("Goodwill__Net");
					this.OnGoodwill__NetChanged();
				}
			}
		}
		
		[Column(Name="[Intangibles, Net]", Storage="_Intangibles__Net", DbType="Money")]
		public System.Nullable<decimal> Intangibles__Net
		{
			get
			{
				return this._Intangibles__Net;
			}
			set
			{
				if ((this._Intangibles__Net != value))
				{
					this.OnIntangibles__NetChanging(value);
					this.SendPropertyChanging();
					this._Intangibles__Net = value;
					this.SendPropertyChanged("Intangibles__Net");
					this.OnIntangibles__NetChanged();
				}
			}
		}
		
		[Column(Name="[Long Term Investments]", Storage="_Long_Term_Investments", DbType="Money")]
		public System.Nullable<decimal> Long_Term_Investments
		{
			get
			{
				return this._Long_Term_Investments;
			}
			set
			{
				if ((this._Long_Term_Investments != value))
				{
					this.OnLong_Term_InvestmentsChanging(value);
					this.SendPropertyChanging();
					this._Long_Term_Investments = value;
					this.SendPropertyChanged("Long_Term_Investments");
					this.OnLong_Term_InvestmentsChanged();
				}
			}
		}
		
		[Column(Name="[Other Long Term Assets, Total]", Storage="_Other_Long_Term_Assets__Total", DbType="Money")]
		public System.Nullable<decimal> Other_Long_Term_Assets__Total
		{
			get
			{
				return this._Other_Long_Term_Assets__Total;
			}
			set
			{
				if ((this._Other_Long_Term_Assets__Total != value))
				{
					this.OnOther_Long_Term_Assets__TotalChanging(value);
					this.SendPropertyChanging();
					this._Other_Long_Term_Assets__Total = value;
					this.SendPropertyChanged("Other_Long_Term_Assets__Total");
					this.OnOther_Long_Term_Assets__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Total Assets]", Storage="_Total_Assets", DbType="Money")]
		public System.Nullable<decimal> Total_Assets
		{
			get
			{
				return this._Total_Assets;
			}
			set
			{
				if ((this._Total_Assets != value))
				{
					this.OnTotal_AssetsChanging(value);
					this.SendPropertyChanging();
					this._Total_Assets = value;
					this.SendPropertyChanged("Total_Assets");
					this.OnTotal_AssetsChanged();
				}
			}
		}
		
		[Column(Name="[Accounts Payable]", Storage="_Accounts_Payable", DbType="Money")]
		public System.Nullable<decimal> Accounts_Payable
		{
			get
			{
				return this._Accounts_Payable;
			}
			set
			{
				if ((this._Accounts_Payable != value))
				{
					this.OnAccounts_PayableChanging(value);
					this.SendPropertyChanging();
					this._Accounts_Payable = value;
					this.SendPropertyChanged("Accounts_Payable");
					this.OnAccounts_PayableChanged();
				}
			}
		}
		
		[Column(Name="[Accrued Expenses]", Storage="_Accrued_Expenses", DbType="Money")]
		public System.Nullable<decimal> Accrued_Expenses
		{
			get
			{
				return this._Accrued_Expenses;
			}
			set
			{
				if ((this._Accrued_Expenses != value))
				{
					this.OnAccrued_ExpensesChanging(value);
					this.SendPropertyChanging();
					this._Accrued_Expenses = value;
					this.SendPropertyChanged("Accrued_Expenses");
					this.OnAccrued_ExpensesChanged();
				}
			}
		}
		
		[Column(Name="[Notes Payable/Short Term Debt]", Storage="_Notes_Payable_Short_Term_Debt", DbType="Money")]
		public System.Nullable<decimal> Notes_Payable_Short_Term_Debt
		{
			get
			{
				return this._Notes_Payable_Short_Term_Debt;
			}
			set
			{
				if ((this._Notes_Payable_Short_Term_Debt != value))
				{
					this.OnNotes_Payable_Short_Term_DebtChanging(value);
					this.SendPropertyChanging();
					this._Notes_Payable_Short_Term_Debt = value;
					this.SendPropertyChanged("Notes_Payable_Short_Term_Debt");
					this.OnNotes_Payable_Short_Term_DebtChanged();
				}
			}
		}
		
		[Column(Name="[Current Port. of LT Debt/Capital Leases]", Storage="_Current_Port__of_LT_Debt_Capital_Leases", DbType="Money")]
		public System.Nullable<decimal> Current_Port__of_LT_Debt_Capital_Leases
		{
			get
			{
				return this._Current_Port__of_LT_Debt_Capital_Leases;
			}
			set
			{
				if ((this._Current_Port__of_LT_Debt_Capital_Leases != value))
				{
					this.OnCurrent_Port__of_LT_Debt_Capital_LeasesChanging(value);
					this.SendPropertyChanging();
					this._Current_Port__of_LT_Debt_Capital_Leases = value;
					this.SendPropertyChanged("Current_Port__of_LT_Debt_Capital_Leases");
					this.OnCurrent_Port__of_LT_Debt_Capital_LeasesChanged();
				}
			}
		}
		
		[Column(Name="[Other Current liabilities, Total]", Storage="_Other_Current_liabilities__Total", DbType="Money")]
		public System.Nullable<decimal> Other_Current_liabilities__Total
		{
			get
			{
				return this._Other_Current_liabilities__Total;
			}
			set
			{
				if ((this._Other_Current_liabilities__Total != value))
				{
					this.OnOther_Current_liabilities__TotalChanging(value);
					this.SendPropertyChanging();
					this._Other_Current_liabilities__Total = value;
					this.SendPropertyChanged("Other_Current_liabilities__Total");
					this.OnOther_Current_liabilities__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Total Current Liabilities]", Storage="_Total_Current_Liabilities", DbType="Money")]
		public System.Nullable<decimal> Total_Current_Liabilities
		{
			get
			{
				return this._Total_Current_Liabilities;
			}
			set
			{
				if ((this._Total_Current_Liabilities != value))
				{
					this.OnTotal_Current_LiabilitiesChanging(value);
					this.SendPropertyChanging();
					this._Total_Current_Liabilities = value;
					this.SendPropertyChanged("Total_Current_Liabilities");
					this.OnTotal_Current_LiabilitiesChanged();
				}
			}
		}
		
		[Column(Name="[Long Term Debt]", Storage="_Long_Term_Debt", DbType="Money")]
		public System.Nullable<decimal> Long_Term_Debt
		{
			get
			{
				return this._Long_Term_Debt;
			}
			set
			{
				if ((this._Long_Term_Debt != value))
				{
					this.OnLong_Term_DebtChanging(value);
					this.SendPropertyChanging();
					this._Long_Term_Debt = value;
					this.SendPropertyChanged("Long_Term_Debt");
					this.OnLong_Term_DebtChanged();
				}
			}
		}
		
		[Column(Name="[Capital Lease Obligations]", Storage="_Capital_Lease_Obligations", DbType="Money")]
		public System.Nullable<decimal> Capital_Lease_Obligations
		{
			get
			{
				return this._Capital_Lease_Obligations;
			}
			set
			{
				if ((this._Capital_Lease_Obligations != value))
				{
					this.OnCapital_Lease_ObligationsChanging(value);
					this.SendPropertyChanging();
					this._Capital_Lease_Obligations = value;
					this.SendPropertyChanged("Capital_Lease_Obligations");
					this.OnCapital_Lease_ObligationsChanged();
				}
			}
		}
		
		[Column(Name="[Total Long Term Debt]", Storage="_Total_Long_Term_Debt", DbType="Money")]
		public System.Nullable<decimal> Total_Long_Term_Debt
		{
			get
			{
				return this._Total_Long_Term_Debt;
			}
			set
			{
				if ((this._Total_Long_Term_Debt != value))
				{
					this.OnTotal_Long_Term_DebtChanging(value);
					this.SendPropertyChanging();
					this._Total_Long_Term_Debt = value;
					this.SendPropertyChanged("Total_Long_Term_Debt");
					this.OnTotal_Long_Term_DebtChanged();
				}
			}
		}
		
		[Column(Name="[Total Debt]", Storage="_Total_Debt", DbType="Money")]
		public System.Nullable<decimal> Total_Debt
		{
			get
			{
				return this._Total_Debt;
			}
			set
			{
				if ((this._Total_Debt != value))
				{
					this.OnTotal_DebtChanging(value);
					this.SendPropertyChanging();
					this._Total_Debt = value;
					this.SendPropertyChanged("Total_Debt");
					this.OnTotal_DebtChanged();
				}
			}
		}
		
		[Column(Name="[Deferred Income Tax]", Storage="_Deferred_Income_Tax", DbType="Money")]
		public System.Nullable<decimal> Deferred_Income_Tax
		{
			get
			{
				return this._Deferred_Income_Tax;
			}
			set
			{
				if ((this._Deferred_Income_Tax != value))
				{
					this.OnDeferred_Income_TaxChanging(value);
					this.SendPropertyChanging();
					this._Deferred_Income_Tax = value;
					this.SendPropertyChanged("Deferred_Income_Tax");
					this.OnDeferred_Income_TaxChanged();
				}
			}
		}
		
		[Column(Name="[Minority Interest]", Storage="_Minority_Interest", DbType="Money")]
		public System.Nullable<decimal> Minority_Interest
		{
			get
			{
				return this._Minority_Interest;
			}
			set
			{
				if ((this._Minority_Interest != value))
				{
					this.OnMinority_InterestChanging(value);
					this.SendPropertyChanging();
					this._Minority_Interest = value;
					this.SendPropertyChanged("Minority_Interest");
					this.OnMinority_InterestChanged();
				}
			}
		}
		
		[Column(Name="[Other Liabilities, Total]", Storage="_Other_Liabilities__Total", DbType="Money")]
		public System.Nullable<decimal> Other_Liabilities__Total
		{
			get
			{
				return this._Other_Liabilities__Total;
			}
			set
			{
				if ((this._Other_Liabilities__Total != value))
				{
					this.OnOther_Liabilities__TotalChanging(value);
					this.SendPropertyChanging();
					this._Other_Liabilities__Total = value;
					this.SendPropertyChanged("Other_Liabilities__Total");
					this.OnOther_Liabilities__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Total Liabilities]", Storage="_Total_Liabilities", DbType="Money")]
		public System.Nullable<decimal> Total_Liabilities
		{
			get
			{
				return this._Total_Liabilities;
			}
			set
			{
				if ((this._Total_Liabilities != value))
				{
					this.OnTotal_LiabilitiesChanging(value);
					this.SendPropertyChanging();
					this._Total_Liabilities = value;
					this.SendPropertyChanged("Total_Liabilities");
					this.OnTotal_LiabilitiesChanged();
				}
			}
		}
		
		[Column(Name="[Redeemable Preferred Stock, Total]", Storage="_Redeemable_Preferred_Stock__Total", DbType="Money")]
		public System.Nullable<decimal> Redeemable_Preferred_Stock__Total
		{
			get
			{
				return this._Redeemable_Preferred_Stock__Total;
			}
			set
			{
				if ((this._Redeemable_Preferred_Stock__Total != value))
				{
					this.OnRedeemable_Preferred_Stock__TotalChanging(value);
					this.SendPropertyChanging();
					this._Redeemable_Preferred_Stock__Total = value;
					this.SendPropertyChanged("Redeemable_Preferred_Stock__Total");
					this.OnRedeemable_Preferred_Stock__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Preferred Stock - Non Redeemable, Net]", Storage="_Preferred_Stock___Non_Redeemable__Net", DbType="Money")]
		public System.Nullable<decimal> Preferred_Stock___Non_Redeemable__Net
		{
			get
			{
				return this._Preferred_Stock___Non_Redeemable__Net;
			}
			set
			{
				if ((this._Preferred_Stock___Non_Redeemable__Net != value))
				{
					this.OnPreferred_Stock___Non_Redeemable__NetChanging(value);
					this.SendPropertyChanging();
					this._Preferred_Stock___Non_Redeemable__Net = value;
					this.SendPropertyChanged("Preferred_Stock___Non_Redeemable__Net");
					this.OnPreferred_Stock___Non_Redeemable__NetChanged();
				}
			}
		}
		
		[Column(Name="[Common Stock, Total]", Storage="_Common_Stock__Total", DbType="Money")]
		public System.Nullable<decimal> Common_Stock__Total
		{
			get
			{
				return this._Common_Stock__Total;
			}
			set
			{
				if ((this._Common_Stock__Total != value))
				{
					this.OnCommon_Stock__TotalChanging(value);
					this.SendPropertyChanging();
					this._Common_Stock__Total = value;
					this.SendPropertyChanged("Common_Stock__Total");
					this.OnCommon_Stock__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Additional Paid-In Capital]", Storage="_Additional_Paid_In_Capital", DbType="Money")]
		public System.Nullable<decimal> Additional_Paid_In_Capital
		{
			get
			{
				return this._Additional_Paid_In_Capital;
			}
			set
			{
				if ((this._Additional_Paid_In_Capital != value))
				{
					this.OnAdditional_Paid_In_CapitalChanging(value);
					this.SendPropertyChanging();
					this._Additional_Paid_In_Capital = value;
					this.SendPropertyChanged("Additional_Paid_In_Capital");
					this.OnAdditional_Paid_In_CapitalChanged();
				}
			}
		}
		
		[Column(Name="[Retained Earnings (Accumulated Deficit)]", Storage="_Retained_Earnings__Accumulated_Deficit_", DbType="Money")]
		public System.Nullable<decimal> Retained_Earnings__Accumulated_Deficit_
		{
			get
			{
				return this._Retained_Earnings__Accumulated_Deficit_;
			}
			set
			{
				if ((this._Retained_Earnings__Accumulated_Deficit_ != value))
				{
					this.OnRetained_Earnings__Accumulated_Deficit_Changing(value);
					this.SendPropertyChanging();
					this._Retained_Earnings__Accumulated_Deficit_ = value;
					this.SendPropertyChanged("Retained_Earnings__Accumulated_Deficit_");
					this.OnRetained_Earnings__Accumulated_Deficit_Changed();
				}
			}
		}
		
		[Column(Name="[Treasury Stock - Common]", Storage="_Treasury_Stock___Common", DbType="Money")]
		public System.Nullable<decimal> Treasury_Stock___Common
		{
			get
			{
				return this._Treasury_Stock___Common;
			}
			set
			{
				if ((this._Treasury_Stock___Common != value))
				{
					this.OnTreasury_Stock___CommonChanging(value);
					this.SendPropertyChanging();
					this._Treasury_Stock___Common = value;
					this.SendPropertyChanged("Treasury_Stock___Common");
					this.OnTreasury_Stock___CommonChanged();
				}
			}
		}
		
		[Column(Name="[Other Equity, Total]", Storage="_Other_Equity__Total", DbType="Money")]
		public System.Nullable<decimal> Other_Equity__Total
		{
			get
			{
				return this._Other_Equity__Total;
			}
			set
			{
				if ((this._Other_Equity__Total != value))
				{
					this.OnOther_Equity__TotalChanging(value);
					this.SendPropertyChanging();
					this._Other_Equity__Total = value;
					this.SendPropertyChanged("Other_Equity__Total");
					this.OnOther_Equity__TotalChanged();
				}
			}
		}
		
		[Column(Name="[Total Equity]", Storage="_Total_Equity", DbType="Money")]
		public System.Nullable<decimal> Total_Equity
		{
			get
			{
				return this._Total_Equity;
			}
			set
			{
				if ((this._Total_Equity != value))
				{
					this.OnTotal_EquityChanging(value);
					this.SendPropertyChanging();
					this._Total_Equity = value;
					this.SendPropertyChanged("Total_Equity");
					this.OnTotal_EquityChanged();
				}
			}
		}
		
		[Column(Name="[Total Liabilities & Shareholders\' Equity]", Storage="_Total_Liabilities___Shareholders__Equity", DbType="Money")]
		public System.Nullable<decimal> Total_Liabilities___Shareholders__Equity
		{
			get
			{
				return this._Total_Liabilities___Shareholders__Equity;
			}
			set
			{
				if ((this._Total_Liabilities___Shareholders__Equity != value))
				{
					this.OnTotal_Liabilities___Shareholders__EquityChanging(value);
					this.SendPropertyChanging();
					this._Total_Liabilities___Shareholders__Equity = value;
					this.SendPropertyChanged("Total_Liabilities___Shareholders__Equity");
					this.OnTotal_Liabilities___Shareholders__EquityChanged();
				}
			}
		}
		
		[Column(Name="[Shares Outs - Common Stock Primary Issue]", Storage="_Shares_Outs___Common_Stock_Primary_Issue", DbType="Money")]
		public System.Nullable<decimal> Shares_Outs___Common_Stock_Primary_Issue
		{
			get
			{
				return this._Shares_Outs___Common_Stock_Primary_Issue;
			}
			set
			{
				if ((this._Shares_Outs___Common_Stock_Primary_Issue != value))
				{
					this.OnShares_Outs___Common_Stock_Primary_IssueChanging(value);
					this.SendPropertyChanging();
					this._Shares_Outs___Common_Stock_Primary_Issue = value;
					this.SendPropertyChanged("Shares_Outs___Common_Stock_Primary_Issue");
					this.OnShares_Outs___Common_Stock_Primary_IssueChanged();
				}
			}
		}
		
		[Column(Name="[Total Common Shares Outstanding]", Storage="_Total_Common_Shares_Outstanding", DbType="Money")]
		public System.Nullable<decimal> Total_Common_Shares_Outstanding
		{
			get
			{
				return this._Total_Common_Shares_Outstanding;
			}
			set
			{
				if ((this._Total_Common_Shares_Outstanding != value))
				{
					this.OnTotal_Common_Shares_OutstandingChanging(value);
					this.SendPropertyChanging();
					this._Total_Common_Shares_Outstanding = value;
					this.SendPropertyChanged("Total_Common_Shares_Outstanding");
					this.OnTotal_Common_Shares_OutstandingChanged();
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
