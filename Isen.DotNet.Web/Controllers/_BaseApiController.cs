using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Isen.DotNet.Web.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Isen.DotNet.Library.Repositories.InMemory;
using Isen.DotNet.Library.Models.Implementation;
using Microsoft.Extensions.Logging;
using Isen.DotNet.Library.Models.Base;
using System.Dynamic;

namespace Isen.DotNet.Web.Controllers
{
    public abstract partial class BaseController<T> : Controller
        where T : BaseModel
    {
        [HttpGet]
        [Route("api/[controller]")]
        public JsonResult GetAll()
        {
            var all = _repository
                .GetAll()
                .Select(t => t.ToDynamic())
                .ToList();
            return Json(all);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public JsonResult GetById(int id)
        {
            var single = _repository.Single(id);
            return Json(single);
        }
    }
}