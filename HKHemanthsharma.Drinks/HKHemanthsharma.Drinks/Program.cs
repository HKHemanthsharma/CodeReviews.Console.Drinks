using HKHemanthsharma.Drinks.Models;
namespace HKHemanthsharma.Drinks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool noExit = true;
            while (noExit)
            {
                Console.Clear();
                string baseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";
                Cocktails coctails = new Cocktails(baseUrl);
                var CategoryList = coctails.GetCategoryAsync().GetAwaiter().GetResult();
                UserOutputs.CategoryMenu(CategoryList);
                string userChoice = UserInputs.ChooseCategory(CategoryList);
                var drinksListByCategory = coctails.GetDrinksByCategoryAsync(userChoice).GetAwaiter().GetResult();
                string drinkId = UserOutputs.DrinksListMenu(drinksListByCategory);
                if (!(drinkId.ToLower() == "x"))
                {
                    InformationDrinks drinksInfo = coctails.GetDrinkInformationByIdAsync(drinkId).GetAwaiter().GetResult();
                    UserOutputs.DisplayDrinkInfo(drinksInfo);
                }
            }
        }
    }
}
