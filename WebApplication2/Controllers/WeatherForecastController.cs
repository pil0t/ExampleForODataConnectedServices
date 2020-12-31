using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Extensions.Logging;
using Teachers;

namespace Students
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

namespace Teachers
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

namespace WebApplication2.Controllers
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Students.Person> Students { get; set; }
        public ICollection<Person> AnotherStudents { get; set; }
    }

    public class GroupsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Group> Get()
        {
            return Enumerable.Empty<Group>();
        }
    }
}