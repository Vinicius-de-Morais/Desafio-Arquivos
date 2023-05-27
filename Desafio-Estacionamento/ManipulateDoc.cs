using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Estacionamento
{
    internal class ManipulateDoc
    {

        public static void printFile(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                do
                {
                    Console.WriteLine(reader.ReadLine());
                } while (!reader.EndOfStream);
                reader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }


        public static List<Veiculo> getFileList(string file)
        {
            List<Veiculo> contentList = new();
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                string[] vectorVeiculo;
                string actualLine;
                do
                {
                    actualLine = reader.ReadLine();
                    if(actualLine == null)
                    {
                        break;
                    }
                    vectorVeiculo = actualLine.Split("-");
                    contentList.Add(new Veiculo(vectorVeiculo[0], vectorVeiculo[1], vectorVeiculo[2], DateTime.Parse(vectorVeiculo[3]), TimeSpan.Parse(vectorVeiculo[4])));

                } while (!reader.EndOfStream);
                reader.Close();

                return contentList;
            }
            catch (System.IO.FileNotFoundException)
            {
                // significa q e a primeira leitura
                return contentList;
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }

        public static void writeOne(Veiculo veiculo, string file)
        {
            try
            {
                List<Veiculo> list = getFileList(file); // tem que ser declarado antes pois o arquivo nao pode estar em uso
                StreamWriter writer = new StreamWriter(file, append: true);

                if (!list.Contains(veiculo))
                {
                    if(veiculo.ValorCobrado <= 0)
                    {
                        string data = veiculo.DataEntrada.ToString("dd/MM/yyyy");
                        // q codigo feio mds
                        string hora = veiculo.HoraEntrada.Hours.ToString() + ':' + veiculo.HoraEntrada.Minutes.ToString() + ':' + veiculo.HoraEntrada.Seconds.ToString();
                        writer.WriteLine(veiculo.Tipo + "-" + veiculo.Placa + "-" + veiculo.Modelo + "-" + data + "-" + hora);
                    }
                    else
                    {
                        writer.WriteLine(veiculo.Tipo + "-" + veiculo.Placa + "-" + veiculo.Modelo + "-" + veiculo.TempoPermanencia + "-" + veiculo.ValorCobrado);
                    }
                }
                else
                {
                    throw new Exception("Veiculo ja cadastrado");
                }

                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static void writeByList(List<Veiculo> list, string file, bool append = true)
        {
            try
            {
                StreamWriter writer = new StreamWriter(file, append: append);

                foreach (var item in list)
                {
                    if (item.ValorCobrado <= 0)
                    {
                        writer.WriteLine(item.Tipo + "-" + item.Placa + "-" + item.Modelo + "-" + item.DataEntrada + "-" + item.HoraEntrada);
                    }
                    else
                    {
                        writer.WriteLine(item.Tipo + "-" + item.Placa + "-" + item.Modelo + "-" + item.TempoPermanencia + "-" + item.ValorCobrado);
                    }
                    writer.Flush();
                }
                writer.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static Veiculo remove(string placa,string file)
        {
            try
            {
                List<Veiculo> list = getFileList(file);
                bool removed = false;
                Veiculo removedItem = null;

                foreach (var item in list)
                {
                    if(item.Placa == placa)
                    {
                        removedItem = item;
                        list.Remove(item);
                        removed = true;
                        break;
                    }
                }

                if (removed)
                {
                    writeByList(list, file, false);
                    return removedItem;
                }
                else
                {
                    throw new Exception("Placa não encontrada nos registros");
                }
            }
            catch (Exception)
            {
                throw new Exception("Error while writing on file");
            }
        }

        public static int getLength(string file)
        {
            List<Veiculo> list = getFileList(file);
            return list.Count;
        }
    }
}
