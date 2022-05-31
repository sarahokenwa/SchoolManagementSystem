using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceobj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceobj2 = new StudentAttendanceDetailsModel();

            attendanceobj1.StudentID = 1;
            attendanceobj1.StudentName = "Sarah";
            attendanceobj1.AttendancePercentage = 83.02;


            attendanceobj2.StudentID = 2;
            attendanceobj2.StudentName = "Duchess";
            attendanceobj2.AttendancePercentage = 71.02;

            List<StudentAttendanceDetailsModel> listobj = new List<StudentAttendanceDetailsModel>
            {
                attendanceobj1,
                attendanceobj2
            };
            return listobj;
            // return new string[] { "value1", "value2" };
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
