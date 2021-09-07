' Developer Express Code Central Example:
' How to display a check box within column headers
' 
' This example demonstrates how to display a check box within column headers. If
' the check box is checked, the corresponding column is made read-only. Uncheck
' the check box to allow column values to be edited.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1517

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid

Namespace DXGrid_ShowCheckBoxInColumnHeaders
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
			CreateList()
			DataContext = Me

		End Sub
		Public Property ListPerson() As List(Of Person)
		Private Sub CreateList()
			ListPerson = New List(Of Person)()
			For i As Integer = 0 To 9
				ListPerson.Add(New Person(i))
			Next i
		End Sub
	End Class

	Public Class Person
		Public Sub New(ByVal i As Integer)
			FirstName = "FirstName" & i
			LastName = "LastName" & i
			Age = i * 10
		End Sub
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Age() As Integer


	End Class
End Namespace
