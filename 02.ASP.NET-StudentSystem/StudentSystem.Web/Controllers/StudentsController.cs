namespace StudentSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using StudentSystem.Data;
    using StudentSystem.Web.Models;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private IStudentSystemData data;

        public StudentsController()
            : this(new StudentsSystemData())
        {
        }

        public StudentsController(IStudentSystemData studentsSystemData)
        {
            this.data = studentsSystemData;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var students = this.data
                .Students
                .All()
                .Select(StudentModel.FromStudent);

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var newStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level,
                AdditionalInformation = student.AdditionalInformation
            };

            this.data.Students.Add(newStudent);
            this.data.SaveChanges();

            student.StudentIdentification = newStudent.StudentIdentification;
            return Ok(student);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, StudentModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var existingStudent = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);
            if (existingStudent == null)
            {
                return BadRequest("Such student does not exist!");
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Level = student.Level;
            existingStudent.AdditionalInformation = student.AdditionalInformation;
            this.data.SaveChanges();

            return Ok(student);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var student = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);
            if (student == null)
            {
                return BadRequest("Such student does not exist.");
            }

            this.data.Students.Delete(student);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddCourse(int studentId, Guid courseId)
        {
            var student = this.data.Students.All().FirstOrDefault(s => s.StudentIdentification == studentId);
            if (student == null)
            {
                return BadRequest("Such course does not exist!");
            }

            var course = this.data.Courses.All().FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                return BadRequest("Such course does not exist!");
            }

            student.Courses.Add(course);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
