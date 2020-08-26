using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PrsEfTutorialLibrary.Models {
    
    public class User {

        public int Id { get; set; } = 0;
        public string Username { get; set; } = $"XXX{DateTime.Now.Millisecond}";
        public string Password { get; set; } = "XXX";
        public string Firstname { get; set; } = "XXX";
        public string Lastname { get; set; } = "XXX";
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        [JsonIgnore]
        public virtual IEnumerable<Request> Requests { get; set; }

        public User() { }

        public override string ToString() => $"{Id}/{Username}/{Firstname} {Lastname}";
    }
}
