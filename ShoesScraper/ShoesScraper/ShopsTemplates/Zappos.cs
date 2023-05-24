using ShoesScraper.ScraperModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShoesScraper.ShopsTemplates
{
    internal class Zappos : ShoesShop
    {
        private string selectGender;
        protected override string SelectGender
        {
            get { return selectGender; }
            set
            {
                if (value.Equals("Male"))
                {
                    value = "men";
                    selectGender = value;
                }
                if (value.Equals("Female"))
                {
                    value = "women";
                    selectGender = value;
                }
            }
        }
        public Zappos(string searchProduct, string selectGender = "Male") : base(searchProduct, selectGender)
        {
            URL = $"https://www.zappos.com/{searchProduct}-{this.selectGender}-shoes/CK_XAeICAQE.zso?t={searchProduct}%20{this.selectGender}";
        
            PricePath[0] = "//*[@id=\"products\"]/article[4";
            PricePath[1] = "]/a";

            
            ImgPath[0] = "//*[@id=\"products\"]/article[";
            ImgPath[1] = "]/div[1]/figure/picture[1]/img";
            
            SearchingAttributes = "src";
            

        }
    }
}
