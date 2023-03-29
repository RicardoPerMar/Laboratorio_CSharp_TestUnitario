using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class EmailProgram
    {
        public string email;
        List<string> emailList = new List<string>();
        bool checkList = true;
        bool check = true;
        private readonly ICurrentEmail currentEmail;

        public EmailProgram(ICurrentEmail currentEmail)
        {
            this.currentEmail = currentEmail;
        }
        public bool emailRequest()
        {
            Console.Write("Introduce un correo electronico: ");
            email = currentEmail.GetEmail();
            checkList = currentEmail.checkListContains(emailList, email);
            if (isValid(email) && checkList)
            {
                emailList.Add(email);
                check = true;
            }
            else
            {
                check = false;
            }
            Console.WriteLine(check);
            return check;
        }
        public static bool isValid(string email) // True: contiene @ | False: no contiene @. Da igual el tamaño del email. PE: a@a => true / aa.com => false
        {
            return new EmailAddressAttribute().IsValid(email);
        }

    }
}
