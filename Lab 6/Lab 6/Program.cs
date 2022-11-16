using System.Text;
using System.Text.Json;

namespace Lab_6;
class Program
{
    private static List<Book> books = new List<Book>();
    static void Main(string[] args)
    {
        string jsonString = string.Empty;
        var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        var dataFolder = root + Path.DirectorySeparatorChar + "Data";
        var fileNames = new List<string>();

        var serializeFolder = root + Path.DirectorySeparatorChar + "Serialized";
        var writeJSON = serializeFolder + Path.DirectorySeparatorChar + "books.JSON";

        foreach (var file in Directory.GetFiles(dataFolder))
        {
            fileNames.Add(file);
        }

        foreach (var book in ReadBookFile(fileNames))
        {
            Console.WriteLine(book);
        }


        WriteJsonToFile(writeJSON);
        Console.ReadKey();
    }

    private static string WriteJsonToFile(string writeJSON)
    {
        string jsonString;
        var options = new JsonSerializerOptions { WriteIndented = true };
        jsonString = JsonSerializer.Serialize(books, options);

        using (var sw = new StreamWriter(writeJSON, false))
        {
            sw.WriteLine(jsonString);
        }

        return jsonString;
    }

    static List<Book> ReadBookFile(List<string> fileNames)
    {
        //var books = new List<Book>();
        
        foreach(var file in fileNames)
        {
            string jsonString = string.Empty;
            using (var sr = new StreamReader(file))
            {
                jsonString = sr.ReadToEnd();
            }
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var book = JsonSerializer.Deserialize<Book>(jsonString, options);
            books.Add(book);
        }

        return books;
    }
}

