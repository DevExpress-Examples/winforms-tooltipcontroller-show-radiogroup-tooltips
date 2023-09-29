<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618918/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3475)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms RadioGroup - Display item tooltips using ToolTipController

This example demonstrates how to use the WinForms ToolTipController component to display hints for items in a radio group.

The example assigns the `ToolTipController` to the radio group's [ToolTipController](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Container.EditorContainer.ToolTipController) property and handles the [ToolTipController.GetActiveObjectInfo](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController.GetActiveObjectInfo) event to display an item's description in the tooltip:

```csharp
private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {
    RadioGroup rg = e.SelectedControl as RadioGroup;
    if (rg == null) return;
    for (int i = 0; i < rGroup.Properties.Items.Count; i++) {
        Rectangle rect = rGroup.GetItemRectangle(i);
        if (rect.Contains(e.ControlMousePosition)) {
            e.Info = new ToolTipControlInfo(i, rGroup.Properties.Items[i].Description);
            break;
        }
    }
}
```


## Files to Review

* [Form1.cs](./CS/RadioGroupControlToolTip/Form1.cs) (VB: [Form1.vb](./VB/RadioGroupControlToolTip/Form1.vb))


## Documentation

* [Hints and Tooltips](https://docs.devexpress.com/WindowsForms/2398/common-features/tooltips)


## See Also

* [WinForms ListBoxControl - Display item tooltips](https://github.com/DevExpress-Examples/winforms-listbox-show-item-tooltips)
