using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public interface ICurrentEmail
    {
        string GetEmail();
        bool checkListContains(List<string> emailList, string email);
    }
    public class CurrentEmail : ICurrentEmail
    {
        public string GetEmail()
        {
            var email = Console.ReadLine();
            return email;
        }

        public bool checkListContains(List<string> emailList, string email)
        {
            bool result;
            if (emailList.Contains(email))
            {
                Console.WriteLine("Ya se ha validado el correo electrónico");
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
