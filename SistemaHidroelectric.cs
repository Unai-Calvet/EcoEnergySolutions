using System;

namespace EcoEnergySolutions {
    public class SistemaHidroelectric : SistemaEnergia {
        public int CabalAigua { get; set; }

        public SistemaHidroelectric(int velocitatVent, float energiaGenerada, string tipusSistema, string data) {
            CabalAigua = velocitatVent;
            EnergiaGenerada = energiaGenerada;
            TipusSistema = tipusSistema;
            Data = data;
        }
        public SistemaHidroelectric() : this(0, 0, "Hidroelèctric", DateTime.Today.ToString("g")) { }

        public override void ConfigurarParametre(int cabalAigua) {
            CabalAigua = cabalAigua;
        }
        public override void CalcularEnergiaGenerada(int cabalAigua) {
            EnergiaGenerada = cabalAigua * 9.8f * 0.8f;
        }
        public override void MostrarInforme() {
            Console.WriteLine("|Tipus de sistema\t|Data de la simulació\t|VelocitatVent\t|Energia generada\t|");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine($"|{TipusSistema}\t\t|{Data}\t\t|{CabalAigua}\t\t|{EnergiaGenerada}\t\t|");
        }
    }
}