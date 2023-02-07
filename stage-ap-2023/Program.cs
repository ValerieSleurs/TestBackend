using Newtonsoft.Json;
using System.Net.Http.Headers;

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://api.github.com");
    client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    var url = "repos/symfony/symfony/contributors";
    var response = client.GetAsync(url).GetAwaiter().GetResult();
    response.EnsureSuccessStatusCode();
    var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

    List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(result);
    foreach (var contributor in contributors)
    {
        Console.WriteLine($"{contributor.login}: {contributor.contributions}");
    }
} 

string[] lines = File.ReadAllLines(@"C:\Users\sleur\OneDrive\Desktop\users.csv");
for (int i = 0; i < lines.Length; i++)
{
    string[] properties = lines[i].Split(';');
    Console.WriteLine($"First Name {i}: {properties[1]}");
    Console.WriteLine($"Last Name {i}: {properties[0]}");
    Console.WriteLine($"Birth Year {i}: {properties[2]}");
}

public class Rootobject
{
    public Contributor[] Property1 { get; set; }
}

public class Contributor
{
    public string login { get; set; }
    public int id { get; set; }
    public string node_id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public bool site_admin { get; set; }
    public int contributions { get; set; }
}
