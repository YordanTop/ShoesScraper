using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesScraper.Collection;

namespace ShoesScraper.ScraperModel
{
    internal interface IScraper
    {
        internal Task<List<Product>> GetItems();

    }
}
