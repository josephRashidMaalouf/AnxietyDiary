using AnxietyDiary.Managers;
using AnxietyDiary.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AnxietyDiary.ViewModels;

public class SummaryViewModel : ObservableObject
{
    private string _summaryText;

    public string SummaryText
    {
        get => _summaryText;
        set
        {
            if (value == _summaryText) return;
            _summaryText = value;
            OnPropertyChanged();
        }
    }

    public SummaryViewModel()
    {
        EntryManager.SummaryRequested += CreateSummary;
    }

    private void CreateSummary(List<EntryModel> entryList)
    {
        SummaryText = string.Empty;

        foreach (var entry in entryList)
        {
            if (!SummaryText.Contains(entry.ListDisplayDate))
            {
                SummaryText += entry.ListDisplayDate + "\n";
            }

            SummaryText += $"\t{entry.TimeOfEntry} \n| {entry.EntryText} \n| Ångest nivå: {entry.AnxietyLevel} \n| Typ av oro: {entry.AnxietyType}\n\n";
        }
    }
}