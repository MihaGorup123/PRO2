using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class GenSklad<t>
    {
        int m_size;
        int m_stackPointer = 0;
        t[] m_items;
        public GenSklad(int velikost)
        {
            m_size = velikost;
            m_items = new t[velikost];
        }
        public GenSklad() : this(100)
        {
        }
        public void Push(t item)
        {
            if (m_stackPointer >= m_size)
            {
                throw new StackOverflowException("sklad je poln");
            }
            m_items[m_stackPointer] = item;
            m_stackPointer++;
        }
        public object pop()
        {
            m_stackPointer--;
            if (m_stackPointer >= 0)
            {
                return m_items[m_stackPointer];
            }
            m_stackPointer = 0;
            throw new StackOverflowException("sklad je prazen");
        }
    }
}
