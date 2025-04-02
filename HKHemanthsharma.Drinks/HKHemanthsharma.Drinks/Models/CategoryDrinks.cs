
using System.Text.Json.Serialization;


namespace HKHemanthsharma.Drinks.Models
{
    public class CategoryDrinks
    {
        [property: JsonPropertyName("drinks")]
        public List<DrinkInformation> DrinksByCategory { get; set; }

    }
}
