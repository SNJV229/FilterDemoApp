using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemoApp
{
    public class MyActionFilterAttribute  : Attribute, IActionFilter
    {
        private readonly string _name;

        public  MyActionFilterAttribute(string name) 
        {
            _name = name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionExecuted - {_name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionExecuting - {_name}");
        }
    }
}
