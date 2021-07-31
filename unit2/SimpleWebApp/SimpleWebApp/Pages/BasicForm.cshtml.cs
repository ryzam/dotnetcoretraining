using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages
{
    public class BasicFormModel : PageModel
    {
        private readonly InMemoryDbContext _context;
        public BasicFormModel(InMemoryDbContext context)
        {
            _context = context;
        }
       
        public void OnGet()
        {

        }

        [BindProperty]
        public Person Person { get; set; }

        public async Task<IActionResult> OnPostAsync(Person person)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Persons.Add(person);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
