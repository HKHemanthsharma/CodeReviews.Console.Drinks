using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKHemanthsharma.Drinks
{
    public class Cocktails
    {
        private readonly string baseUrl;
        public Cocktails(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }
        public async Task<string> GetCategriesAsync()
        {
            try
            {
                HttpClient client = new HttpClient();
                string categoriesUrl = baseUrl + "/list.php?c=list";
                return await client.GetStringAsync(categoriesUrl);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "empty";
            
        }
    }
}
