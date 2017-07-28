using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coding_Task.Models;
using Coding_Task.Helpers;
using BusinessLogic;

namespace Coding_Task.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public string FetchSequences(int num)
        {
            object result = null;
            string strReturn = string.Empty;

            try
            {
                List<int> allnumbers = new List<int>();
                List<int> allevennumbers = new List<int>();
                List<int> alloddnumbers = new List<int>();
                List<string> allconditionalnumbers = new List<string>();
                List<int> allfibonaccinumbers = new List<int>();

                NumberFunctions.generateAllNumbersInLoop(num, ref allnumbers, ref allevennumbers, ref alloddnumbers, ref allconditionalnumbers);
                NumberFunctions.generateFibonacci(num, ref allfibonaccinumbers);

                NumbersModel numbersmodel = new NumbersModel();

                numbersmodel.allnumbers = allnumbers;
                numbersmodel.allevennumbers = allevennumbers;
                numbersmodel.alloddnumbers = alloddnumbers;
                numbersmodel.allconditionalnumbers = allconditionalnumbers;
                numbersmodel.allfibonaccinumbers = allfibonaccinumbers;

                result = new { st = 1, msg = clsUtilities.ConvertToJson(numbersmodel) };
            }
            catch (Exception ex)
            {
                result = new { st = 0, msg = "Kindly try after some time." };
            }
            strReturn = clsUtilities.ConvertToJson(result);
            return strReturn;
        }

    }

     
}
