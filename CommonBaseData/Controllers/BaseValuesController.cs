using CommonBaseData.Entity.Repository;
using CommonBaseData.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommonBaseData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseValuesController : ControllerBase
    {


        private IBaseValueRepository _baseValueRepository;
        public BaseValuesController(IBaseValueRepository baseValueRepository)
        {
            _baseValueRepository = baseValueRepository;
        }




        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<TblCommonBaseData> ws_loadBaseValue()
        {
            return _baseValueRepository.loadBaseValue();
        }


        // GET api/<BaseValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> ws_loadBaseValue([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baseValue = await _baseValueRepository.ws_loadBaseValueById(id);

            if (baseValue == null)
            {
                return NotFound();
            }

            return Ok(baseValue);
        }


        // GET api/<BaseValuesController>/name
        [HttpGet("{name}")]
        public async Task<IActionResult> ws_loadBaseValue([FromBody] string code)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baseValue = await _baseValueRepository.ws_loadBaseValueByTitle(code);

            if (baseValue == null)
            {
                return NotFound();
            }

            return Ok(baseValue);
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
