using AnxietyDiary.ViewModels;

namespace AnxietyDiary.Views;

public partial class ButtonView : ContentView
{
    ButtonViewViewModel context = new ButtonViewViewModel();
	public ButtonView()
	{
		InitializeComponent();
        BindingContext = new ButtonViewViewModel();
    }

    
}