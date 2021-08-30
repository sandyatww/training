using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Solid.Services
{

    public interface IUserService{
       void  PrintAge();
}

    class UserService : IUserService
    {

        public static void prinname()
        {
            Debug.WriteLine("My name is Sandeep Singh..");
        }

        public void PrintAge()
        {
            throw new NotImplementedException();
        }
    }

}
