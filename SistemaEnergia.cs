using System;

namespace EcoEnergySolutions {
    public abstract class SistemaEnergia : ICalculEnergia {
        public float EnergiaGenerada { get; set; }
        public string? TipusSistema { get; set; }
        public string? Data { get; set; }

        public abstract void ConfigurarParametre(int valorParametre);
        public abstract float CalcularEnergia(int valorParametre);
        public abstract void MostrarInforme();

    }
}