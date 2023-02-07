namespace stage_ap_2023
{
    public class CSV
    {
        public static void ReadCsvFile(string csvLocation)
        {
            string[] lines = File.ReadAllLines(csvLocation);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] properties = lines[i].Split(';');
                Console.WriteLine($"First Name {i}: {properties[1]}");
                Console.WriteLine($"Last Name {i}: {properties[0]}");
                Console.WriteLine($"Birth Year {i}: {properties[2]}");
            }
        }  
    }
}
