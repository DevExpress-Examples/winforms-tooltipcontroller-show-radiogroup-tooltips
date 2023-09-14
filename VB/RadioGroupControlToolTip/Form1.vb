Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace RadioGroupControlToolTip

    Public Partial Class FormMain
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            Dim rg As RadioGroup = TryCast(e.SelectedControl, RadioGroup)
            If rg Is Nothing Then Return
            For i As Integer = 0 To rGroup.Properties.Items.Count - 1
                Dim rect As Rectangle = rGroup.GetItemRectangle(i)
                If rect.Contains(e.ControlMousePosition) Then
                    e.Info = New ToolTipControlInfo(i, rGroup.Properties.Items(i).Description)
                    Exit For
                End If
            Next
        End Sub
    End Class
End Namespace
