using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Application.common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}