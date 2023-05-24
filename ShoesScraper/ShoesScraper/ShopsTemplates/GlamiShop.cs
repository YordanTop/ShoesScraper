using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ShoesScraper.ScraperModel;

namespace ShoesScraper.ShopsTemplates
{
    internal class GlamiShop : ShoesShop
    {
        private string selectGender;
        protected override string SelectGender
        {
            get { return selectGender; }
            set
            {
                if (value.Equals("Male"))
                {
                    value = "mzki";
                    selectGender = value;
                }
                if (value.Equals("Female"))
                {
                    value = "damski";
                    selectGender = value;
                }
            }
        }

        public static readonly string[] Description = new string[2];
        public GlamiShop(string searchProduct, string selectGender = "Male") : base(searchProduct, selectGender)
        {
            URL = $"https://www.glami.bg/{searchProduct}/{this.selectGender}-obuvki/";
            PricePath[0] = "//*[@id=\"products\"]/div[1]/div/div[";
            PricePath[1] = "]/div/a/div[2]/div[1]/span/span";

            ImgPath[0] = "//*[@id=\"products\"]/div[1]/div/div[";
            ImgPath[1] = "]/div/a/div[1]/div/img";

            Description[0] = "//*[@id=\"products\"]/div[1]/div/div[";
            Description[1] = "]/div/a/div[2]/div[4]";

            SearchingAttributes = "src";
        }

    }
}
