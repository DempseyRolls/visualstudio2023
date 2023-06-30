namespace MedidoresModel
{
    public class Medidor
    {
        private string nombreMedidor;
        private string numeroSerie;
        private int tipoMedidor;

        public string TipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (TipoMedidor)
                {
                    case 1:
                        tipoTxt = "tipo1";
                        break;
                    case 2:
                        tipoTxt = "tipo2";
                        break;
                    case 3:
                        tipoTxt = "tipo3";
                        break;
                }
                return tipoTxt;
            }
        }
        public string NombreMedidor { get => nombreMedidor; set => nombreMedidor = value; }
        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public int TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
