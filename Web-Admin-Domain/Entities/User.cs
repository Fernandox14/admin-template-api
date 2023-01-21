using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Web_Admin_Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
         [JsonIgnore]
        public int UserLevelId { get; set; }
        public UserLevel? UserLevel { set;  get; }
    }

    public class UserLevel {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
