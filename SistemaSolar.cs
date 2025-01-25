using System;

namespace EcoEnergySolutions {
    public class SistemaSolar : SistemaEnergia {
        public int HoresSol {  get; set; }

        SistemaSolar(int horesSol, float energiaGenerada, string tipusSistema, string data) { 
            HoresSol = horesSol;
            EnergiaGenerada = energiaGenerada;
            TipusSistema = tipusSistema;
            Data = data;
        }
        SistemaSolar() : this(0, 0, "Solar", DateTime.Today.ToString("d")) { }

        public override void ConfigurarParametre(int horesSol) { 
            HoresSol = horesSol; 
        }
        public override void CalcularEnergiaGenerada(int horesSol) { 
            EnergiaGenerada = horesSol * 1.5f;
        }
        public override void MostrarInforme() {
            Console.WriteLine("|Tipus de sistema\t|Data de la simulació\t|Hores de sol\t|Energia generada\t|");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine($"|{TipusSistema}\t\t|{Data}\t\t|{HoresSol}\t\t|{EnergiaGenerada}\t\t|");
        }
    }
}