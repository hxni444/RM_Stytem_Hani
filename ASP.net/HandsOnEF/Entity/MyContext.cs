﻿using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEF.Entity
{
    public class MyContext:DbContext
    {
        public DbSet<Student> students {  get; set; }
        public DbSet<Mark> marks { get; set; }
        public DbSet<Staff> staffs  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RMPLC4CE83617ZZ\SQL2022;Initial Catalog=SMSDBSE;User ID=sa;Password=Password123.;Trust Server Certificate=True");
        }
    }
}
