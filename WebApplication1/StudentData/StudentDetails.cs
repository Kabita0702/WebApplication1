﻿using WebApplication1.Models;

namespace WebApplication1.StudentData
{
    public class StudentDetails
    {
        public static IList<Student> studentdata = new List<Student>()
        {
            new Student()
            {
                Id = 1,StudentName="Kabita",StudentAddress="Jamshedpur",StudentClass="Automation"
            },
            new Student()
            {
                 Id = 2,StudentName="Mansi",StudentAddress="Ranchi",StudentClass="Automation"
            },
        };
    }
}
