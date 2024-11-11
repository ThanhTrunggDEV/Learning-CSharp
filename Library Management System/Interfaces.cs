using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_Management_System
{
    public interface IBorrowable
    {
        DateTime DueDate { get; set; }
        void Borrow(int day);
        void Return();

    }
}
