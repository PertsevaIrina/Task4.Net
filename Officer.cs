using System;

namespace Task4
{
    public class Officer : Soldier
    {
        private Education p;

        public Officer(string name, float height, float weight, Education p) : base(name, height, weight)
        {
            this.p = p;
            findQ();
        }

        protected override void findQ()
        {
            base.findQ();
            switch (this.p)
            {
                case Education.elementary:
                    this.q *= 0.5f;
                    break;
                case Education.higher:
                    this.q *= 2f;
                    break;
                default:
                    this.q *= 1f;
                    break;
            }
        }

        public override string getInfo()
        {
            return base.getInfo() + "\tОфицер, образование: " + p.ToString();
        }
    }
}