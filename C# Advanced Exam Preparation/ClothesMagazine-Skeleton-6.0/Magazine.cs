using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        private List<Cloth> clothes;
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            clothes = new List<Cloth>();
        }

        public string Type { get;  }
        public int Capacity { get;  }
        public List<Cloth> Clothes => clothes;


        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }

            
        }

       public bool RemoveCloth(string color)
        {
            var removeCloth = Clothes.FirstOrDefault(c => c.Color == color);
            if (removeCloth != null)
            {
                Clothes.Remove(removeCloth);
                return true;
            }

            return false;

        }

        public Cloth GetSmallestCloth()
        {
            return Clothes.MinBy(c => c.Size);

        }

        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Type} magazine contains:");

            foreach (var cloth in Clothes.OrderBy(x=>x.Size))
            {
                sb.AppendLine($"{cloth}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
