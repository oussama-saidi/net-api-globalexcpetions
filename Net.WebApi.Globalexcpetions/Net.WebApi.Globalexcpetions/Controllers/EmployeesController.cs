using Microsoft.AspNetCore.Mvc;
using Net.WebApi.Globalexcpetions.Models;
using Net.WebApi.Globalexcpetions.Services;

namespace Net.WebApi.Globalexcpetions.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly ILogger<EmployeesController> _logger;
    private readonly IEmployeeService _employeeServices;

    public EmployeesController(
        ILogger<EmployeesController> logger,
        IEmployeeService employeeServices)
    {
        _logger = logger;
        _employeeServices = employeeServices;
    }
    [HttpGet("employeelist")]
    public async Task<IEnumerable<Employee>> employeeList()
    {
        var employeeList = await _employeeServices.GetEmployees();
        return employeeList;
    }

    [HttpGet("getemployeebyid")]
    public async Task<IActionResult> GetemployeeById(int Id)
    {
        _logger.LogInformation($"Fetch employee with ID: {Id} from the database");
        var employee = await _employeeServices.GetEmployeeById(Id);
        if (employee == null)
        {
            //throw new Notfound($"employee ID {Id} not found.");
            return NotFound();
        }
        _logger.LogInformation($"Returning employee with ID: {employee.Id}.");
        return Ok(employee);
    }

    [HttpPost("addemployee")]
    public async Task<IActionResult> Addemployee(Employee employee)
    {
        var result = await _employeeServices.AddEmployee(employee);
        return Ok(result);
    }

    [HttpPut("updateemployee")]
    public async Task<IActionResult> Updateemployee(Employee employee)
    {
        var result = await _employeeServices.UpdateEmployee(employee);
        return Ok(result);
    }

    [HttpDelete("deleteemployee")]
    public async Task<bool> Deleteemployee(int Id)
    {
        return await _employeeServices.DeleteEmployee(Id);
    }
}
