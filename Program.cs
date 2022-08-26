namespace DataInventoryManagement
{
    class program
    {
        public static void Main(string []args)
        {
            string path = "C:\\Users\\Admin\\source\\repos\\DataInventoryManagement\\DataInventoryManagement\\Inventory.json";
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();
            Rice data = fetchJsonForRice.Read(path);
            Console.WriteLine("----------------");
            Console.WriteLine("TypesOfRice");
            Console.WriteLine("----------------");

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice.name);
                Console.WriteLine(data.typesOfRice.Weight);
                Console.WriteLine(data.typesOfRice.price);
            }
        }
    }
}