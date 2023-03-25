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

        static Government SelectGovernment()
        {
            Console.WriteLine("Please select your city's government ruling system by typing it's corresponding number");
            Console.WriteLine("1:Rule of the many");
            Console.WriteLine("2:Rule of the few");
            Console.WriteLine("3:Rule of authority");
            Console.WriteLine("4:Contested rule");
            Console.WriteLine("*:Random");

            var selectedGovernment = Console.ReadLine();

            var government = new Government();
            var governments = Utility.GetGovernments();
            switch ((selectedGovernment))
            {
                case "1":
                    government = governments[0];
                    Console.WriteLine($"Rule: {government.Rule}");
                    break;
                case "2":
                    government = governments[1];
                    Console.WriteLine($"Rule: {government.Rule}");
                    break;
                case "3":
                    government = governments[2];
                    Console.WriteLine($"Rule: {government.Rule}");
                    break;
                case "4":
                    government = governments[3];
                    Console.WriteLine($"Rule: {government.Rule}");
                    break;
                case "*":
                    var rnd = new Random();
                    government = governments[rnd.Next(0, governments.Count)];
                    Console.WriteLine($"Rule: {government.Rule}");
                    break;
            }
            return government;
        }
        static void CityGenerator()
        {

            var rnd = new Random();
            var biome = SelectBiome();
            var allResources = biome.Resources;
            var resources = new List<string>();

            if (allResources != null)
                resources = allResources.OrderBy(x => rnd.Next()).Take(3).ToList();

            var government = SelectGovernment();
            var allGoverntmentTypes = government.GovernmentType;
            var govermentTypes = new List<string>();

            if (allGoverntmentTypes != null)
                govermentTypes = allGoverntmentTypes.OrderBy(x => rnd.Next()).Take(1).ToList();

            Console.WriteLine($"Government: {govermentTypes[0]}");

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



            Console.WriteLine($"Local Resources: {resources[0]}, {resources[1]}, {resources[2]}");
            Console.WriteLine(cityType);
            Console.WriteLine($"Population: {population}");

        }
    }

}