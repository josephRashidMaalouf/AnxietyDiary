using AnxietyDiary.ViewModels;

namespace AnxietyDiary.Views;

public partial class InfoDisplayView : ContentView
{
	public InfoDisplayView()
	{
		InitializeComponent();

        BindingContext = new InfoDisplayViewViewModel();

		
    }
}