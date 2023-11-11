using System.Collections.ObjectModel;
using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AnxietyDiary.ViewModels;

public class ButtonViewViewModel : ObservableObject
{
    public EntryModel SelectedEntry { get; set; }

    

    #region Commands

    public IRelayCommand AddNewEntryCommand { get; }
    public IRelayCommand RemoveEntryCommand { get; }
    public IRelayCommand InformationCommand { get; }
    public IRelayCommand SummaryCommand { get; }

    #endregion

    public ButtonViewViewModel()
    {
        AddNewEntryCommand = new RelayCommand(AddNewEntryCommandExecute, AddNewEntryCommandCanExecute);
        RemoveEntryCommand = new RelayCommand(RemoveEntryCommandExecute, RemoveEntryCommandCanExecute);
        InformationCommand = new RelayCommand(InformationCommandExecute, InformationCommandCanExecute);
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

    private bool InformationCommandCanExecute()
    {
        throw new NotImplementedException();
    }

    private void InformationCommandExecute()
    {
        throw new NotImplementedException();
    }

    private bool RemoveEntryCommandCanExecute()
    {
        throw new NotImplementedException();
    }

    private void RemoveEntryCommandExecute()
    {
        throw new NotImplementedException();
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