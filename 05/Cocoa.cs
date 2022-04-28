namespace _05
{
    public class Cocoa : ChocolateProduct
    {
        protected bool isWithMilk;
        public Cocoa() :base()
        {
            isWithMilk = false;
            weight = 0.0;
        }
        public Cocoa(string name, bool liquid, bool milk, bool sweet, double w, decimal price) :base(name, price, liquid, sweet)
        {
            isWithMilk = milk;
            weight = w;
        }

        public bool IsWithMilk
        {
            get { return isWithMilk; }
            set { isWithMilk = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}