using accounting_api.Models.Setup.Tax;
using accounting_api.Models.Setup.User;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace accounting_api.Data
{
    public class ApplicationAtDBContext : DbContext
    {
        public ApplicationAtDBContext(DbContextOptions<ApplicationAtDBContext> options):base(options) {
        
        }

        public DbSet<Setup_Users_model_at> setup_users_at { get; set; }  
        public DbSet<Setup_Inputvat_model_at> setup_input_vat_at { get; set; } 
        public DbSet<Setup_Outputvat_model_at> setup_output_vat_at { get; set; } 
        public DbSet<Setup_Expandedtax_model_at> setup_expanded_tax_at { get; set; }
        public DbSet<Setup_Finaltax_model_at> setup_final_tax_at { get; set; }
    }
}
