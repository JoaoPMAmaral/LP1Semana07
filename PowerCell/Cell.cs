using System;

namespace PowerCell
{
    public class Cell
    {
        private float charge;
        public string Name{get;}

        public Cell(string Name)
        {
            this.Name = Name;
            charge = 200;
        }

        public float Charge
        {
            get
            {
                if(charge >= 0 && charge <= 200)
                {
                    return charge;
                }
                else
                {
                    return 0;
                }

            }
        }
        public int Level
        {
            get
            {
                return 1 + Convert.ToInt32(Charge) / 40;
            }
        }
        public void Consume(float ammount)
        {
            charge -= ammount;
        }
        public void Restore()
        {
            charge = 200;
        }

        public override string ToString()
        {
            return $"[{Name}] Level {Level}: {Charge:F0}/200";
        }
    }
}

    