using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class AbstractDemo
    {
    }

    public abstract class Authentication
    {

        protected abstract void LoginWithEmailAndPassword();

        protected abstract void loginWithGmail();

        void loginWithFacebook() { 
        
        }

        void signUpWithWithEmailAndPassword(string email, string password, string fullName) { 
        
        }

    }


    public class AuthImpl :Authentication{
        protected override void LoginWithEmailAndPassword() {
            Console.WriteLine("Login with email n pssword");

        }

        protected override void loginWithGmail() {
            Console.WriteLine("Gmail Login");
        }

    }

    public class AnotherDeveloper:AuthImpl {

        int Test() {
            //var s[] = { 1, 2 };

            this.LoginWithEmailAndPassword();
            return 0;
        }
    }
}
