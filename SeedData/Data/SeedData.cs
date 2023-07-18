using Microsoft.EntityFrameworkCore;
using SeedData.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Data
{
    public class SeedDatas
    {
        public DbUser user = new DbUser();
        public List<User> us = new List<User>()
            {
                new User() {Id = 4, Name = "Jasur" , Email = "jas@gmail.com" , Password = "0121"},
                new User() {Id = 5, Name = "Sardor" , Email = "Sar@gmail.com" , Password = "1234"},
                new User() {Id = 6, Name = "Asil" , Email = "asil@gmail.com",Password = "0987"}
            };

        public SeedDatas() 
        {
            user.Database.EnsureCreated();
            user.Database.Migrate();
            if (!us.Any(u=> user.Users.Contains(u)))
            {
                user.AddRange(us);
                user.SaveChanges();
            }

        }

    }
}
