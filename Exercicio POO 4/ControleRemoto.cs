namespace Exercicio_POO_4
{
    public class ControleRemoto
    {
        Televisao televisao = new Televisao();

        public ControleRemoto() { }

        public bool AumentarVolume() => televisao.AumentarVolume();
        public bool DiminuirVolume() => televisao.DiminuirVolume();
        public bool SubirCanal() => televisao.SubirCanal();
        public bool DescerCanal() => televisao.DescerCanal();

        public bool EscolherCanal(int canal) => televisao.EscolherCanal(canal);

        public int GetCanal() => televisao.GetCanal();
        public int GetVolume() => televisao.GetVolume();
    }
}
