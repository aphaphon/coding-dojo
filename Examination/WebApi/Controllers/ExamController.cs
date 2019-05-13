using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController
    {
        public static List<ExamResultInfo> ExamResults { get; private set; }

        static ExamController()
        {
            ExamResults = new List<ExamResultInfo>();
        }

        // TODO: Create new exam result
        [HttpPost]
        public void CreateNewExamResult([FromBody] ExamResultInfo value)
        {
            ExamResults.Add(value);
        }

        // TODO: (Optional) Get all exam results
        [HttpGet]
        public IEnumerable<ExamResultInfo> Get()
        {
            var getCourseId = CourseController.Courses;
            var qry = getCourseId.Where(it => ExamResults.Contains(it.Id));
            return ExamResults;
        }

        // TODO: (Optional) Update exam result by Id
        [HttpPut]
        public void UpdateExamResult([FromBody] ExamResultInfo value)
        {
            var updateExamResult = ExamResults.FirstOrDefault(it => it.Id == value.Id);
            if (updateExamResult == null)
            {
                return;
            }
            updateExamResult.Id = value.Id;
            updateExamResult.CourseId = value.CourseId;
            updateExamResult.StudentId = value.StudentId;
            updateExamResult.Score = value.Score;

        }

        // TODO: (Optional) Delete exam result by Id
        [HttpDelete("{id}")]
        public void DeleteExamResult(string id)
        {
            var deleteExamResult = ExamResults.Where(it => it.Id == id).FirstOrDefault();
            if (deleteExamResult == null)
            {
                return;
            }
            ExamResults.Remove(deleteExamResult);
        }
    }
}
