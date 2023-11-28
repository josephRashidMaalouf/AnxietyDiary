using AnxietyDiary.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AnxietyDiary.Models;

public class EntryModel : ObservableObject
{
    private DateOnly _date;
    private TimeOnly _timeOfEntry;
    private string _listDisplayInfo;
    private int _anxietyLevel;
    private string _situationText;
    private string _thoughtsText;
    private string _actionsText;
    private string _resultsText;

    #region Props
    
    public int AnxietyLevel
    {
        get => _anxietyLevel;
        set
        {
            if (value == _anxietyLevel) return;
            _anxietyLevel = value;
            OnPropertyChanged();
        }
    }


    public string ListDisplayDate
    {
        get => _date.ToShortDateString();
        set
        {
            if (value == _listDisplayInfo) return;
            _listDisplayInfo = ListDisplayDate;
            OnPropertyChanged();
        }
    }

    public DateOnly Date
    {
        get => _date;
        set
        {
            if (value.Equals(_date)) return;
            _date = value;
            OnPropertyChanged();
        }
    }

    public TimeOnly TimeOfEntry
    {
        get => _timeOfEntry;
        set
        {
            if (value.Equals(_timeOfEntry)) return;
            _timeOfEntry = value;
            OnPropertyChanged();
        }
    }

    public string SituationText
    {
        get => _situationText;
        set
        {
            if (value == _situationText) return;
            _situationText = value;
            OnPropertyChanged();
        }
    }

    public string ThoughtsText
    {
        get => _thoughtsText;
        set
        {
            if (value == _thoughtsText) return;
            _thoughtsText = value;
            OnPropertyChanged();
        }
    }

    public string ActionsText
    {
        get => _actionsText;
        set
        {
            if (value == _actionsText) return;
            _actionsText = value;
            OnPropertyChanged();
        }
    }

    public string ResultsText
    {
        get => _resultsText;
        set
        {
            if (value == _resultsText) return;
            _resultsText = value;
            OnPropertyChanged();
        }
    }

    #endregion

    public EntryModel()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _timeOfEntry = TimeOnly.FromDateTime(DateTime.Now);

        _anxietyLevel = 1;

        _situationText = string.Empty;
        _thoughtsText = string.Empty;
        _actionsText = string.Empty;
        _resultsText = string.Empty;
    }
}