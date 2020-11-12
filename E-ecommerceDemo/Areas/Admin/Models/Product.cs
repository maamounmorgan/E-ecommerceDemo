using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceDemo.Areas.Admin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Tag { get; set; }
        public string Desc { get; set; }


        //هوا لازم أعمل فيو موديل علشان احط فيها البروبيرتي دي 
        public IFormFile file {get; set; }

    }
}
