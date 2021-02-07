using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BlazorServerDbContextExample.Data
{
    public class TodoContext : DbContext
    {

       


        public static readonly string RowVersion = nameof(RowVersion);

        public static readonly string todoblaz = nameof(todoblaz).ToLower();

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
           
            Debug.WriteLine($"{ContextId} context created.");
        }




        public DbSet<Todo> Todo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this property isn't on the C# class
            // so we set it up as a "shadow" property and use it for concurrency
            modelBuilder.Entity<Todo>().ToTable("Todo");

            //base.OnModelCreating(modelBuilder);
        }

        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }

    }
}
