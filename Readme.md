<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128627669/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E538)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Display Images from a data field with image paths

This example creates an unbound column and handles the [CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData) event to display images within grid cells when a data source contains the file names of images stored on a local disk (the **Images** folder). The event handler loads images, caches them in a hash table, and displays them within appropriate cells.


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


Documentation

* [How to: Display Images from a Data Field with Image Paths](https://docs.devexpress.com/WindowsForms/403845/controls-and-libraries/data-grid/examples/data-presentation/how-to-display-images-from-url)
