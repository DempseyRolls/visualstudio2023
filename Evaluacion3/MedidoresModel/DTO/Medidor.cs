namespace MedidoresModel
{
    public class Medidor
    {
        
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
                        tipoTxt = "rural";
                        break;
                    case 2:
                        tipoTxt = "urbano";
                        break;
                    
                }
                return tipoTxt;
            }
        }
        
        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public int TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
    }
}
