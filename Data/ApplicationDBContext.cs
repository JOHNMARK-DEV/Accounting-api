using accounting_api.Models.Setup.Tax;
using accounting_api.Models.Setup.User;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace accounting_api.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) {
        
        }
        public DbSet<Setup_Users_model> setup_users { get; set; }
        public DbSet<Setup_Inputvat_model> setup_input_vat { get; set; }
        public DbSet<Setup_Outputvat_model> setup_output_vat { get; set; }
        public DbSet<Setup_Expandedtax_model> setup_expanded_tax { get; set; }
        public DbSet<Setup_Finaltax_model> setup_final_tax { get; set; } 
    }
}
