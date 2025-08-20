# How to animate the listview items?
This example demonstrates how to the animation the listview items while scrolling.

## Sample

```xaml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="50" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>

    <SearchBar x:Name="filterText"
        Placeholder="Search here to filter"
        Grid.Row="0">
        <SearchBar.HeightRequest>
            <OnPlatform x:TypeArguments="x:Double"
                Android="50"
                iOS="50">
                <OnPlatform.WinPhone>
                    <OnIdiom x:TypeArguments="x:Double">
                        <OnIdiom.Phone>40</OnIdiom.Phone>
                        <OnIdiom.Tablet>40</OnIdiom.Tablet>
                    </OnIdiom>
                </OnPlatform.WinPhone>
            </OnPlatform>
        </SearchBar.HeightRequest>
    </SearchBar>

    <listView:SfListView x:Name="listView" Grid.Row="1" ItemSize="60" AllowGroupExpandCollapse="True"
                        ItemsSource="{Binding CustomerDetails}">
        <!--<listView:SfListView.DataSource>
            <data:DataSource>
                <data:DataSource.GroupDescriptors>
                    <data:GroupDescriptor PropertyName="ContactType" />
                </data:DataSource.GroupDescriptors>
            </data:DataSource>
        </listView:SfListView.DataSource>-->
        <listView:SfListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>

                            <Grid Grid.Column="0"
                    RowSpacing="1"
                    Padding="0,0,0,0"
                    VerticalOptions="Start">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="*" />
                                    <RowDefinition Height="*" />
                                </Grid.RowDefinitions>

                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="*" />
                                    <ColumnDefinition Width="*" />
                                </Grid.ColumnDefinitions>

                                <Label LineBreakMode="NoWrap"
                        Text="{Binding ContactName}"
                                    FontAttributes="Bold"
                        TextColor="Teal">
                                    <Label.FontSize>
                                        <OnPlatform x:TypeArguments="x:Double">
                                            <OnPlatform.WinPhone>
                                                <OnIdiom x:TypeArguments="x:Double" Phone="18" Tablet="20" />
                                            </OnPlatform.WinPhone>
                                            <OnPlatform.Android>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="16"
                                Tablet="18" />
                                            </OnPlatform.Android>
                                            <OnPlatform.iOS>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="18"
                                Tablet="20" />
                                            </OnPlatform.iOS>
                                        </OnPlatform>
                                    </Label.FontSize>
                                </Label>
                                <Label Grid.Row="1"
                        Grid.Column="0"
                        LineBreakMode="NoWrap"
                        Text="{Binding ContactNumber}"
                        TextColor="Teal">
                                    <Label.FontSize>
                                        <OnPlatform x:TypeArguments="x:Double">
                                            <OnPlatform.WinPhone>
                                                <OnIdiom x:TypeArguments="x:Double" Phone="12" Tablet="12" />
                                            </OnPlatform.WinPhone>
                                            <OnPlatform.Android>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="12"
                                Tablet="14" />
                                            </OnPlatform.Android>
                                            <OnPlatform.iOS>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="12"
                                Tablet="14" />
                                            </OnPlatform.iOS>
                                        </OnPlatform>
                                    </Label.FontSize>
                                </Label>
                                <Label LineBreakMode="NoWrap"
                Text="{Binding ContactType}"
                TextColor="Teal" Grid.Row="0" Grid.Column="1"  VerticalTextAlignment="End" XAlign="End" YAlign="End" Margin="5" >
                                    <Label.FontSize>
                                        <OnPlatform x:TypeArguments="x:Double">
                                            <OnPlatform.WinPhone>
                                                <OnIdiom x:TypeArguments="x:Double" Phone="10" Tablet="11" />
                                            </OnPlatform.WinPhone>
                                            <OnPlatform.Android>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="10"
                                Tablet="12" />
                                            </OnPlatform.Android>
                                            <OnPlatform.iOS>
                                                <OnIdiom x:TypeArguments="x:Double"
                                Phone="10"
                                Tablet="12" />
                                            </OnPlatform.iOS>
                                        </OnPlatform>
                                    </Label.FontSize>
                                </Label>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </listView:SfListView.ItemTemplate>
    </listView:SfListView>
</Grid>
```


## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
