 using Microsoft.EntityFrameworkCore;
using Models;

 namespace SimpleWebAPI.Models
 {
     public class VacationContext : DbContext
     {
         public VacationContext(DbContextOptions<VacationContext> options)
             : base(options)
         {
         }

         public DbSet<Vacation> Vacations { get; set; }
     }
 }