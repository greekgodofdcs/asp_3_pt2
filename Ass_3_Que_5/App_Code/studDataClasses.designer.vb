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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Student_Managment_System")>  _
Partial Public Class studDataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertTblClass(instance As TblClass)
    End Sub
  Partial Private Sub UpdateTblClass(instance As TblClass)
    End Sub
  Partial Private Sub DeleteTblClass(instance As TblClass)
    End Sub
  Partial Private Sub InsertTblCourse(instance As TblCourse)
    End Sub
  Partial Private Sub UpdateTblCourse(instance As TblCourse)
    End Sub
  Partial Private Sub DeleteTblCourse(instance As TblCourse)
    End Sub
  Partial Private Sub InsertTblStudent(instance As TblStudent)
    End Sub
  Partial Private Sub UpdateTblStudent(instance As TblStudent)
    End Sub
  Partial Private Sub DeleteTblStudent(instance As TblStudent)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("Student_Managment_SystemConnectionString").ConnectionString, mappingSource)
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
	
	Public ReadOnly Property TblClasses() As System.Data.Linq.Table(Of TblClass)
		Get
			Return Me.GetTable(Of TblClass)
		End Get
	End Property
	
	Public ReadOnly Property TblCourses() As System.Data.Linq.Table(Of TblCourse)
		Get
			Return Me.GetTable(Of TblCourse)
		End Get
	End Property
	
	Public ReadOnly Property TblStudents() As System.Data.Linq.Table(Of TblStudent)
		Get
			Return Me.GetTable(Of TblStudent)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblClass")>  _
Partial Public Class TblClass
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Class_Id As String
	
	Private _Course_Id As String
	
	Private _Class_Name As String
	
	Private _TblStudents As EntitySet(Of TblStudent)
	
	Private _TblCourse As EntityRef(Of TblCourse)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnClass_IdChanging(value As String)
    End Sub
    Partial Private Sub OnClass_IdChanged()
    End Sub
    Partial Private Sub OnCourse_IdChanging(value As String)
    End Sub
    Partial Private Sub OnCourse_IdChanged()
    End Sub
    Partial Private Sub OnClass_NameChanging(value As String)
    End Sub
    Partial Private Sub OnClass_NameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblStudents = New EntitySet(Of TblStudent)(AddressOf Me.attach_TblStudents, AddressOf Me.detach_TblStudents)
		Me._TblCourse = CType(Nothing, EntityRef(Of TblCourse))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Class_Id", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Class_Id() As String
		Get
			Return Me._Class_Id
		End Get
		Set
			If (String.Equals(Me._Class_Id, value) = false) Then
				Me.OnClass_IdChanging(value)
				Me.SendPropertyChanging
				Me._Class_Id = value
				Me.SendPropertyChanged("Class_Id")
				Me.OnClass_IdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Course_Id", DbType:="VarChar(50)")>  _
	Public Property Course_Id() As String
		Get
			Return Me._Course_Id
		End Get
		Set
			If (String.Equals(Me._Course_Id, value) = false) Then
				If Me._TblCourse.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnCourse_IdChanging(value)
				Me.SendPropertyChanging
				Me._Course_Id = value
				Me.SendPropertyChanged("Course_Id")
				Me.OnCourse_IdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Class_Name", DbType:="VarChar(50)")>  _
	Public Property Class_Name() As String
		Get
			Return Me._Class_Name
		End Get
		Set
			If (String.Equals(Me._Class_Name, value) = false) Then
				Me.OnClass_NameChanging(value)
				Me.SendPropertyChanging
				Me._Class_Name = value
				Me.SendPropertyChanged("Class_Name")
				Me.OnClass_NameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblClass_TblStudent", Storage:="_TblStudents", ThisKey:="Class_Id", OtherKey:="Class")>  _
	Public Property TblStudents() As EntitySet(Of TblStudent)
		Get
			Return Me._TblStudents
		End Get
		Set
			Me._TblStudents.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblCourse_TblClass", Storage:="_TblCourse", ThisKey:="Course_Id", OtherKey:="Course_Id", IsForeignKey:=true)>  _
	Public Property TblCourse() As TblCourse
		Get
			Return Me._TblCourse.Entity
		End Get
		Set
			Dim previousValue As TblCourse = Me._TblCourse.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TblCourse.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TblCourse.Entity = Nothing
					previousValue.TblClasses.Remove(Me)
				End If
				Me._TblCourse.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.TblClasses.Add(Me)
					Me._Course_Id = value.Course_Id
				Else
					Me._Course_Id = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("TblCourse")
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
	
	Private Sub attach_TblStudents(ByVal entity As TblStudent)
		Me.SendPropertyChanging
		entity.TblClass = Me
	End Sub
	
	Private Sub detach_TblStudents(ByVal entity As TblStudent)
		Me.SendPropertyChanging
		entity.TblClass = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblCourse")>  _
Partial Public Class TblCourse
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Course_Id As String
	
	Private _Cname As String
	
	Private _TblClasses As EntitySet(Of TblClass)
	
	Private _TblStudents As EntitySet(Of TblStudent)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCourse_IdChanging(value As String)
    End Sub
    Partial Private Sub OnCourse_IdChanged()
    End Sub
    Partial Private Sub OnCnameChanging(value As String)
    End Sub
    Partial Private Sub OnCnameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblClasses = New EntitySet(Of TblClass)(AddressOf Me.attach_TblClasses, AddressOf Me.detach_TblClasses)
		Me._TblStudents = New EntitySet(Of TblStudent)(AddressOf Me.attach_TblStudents, AddressOf Me.detach_TblStudents)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Course_Id", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Course_Id() As String
		Get
			Return Me._Course_Id
		End Get
		Set
			If (String.Equals(Me._Course_Id, value) = false) Then
				Me.OnCourse_IdChanging(value)
				Me.SendPropertyChanging
				Me._Course_Id = value
				Me.SendPropertyChanged("Course_Id")
				Me.OnCourse_IdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cname", DbType:="VarChar(50)")>  _
	Public Property Cname() As String
		Get
			Return Me._Cname
		End Get
		Set
			If (String.Equals(Me._Cname, value) = false) Then
				Me.OnCnameChanging(value)
				Me.SendPropertyChanging
				Me._Cname = value
				Me.SendPropertyChanged("Cname")
				Me.OnCnameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblCourse_TblClass", Storage:="_TblClasses", ThisKey:="Course_Id", OtherKey:="Course_Id")>  _
	Public Property TblClasses() As EntitySet(Of TblClass)
		Get
			Return Me._TblClasses
		End Get
		Set
			Me._TblClasses.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblCourse_TblStudent", Storage:="_TblStudents", ThisKey:="Course_Id", OtherKey:="Course")>  _
	Public Property TblStudents() As EntitySet(Of TblStudent)
		Get
			Return Me._TblStudents
		End Get
		Set
			Me._TblStudents.Assign(value)
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
	
	Private Sub attach_TblClasses(ByVal entity As TblClass)
		Me.SendPropertyChanging
		entity.TblCourse = Me
	End Sub
	
	Private Sub detach_TblClasses(ByVal entity As TblClass)
		Me.SendPropertyChanging
		entity.TblCourse = Nothing
	End Sub
	
	Private Sub attach_TblStudents(ByVal entity As TblStudent)
		Me.SendPropertyChanging
		entity.TblCourse = Me
	End Sub
	
	Private Sub detach_TblStudents(ByVal entity As TblStudent)
		Me.SendPropertyChanging
		entity.TblCourse = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TblStudent")>  _
Partial Public Class TblStudent
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _EnRollNo As String
	
	Private _RollNo As String
	
	Private _Name As String
	
	Private _Class As String
	
	Private _Course As String
	
	Private _Email As String
	
	Private _Mobile As String
	
	Private _DOB As String
	
	Private _TblClass As EntityRef(Of TblClass)
	
	Private _TblCourse As EntityRef(Of TblCourse)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnEnRollNoChanging(value As String)
    End Sub
    Partial Private Sub OnEnRollNoChanged()
    End Sub
    Partial Private Sub OnRollNoChanging(value As String)
    End Sub
    Partial Private Sub OnRollNoChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnCourseChanging(value As String)
    End Sub
    Partial Private Sub OnCourseChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnMobileChanging(value As String)
    End Sub
    Partial Private Sub OnMobileChanged()
    End Sub
    Partial Private Sub OnDOBChanging(value As String)
    End Sub
    Partial Private Sub OnDOBChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TblClass = CType(Nothing, EntityRef(Of TblClass))
		Me._TblCourse = CType(Nothing, EntityRef(Of TblCourse))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EnRollNo", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property EnRollNo() As String
		Get
			Return Me._EnRollNo
		End Get
		Set
			If (String.Equals(Me._EnRollNo, value) = false) Then
				Me.OnEnRollNoChanging(value)
				Me.SendPropertyChanging
				Me._EnRollNo = value
				Me.SendPropertyChanged("EnRollNo")
				Me.OnEnRollNoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RollNo", DbType:="VarChar(50)")>  _
	Public Property RollNo() As String
		Get
			Return Me._RollNo
		End Get
		Set
			If (String.Equals(Me._RollNo, value) = false) Then
				Me.OnRollNoChanging(value)
				Me.SendPropertyChanging
				Me._RollNo = value
				Me.SendPropertyChanged("RollNo")
				Me.OnRollNoChanged
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="VarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				If Me._TblClass.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Course", DbType:="VarChar(50)")>  _
	Public Property Course() As String
		Get
			Return Me._Course
		End Get
		Set
			If (String.Equals(Me._Course, value) = false) Then
				If Me._TblCourse.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnCourseChanging(value)
				Me.SendPropertyChanging
				Me._Course = value
				Me.SendPropertyChanged("Course")
				Me.OnCourseChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="VarChar(50)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Mobile", DbType:="VarChar(50)")>  _
	Public Property Mobile() As String
		Get
			Return Me._Mobile
		End Get
		Set
			If (String.Equals(Me._Mobile, value) = false) Then
				Me.OnMobileChanging(value)
				Me.SendPropertyChanging
				Me._Mobile = value
				Me.SendPropertyChanged("Mobile")
				Me.OnMobileChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOB", DbType:="VarChar(50)")>  _
	Public Property DOB() As String
		Get
			Return Me._DOB
		End Get
		Set
			If (String.Equals(Me._DOB, value) = false) Then
				Me.OnDOBChanging(value)
				Me.SendPropertyChanging
				Me._DOB = value
				Me.SendPropertyChanged("DOB")
				Me.OnDOBChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblClass_TblStudent", Storage:="_TblClass", ThisKey:="Class", OtherKey:="Class_Id", IsForeignKey:=true)>  _
	Public Property TblClass() As TblClass
		Get
			Return Me._TblClass.Entity
		End Get
		Set
			Dim previousValue As TblClass = Me._TblClass.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TblClass.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TblClass.Entity = Nothing
					previousValue.TblStudents.Remove(Me)
				End If
				Me._TblClass.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.TblStudents.Add(Me)
					Me._Class = value.Class_Id
				Else
					Me._Class = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("TblClass")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TblCourse_TblStudent", Storage:="_TblCourse", ThisKey:="Course", OtherKey:="Course_Id", IsForeignKey:=true)>  _
	Public Property TblCourse() As TblCourse
		Get
			Return Me._TblCourse.Entity
		End Get
		Set
			Dim previousValue As TblCourse = Me._TblCourse.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TblCourse.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TblCourse.Entity = Nothing
					previousValue.TblStudents.Remove(Me)
				End If
				Me._TblCourse.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.TblStudents.Add(Me)
					Me._Course = value.Course_Id
				Else
					Me._Course = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("TblCourse")
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
