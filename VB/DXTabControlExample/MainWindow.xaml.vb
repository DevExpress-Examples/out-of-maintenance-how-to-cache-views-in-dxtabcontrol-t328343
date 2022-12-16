Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Controls

Namespace DXTabControlExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub OnShowTestWindowButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim window As TestWindow = New TestWindow(CType(Me.cacheModeComboBox.EditValue, TabContentCacheMode))
            window.Show()
        End Sub
    End Class
End Namespace
