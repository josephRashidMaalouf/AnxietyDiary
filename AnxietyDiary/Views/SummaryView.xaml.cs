using AnxietyDiary.ViewModels;

namespace AnxietyDiary.Views;

public partial class SummaryView : ContentView
{
	public SummaryView()
	{
		InitializeComponent();
        BindingContext = new SummaryViewModel();
    }
}