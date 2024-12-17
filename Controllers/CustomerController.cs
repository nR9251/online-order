using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using prjonlineorder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjonlineorder.Controllers
{
    public class CustomerController : Controller
    {
        dbORD2Context db = new dbORD2Context();
        public IActionResult Menu()
        {
            var Meal = db.TableC.ToList();
            return View(Meal);
        }

        public IActionResult Order()
        {
            return View();
        }
        public IActionResult customerA()
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "UPDATE TableB" + 1 + " SET tPrice=TableC.tPrice*TableB" + 1 + ".tNum FROM TableC WHERE TableC.tMeal=TableB" + 1 + ".tMeal";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            var Meal = db.TableB1.ToList();
            return View(Meal);
        }


        public IActionResult customerB()
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "UPDATE TableB" + 2 + " SET tPrice=TableC.tPrice*TableB" + 2 + ".tNum FROM TableC WHERE TableC.tMeal=TableB" + 2 + ".tMeal";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            var Meal = db.TableB2.ToList();
            return View(Meal);
        }
        public IActionResult customerC()
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "UPDATE TableB" + 3 + " SET tPrice=TableC.tPrice*TableB" + 3 + ".tNum FROM TableC WHERE TableC.tMeal=TableB" + 3 + ".tMeal";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            var Meal = db.TableB3.ToList();
            return View(Meal);
        }

        public IActionResult EditA(int id)
        {
            var i = db.TableB1.Where(m => m.TNumber == id).FirstOrDefault();
            return View(i);
        }
        [HttpPost]
        public IActionResult EditA(TableB1 i)
        {
            var modify = db.TableB1.Where(m => m.TNumber == i.TNumber).FirstOrDefault();
            modify.TNumber = i.TNumber;
            modify.TNum = i.TNum;
            db.SaveChanges();
            return RedirectToAction("customerA");
        }

        public IActionResult EditB(int id)
        {
            var i = db.TableB2.Where(m => m.TNumber == id).FirstOrDefault();
            return View(i);
        }
        [HttpPost]
        public IActionResult EditB(TableB2 i)
        {
            var modify = db.TableB2.Where(m => m.TNumber == i.TNumber).FirstOrDefault();
            modify.TNumber = i.TNumber;
            modify.TNum = i.TNum;
            db.SaveChanges();
            return RedirectToAction("customerB");
        }

        public IActionResult EditC(int id)
        {
            var i = db.TableB3.Where(m => m.TNumber == id).FirstOrDefault();
            return View(i);
        }
        [HttpPost]
        public IActionResult EditC(TableB3 i)
        {
            var modify = db.TableB3.Where(m => m.TNumber == i.TNumber).FirstOrDefault();
            modify.TNumber = i.TNumber;
            modify.TNum = i.TNum;
            db.SaveChanges();
            return RedirectToAction("customerC");
        }
    }
}
