using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, char operation)
        {
            switch (operation)
            {
                case '-':
                    return $"{a} {operation} {b} = {a - b}";
                case '*':
                    return $"{a} {operation} {b} = {a * b}";
                default:
                    if (operation != '+' && operation != 0) return "Вы можете применить только операции сложения, вычитания и умножения";
                    return $"{a} + {b} = {a + b}";
            }
        }
    }
}