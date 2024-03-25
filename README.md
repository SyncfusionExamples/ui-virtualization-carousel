# Xamarin Carousel View (SfCarousel) 

The Essential Xamarin Carousel control allows navigating through image data in an interactive way so that they can be viewed or selected. Also, provides various customization options for its item arrangements.

For know more details about Carousel: https://www.syncfusion.com/xamarin-ui-controls/xamarin-carousel-view

Carousel user guide documentation: https://help.syncfusion.com/xamarin/carousel-view/getting-started

## UIVirtualization in Xamarin Carousel View (SfCarousel)
In UI virtualization concept, only the number of items that can be adaptable to the viewport of our device are arranged. Even, if the numerous items have been added to the collection, it loads only the viewport adaptable count of the carousel Items. Items are added at the right of the view when swiping the countable items in forward direction. At the same time, same number of items are removed at the left of the view for maintaining the same viewport items count. Similarly, items are added at the left of the view when swiping in backward direction for maintaining the same viewport items count. At the time, the same number of items are removed at the right of the view. Using this mechanism, virtualization concept is achieved in the carousel control.

The following property has been used in UIVirtualization support:

*   EnableVirtualization

## EnableVirtualization
UI Virtualization concept is achieved by enabling the EnableVirtualization property.

NOTE
The default value of the EnableVirtualization property is false.

**[XAML]**
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:carousel="clr-namespace:Syncfusion.SfCarousel.XForms;assembly=Syncfusion.SfCarousel.XForms"
             xmlns:local="clr-namespace:CarouselSample"
             x:Class="CarouselSample.MainPage">
     <ContentPage.BindingContext>
        <local:CarouselViewModel />
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="itemTemplate">
                <Image Source="{Binding Image}"
                Aspect="AspectFit"/>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <carousel:SfCarousel x:Name="carousel"
            ItemTemplate="{StaticResource itemTemplate}"
            ItemsSource="{Binding ImageCollection}"
            ItemHeight="200"
            ItemWidth="200"
            ItemSpacing="2"
			ViewMode="Linear"
            EnableVirtualization="true">
        </carousel:SfCarousel>
    </ContentPage.Content>
</ContentPage>
```
## How to run this application?

To run this application, you need to first clone the ui-virtualization-carousel repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.