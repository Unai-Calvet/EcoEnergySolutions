using System;

namespace EcoEnergySolutions {
    public class SistemaEolic : SistemaEnergia {
        public int VelocitatVent { get; set; }

        SistemaEolic(int velocitatVent, float energiaGenerada, string tipusSistema, string data) {
            VelocitatVent = velocitatVent;
            EnergiaGenerada = energiaGenerada;
            TipusSistema = tipusSistema;
            Data = data;
        }
        SistemaEolic() : this(0, 0, "eòlica", DateTime.Today.ToString("d")) { }

        public override void ConfigurarParametre(int velocitatVent) {
            VelocitatVent = velocitatVent;
        }
        public override void CalcularEnergiaGenerada(int velocitatVent) {
            EnergiaGenerada = (float) (Math.Pow( velocitatVent, 3) * 0.2);
        }
        public override void MostrarInforme() {
            Console.WriteLine("|Tipus de sistema\t|Data de la simulació\t|VelocitatVent\t|Energia generada\t|");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine($"|Energia {TipusSistema}\t\t|{Data}\t\t|{VelocitatVent}\t\t|{EnergiaGenerada}\t\t|");
        }
    }
}