using AnxietyDiary.Enums;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AnxietyDiary.ViewModels;

public class InfoDisplayViewViewModel : ObservableObject
{
    private EntryModel _selectedEntry;
    private List<int> _anxietyLevelComboBoxList = new () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private List<string> _anxietyTypeComboBoxList = new() {"Annat", "Aktuell oro", "Hypotetisk oro"};
    


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

    public List<string> AnxietyTypeComboBoxList
    {
        get => _anxietyTypeComboBoxList;
    }

    #endregion

    public InfoDisplayViewViewModel()
    {
        EntryManager.EntrySelected += SetSelectedEntry;
    }

    private void SetSelectedEntry(EntryModel selectedEntry)
    {
        SelectedEntry = selectedEntry;
    }
}