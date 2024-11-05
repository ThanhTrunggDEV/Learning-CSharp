using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Zoo_Management
{
    public interface IHerbivore
    {
        void Graze();
    }
    public interface ICarnivor
    {
        void Hunt();
    }
}
