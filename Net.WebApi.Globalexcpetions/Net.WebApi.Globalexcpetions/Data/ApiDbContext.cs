using Microsoft.EntityFrameworkCore;
using Net.WebApi.Globalexcpetions.Models;

namespace Net.WebApi.Globalexcpetions.Data;

public class ApiDbContext :DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
    public DbSet<Employee> Employees { get; set; }
}
