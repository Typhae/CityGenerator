namespace CityGenerator
{
    /* TODO:
     * Biome
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

        static void CityGenerator()
        {
            var biomes = new string[] { "Tundra", "Tropical Rainforest", "Savanna", "Mangrove Swamp" };
            var rnd = new Random();
            var biome = biomes[rnd.Next(0, biomes.Length)];

            var tundraResources = new string[] { "Oil", "Precious Metals", "Hardwood", };
            var tropicalRainforestResources = new string[] { "Spices", "Softwood", "Cacao" };
            var savannaResources = new string[] { "Hide", "Ivory", "Incense" };
            var mangroveSwampResources = new string[] { "Mushrooms", "Herbs", "Gossamer" };
            var resource = "";
            if (biome == "Tundra")
                resource = tundraResources[rnd.Next(0, tundraResources.Length)];
            else if (biome == "Tropical Rainforest")
                resource = tropicalRainforestResources[rnd.Next(0, tropicalRainforestResources.Length)];
            else if (biome == "Savanna")
                resource = savannaResources[rnd.Next(0, savannaResources.Length)];
            else if (biome == "Mangrove Swamp")
                resource = mangroveSwampResources[rnd.Next(0, mangroveSwampResources.Length)];
            Console.WriteLine(biome);
            Console.WriteLine(resource);

        }
    }

}