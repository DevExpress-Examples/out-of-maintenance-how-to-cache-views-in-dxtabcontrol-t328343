Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes

Namespace DXTabControlExample
	''' <summary>
	''' Interaction logic for TestWindow.xaml
	''' </summary>
	Partial Public Class TestWindow
		Inherits Window

		Public Sub New(ByVal tabCacheMode As TabContentCacheMode)
			InitializeComponent()
			tabControl.TabContentCacheMode = tabCacheMode
			Dim items As New ObservableCollection(Of Item)()
			For i As Integer = 0 To 14
				items.Add(New Item() With {.Name = "Item" & i})
			Next i
			tabControl.ItemsSource = items
		End Sub
	End Class

	Public Class Item
		Public Property Name() As String
	End Class
End Namespace
