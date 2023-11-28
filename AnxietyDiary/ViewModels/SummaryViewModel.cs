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
        SummaryText = String.Empty;

        foreach (var entry in entryList)
        {
            if (!SummaryText.Contains(entry.ListDisplayDate))
            {
                SummaryText += "########################" + "\n";
                SummaryText += entry.ListDisplayDate + "\n";
            }
            SummaryText += $"---------------------------------- \n";
            SummaryText += $"\tTid: {entry.TimeOfEntry} \n";
            SummaryText += $"\t[Situation] \n\t{entry.SituationText}\n";
            SummaryText += $"\t[Känsla] \n\t{entry.AnxietyLevel}\n";
            SummaryText += $"\t[Tankar] \n\t{entry.ThoughtsText}\n";
            SummaryText += $"\t[Handling] \n\t{entry.ActionsText}\n";
            SummaryText += $"\t[Resultat] \n\t{entry.ResultsText}\n";

        }
    }
}