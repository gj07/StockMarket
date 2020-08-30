using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Services;

namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("companies/all")]
        public IActionResult GetAllCompanies()
        {
            try
            {
                List<Company> companies = _service.getAllCompanies();
                if (companies == null)
                {
                    return StatusCode(400, "No company is present in the records yet.");
                }
                else
                {
                    return Ok(companies);
                }
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpGet]
        [Route("companies/{id}")]
        public IActionResult GetCompany(string id)
        {
            try
            {
                Company company = _service.getCompany(id);
                if (company == null)
                {
                    return StatusCode(400, "Invalid company code");
                }
                else
                {
                    return Ok(company);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("companies")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                _service.addCompany(company);
                return StatusCode(201, "New company added");
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpDelete]
        [Route("companies/{id}")]
        public IActionResult RemoveCompany(string id)
        {
            try
            {
                _service.removeCompany(id);
                return Ok($"The company with company code {id} was deleted.");
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpPut]
        [Route("companies")]
        public IActionResult EditCompany(Company company)
        {
            try
            {
                _service.editCompany(company);
                return Ok("Company");
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
    }
}
