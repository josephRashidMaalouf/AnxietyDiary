using AnxietyDiary.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AnxietyDiary.Models;

public class EntryModel : ObservableObject
{
    private DateOnly _date;
    private TimeOnly _timeOfEntry;
    private string _entryText;
    private string _listDisplayInfo;
    private string _anxietyType;
    private int _anxietyLevel;

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

    public string AnxietyType
    {
        get => _anxietyType;
        set
        {
            if (value == _anxietyType) return;
            _anxietyType = value;
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

    public string EntryText
    {
        get => _entryText;
        set
        {
            if (value == _entryText) return;
            _entryText = value;
            OnPropertyChanged();
        }
    }

    #endregion

    public EntryModel()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _timeOfEntry = TimeOnly.FromDateTime(DateTime.Now);

        _anxietyType = string.Empty;
        _anxietyLevel = 1;

        _entryText = string.Empty;

    }
}