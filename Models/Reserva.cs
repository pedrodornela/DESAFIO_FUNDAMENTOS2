using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIO_FUNDAMENTOS2.Models
{
    public class Reserva
    {
        public Reserva(){ }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                Console.WriteLine("--- A quantidade de hóspedes não pode exceder a capacidade da Suíte! ---");
                Console.WriteLine("--- Não foi possível cadastrar nenhum Hóspede! ---");
                Hospedes = [];
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite) => Suite = suite;

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            var valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                return valor - (0.1M * valor);
            }
            else
            {
                return valor;
            }
        }

    }
}