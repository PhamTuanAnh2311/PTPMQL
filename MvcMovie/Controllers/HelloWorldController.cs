using Microsoft.AspNetCore.Mvc;
using SystemAcl.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET:/HelloWorld/
        public string Index()
        {
            return "Ma sinh vien";
        }
        //GET:/HelloWorld/Welcome/
        public string Welcome()
        {
            return "Fullname"
        }
    }
}
