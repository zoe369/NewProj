using System.Collections.Generic;
using System.Web.Mvc;
using NewProj.Dao;
using NewProj.Models;
using System.Data.SqlClient;

namespace NewProj.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Partial(string search)

        {
            if (search == "")
            {
                ViewBag.a = "Please enter a search item in the search box..";
            }
            List<CarModel> car = new List<CarModel>();
            using (SqlConnection conn = new SqlConnection("Server=.; Database=Sasha; Integrated Security=true"))
            {
                conn.Open();
                string sql = @"select * from Car where Marca like '%" + search + "%' or Model like '%" + search + "%' or Pret like '%" + search + "%' or [An fabricatie] like '%" + search + "%' or Km like '%" + search + "%' or Culoare like '%" + search + "%' or Cutie like '%" + search + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //CarModel c = new CarModel()
                    //{
                    //    Car_id = (int)reader["ID"],
                    //    Car_marca = (string)reader["Marca"],
                    //    Car_model = (string)reader["Model"],
                    //    Car_price = (int)reader["Pret"],
                    //    Car_image = (string)reader["Image"],
                    //    Car_an = (int)reader["An fabricatie"],
                    //    Car_km = (int)reader["Km"],
                    //    Car_culoare = (string)reader["Culoare"],
                    //    Car_cutie = (string)reader["Cutie"]

                    //};
                    //car.Add(c);
                }
            }
            if (car != null)
            {
                ViewData["partial"] = car;
            }
            else
                ViewBag.alert = "Sorry, the item is out of stock..";
            //ViewBag.Count = int.Parse(Request.Cookies["Count"].Value);
            //ViewBag.firstname = Request.Cookies["firstname"].Value;
            ViewBag.a = 2;
            return View("../Home/Index");
        }
    }
}
