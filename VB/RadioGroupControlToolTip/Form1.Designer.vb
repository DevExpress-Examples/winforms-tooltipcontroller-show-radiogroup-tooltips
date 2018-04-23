Imports Microsoft.VisualBasic
Imports System
Namespace RadioGroupControlToolTip
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.rGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.rGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rGroup
			' 
			Me.rGroup.Location = New System.Drawing.Point(12, 12)
			Me.rGroup.Name = "rGroup"
			Me.rGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Item 1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Item 2"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Item 3")})
			Me.rGroup.Size = New System.Drawing.Size(194, 97)
			Me.rGroup.TabIndex = 0
			Me.rGroup.ToolTipController = Me.toolTipController1
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.GetActiveObjectInfo += New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(Me.toolTipController1_GetActiveObjectInfo);
			' 
			' FormMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(435, 373)
			Me.Controls.Add(Me.rGroup)
			Me.Name = "FormMain"
			Me.Text = "Main form"
			CType(Me.rGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rGroup As DevExpress.XtraEditors.RadioGroup
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

