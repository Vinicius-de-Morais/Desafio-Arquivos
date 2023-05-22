using Desafio_Arquivo;

string file = "E:\\Desafio04\\Desafio-Arquivo\\Pessoas.txt";
List < Pessoa > pessoas = ManipulateDoc.getFileList(file);


int alunos = 0;
foreach ( Pessoa pe in pessoas)
{
    if (pe is Aluno) { 
    
        Console.WriteLine(pe);
        alunos++;
    }
}
Console.WriteLine("Pessoas: "+(pessoas.Count - alunos) +" Alunos: "+alunos);
