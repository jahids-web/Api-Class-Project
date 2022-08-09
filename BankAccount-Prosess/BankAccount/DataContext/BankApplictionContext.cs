using BankAccount.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.DataContext
{
    public class BankApplictionContext : DbContext
    {
        public BankApplictionContext(DbContextOptions<BankApplictionContext>options) : base(options)
        {
                
        }
        public DbSet<PaymentDetail> PaymentDetail { get; set; }
    }
}
