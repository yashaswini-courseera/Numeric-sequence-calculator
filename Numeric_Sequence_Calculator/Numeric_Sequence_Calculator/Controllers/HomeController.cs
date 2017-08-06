using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numeric_Sequence_Calculator.Controllers
{
    public class HomeController : Controller
    {
        List<string> list = new List<string>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SequenceType(string txtNumber, string id)
        {
            
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNumber))
                {
                   
                    var number = Convert.ToInt32(txtNumber);
                    switch (Convert.ToInt32(id))
                    {
                        case 1:
                            list = getNumericList(number);
                            break;

                        case 2:
                            list = getEvenNumbers(number);
                            break;
                        case 3:
                            list = getOddNumbers(number);
                            break;
                        case 4:
                            list = replaceMultiplesOf3and5(number);
                            break;
                        case 5:
                            list = getFibonacciList(number);
                            break;
                        default: return View();
                    }
                    
                }
                return PartialView("SequenceType", list);
            }
            catch(Exception ex)
            {
                return new HttpNotFoundResult(ex.Message);
            }
        }
        public List<string> getFibonacciList(int numb)
        {
            var a = 0;
            var b = 1;
            var fib = 1;
            for (int i = 0; fib <= numb; i++)
            {
                list.Add(fib.ToString());
                fib = a + b;
                a = b;
                b = fib;
                
            }
            return list;
        }
        public List<string> getNumericList(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }
        public List<string> getEvenNumbers(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                if (i % 2 == 0)
                    list.Add(i.ToString());
            }
            return list;
        }
        public List<string> getOddNumbers(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                if (i % 2 == 1)
                    list.Add(i.ToString());
            }
            return list;
        }
        public List<string> replaceMultiplesOf3and5(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                if (i % 3 == 0)
                    list.Add("C");
                else if (i % 5 == 0)
                    list.Add("E");
                else if (i % 3 == 0 && i % 5 == 0)
                    list.Add("Z");
                else
                    list.Add(i.ToString());
            }
            return list;
        }
    }
}