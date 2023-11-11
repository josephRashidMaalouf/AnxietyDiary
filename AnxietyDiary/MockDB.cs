using AnxietyDiary.Models;

namespace AnxietyDiary;

public class MockDB
{
    public List<EntryModel> Entries { get; set; } = new List<EntryModel>()
    {
        new EntryModel()
        {
            Date = new DateOnly(2023, 11, 10),
            TimeOfEntry = new TimeOnly(15, 50),
            EntryText= "Orolig för framtiden"
        },
        new EntryModel()
        {
            Date = new DateOnly(2023, 11, 10),
            TimeOfEntry = new TimeOnly(16, 32),
            EntryText= "Orolig för framtiden"
        },
        new EntryModel()
        {
            Date = new DateOnly(2023, 11, 11),
            TimeOfEntry = new TimeOnly(12, 50),
            EntryText= "Orolig för framtiden"
        },
        new EntryModel()
        {
            Date = new DateOnly(2023, 11, 1),
            TimeOfEntry = new TimeOnly(11, 20),
            EntryText= "Orolig för framtiden"
        },
        new EntryModel()
        {
            Date = new DateOnly(2022, 11, 12),
            TimeOfEntry = new TimeOnly(18, 50),
            EntryText= "Orolig för framtiden"
        },
        new EntryModel()
        {
            Date = new DateOnly(2023, 1, 10),
            TimeOfEntry = new TimeOnly(22, 54),
            EntryText= "Orolig för framtiden"
        }
    };

    
}