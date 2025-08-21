# How to animate the listview items?
This example demonstrates how to the animation the listview items while scrolling.

## Sample

```xaml
    <listView:SfListView x:Name="listView"
                        ItemsSource="{Binding CustomerDetails}">
        <listView:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid x:Name="grid">
                     <Grid.RowDefinitions>
                         <RowDefinition Height="*" />
                         <RowDefinition Height="1" />
                     </Grid.RowDefinitions>
                     . . .
                     . . .
                          <Label LineBreakMode="NoWrap"
                        Text="{Binding ContactName}"
                                    FontAttributes="Bold"
                        TextColor="Teal"/>
                          <Label Grid.Row="1"
                        Grid.Column="0"
                        LineBreakMode="NoWrap"
                        Text="{Binding ContactNumber}"
                        TextColor="Teal"/>
                         . . .
                         . . .
                        </Grid>
            </DataTemplate>
        </listView:SfListView.ItemTemplate>
    </listView:SfListView>
</Grid>

    public class ItemGeneratorExt : ItemGenerator
    {        
        public ItemGeneratorExt(SfListView listview) : base(listview)
        {
            
        }
        protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
                return new ListViewItemExt();
            return base.OnCreateListViewItem(itemIndex, type, data);
        }
    }
    public class ListViewItemExt : ListViewItem
    {        
        public ListViewItemExt()
        {            
        }
        protected override void OnItemAppearing()
        {
           this.Opacity = 0;
            this.FadeTo(1, 400, Easing.SinInOut);
            base.OnItemAppearing();
        }       
    }

listView.ItemGenerator = new ItemGeneratorExt(listView);
```


## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
