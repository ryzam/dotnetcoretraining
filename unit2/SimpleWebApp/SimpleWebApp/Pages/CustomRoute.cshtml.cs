using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages
{
    public class CustomRouteModel : PageModel
    {
        public string CustomerName { get; set; }
        public void OnGet()
        {
          
            CustomerName = "Irwan Azam";
        }
    }
}
