using Marketim.Business.Abstracts;
using Marketim.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marketim.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {

        private readonly IManagerService _managerService;
        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }


        // GET: api/<ManagerController>
        [HttpGet]
        public IEnumerable<Manager> Get()
        {
            return _managerService.GetAll();
        }

        // GET api/<ManagerController>/5
        [HttpGet("{id}")]
        public Manager Get(int id)
        {
            return _managerService.Get(x => x.Id == id);
        }

        // POST api/<ManagerController>
        [HttpPost]
        public void Post([FromBody] Manager manager)
        {

            _managerService.Insert(manager);

        }

        // PUT api/<ManagerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Manager manager)
        {
            manager.Id = id;
            _managerService.Update(manager);
        }

        // DELETE api/<ManagerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _managerService.Delete(new Manager { Id = id });
        }
    }
}
