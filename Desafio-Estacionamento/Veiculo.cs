using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public TimeSpan HoraSaida { get; set; }
        public TimeSpan TempoPermanencia { get; set; }
        public decimal ValorCobrado { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public Veiculo(string placa, DateTime dataEntrada, TimeSpan horaEntrada)
        {
            Placa = placa;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
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
            TempoPermanencia = HoraSaida - HoraEntrada;
        }

        public DateTime GerarData()
        {
            return DateTime.Now.Date;
        }

        public TimeSpan GerarHora()
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
            throw new NotImplementedException();
        }
    }

}
