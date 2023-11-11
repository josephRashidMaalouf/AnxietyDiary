using AnxietyDiary.Models;

namespace AnxietyDiary.Managers;

public static class EntryManager
{
    public static event Action<EntryModel> NewEntryMade;
    public static event Action<EntryModel> EntrySelected;

    public static void OnNewEntryMade(EntryModel newEntry)
    {
        NewEntryMade.Invoke(newEntry);
    }
    public static void OnNewEntrySelected(EntryModel newEntry)
    {
        EntrySelected.Invoke(newEntry);
    }
}