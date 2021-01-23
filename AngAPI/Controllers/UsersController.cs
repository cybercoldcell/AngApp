using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AngAPI.Entities;
using AngAPI.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AngAPI.Controllers
{

    public class UsersController : BaseController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {

            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {

           return await _context.Users.FindAsync(id);
           
        }

    }
}