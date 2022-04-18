using ConsoleApp1.DAL;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCourse();
        }

        static void AddCourse()
        {
            Course course = new Course
            {
                Name = "Codeacademy",
                Description= "Information Technology course",
                Price=55
            };
            using (AppDbContext dbContext=new AppDbContext())
            {
                dbContext.courses.Add(course);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"{course.Name} created");
        }



    }
}


