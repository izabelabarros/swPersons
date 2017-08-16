using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebTestProject.Models;

namespace WebTestProject.Controllers
{
    [RoutePrefix("v1/persons")]
    public class PersonsController : ApiController
    {
        private string Name { get; set; }
        private static IList<Person> _persons = new List<Person>();

        [Route("{id}/name")]  
        [HttpGet]
        public string GetName(int id)
        {
            Name = "Izabela";
            return Name;
        }

        [Route("{id}/old")]
        [HttpGet]
        public int GetIOld(int id)
        {
            return id;
        }

        [Route("{id}/surname")]
        [HttpGet]
        public string GetSurName(int id)
        {
            return "Barros";
        }

        [Route("{id}")]
        [HttpGet]
        public Person GetPersons(int id)
        {
            return _persons[id];
        }

        [Route("{persons}")]
        [HttpGet]
        public IList<Person> GetPersons()
        {
            return _persons;
        }

        [Route]
        [HttpPost]
        public object CreatePersons(object person)
        {
            return person;
        }

        [Route]
        [HttpPost]
        public Person CreatePersons(Person person)
        {
            _persons.Add(person);
            //person.ID = _person.Count;
            return person;
        }
    }
}
