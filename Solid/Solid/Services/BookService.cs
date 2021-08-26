using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Solid.Services
{
    class BookService
    {
        public void EnterBookDetails(string title, string author, bool avail, DateTime published, double cost )
        {
            Debug.WriteLine("Thanks for entering book details, we have Title as  ' {0} ', and Authour is {1}, and book was published on {2}", title, author, published);


        }

    }
}
