namespace RadioGroupControlToolTip
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rGroup = new DevExpress.XtraEditors.RadioGroup();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rGroup
            // 
            this.rGroup.Location = new System.Drawing.Point(12, 12);
            this.rGroup.Name = "rGroup";
            this.rGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Item 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Item 2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Item 3")});
            this.rGroup.Size = new System.Drawing.Size(194, 97);
            this.rGroup.TabIndex = 0;
            this.rGroup.ToolTipController = this.toolTipController1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 373);
            this.Controls.Add(this.rGroup);
            this.Name = "FormMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.rGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rGroup;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

