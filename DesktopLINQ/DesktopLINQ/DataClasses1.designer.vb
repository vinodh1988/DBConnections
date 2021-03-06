﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="tvs")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertPerson(instance As Person)
    End Sub
  Partial Private Sub UpdatePerson(instance As Person)
    End Sub
  Partial Private Sub DeletePerson(instance As Person)
    End Sub
  Partial Private Sub InsertEmployee(instance As Employee)
    End Sub
  Partial Private Sub UpdateEmployee(instance As Employee)
    End Sub
  Partial Private Sub DeleteEmployee(instance As Employee)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DesktopLINQ.My.MySettings.Default.tvsConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Persons() As System.Data.Linq.Table(Of Person)
		Get
			Return Me.GetTable(Of Person)
		End Get
	End Property
	
	Public ReadOnly Property Employees() As System.Data.Linq.Table(Of Employee)
		Get
			Return Me.GetTable(Of Employee)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Person")>  _
Partial Public Class Person
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Sno As Decimal
	
	Private _Name As String
	
	Private _City As String
	
	Private _Employees As EntitySet(Of Employee)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSnoChanging(value As Decimal)
    End Sub
    Partial Private Sub OnSnoChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Employees = New EntitySet(Of Employee)(AddressOf Me.attach_Employees, AddressOf Me.detach_Employees)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sno", DbType:="Decimal(3,0) NOT NULL", IsPrimaryKey:=true)>  _
	Public Property Sno() As Decimal
		Get
			Return Me._Sno
		End Get
		Set
			If ((Me._Sno = value)  _
						= false) Then
				Me.OnSnoChanging(value)
				Me.SendPropertyChanging
				Me._Sno = value
				Me.SendPropertyChanged("Sno")
				Me.OnSnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="VarChar(50)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Person_Employee", Storage:="_Employees", ThisKey:="Sno", OtherKey:="Sno")>  _
	Public Property Employees() As EntitySet(Of Employee)
		Get
			Return Me._Employees
		End Get
		Set
			Me._Employees.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Person = Me
	End Sub
	
	Private Sub detach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Person = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Employee")>  _
Partial Public Class Employee
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _EmployeeID As Decimal
	
	Private _Designation As String
	
	Private _AnnualIncome As Decimal
	
	Private _Sno As Decimal
	
	Private _Person As EntityRef(Of Person)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnEmployeeIDChanging(value As Decimal)
    End Sub
    Partial Private Sub OnEmployeeIDChanged()
    End Sub
    Partial Private Sub OnDesignationChanging(value As String)
    End Sub
    Partial Private Sub OnDesignationChanged()
    End Sub
    Partial Private Sub OnAnnualIncomeChanging(value As Decimal)
    End Sub
    Partial Private Sub OnAnnualIncomeChanged()
    End Sub
    Partial Private Sub OnSnoChanging(value As Decimal)
    End Sub
    Partial Private Sub OnSnoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Person = CType(Nothing, EntityRef(Of Person))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmployeeID", DbType:="Decimal(6,0) NOT NULL", IsPrimaryKey:=true)>  _
	Public Property EmployeeID() As Decimal
		Get
			Return Me._EmployeeID
		End Get
		Set
			If ((Me._EmployeeID = value)  _
						= false) Then
				Me.OnEmployeeIDChanging(value)
				Me.SendPropertyChanging
				Me._EmployeeID = value
				Me.SendPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Designation", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property Designation() As String
		Get
			Return Me._Designation
		End Get
		Set
			If (String.Equals(Me._Designation, value) = false) Then
				Me.OnDesignationChanging(value)
				Me.SendPropertyChanging
				Me._Designation = value
				Me.SendPropertyChanged("Designation")
				Me.OnDesignationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AnnualIncome", DbType:="Decimal(10,2) NOT NULL")>  _
	Public Property AnnualIncome() As Decimal
		Get
			Return Me._AnnualIncome
		End Get
		Set
			If ((Me._AnnualIncome = value)  _
						= false) Then
				Me.OnAnnualIncomeChanging(value)
				Me.SendPropertyChanging
				Me._AnnualIncome = value
				Me.SendPropertyChanged("AnnualIncome")
				Me.OnAnnualIncomeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sno", DbType:="Decimal(3,0) NOT NULL")>  _
	Public Property Sno() As Decimal
		Get
			Return Me._Sno
		End Get
		Set
			If ((Me._Sno = value)  _
						= false) Then
				If Me._Person.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnSnoChanging(value)
				Me.SendPropertyChanging
				Me._Sno = value
				Me.SendPropertyChanged("Sno")
				Me.OnSnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Person_Employee", Storage:="_Person", ThisKey:="Sno", OtherKey:="Sno", IsForeignKey:=true)>  _
	Public Property Person() As Person
		Get
			Return Me._Person.Entity
		End Get
		Set
			Dim previousValue As Person = Me._Person.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Person.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Person.Entity = Nothing
					previousValue.Employees.Remove(Me)
				End If
				Me._Person.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Employees.Add(Me)
					Me._Sno = value.Sno
				Else
					Me._Sno = CType(Nothing, Decimal)
				End If
				Me.SendPropertyChanged("Person")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
