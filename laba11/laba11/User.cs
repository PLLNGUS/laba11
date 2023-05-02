using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public string UserName { get; set; }

        public string UserSurname{ get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public string Number { get; set; }

        public string Kafedra { get; set; }

        public string Stepen { get; set; }

        public string Datatime { get; set; }
        public User()
        { }
        public User(string Login, string Password, string Email, string Role, string Number, string Kafedra, string Stepen, string Datatime)
        {
            this.Login = Login;
            this.Password = Password;
            this.UserName = UserName;
            this.UserName = UserName;
            this.Role = Role;
            this.Email = Email;
            this.Number = Number;
            this.Kafedra = Kafedra;
            this.Stepen = Stepen;
            this.Datatime = Datatime;
        }
    }

}
