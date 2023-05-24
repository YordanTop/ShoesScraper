using HtmlAgilityPack;
using ShoesScraper.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesScraper.ScraperModel
{
    internal class Scraper:IDisposable
    {
        private IScraper _scraper;

        private List<Product> products;

        public Scraper(IScraper scraper)
        {
            _scraper = scraper;
        }
        /// <summary>
        /// This function take the Html document for the given url  
        /// </summary>
        /// <param name="url">Website link.</param>
        /// <returns>the parsed HTML document</returns>
        public static async Task<HtmlAgilityPack.HtmlDocument> GetRequest(string url)
        {
            HtmlWeb web = new HtmlWeb();

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            htmlDocument = web.Load(url);

            return htmlDocument;
        }
        public async void DisplayItem()
        {
            
            int positionX = 0, positionY = 10;
            products = await _scraper.GetItems();
           
            foreach (Product item in products)
            {
                if(item.Id > 1)
                {
                    positionX += 145;
                }

                if (item.Id%5 == 0)
                {
                    positionX = 0;
                    positionY += 155;
                }

                SearchForm.ShoesFrame(item, positionX, positionY);
            }
            if(products.Count == 0)
            {
                SearchForm.ItemError("Items are not found.");
            }

            if (products != null)
            {
                products.Clear();
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
