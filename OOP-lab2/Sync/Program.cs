using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string api_link = "https://api.hh.ru/openapi/redoc#section/Obshaya-informaciya/Vybor-s";
        
        string response = Request(api_link);

        Console.WriteLine(response);
        Console.WriteLine(response);
        Console.WriteLine(response);

        Console.WriteLine("Done!");
    }

    public static string Request(string a)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(a).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    return $"Fail. Status code: {response.StatusCode}";
                }
            }
        }
        catch (HttpRequestException ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}