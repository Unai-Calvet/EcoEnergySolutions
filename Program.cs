using System;
namespace EcoEnergySolutions {
    public class Programa {


        /// <summary>
        /// Valida si un némero és major a un altre
        /// </summary>
        /// <param name="numAValidar"></param>
        /// <param name="minim"></param>
        /// <returns></returns>
        public static bool ValidarMajorOIgual(int numAValidar, int minim) { 
            return numAValidar >= minim;
        }


        /// <summary>
        /// Valida si un número esta inclòs en un rang
        /// </summary>
        /// <param name="numAValidar"></param>
        /// <param name="minim"></param>
        /// <param name="maxim"></param>
        /// <returns></returns>
        public static bool ValidarDinsDelRang(int numAValidar, int minim, int maxim) {
            return (ValidarMajorOIgual(numAValidar, minim) && numAValidar <= maxim);
        }
        
        
        /// <summary>
        /// Demana a l'usuari un valor, comprova que sigui enter i el retorna.
        /// </summary>
        /// <param name="missatge"></param>
        /// <returns>Valor enter</returns>
        public static int DemanarValorEnter(string missatge) {
            int num;
            Console.WriteLine(missatge);
            if (Int32.TryParse(Console.ReadLine(), out num)) { 
                return num;
            }
            Console.WriteLine("Error: Dada no vàlida");
            return DemanarValorEnter(missatge);
        }
        
        
        /// <summary>
        /// Demana a l'usuari un valor, comprova que sigui enter i major o igual a un valor i el retorna.
        /// </summary>
        /// <param name="missatge"></param>
        /// <param name="minim"></param>
        /// <returns></returns>
        public static int DemanarValorEnter(string missatge, int minim) {
            int num;
            Console.WriteLine(missatge);
            if (Int32.TryParse(Console.ReadLine(), out num) && num >= minim) {
                return num;
            }
            Console.WriteLine("Error: Dada no vàlida");
            return DemanarValorEnter(missatge);
        }
        
        
        /// <summary>
        /// Demana a l'usuari un valor, comprova que sigui enter i estingui en un interval i el retorna.
        /// </summary>
        /// <param name="missatge"></param>
        /// <param name="minim"></param>
        /// <returns></returns>
        public static int DemanarValorEnter(string missatge, int minim, int maxim) {
            int num;
            Console.WriteLine(missatge);
            if (Int32.TryParse(Console.ReadLine(), out num) && num >= minim && num <= maxim) {
                return num;
            }
            Console.WriteLine("Error: Dada no vàlida");
            return DemanarValorEnter(missatge);
        }


        /// <summary>
        /// Crea, calcula els atrubuts i desa una simulacio del sistema d'energia solar.
        /// </summary>
        public static void CrearIDesarSistemaSolar() {
            const string DemanarHoresSol = "Indica les hores de sol:";

            SistemaSolar sistemaSolar = new SistemaSolar();

            sistemaSolar.ConfigurarParametre(DemanarValorEnter(DemanarHoresSol));
            sistemaSolar.CalcularEnergiaGenerada(sistemaSolar.HoresSol);

            Simulacio.RegistrarNovaSimulacio(sistemaSolar);
        }


        /// <summary>
        /// Crea, calcula els atrubuts i desa una simulacio del sistema d'energia eòlica.
        /// </summary>
        public static void CrearIDesarSistemaEolic() {
            const string DemanarHoresSol = "Indica la velocitat del vent:";

            SistemaEolic sistemaEolic = new SistemaEolic();

            sistemaEolic.ConfigurarParametre(DemanarValorEnter(DemanarHoresSol));
            sistemaEolic.CalcularEnergiaGenerada(sistemaEolic.VelocitatVent);

            Simulacio.RegistrarNovaSimulacio(sistemaEolic);
        }


        /// <summary>
        /// Crea, calcula els atrubuts i desa una simulacio del sistema d'energia hidroelèctrica.
        /// </summary>
        public static void CrearIDesarSistemaHidroelectric() {
            const string DemanarCabalAigua = "Indica els cabals de l'aigua:";

            SistemaHidroelectric sistemaHidroelectric = new SistemaHidroelectric();

            sistemaHidroelectric.ConfigurarParametre(DemanarValorEnter(DemanarCabalAigua));
            sistemaHidroelectric.CalcularEnergiaGenerada(sistemaHidroelectric.CabalAigua);

            Simulacio.RegistrarNovaSimulacio(sistemaHidroelectric);
        }


        /// <summary>
        /// Genera una simulació
        /// </summary>
        public static void GenerarUnaSimulacio() {
            const string DemanarTipusDeSistema = "Tria el tipus de sistema que vols generar:\n1. Solar\n2. Eòlic\n3. Hidroelèctric";
            switch (DemanarValorEnter(DemanarTipusDeSistema, 1, 3)) {
                case 1:
                    CrearIDesarSistemaSolar();
                    break;
                case 2:
                    CrearIDesarSistemaEolic();
                    break;
                case 3:
                    CrearIDesarSistemaHidroelectric();
                    break;
                default:
                    break;
            }

        }


        /// <summary>
        /// Genera tantes simulacions con indica el parametre
        /// </summary>
        /// <param name="numeroDeSimulacions"></param>
        public static void GenerarSimulacions(int numeroDeSimulacions) {
            for (int i = 0; i < numeroDeSimulacions; i++) {
                GenerarUnaSimulacio();
            }
        }


        /// <summary>
        /// Demana qunates simulacions es vol generar i genera aquest número de simulacions.
        /// </summary>
        public static void IniciarSimulacio() {
            const string DemanarNumeroSimullacionsGenerades = "Indica cauntes simulacions vols generar";
            int numeroMaximDeSimulacionsAGenerar = Simulacio.Simulacions.Length - Simulacio.NumSimulacio;
            int numeroDeSimulacionsAGenerar;
            numeroDeSimulacionsAGenerar = DemanarValorEnter(DemanarNumeroSimullacionsGenerades, 1, numeroMaximDeSimulacionsAGenerar);
            GenerarSimulacions(numeroDeSimulacionsAGenerar);
        }


        /// <summary>
        /// En base a la opció escollida en el menú, s'invoca un funció per a crear noves simulacions, per a mostra les 
        /// existent o per a aturar el programa.
        /// </summary>
        /// <param name="opcioEscollida"></param>
        /// <returns></returns>
        public static bool OpcioMenu(int opcioEscollida) {
            switch (opcioEscollida) { 
                case 1:
                    IniciarSimulacio();
                    return true;
                case 2:
                    Simulacio.MostrarTotesSimulacions();
                    return true;
                case 3:
                    return false;
                default:
                    return true;
            }
        }


        public static void Main() {
            const string DemanarQuantitatSimulacions = "Introdueix quantes simulacions vols desar en total: ";
            const string MostrarMenu = "1. Iniciar simulació\n2. Veure informe de simulacions\n3. Sortir";

            // La següent variable indica, si el programa es continuara executant o si es tancarà.
            bool ProgramaEnExecucio = true;
            // La seguent variable desa diferent dades al llarg del programa
            int num;

            num = DemanarValorEnter(DemanarQuantitatSimulacions, 1);
            Simulacio.CrearEspaiPerSimulacions(num);
            while (ProgramaEnExecucio) {
                num = DemanarValorEnter(MostrarMenu);
                ProgramaEnExecucio = OpcioMenu(num);
            }
        }
    }
}