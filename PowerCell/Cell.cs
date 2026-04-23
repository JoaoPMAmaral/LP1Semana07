namespace PowerCell
{
    public class Cell
    {
        private float charge;
        public string Name{get;}        

        public Cell(string Name)
        {
            this.Name = Name;
            Charge = 200;
        }

        public float Charge
        {
            get
            {
                return charge;
            }
            set
            {
                charge = value;
            }
        }
        public int Level
        {
            set
            {
                value = 1 + int.Parse(charge) / 40;
            }
            get
            {
                return Level;
            }
        }
        public void Consume(float ammount)
        {
            Charge -= ammount;
        }
        public void Restore()
        {
            Charge = 200;
        }

        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge:F0}/200";
        }
    }
}

    