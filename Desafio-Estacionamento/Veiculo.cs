using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desafio_Estacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime DataEntrada { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public TimeSpan HoraSaida { get; set; }
        public double TempoPermanencia { get; set; }
        public double ValorCobrado { get; set; }

        public string Tipo { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public Veiculo(string tipo, string placa, string modelo,DateTime dataEntrada, TimeSpan horaEntrada)
        {
            Tipo = tipo;
            Placa = placa;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
            Modelo = modelo;
        }

        public Veiculo(string tipo, string placa, string modelo)
        {
            Tipo = tipo;
            Placa = placa;
            Modelo = modelo;
        }

        public void GerarDataHoraEntrada()
        {
            DataEntrada = GerarData();
            HoraEntrada = GerarHora();
        }

        public void GerarDataHoraSaida()
        {
            DataSaida = GerarData();
            HoraSaida = GerarHora();
            TempoPermanencia = HoraSaida.TotalMinutes - HoraEntrada.TotalMinutes;
            ValorCobrado = Math.Ceiling(TempoPermanencia/60) * 5.0;
        }

        public static DateTime GerarData()
        {
            return DateTime.Now.Date;
        }

        public static TimeSpan GerarHora()
        {
            return DateTime.Now.TimeOfDay;
        }

        public bool JaCadastrada(string placa)
        {
            // Chamar a logica le leitura do Persistencia
            throw new NotImplementedException();
        }

        public bool TemLugar()
        {
            // Chamar a logica le leitura do Persistencia
            // TIREI DAQUI pois nao acho que seja da reponsabilidade
            // de um veiculo saber se o estacionamento tem lugar ou nao
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return obj is Veiculo veiculo &&
                   Placa == veiculo.Placa;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {

            if (ValorCobrado >= 0)
                return this.Tipo + "-" + this.Placa + "-" + this.Modelo + "-" + this.DataEntrada.ToString("dd/mm/yyyy") + "-" + this.HoraEntrada;
            else
                return this.Tipo + "-" + this.Placa + "-" + this.Modelo + "-" + this.TempoPermanencia + "-" + this.ValorCobrado;
        }
    }

}
