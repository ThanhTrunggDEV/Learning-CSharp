using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class Pro<T>
    {
        private T val;

        public T Val { get { return val; } set { val = value; } }

        public Pro() { }
        public Pro (T val)
        {
            this.Val = val;
        }



    }
    public class Pro
    {
        private int val;

        public int Val { get { return val; } set { val = value; } }

        public Pro() { }
        public Pro(int val)
        {
            this.Val = val;
        }

        public static Pro operator +(Pro a, Pro b)
        {
            return new Pro(a.val + b.val);
        }

        public override string ToString()
        {
            return val.ToString();
        }
        public static Pro operator ++(Pro a)
        {
            return new Pro(a.val+1);
        }
    }
}
