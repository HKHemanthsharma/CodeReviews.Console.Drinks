
using System.Text.Json.Serialization;


namespace HKHemanthsharma.Drinks.Models
{
    public class Drinksdomain
    {
        [property: JsonPropertyName("drinks")]
        public List<Category> drinkCategories { get; set; }
    }
}
