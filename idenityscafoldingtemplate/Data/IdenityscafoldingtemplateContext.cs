using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace idenityscafoldingtemplate.Data
{
    public class IdenityscafoldingtemplateContext(DbContextOptions<IdenityscafoldingtemplateContext> options) 
        : IdentityDbContext<IdentityUser>(options)
    {
    }
}
