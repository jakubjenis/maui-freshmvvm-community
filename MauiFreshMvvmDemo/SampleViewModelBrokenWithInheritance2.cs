using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiFreshMvvmDemo
{
    /// <summary>
    /// This seems like it could work - INotifyPropertyChanged is implemented in FreshBaseContentPage
    /// We only want to raise the PropertyChanged event inside the generated property
    /// But since the generator is relying on a precide OnPropertyChanged signature, that is not present in FreshBaseContentPage, it does not work
    /// Error CS1503  Argument 1: cannot convert from 'System.ComponentModel.PropertyChangedEventArgs' to 'string'	
    /// </summary>
    public partial class SampleViewModelBrokenWithInheritance2 : FreshMvvm.Maui.FreshBasePageModel
    {
        [ObservableProperty]
        int _bla;
    }
}
