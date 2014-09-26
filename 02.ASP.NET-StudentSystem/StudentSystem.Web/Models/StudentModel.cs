using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Web.Models
{
    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get
            {
                return s => new StudentModel
                {
                    StudentIdentification = s.StudentIdentification,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Level = s.Level,
                    AdditionalInformation = s.AdditionalInformation
                };
            }
        }

        public int StudentIdentification { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Level { get; set; }

        public StudentInfo AdditionalInformation { get; set; }
    }
}