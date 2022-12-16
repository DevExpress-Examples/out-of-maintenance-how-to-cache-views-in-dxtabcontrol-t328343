Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace DXTabControlExample

    ''' <summary>
    ''' Interaction logic for TestWindow.xaml
    ''' </summary>
    Public Partial Class TestWindow
        Inherits Window

        Public Sub New(ByVal tabCacheMode As TabContentCacheMode)
            Me.InitializeComponent()
            Me.tabControl.TabContentCacheMode = tabCacheMode
            Dim items As ObservableCollection(Of Item) = New ObservableCollection(Of Item)()
            For i As Integer = 0 To 15 - 1
                items.Add(New Item() With {.Name = "Item" & i})
            Next

            Me.tabControl.ItemsSource = items
        End Sub
    End Class

    Public Class Item

        Public Property Name As String
    End Class
End Namespace
