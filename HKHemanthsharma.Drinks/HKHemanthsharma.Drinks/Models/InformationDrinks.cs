
using System.Text.Json.Serialization;

namespace HKHemanthsharma.Drinks.Models
{
    public class InformationDrinks
    {
        [property: JsonPropertyName("drinks")]
        public List<InfoForDrink> DrinksInformation { get; set; }
    }
    public class InfoForDrink
    {
        [property: JsonPropertyName("idDrink")]
        public string Id { get; set; }
        [property: JsonPropertyName("strDrink")]
        public string DrinkName { get; set; }
        [property: JsonPropertyName("strCategory")]
        public string CategoryName { get; set; }
        [property: JsonPropertyName("strAlcoholic")]
        public string IsAlcoholic { get; set; }
        [property: JsonPropertyName("strGlass")]
        public string Glass { get; set; }
        [property: JsonPropertyName("strInstructions")]
        public string Instructions { get; set; }
    }
}
