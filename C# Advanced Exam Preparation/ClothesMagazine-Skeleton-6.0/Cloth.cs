using System;
using System.Text;

namespace ClothesMagazine
{
    public class Cloth
    {
        public Cloth(string color,int size, string type)
        {
            Color = color;
            Size = size;
            Type = type;
        }
        public string Color { get;   }
        public int Size { get;  }
        public string Type { get;  }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Product: {this.Type} with size {Size}, color {Color}");
            return sb.ToString().TrimEnd();
        }
    }
}
