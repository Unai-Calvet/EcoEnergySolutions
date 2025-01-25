using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySolutions {
    public static class Simulacio {
        public static SistemaEnergia[] Simulacions { get; set; }
// NumSimulacio serveix per a indicar el número d'espais per a simulacions ocupats i la posicio del primer espai buit.
        public static int NumSimulacio { get; set; }

        public static void AfegirSimulacio(SistemaEnergia novaSimulacio) {
            Simulacions[NumSimulacio] = novaSimulacio;
            NumSimulacio++;
        }
        public static void MostrarSimulacions() {
            Console.WriteLine("|Tipus de sistema\t|Data de la simulació\t|Energia generada\t|");
            for (int i = 0; i < NumSimulacio; i++) {
                Console.WriteLine($"|{Simulacions[i].TipusSistema}\t\t|{Simulacions[i].Data}\t\t|{Simulacions[i].EnergiaGenerada}\t\t|");
            }
        }
    }
}
