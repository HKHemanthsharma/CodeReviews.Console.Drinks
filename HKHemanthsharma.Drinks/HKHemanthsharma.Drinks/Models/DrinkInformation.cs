
using System.Text.Json.Serialization;
namespace HKHemanthsharma.Drinks.Models
{
    public class DrinkInformation
    {
        [property: JsonPropertyName("strDrink")]
        public string DrinkName { get; set; }
        [property: JsonPropertyName("strDrinkThumb")]
        public string DrinkImageUrl { get; set; }
        [property: JsonPropertyName("idDrink")]
        public string DrinkId { get; set; }
    }
}
