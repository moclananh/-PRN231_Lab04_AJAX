using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObjects.Models;
using Repositories.Interfaces;
using Repositories.Respositories;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository repository = new CategoryRepository();

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategory()
        {
            return repository.GetCategories();
        }


    }
}
