using Net.WebApi.Globalexcpetions.Models;

namespace Net.WebApi.Globalexcpetions.Services;

public interface IEmployeeService
{
    public Task<IEnumerable<Employee>> GetEmployees();
    public Task<Employee?> GetEmployeeById(int id);
    public Task<Employee> AddEmployee(Employee Employee);
    public Task<Employee> UpdateEmployee(Employee Employee);
    public Task<bool> DeleteEmployee(int Id);
}
