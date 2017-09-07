using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Tower<Disk> : IPrintable, IComparable
    {
        Stack<Disk> hanoi = new Stack<Disk>();
        public Disk HanoiPeek;
        int towerHeight;
        public int TowerHeight
        {
            get
            {
                return towerHeight;
            }

            set
            {
                towerHeight = value;
            }
        }
        Hanoi.Disk d = new Hanoi.Disk(5, 4);
        
        public Tower(int TowerHeight)
        {
            this.TowerHeight = TowerHeight;
        }

        public void Push(Disk d)
        {
            if (d < HanoiPeek)
            {
                hanoi.Push(Element);
            }
            else
            {
                throw new LargerOnSmallerException("Próbujesz położyć większy krążek na mniejszy. Nie wolno!");
            }
        }

        public void Pop()
        {
            if(hanoi.Peek() = true)
            {
                return hanoi.Peek();
            }
            else
            {
                throw new EmptyTowerException("Wieża jest pusta, nie możesz z niej nic ściągnąć!");
            }
        }

        public void Print()
        {
            Console.WriteLine("Coś się pojawia na ekranie.");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
