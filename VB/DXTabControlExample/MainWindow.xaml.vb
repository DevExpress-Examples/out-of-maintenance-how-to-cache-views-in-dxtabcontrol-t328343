Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
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
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DXTabControlExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXWindow

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnShowTestWindowButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim window As New TestWindow(CType(cacheModeComboBox.EditValue, TabContentCacheMode))
			window.Show()
		End Sub

	End Class
End Namespace
