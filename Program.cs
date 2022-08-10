using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class TestClass
{
    public static void Test()
    {
        var data = JObject.Parse(GetJson());
        var values = (JArray)data["data"]?["values"];
        var valCount = values.Count();

        // Create JSON result using a string
        var json = "{ \"totalCount\": " + valCount + " }";
        Console.WriteLine($"JSON string: {json}");

        // Create JSON result using JObject
        var jo = new JObject();
        jo.Add("totalCount", valCount);
        Console.WriteLine($"JSON object: {jo}");
    }

    static string GetJson()
    {
        // PASTE JSON HERE - USE "" FOR QUOTES
        var json = @"{
    ""status"": 200,
    ""type"": ""Success"",
    ""message"": ""OK"",
    ""data"": {
        ""values"": [
            {
                ""Code"": 14111,
                ""Quantity"": 5
            },
            {
                ""Code"": 14110,
                ""Quantity"": 5
            },
            {
                ""Code"": 14107,
                ""Quantity"": 50
            }
        ],
        ""pageInfo"": {
            ""totalSize"": 15,
            ""pageSize"": 10,
            ""pageNum"": 1
        }
    }
}";
        return json;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Environment version: " + Environment.Version);
        Console.WriteLine("Json.NET version: " + typeof(JsonSerializer).Assembly.FullName);
        Console.WriteLine("");

        TestClass.Test();
    }

}