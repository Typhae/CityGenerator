using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CityGenerator
{
    public static class Utility
    {
        public static List<Biome> GetBiomes()
        {
            using StreamReader reader = new("Biomes.json");
            var json = reader.ReadToEnd();
            var biomes = JsonSerializer.Deserialize<List<Biome>>(json);
            if (biomes == null)
                return new List<Biome>();
            return biomes;
        }
        public static List<Governments> GetGovernments()
        {
            using StreamReader reader = new("Governments.json");
            var json = reader.ReadToEnd();
            var governments = JsonSerializer.Deserialize<List<Governments>>(json);
            if (governments == null)
                return new List<Governments>();
            return governments;
        }
    }
}
