using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiFreshMvvmDemo
{
    public partial class SampleViewModelBrokenWithInheritance2 : FreshMvvm.Maui.FreshBaseContentPage
    {
        [ObservableProperty]
        int _bla;
    }
}
