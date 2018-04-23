Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors




Namespace RadioGroupControlToolTip
	Partial Public Class FormMain
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub



		Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			Dim rg As RadioGroup = TryCast(e.SelectedControl, RadioGroup)
			If rg Is Nothing Then
				Return
			End If

			For i As Integer = 0 To rGroup.Properties.Items.Count - 1
				Dim rect As Rectangle = rGroup.GetItemRectangle(i)

				If rect.Contains(e.ControlMousePosition) Then
					e.Info = New ToolTipControlInfo(i, rGroup.Properties.Items(i).Description)
					Exit For
				End If
			Next i
		End Sub
	End Class
End Namespace