using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab9.Models;

namespace Lab9.Pages.Emp
{
    public class CreateModel : PageModel
    {
        private readonly Lab9.Models.DataContext _context;

        public CreateModel(Lab9.Models.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return Page();
        }

        [BindProperty(SupportsGet =true)]
        public Employee Employee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public IActionResult OnPostAsync()
        {
    

            var department = _context.Departments.FirstOrDefault(d => d.Id == Employee.DepartmentId);
            department?.Employees.Add(Employee);

            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
