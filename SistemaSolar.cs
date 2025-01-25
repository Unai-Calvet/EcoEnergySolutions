﻿using System;

namespace EcoEnergySolutions {
    public class SistemaSolar : SistemaEnergia {
        public int HoresSol {  get; set; }

        SistemaSolar(int horesSol, float energiaGenerada, string tipusSistema, string data) { 
            HoresSol = horesSol;
            EnergiaGenerada = energiaGenerada;
            TipusSistema = tipusSistema;
            Data = data;
        }
        SistemaSolar(int horesSol) : this(horesSol, 0, "solar", DateTime.Today.ToString("d")) { }
        SistemaSolar() : this(0, 0, "solar", DateTime.Today.ToString("d")) { }

        public override void ConfigurarParametre(int horesSol) { 
            HoresSol = horesSol; 
        }
        public override float CalcularEnergia(int horesSol) { 
            return horesSol * 1.5f;
        }
        public override void MostrarInforme() {
            Console.WriteLine("Tipus de sistema\tData de la simulació\tHores de sol\tEnergia generada");
            Console.WriteLine($"Energia {TipusSistema}\t\t{Data}\t\t{HoresSol}\t\t{EnergiaGenerada}");
        }
    }
}