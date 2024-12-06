using System.IO.Compression;
using System.Text.Json;

public static class FileCrud
{
    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        WriteIndented = false // Minimizza per risparmiare spazio
    };

    // Create: Aggiunge un nuovo record al file
    public static void AddRecord<T>(string filePath, T record)
    {
        var allRecords = GetAllRecords<T>(filePath) ?? new List<T>();
        allRecords.Add(record);
        SaveAllRecords(filePath, allRecords);
    }

    // Read: Legge tutti i record dal file
    public static List<T>? GetAllRecords<T>(string filePath)
    {
        if (!File.Exists(filePath)) return new List<T>();

        using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        using var gzipStream = new GZipStream(fileStream, CompressionMode.Decompress);
        using var reader = new StreamReader(gzipStream);

        var json = reader.ReadToEnd();
        return JsonSerializer.Deserialize<List<T>>(json, JsonOptions);
    }

    // Update: Aggiorna un record in base a una condizione
    public static void UpdateRecord<T>(string filePath, Func<T, bool> predicate, Action<T> updateAction)
    {
        var allRecords = GetAllRecords<T>(filePath) ?? new List<T>();

        foreach (var record in allRecords)
        {
            if (predicate(record))
            {
                updateAction(record);
                break;
            }
        }

        SaveAllRecords(filePath, allRecords);
    }

    // Delete: Elimina un record in base a una condizione
    public static void DeleteRecord<T>(string filePath, Func<T, bool> predicate)
    {
        var allRecords = GetAllRecords<T>(filePath) ?? new List<T>();
        allRecords.RemoveAll(record => predicate(record));
        SaveAllRecords(filePath, allRecords);
    }

    // Salva tutti i record comprimendoli
    private static void SaveAllRecords<T>(string filePath, List<T> records)
    {
        using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        using var gzipStream = new GZipStream(fileStream, CompressionMode.Compress);
        using var writer = new StreamWriter(gzipStream);

        var json = JsonSerializer.Serialize(records, JsonOptions);
        writer.Write(json);
    }
}
