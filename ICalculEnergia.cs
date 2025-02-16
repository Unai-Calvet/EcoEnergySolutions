﻿using System;

namespace EcoEnergySolutions {
    interface ICalculEnergia {
        /// <summary>
        /// Configura el paràmetre de càlcul de l'energia
        /// </summary>
        /// <param name="valorParametre"></param>
        public void ConfigurarParametre(int valorParametre);

        /// <summary>
        /// Calcula la energia generada a partir de paràmetre
        /// </summary>
        /// <param name="valorParametre"></param>
        public void CalcularEnergiaGenerada(int valorParametre);

        /// <summary>
        /// Mostra les propietats en format de taula
        /// </summary>
        public void MostrarInforme();
    }
}
