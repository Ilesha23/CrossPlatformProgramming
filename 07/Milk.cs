namespace _07
{
    public class Milk : MilkProduct
    {
        protected double volume;
        public Milk() :base()
        {
            fattiness = 0.0;
            volume = 0.0;
        }
        public Milk(string name, bool liquid, double fat, double vol, int shelfLife, decimal price) :base(name, price, liquid, shelfLife)
        {
            fattiness = fat;
            volume = vol;
        }

        public double Fattiness
        {
            get { return fattiness; }
            set { fattiness = value; }
        }

        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Liquid: " + isLiquid + "    Fattiness: " + fattiness + "%    Volume: " + volume + "(L)    Shelf Life: " + shelfLifeDays + " day(s)    Price: " + price;
            return s;
        }
    }
}