using System;

namespace EcoEnergySolutions {
    interface ICalculEnergia {
        public void ConfigurarParametre(int valorParametre);
        public void CalcularEnergia();
        public void MostrarInforme();
    }
}
