 
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
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) {
        
        }
        public DbSet<Setup_Users_model> setup_users { get; set; }
        public DbSet<Setup_Inputvat_model> setup_input_vat { get; set; }
        public DbSet<Setup_Outputvat_model> setup_output_vat { get; set; }
        public DbSet<Setup_Expandedtax_model> setup_expanded_tax { get; set; } 
        public DbSet<Setup_Finaltax_model> setup_final_tax { get; set; }   


        //OTHERS  
        public DbSet<Setup_Bank_model> setup_Bank { get; set; }
        public DbSet<Setup_Currency_model> setup_Currency { get; set; }

        public DbSet<Setup_Industry_model> setup_industry { get; set; } 
        public DbSet<Setup_Category_model> setup_category { get; set; }
        public DbSet<Setup_Department_model> setup_department { get; set; }
        public DbSet<Setup_Project_model> setup_project { get; set; }
        public DbSet<Setup_Terms_model> setup_term { get; set; }

        //Book
        public DbSet<Setup_Book_model> setup_book { get; set; }


        //CHART
        public DbSet<Setup_Chartclass_model> setup_chart_class { get; set; }
        public DbSet<Setup_Chartgroup_model> setup_chart_group { get; set; }
        public DbSet<Setup_Chartofaccount_model> setup_chart_of_account { get; set; }

        //AGING 
        public DbSet<Setup_Aging_model> setup_aging { get; set; }

        //COMPANY 
        public DbSet<Setup_Company_model> setup_company { get; set; }

        // Business Partner
        public DbSet<Setup_Businesspartner_model> setup_business_partner { get; set; }

         
    }
}
