 
﻿using accounting_api.Models.Setup.Tax; 
﻿using accounting_api.Models.Setup;
using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Chart;
using accounting_api.Models.Setup.Others;
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
  
        //OTHERS  
        public DbSet<Setup_Bank_model_at> Setup_Bank_at { get; set; } 
        public DbSet<Setup_Currency_model_at> Setup_Currency_at { get; set; }

        public DbSet<Setup_Industry_model_at> setup_industry_at { get; set; }
        public DbSet<Setup_Category_model_at> setup_category_at { get; set; }
        public DbSet<Setup_Department_model_at> setup_department_at { get; set; }
        public DbSet<Setup_Project_model_at> setup_project_at { get; set; }
        public DbSet<Setup_Terms_model_at> setup_term_at { get; set; }

        //Book
        public DbSet<Setup_Book_model_at> setup_book_at { get; set; }

        //CHART
        public DbSet<Setup_Chartclass_model_at> setup_chart_class_at { get; set; }
        public DbSet<Setup_Chartgroup_model_at> setup_chart_group_at { get; set; }
        public DbSet<Setup_Chartofaccount_model_at> setup_chart_of_account_at { get; set; }

        //AGING 
        public DbSet<Setup_Aging_model_at> setup_aging_at { get; set; }
         
        //COMPANY 
        public DbSet<Setup_Company_model_at> setup_company_at { get; set; }

        // Business Partner
        public DbSet<Setup_Businesspartner_model_at> setup_business_partner { get; set; }
         
    }
}
