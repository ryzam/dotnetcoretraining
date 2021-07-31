using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages
{
    public class ViewFormModel : PageModel
    {
        public IList<Person> Persons { get; set; }

        private readonly InMemoryDbContext _context;
        public ViewFormModel(InMemoryDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Persons = _context.Persons.ToList();
        }
    }
}
