using AnxietyDiary.ViewModels;

namespace AnxietyDiary.Views;

public partial class EntriesView : ContentView
{
	public EntriesView()
	{
		InitializeComponent();

        BindingContext = new EntriesViewViewModel();

		
    }
}