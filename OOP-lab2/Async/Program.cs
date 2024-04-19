using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string api_link = "https://api.hh.ru/openapi/redoc#section/Obshaya-informaciya/Vybor-s";

        await Request(api_link);
        await Request(api_link);
        await Request(api_link);

        Console.WriteLine("Done!");
    }

    public static async Task Request(string a)
    {

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(a);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response from {a}: {responseBody}");
                }
                else
                {
                    Console.WriteLine($"Fail. Status code: {response.StatusCode}");
                }
            }
        }

        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    }