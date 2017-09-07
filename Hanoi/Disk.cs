using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Disk : IPrintable, IComparable
    {
        int diskSize;
        public int DiskSize
        {
            get
            {
                return diskSize;
            }

            set
            {
                diskSize = value;
            }
        }

        public Disk(int TowerHeight, int DiskSize)
        {
            this.TowerHeight = TowerHeight;
            this.DiskSize = DiskSize;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Coś się pojawia na ekranie.");
        }
    }
}
