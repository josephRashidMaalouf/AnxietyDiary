using AnxietyDiary.Enums;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AnxietyDiary.ViewModels;

public class InfoDisplayViewViewModel : ObservableObject
{
    private EntryModel _selectedEntry;
    private List<int> _anxietyLevelComboBoxList = new ();
    
    #region Props

    public EntryModel SelectedEntry
    {
        get => _selectedEntry;
        set
        {
            if (Equals(value, _selectedEntry)) return;
            _selectedEntry = value;
            OnPropertyChanged();
        }
    }

    public List<int> AnxietyLevelComboBoxList
    {
        get => _anxietyLevelComboBoxList;
    }


    #endregion

    public InfoDisplayViewViewModel()
    {
        for (int i = 0; i <= 100; i++)
        {
            AnxietyLevelComboBoxList.Add(i);
        }

        EntryManager.EntrySelected += SetSelectedEntry;
        EntryManager.NewEntryMade += SetNewEntry;
    }

    private void SetNewEntry(EntryModel newEntry)
    {
        SelectedEntry = newEntry;
    }

    private void SetSelectedEntry(EntryModel selectedEntry)
    {
        SelectedEntry = selectedEntry;
    }
}