using Ejercicio1;
EmailProgram email;
email = new EmailProgram(new CurrentEmail());
do
{
    email.emailRequest();
} while (!email.email.Equals("quit"));



