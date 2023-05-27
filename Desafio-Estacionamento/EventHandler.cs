using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento
{
    internal class EventHandler
    {
        public string FileEntry { get; set; }
        public string FileOut { get; set; }

        public EventHandler(string filePathEntry, string filePathOut) {
            FileEntry = filePathEntry;
            FileOut = filePathOut;
        }

        public EventHandler()
        {
            // [e uma merda n saber usar relative path
            FileEntry = "E:\\Desafio04\\Desafio-Estacionamento\\registros\\ENTRADA_" + DateTime.Now.ToString("yyyy-M-dd") + ".txt";
            FileOut = "E:\\Desafio04\\Desafio-Estacionamento\\registros\\SAIDA_" + DateTime.Now.ToString("yyyy-M-dd") + ".txt";
        }

        public void register(Veiculo veiculo)
        {
            int tamanho = ManipulateDoc.getLength(FileEntry);

            if(tamanho < 50)
            {
                veiculo.GerarDataHoraEntrada();
                ManipulateDoc.writeOne(veiculo, FileEntry);
            }
            else
            {
                throw new Exception("Tamanho do estacionameto excedido");
            }
        }

        public void remove(Veiculo veiculo)
        {
            Veiculo removed = ManipulateDoc.remove(veiculo.Placa, FileEntry);

            veiculo.GerarDataHoraSaida();

            ManipulateDoc.writeOne(removed, FileOut);

        }

        internal void entryLenght()
        {
            ManipulateDoc.getLength(FileEntry);
        }

        public List<Veiculo> getEntryList()
        {
            return ManipulateDoc.getFileList(FileEntry);
        }

        public List<Veiculo> getOutList()
        {
            return ManipulateDoc.getFileList(FileOut);
        }
    }
}
