namespace _05
{
    public class Cheese : MilkProduct
    {
        protected double weight;
        protected bool isSoft;
        public Cheese() :base()
        {
            isSoft = false;
            fattiness = 0.0;
            weight = 0.0;
        }
        public Cheese(string name, bool liquid, int ShelfLife, bool soft, double fat, double w, decimal price) :base(name, price, liquid, ShelfLife)
        {
            isSoft = soft;
            fattiness = fat;
            weight = w;
        }

        public bool IsSoft
        {
            get { return IsSoft; }
            set { IsSoft = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}