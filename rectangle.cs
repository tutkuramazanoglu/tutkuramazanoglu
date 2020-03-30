using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class rectangle
    {
        public int newLenght;
        public int newWidht;
        public int newHeight;
        public rectangle()
        {
            newLenght = 0;
            newWidht = 0;
            newHeight = 0;
        }
        public rectangle(int lenght, int widht, int height)
        {
            newLenght = lenght;
            newWidht = widht;
            newHeight = height;
        }
        public int getLenght()
        {
            return newLenght;
        }
        public int getwidht()
        {
            return newWidht;
        }
        public int getHeight()
        {
            return newHeight;
        }
        public void setLenght(int lenght)
        {
            newLenght = lenght;
        }
        public void setwidht(int widht)
        {
            newWidht = widht;
        }
        public void setHeight(int height)
        {
            newHeight = height; 
}
    }
}
