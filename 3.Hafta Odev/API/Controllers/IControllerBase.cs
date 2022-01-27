using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    public interface IControllerBase<T>
    {
        ActionResult<List<T>> Get();
        ActionResult AddItem([FromBody] T entity);
    }
}