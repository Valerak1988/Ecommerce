
using BLL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Xml.Linq;

namespace Ecommerce
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Category> CategoryList = new List<Category>();
            CategoryList.Add(new Category()
            {
                Cid = 1,
                Cname = "Electronics",
                Picname = "Electronics.jpg",
                ParentCid = 100,
                Status = 1,
                AddDate = new DateTime(2024, 2, 1)
            });
            CategoryList.Add(new Category()
            {
                Cid = 2,
                Cname = "Sports",
                Picname = "Sports.jpg",
                ParentCid = 200,
                Status = 1,
                AddDate = new DateTime(2023, 5, 23)
            });
            CategoryList.Add(new Category()
            {
                Cid = 3,
                Cname = "Toys",
                Picname = "Toys.jpg",
                ParentCid = 300,
                Status = 1,
                AddDate = new DateTime(2023, 9, 11)
            });
            CategoryList.Add(new Category()
            {
                Cid = 4,
                Cname = "Music",
                Picname = "Music.jpg",
                ParentCid = 400,
                Status = 1,
                AddDate = new DateTime(2024, 1, 10)
            });
            CategoryList.Add(new Category()
            {
                Cid = 5,
                Cname = "Books",
                Picname = "Books.jpg",
                ParentCid = 500,
                Status = 1,
                AddDate = new DateTime(2023, 4, 16)
            });
            Application["Category"] = CategoryList;


            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product()
            {
                Pid = 10,
                Pname = "Gaming Pc",
                Price = 7000,
                Pdesc = "Best For Gaming",
                Picname = "Pc.jpg",
                Cid = 1,
                Status = 1,
                AddDate = new DateTime(2024, 2, 2)
            });
                ProductList.Add(new Product()
                {
                    Pid = 20,
                    Pname = "Sport Bike",
                    Price = 2000,
                    Pdesc = "Sport Bike in smart price",
                    Picname = "Bike.jpg",
                    Cid = 2,
                    Status = 1,
                    AddDate = new DateTime(2023, 5, 25)
                });
            ProductList.Add(new Product()
            {
                Pid = 30,
                Pname = "XBOX",
                Price = 2500,
                Pdesc = "Gaming Console",
                Picname = "XBOX.jpg",
                Cid = 3,
                Status = 1,
                AddDate = new DateTime(2023, 9, 15)
            });
            ProductList.Add(new Product()
            {
                Pid = 40,
                Pname = "AC DC ALL ALBOMS",
                Price = 350,
                Pdesc = "CLASSIC OF ROCK",
                Picname = "ACDC.jpg",
                Cid = 4,
                Status = 1,
                AddDate = new DateTime(2024, 2, 10)
            });
            ProductList.Add(new Product()
            {
                Pid = 50,
                Pname = "HTML FOR BEGINNERS",
                Price = 100,
                Pdesc = "HTML START",
                Picname = "HTML.jpg",
                Cid = 5,
                Status = 1,
                AddDate = new DateTime(2023, 7, 23)
            });
            Application["Product"] = ProductList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}