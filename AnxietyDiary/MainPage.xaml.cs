using System.ComponentModel;
using AnxietyDiary.Managers;
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