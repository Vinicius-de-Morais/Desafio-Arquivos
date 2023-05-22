using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arquivo
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


        public static List<Pessoa> getFileList(string file)
        {

            List<Pessoa> contentList = new();
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                string[] vectorPessoa;
                string actualLine;
                string[] oldPeople = new string[5];
                do
                {


                    actualLine = reader.ReadLine();
                    vectorPessoa = actualLine.Split("-");
                    
                    if(vectorPessoa[0] == "Y")
                    {
                        Aluno aluno = new Aluno(oldPeople[1], oldPeople[2], oldPeople[3], oldPeople[4], oldPeople[5],
                            vectorPessoa[1], vectorPessoa[2], vectorPessoa[3]
                            );

                        contentList.RemoveAt(contentList.Count - 1);
                        contentList.Add(aluno);
                        continue;
                    }
                    else if (vectorPessoa[0] == "X")
                    {
                        continue;
                    }

                    oldPeople = vectorPessoa;
                    contentList.Add(new Pessoa(oldPeople[1], oldPeople[2], oldPeople[3], oldPeople[4], oldPeople[5]));

                } while (!reader.EndOfStream);
                reader.Close();

                return contentList;
            }
            catch (Exception)
            {
                throw new Exception("Error while reading the file's content");
            }
        }

    }
}
