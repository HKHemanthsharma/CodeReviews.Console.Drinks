
using System.Text.Json.Serialization;


namespace HKHemanthsharma.Drinks.Models
{

    public class Category
    {
        [property: JsonPropertyName("strCategory")]
        public string CategoryName { get; set; }
    }
}
