using System.IO;
using System.Text.Json;
using AnxietyDiary.Models;

namespace AnxietyDiary.Managers;

public static class EntryManager
{
    private static readonly List<EntryModel> _entries = new ();

    static string DirPath = FileSystem.Current.AppDataDirectory;
    static string FullPath = Path.Combine(DirPath, "entries.json");


    public static List<EntryModel> Entries
    {
        get
        {
            return _entries;
        }
    }

    public static event Action<EntryModel> NewEntryMade;
    public static event Action<EntryModel> EntrySelected;
    public static event Action<EntryModel> EntryDeleted;
    public static event Action<List<EntryModel>> SummaryRequested;

    public static void OnSummaryRequested()
    {
        SummaryRequested.Invoke(Entries);
    }
    public static void OnNewEntryMade(EntryModel newEntry)
    {
        NewEntryMade.Invoke(newEntry);
    }
    public static void OnNewEntrySelected(EntryModel selectedEntry)
    {
        EntrySelected.Invoke(selectedEntry);
    }
    public static void OnEntryDeleted(EntryModel deletedEntry)
    {
        EntryDeleted.Invoke(deletedEntry);
    }

    public static void LoadEntriesFromFile()
    {

        if (File.Exists(FullPath))
        {
            // Use fullPath to create the fileStream
            using var fileStream = File.OpenRead(FullPath);

            // create the reader
            using StreamReader reader = new StreamReader(fileStream);

            // read the contents of the FloatVals.json file from internal memory
            string jsonData = reader.ReadToEnd();

            Entries.AddRange(JsonSerializer.Deserialize<List<EntryModel>>(jsonData));
        }
        
    }
    

    public static async Task SaveEntriesToFile()
    {
        

        var jsonString = JsonSerializer.Serialize(Entries);

        File.WriteAllText(FullPath, jsonString);

        await Shell.Current.DisplayAlert("Saved", "Your entries have been saved", "Ok");
    }

}