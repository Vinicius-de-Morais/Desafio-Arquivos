namespace Desafio_Arquivo_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            List<Pessoa> pessoas = ManipulateDoc.getFileList(fileDialog.FileName);

            string listaString = "";
            int alunos = 0;
            foreach (Pessoa pessoa in pessoas)
            {
                listaString += pessoa.ToString() + "\n";

                if (pessoa is Aluno) alunos++;
            }
            listBox.DataSource = pessoas;
            information.Text = "A lista tem: " + pessoas.Count() + " Pessoas, sendo " + alunos + " delas Alunos";
        }


    }
}