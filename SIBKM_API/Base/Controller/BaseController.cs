using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIBKM_API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Base.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Repository, Entity> : ControllerBase
        where Repository : class, IGeneralRepository<Entity>
        where Entity : class
    {
        Repository repository;
            public BaseController(Repository repository)
        {
            this.repository = repository;
        }

        // CREATE
        public IActionResult Post(Entity entity)
        {
            var result = repository.Post(entity);
            if(result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }
        // UPDATE 
        public IActionResult Put(Entity entity)
        {
            var result = repository.Put(entity);
            if(result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }
        // READ
        public IActionResult Get()
        {
            var data = repository.Get();
            return Ok(new { data = data });
        }
        // READ BY ID
        public IActionResult Get(int id)
        {
            var data = repository.Get(id);
            return Ok(new { data = data });
        }
        // DELETE
        public IActionResult Delete(int id)
        {
            var result = repository.Delete(id);
            if(result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
    }
