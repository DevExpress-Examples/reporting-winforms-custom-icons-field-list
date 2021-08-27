<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602911/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2706)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomFieldListService.cs](./CS/CustomFieldListService.cs) (VB: [CustomFieldListService.vb](./VB/CustomFieldListService.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to provide custom icons for the Field List in the End-User Designer


<p>The following example demonstrates how to provide custom images for <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument4259"><u>Field List</u></a> elements.</p><p><br />
See also: <a href="https://www.devexpress.com/Support/Center/p/E459">How to provide custom names for the Field List data items</a>.</p>


<h3>Description</h3>

<p>To accomplish this task, it is necessary to create a custom Field List service inherited from the base <strong>DevExpress.XtraReports.UserDesigner.FieldListService</strong> class and override the <strong>GetColumnImageIndex</strong> method. Then, to active this custom service it is necessary to assign its instance to the <strong>FieldListService.Instance</strong> static property.</p>

<br/>


