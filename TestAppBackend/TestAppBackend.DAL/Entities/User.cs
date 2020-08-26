using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAppBackend.DAL.Entities
{
    public class User : IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
    }
}