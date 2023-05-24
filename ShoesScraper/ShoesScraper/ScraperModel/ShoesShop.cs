using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ShoesScraper.Collection;
using ShoesScraper.ShopsTemplates;

namespace ShoesScraper.ScraperModel
{
    internal class ShoesShop: IScraper
    {
        private List<Product> Products;

        internal const int MAX_ITEMS = 30;
        protected virtual string SelectGender { get; set; }
        
        protected string SearchProduct { get; set; }

        protected string URL { get; set; }

        protected string[] PricePath = new string[2];

        protected string[] ImgPath = new string[2];

        protected int ID { get; set; }

        protected string SearchingAttributes { get; set; }

        public ShoesShop(string searchProduct, string selectGender = "Male")
        {
            SelectGender = selectGender;
            SearchProduct = searchProduct;
            ID = 0;
        }


        async Task<List<Product>> IScraper.GetItems()
        {
            Products = new List<Product>();
            HtmlAgilityPack.HtmlDocument document = await Scraper.GetRequest(URL);
            HtmlNode InfoNode = null;
            await Task.Run(() =>
            {
                for (int i = 1; i <= MAX_ITEMS; i++)
                {
                    ID = i;

                    HtmlNode descriptionNode = document.DocumentNode.SelectSingleNode(PricePath[0] + ID + PricePath[1]);
                    HtmlNode imgNode = document.DocumentNode.SelectSingleNode(ImgPath[0]+ ID + ImgPath[1]);

                    if (imgNode != null && descriptionNode != null)
                    {
                        string Info = String.Empty;
                        if (this is ShopsTemplates.GlamiShop)
                        {
                            InfoNode = document.DocumentNode.SelectSingleNode(GlamiShop.Description[0] + ID + GlamiShop.Description[1]);
                            Info = InfoNode.InnerHtml;
                        }

                        string productDescription = $"{(Info.TrimStart())} {(descriptionNode.InnerText.TrimStart())}";
                        string productImg = imgNode.GetAttributeValue(SearchingAttributes, "https://www.shareicon.net/data/256x256/2016/04/27/756334_help_512x512.png");


                        Products.Add(new Product(ID, productImg, productDescription));
                    }
                }
            });
           return Products;

        }
    }
}