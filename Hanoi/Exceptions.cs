using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{

    //test 2 branch
    [Serializable]
    public class LargerOnSmallerException : Exception
    {
        public LargerOnSmallerException()
        { }

        public LargerOnSmallerException(string message)
            : base(message)
        { }

        public LargerOnSmallerException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }

    [Serializable]
    public class EmptyTowerException : Exception
    {
        public EmptyTowerException()
        { }

        public EmptyTowerException(string message)
            : base(message)
        { }

        public EmptyTowerException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
