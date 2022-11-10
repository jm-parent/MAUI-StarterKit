using CommunityToolkit.Maui.Core;

namespace MyStarterKit.ViewModels;

public partial class DrawingSampleViewModel : BaseViewModel
{
    [ObservableProperty]
    public ObservableCollection<IDrawingLine> lines = new();

    [RelayCommand]
    public void Clear()
    {
        Lines.Clear();
    }

    [RelayCommand]
    public void Save()
    {
        
    }
}
