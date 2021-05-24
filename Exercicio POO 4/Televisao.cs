namespace Exercicio_POO_4
{
    public class Televisao
    {
        private int Volume = 0, Canal = 1;

        public Televisao() { }

        public bool AumentarVolume()
        {
            if (Volume < 10)
            {
                Volume++;
                return true;
            }
            return false;
        }
        public bool DiminuirVolume()
        {
            if (Volume > 0)
            {
                Volume--;
                return true;
            }
            return false;
        }

        public bool SubirCanal() 
        {
            if (Canal < 99)
            {
                Canal++;
                return true;
            }
            return false;
        }

        public bool DescerCanal()
        {
            if (Canal > 1)
            {
                Canal--;
                return true;
            }
            return false;
        }

        public bool EscolherCanal(int canal)
        {
            if (canal >= 1 && canal <= 99)
            {
                Canal = canal;
                return true;
            }
            return false;
        }

        public int GetCanal() => Canal;
        public int GetVolume() => Volume;
    }
}
