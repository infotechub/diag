using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NovoDiagnosis.Models;

namespace NovoDiagnosis.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyBenefit> CompanyBenefit { get; set; }
        public DbSet<CompanyBranch> CompanyBranch { get; set; }
        public DbSet<CompanyPlan> CompanyPlans { get; set; }
        public DbSet<CompanySubsidiary> CompanySubsidiaries { get; set; }
        public DbSet<DiagnosisDetails> DiagnosisDetails { get; set; }
        public DbSet<Enrollee> Enrollees { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<User> NovoUsers { get; set; }
        public DbSet<State> States { get; set; }
    }
}
