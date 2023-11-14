using AnxietyDiary.Managers;
using AnxietyDiary.ViewModels;

namespace AnxietyDiary.Views;

public partial class EntriesView : ContentView
{
	public EntriesView()
	{
		InitializeComponent();

        BindingContext = new EntriesViewViewModel();

		
    }

    private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        EntryManager.OnShowEntryFormsRequested();
    }
}