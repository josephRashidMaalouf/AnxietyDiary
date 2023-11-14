using System.ComponentModel;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using AnxietyDiary.Views;

namespace AnxietyDiary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            EntryManager.SummaryRequested += EntryManager_SummaryRequested;
            EntryManager.NewEntryMade += EntryManager_NewEntryMade;
            EntryManager.ShowEntryFormsRequested += EntryManager_ShowEntryFormsRequested;


        }

        private void EntryManager_ShowEntryFormsRequested()
        {
            FirstPageView.IsVisible = false;
            SummaryView.IsVisible = false;
        }

        private void EntryManager_NewEntryMade(EntryModel obj)
        {
            FirstPageView.IsVisible = false;
        }

        private void EntryManager_SummaryRequested(List<Models.EntryModel> obj)
        {
            
            if (SummaryView.IsVisible) 
            {
                SummaryView.IsVisible = false;
            }
            else
            {
                SummaryView.IsVisible = true;
            }
        }
    }
}