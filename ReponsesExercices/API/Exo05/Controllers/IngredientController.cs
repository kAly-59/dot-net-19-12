using Microsoft.AspNetCore.Mvc;
using Exo05.Model;
using System.Collections.Generic;
using Exo05.Data;

namespace Exo05.Controllers
{

    public class IngredientController : ControllerBase
    {
        private readonly FakeDb _db;

        public IngredientController(FakeDb db)
        {
            _db = db;
        }
    }
}
