# How-to-add-Header-and-Footer-support-in-DOTNET-MAUI-Autocomplete
This repository contains a sample demonstrating of Header and Footer support in .NET MAUI Autocomplete.

## Header and Footer support in .NET MAUI Autocomplete (SfAutocomplete)

We can provide Header and Footer view in the dropdown in SfAutocomplete by enabling ShowDropDownHeaderView and ShowDropDownFooterView.

## Header Content
We can provide Header Content at the top of the Autocomplete’s dropdown.DropDownHeaderView property is used to set the content of the header. The height of the Header in the SfAutocomplete can be adjusted by the property DropDownHeaderViewHeight.

**XAML**
```
  <StackLayout VerticalOptions="Start" 
                 HorizontalOptions="Start" 
                 Padding="30">
        <autocomplete:SfAutocomplete HeightRequest="40"
                                     ShowDropDownHeaderView ="True"
                                     ItemsSource="{Binding SocialMedias}"
                                     DisplayMemberPath="Name"
                                     DropDownHeaderViewHeight="50">
            <autocomplete:SfAutocomplete.DropDownHeaderView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  x:Name="SearchLabel" 
                            FontSize="20" 
                            VerticalTextAlignment="Center" 
                            HorizontalOptions="Center" 
                            VerticalOptions="Center" 
                            TextColor="#006bcd"   />
                </StackLayout>
            </autocomplete:SfAutocomplete.DropDownHeaderView>
        </autocomplete:SfAutocomplete>
    </StackLayout>
```

## Footer Content

We can provide Footer Content at the bottom of the Autocomplete’s dropdown. DropDownFooterView property is used to set the content of the footer.The height of the Footer in the SfAutocomplete can be adjusted by the property DropDownFooterViewHeight.

The following code example illustrate how to set Footer content in SfAutocomplete.

**XAML**

```
 <StackLayout VerticalOptions="Start" 
                 HorizontalOptions="Start" 
                 Padding="30">
        <autocomplete:SfAutocomplete HeightRequest="40"
                                     ShowDropDownFooterView ="True"
                                     ItemsSource = "{Binding SocialMedias}"
                                     DisplayMemberPath="Name"
                                     DropDownFooterViewHeight="50">
            <autocomplete:SfAutocomplete.DropDownFooterView>
                <StackLayout BackgroundColor="#f0f0f0" >
                    <Label  Text="Add New"
                            FontSize="20" 
                            VerticalTextAlignment="Center" 
                            HorizontalOptions="Center" 
                            VerticalOptions="Center" 
                            TextColor="#006bcd" />
                </StackLayout>
            </autocomplete:SfAutocomplete.DropDownFooterView>
        </autocomplete:SfAutocomplete>
    </StackLayout>
```