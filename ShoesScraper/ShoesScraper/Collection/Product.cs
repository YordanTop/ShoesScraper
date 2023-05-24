using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesScraper.Collection
{
    public class Product
    {
        /// <summary>
        /// Id of a product
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Image of a product
        /// </summary>
        public string Img { get; private set; }
        /// <summary>
        /// Price of a product
        /// </summary>
        public string Price { get; private set; }
        /// <summary>
        /// Does this product is liked
        /// </summary>
        public bool isLiked = false;
        public Product(int id, string img, string price)
        {
            Id = id;
            Img = img;
            Price = price;
        }
    }
}
