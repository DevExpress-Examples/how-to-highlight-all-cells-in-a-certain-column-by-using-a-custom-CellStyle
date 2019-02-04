# How to highlight all cells in a certain column by using a custom CellStyle

The attached project illustrates how a custom [CellStyle](https://docs.devexpress.com/Win10Apps/DevExpress.UI.Xaml.Grid.ColumnBase.CellStyle) can help you highlight cells in a certain column. The **TargetType** property should be set to ***CellControl*** in such a style. Set related properties to desired values to change the appearance in corresponding cells:

```xaml
<dxg:GridTextColumn.CellStyle>
    <Style TargetType="dxg:CellControl">
        <Setter Property="FontWeight" Value="Bold"/>
        <Setter Property="FontStyle" Value="Italic"/>
        <Setter Property="FontSize" Value="16"/>
        <Setter Property="Background" Value="#A3FF8000"/>
    </Style>
</dxg:GridTextColumn.CellStyle>
```

If you want to change the appearance in all GridControl cells, you can use the [CellStyle](https://docs.devexpress.com/Win10Apps/DevExpress.UI.Xaml.Grid.DataControlBase.CellStyle) from the [GridControl](https://docs.devexpress.com/Win10Apps/DevExpress.UI.Xaml.Grid.GridControl) class. Note that a style defined at the column level has a higher priority.