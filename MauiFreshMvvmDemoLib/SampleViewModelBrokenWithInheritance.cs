using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiFreshMvvmDemo
{
    [INotifyPropertyChanged]
    public partial class SampleViewModelBrokenWithInheritance : FreshMvvm.Maui.FreshBaseContentPage
    {
        [ObservableProperty]
        int _bla;
    }
}
