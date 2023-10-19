using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IlcCrashRepro;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    public void DoSomething(object param)
        => Debug.WriteLine($"Hello {param}");
}