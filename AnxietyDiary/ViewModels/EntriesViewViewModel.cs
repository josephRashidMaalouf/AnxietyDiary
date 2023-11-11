using System.Collections.ObjectModel;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AnxietyDiary.ViewModels;

public class EntriesViewViewModel : ObservableObject
{
    private EntryModel _selectedEntry;
    public ObservableCollection<EntryModel> Entries { get; set; } = new();

    public EntryModel SelectedEntry
    {
        get
        {
            return _selectedEntry;
        }
        set
        {
            _selectedEntry = value;
            if (value is not null)
            {
                EntryManager.OnNewEntrySelected(_selectedEntry); //Send to button and infoDisplay
            }
            
        }
    }


    public EntriesViewViewModel()
    {
        EntryManager.NewEntryMade += AddNewEntry;

        
    }

    private void AddNewEntry(EntryModel newEntry)
    {
        Entries.Add(newEntry);
    }





}