using Microsoft.EntityFrameworkCore;
using Net.WebApi.Globalexcpetions.Data;
using Net.WebApi.Globalexcpetions.Models;

namespace Net.WebApi.Globalexcpetions.Services;

public class EmployeeService : IEmployeeService
{
    private readonly ApiDbContext _dbContext;

    public EmployeeService(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await _dbContext.Employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeById(int id)
    {
        return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Employee> AddEmployee(Employee Employee)
    {
        var result = _dbContext.Employees.Add(Employee);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Employee> UpdateEmployee(Employee Employee)
    {
        var result = _dbContext.Employees.Update(Employee);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteEmployee(int Id)
    {
        var filteredData = _dbContext.Employees.FirstOrDefault(x => x.Id == Id);
        var result = _dbContext.Remove(filteredData);
        await _dbContext.SaveChangesAsync();
        return result != null ? true : false;
    }
}
