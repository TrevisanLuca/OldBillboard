using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBillboard.Models
{
    public record Message(string Title, string Body, string Author, DateTime? Created = default, DateTime? Updated = default, int? Id = default);
}
