using System.Collections.ObjectModel;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AnxietyDiary.ViewModels;

public class ButtonViewViewModel : ObservableObject
{
    private EntryModel _selectedEntry;

    public EntryModel? SelectedEntry
    {
        get => _selectedEntry;
        set
        {
            _selectedEntry = value;
            RemoveEntryCommand.NotifyCanExecuteChanged();
        } 
    }


    #region Commands

    public IRelayCommand AddNewEntryCommand { get; }
    public IRelayCommand RemoveEntryCommand { get; }
    public IRelayCommand SaveCommand { get; }
    public IRelayCommand SummaryCommand { get; }

    #endregion

    public ButtonViewViewModel()
    {
        AddNewEntryCommand = new RelayCommand(AddNewEntryCommandExecute, AddNewEntryCommandCanExecute);
        RemoveEntryCommand = new RelayCommand(RemoveEntryCommandExecute, RemoveEntryCommandCanExecute);
        SaveCommand = new RelayCommand(SaveCommandExecute, SaveCommandCanExecute);
        SummaryCommand = new RelayCommand(SummaryCommandExecute, SummaryCommandCanExecute);

        EntryManager.EntrySelected += SetNewSelectedEntry;
        
    }

    private void SetNewSelectedEntry(EntryModel selectedEntry)
    {
        SelectedEntry = selectedEntry;
    }

    #region CommandMethods

    private bool SummaryCommandCanExecute()
    {
        throw new NotImplementedException();
    }

    private void SummaryCommandExecute()
    {
        throw new NotImplementedException();
    }

    private bool SaveCommandCanExecute()
    {
        //implement condition where false when nothing in entry list?
        return true;
    }

    private void SaveCommandExecute()
    {
        EntryManager.SaveEntriesToFile();
    }

    private bool RemoveEntryCommandCanExecute()
    {
        return SelectedEntry is not null;
    }

    private void RemoveEntryCommandExecute()
    {
        EntryManager.OnEntryDeleted(SelectedEntry); // send to entryview
        SelectedEntry = null;
    }

    private bool AddNewEntryCommandCanExecute()
    {
        return true;
    }

    private void AddNewEntryCommandExecute()
    {
        EntryManager.OnNewEntryMade(new EntryModel()); //Send to EntryView
    }

    #endregion
}