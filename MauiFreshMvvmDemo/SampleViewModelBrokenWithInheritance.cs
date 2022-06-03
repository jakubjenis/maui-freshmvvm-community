using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiFreshMvvmDemo
{
    /// <summary>
    /// Doesn't work, because INotifyPropertyChanged is already implemented in FreshBaseContentPage
    /// Source generator cannot generate duplicate implementation in ancestor
    /// Error MVVMTK0004  Cannot apply[INotifyPropertyChanged] to type MauiFreshMvvmDemo.SampleViewModelBrokenWithInheritance, 
    /// as it already declares the INotifyPropertyChanged interface MauiFreshMvvmDemo
    /// </summary>
    [INotifyPropertyChanged]
    public partial class SampleViewModelBrokenWithInheritance : FreshMvvm.Maui.FreshBasePageModel
    {
        [ObservableProperty]
        int _bla;
    }
}
