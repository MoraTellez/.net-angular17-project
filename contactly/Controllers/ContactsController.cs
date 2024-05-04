using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contactly.Data;
using contactly.Model.Domain;
using contactly.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace contactly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly ContactlyDbContext context;

        public ContactsController(ContactlyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContacts()
        {
            var contacts = await context.Contacts.ToListAsync();
            return Ok(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] AddContactRequestDto request)
        {
            var domainModel = new Contact
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Favorite = request.Favorite
            };

            await context.Contacts.AddAsync(domainModel);
            await context.SaveChangesAsync();

            return Ok(domainModel);
        }
    }
}
