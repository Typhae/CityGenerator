namespace CityGenerator
{
    /* TODO:
     * Add more biomes
     * Population
     * Local Resources
     * System of government
     * Renown POIs
     * Wealth
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            CityGenerator();
        }

        static Biome SelectBiome()
        {

            Console.WriteLine("Welcome to the City Generator");
            Console.WriteLine("Please select a biome your city is located in by typing it's corresponding number");
            Console.WriteLine("1:Tundra");
            Console.WriteLine("2:Savanna");
            Console.WriteLine("3:Tropical Rainforest");
            Console.WriteLine("4:Mangrove Swamp");
            Console.WriteLine("*:Random");
            var selectedBiome = Console.ReadLine();

            var biome = new Biome();
            var biomes = Utility.GetBiomes();
            switch ((selectedBiome))
            {
                case "1":
                    biome = biomes[0];
                    Console.WriteLine($"Biome: {biome.BiomeName}");
                    break;
                case "2":
                    biome = biomes[1];
                    Console.WriteLine($"Biome: {biome.BiomeName}");
                    break;
                case "3":
                    biome = biomes[2];
                    Console.WriteLine($"Biome: {biome.BiomeName}");
                    break;
                case "4":
                    biome = biomes[3];
                    Console.WriteLine($"Biome: {biome.BiomeName}");
                    break;
                case "*":
                    var rnd = new Random();
                    biome = biomes[rnd.Next(0, biomes.Count)];
                    Console.WriteLine($"Biome: {biome.BiomeName}");
                    break;
            }
            return biome;
        }

        static void CityGenerator()
        {
            
            var rnd = new Random();
            var biome = SelectBiome();
            var allResources = biome.Resources;
            var resources = new List<string>();

            if (allResources != null)
                resources = allResources.OrderBy(x => rnd.Next()).Take(3).ToList();


            var minPopulation = 12000;
            var maxPopulation = 1000000;
            var population = rnd.Next(minPopulation, maxPopulation);
            var cityType = "";
            if (population < 25000)
                cityType = "Small City";
            else if (population > 25000 && population <= 50000)
                cityType = "Medium City";
            else if (population > 50000 && population <= 100000)
                cityType = "Large City";
            else if (population > 100000 && population <= 200000)
                cityType = "Small Metropolis";
            else if (population > 200000 && population <= 400000)
                cityType = "Medium Metropolis";
            else if (population > 400000 && population < 800000)
                cityType = "Large Metropolis";
            else if (population >= 800000)
                cityType = "Megalopolis";
            //var governments = new List<string> {"Anarchy", "Capitalism", "Colonialism", "Despotism", "Feudalism", "Monarchy", "Plutocracy", "Magocracy", "Totalitarianism", "Socialism", "Tribalism", "Republicanism" };
            var governments = Utility.GetGovernments();
            var government = governments[rnd.Next(0, governments.Count)];

            // Console.WriteLine($"Biome: {biome.BiomeName}");

            Console.WriteLine($"Local Resources: {resources[0]}, {resources[1]}, {resources[2]}");
            Console.WriteLine(cityType);
            Console.WriteLine(government.GovernmentType);
            Console.WriteLine($"Population: {population}");

        }
    }

}