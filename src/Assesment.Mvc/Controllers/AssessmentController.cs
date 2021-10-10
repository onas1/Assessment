using AutoMapper;
using HiresHoldingsAssesment.Models;
using HiresHoldingsAssesment.Repositories.Abstractions;
using HiresHoldingsAssesment.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiresHoldingsAssesment.Controllers
{
    [Authorize]
    public class AssessmentController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public AssessmentController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;

        }

        // GET: AssessmentController/Details/5
        public async Task<ActionResult> Details()
        {
            return View(await _employeeRepository.GetEmployeesAsync());
        }



        public async Task<IActionResult> Search(string query)
        {
            var employees = new List<Employee>();

            if (!string.IsNullOrWhiteSpace(query))
            {
                var result = await _employeeRepository.GetEmployeesAsync();
                employees = result.Where(x => x.FirstName.Contains(query)
                || x.LastName.Contains(query) || x.Department.Contains(query)
                || x.DateOfBirth.Date.ToString("MM/dd/yyyy").Contains(query)).ToList();
            }

            return View(employees);
        }

        // GET: AssessmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssessmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var employee = _mapper.Map<Employee>(model);
            await _employeeRepository.AddEmployeeAsync(employee);
            return RedirectToAction("Details");

        }


    }
}
