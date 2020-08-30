using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Services;

namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                _service.addUser(user);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpGet]
        [Route("validate/{username}/{password}")]
        public IActionResult Validate(string username, string password)
        {
            try
            {
                User user = _service.validate(username, password);
                if (user == null)
                {
                    return StatusCode(403);
                }
                else
                {
                    return Ok(user);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("user/{id}")]
        public IActionResult GetUser(string id)
        {
            try
            {
                User user = _service.getUser(id);
                if (user == null)
                {
                    return StatusCode(400);
                }
                else
                {
                    return Ok(user);
                }
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
    }
}
