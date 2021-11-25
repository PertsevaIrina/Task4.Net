using System;
using System.Text;

namespace Task4
{
    public class Soldier
    {
        protected string name;
        protected float height;
        protected float weight;
        protected float q;

        public Soldier(string name, float height, float weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
            findQ();
        }

        protected virtual void findQ()
        {
            this.q = height * weight;
        }

        public virtual String getInfo()
        {
            return name + (name.Length >= 16 ? "\t" : "\t\t") + "рост: " + height + "м\tвес: " + weight + "кг\tрейтинг: " + Math.Round(q);
        }

        public string Name => name;

        public float Height => height;

        public float Weight => weight;

        public float Q => q;
    }
}