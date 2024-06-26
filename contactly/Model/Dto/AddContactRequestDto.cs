using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contactly.Model.Dto
{
    public class AddContactRequestDto
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public bool Favorite { get; set; }
    }
}