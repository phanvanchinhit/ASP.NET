using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranMinhVuong_Buoi10.Models
{
    public class Student
    {
        private string name;
        private string gender;
        private string email;
        private string addr;
        private string subjects;
        private string username;
        private string password;
        private string comment;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Subjects { get => subjects; set => subjects = value; }
    }
}