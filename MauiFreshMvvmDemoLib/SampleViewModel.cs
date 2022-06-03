using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiFreshMvvmDemo
{
    /// <summary>
    /// This works, but I don't inherit from FreshBaseContentPage yet - and this is required by FreshMvvm
    /// </summary>
    [INotifyPropertyChanged]
    public partial class SampleViewModelWorkingWithoutInheritance
    {
        [ObservableProperty]
        int _bla;
    }
}
