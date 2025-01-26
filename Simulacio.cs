using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySolutions {
    public static class Simulacio {
        public static SistemaEnergia[] Simulacions { get; set; }
// NumSimulacio serveix per a indicar el número d'espais per a simulacions ocupats i la posicio del primer espai buit.
        public static int NumSimulacio { get; set; }

        /// <summary>
        /// Crea un array amb la longitud introduïda
        /// </summary>
        /// <param name="numDeSimulacions"></param>
        public static void CrearEspaiPerSimulacions(int numDeSimulacions) { 
            Simulacions = new SistemaEnergia[numDeSimulacions];
        }

        /// <summary>
        /// Desa les dades de una simulació
        /// </summary>
        /// <param name="novaSimulacio"></param>
        public static void RegistrarNovaSimulacio(SistemaEnergia novaSimulacio) {
            Simulacions[NumSimulacio] = novaSimulacio;
            NumSimulacio++;
        }
        /// <summary>
        /// Mostra la informació desada de les simulacions
        /// </summary>
        public static void MostrarTotesSimulacions() {
            Console.WriteLine("|Tipus de sistema\t|Data de la simulació\t|Energia generada\t|");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < NumSimulacio; i++) {
                Console.WriteLine($"|{Simulacions[i].TipusSistema}\t\t|{Simulacions[i].Data}\t\t|{Simulacions[i].EnergiaGenerada}\t\t|");
            }
        }
    }
}
