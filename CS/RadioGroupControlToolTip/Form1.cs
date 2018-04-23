using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;




namespace RadioGroupControlToolTip
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            RadioGroup rg = e.SelectedControl as RadioGroup;
            if (rg == null) return;

            for (int i = 0; i < rGroup.Properties.Items.Count; i++)
            {
                Rectangle rect = rGroup.GetItemRectangle(i);
                
                if (rect.Contains(e.ControlMousePosition))
                {
                    e.Info = new ToolTipControlInfo(i, rGroup.Properties.Items[i].Description);
                    break;
                }
            }
        }
    }
}