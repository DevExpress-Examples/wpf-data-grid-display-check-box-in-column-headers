Imports System.Collections.ObjectModel
Imports System.Windows

Namespace DXGrid_ShowCheckBoxInColumnHeaders

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim people As ObservableCollection(Of Person) = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 10 - 1
                people.Add(New Person(i))
            Next

            Me.grid.ItemsSource = people
        End Sub
    End Class

    Public Class Person

        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            LastName = "LastName" & i
            Age = i * 10
        End Sub

        Public Property FirstName As String

        Public Property LastName As String

        Public Property Age As Integer
    End Class
End Namespace
