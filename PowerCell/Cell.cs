namespace PowerCell
{
    public class Cell
    {
        private float charge;
        public string Name{get;}
        public float Charge;
        public int Level{get;}

        public Cell(string Name, float Charge)
        {
            this.Name = Name;
            this.Charge = 200;
        }

        public void Consume(float ammount)
        {
            Charge -= ammount;
        }
        public void Restore()
        {
            Charge = 200;
        }
    }
}

    