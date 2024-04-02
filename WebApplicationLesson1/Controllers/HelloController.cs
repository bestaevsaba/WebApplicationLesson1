using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Controllers
{
    public class HelloController : Controller
    {
        public string Hello()
        {
            int currentHour = DateTime.Now.Hour;
            if (currentHour < 6) return "Доброй ночи!";
            else if (currentHour < 12) return "Доброе утро!";
            else if (currentHour < 18) return "Добрый день!";
            else return "Добрый вечер!";
        }
    }
}
