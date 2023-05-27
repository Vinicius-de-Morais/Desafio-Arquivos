namespace Desafio_Estacionamento
{
    public partial class Form1 : Form
    {
        private EventHandler eventHandler = new EventHandler();

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            hourLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            eventHandler.FileEntry = fileDialog.FileName;
            entryBox.DataSource = getEntryList();


        }

        private List<Veiculo> getEntryList()
        {
            return eventHandler.getEntryList();
        }

        private List<Veiculo> getOutList()
        {
            return eventHandler.getOutList();
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = GetVeiculo();

                eventHandler.register(veiculo);

                entryBox.DataSource = getEntryList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = GetVeiculo();
                //eventHandler.remove(veiculo);
                veiculo.GerarDataHoraEntrada();
                veiculo.GerarDataHoraSaida();

                entryBox.DataSource = getEntryList();
                outBox.DataSource = getOutList();
                entryLabel.Text = veiculo.ValorCobrado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private Veiculo GetVeiculo()
        {
            string plate = plateInput.Text;
            string model = modelInput.Text != "" ? modelInput.Text : "vazio";
            string type = typeInput.Text != "" ? typeInput.Text : "vazio";
            Veiculo veiculo = new Veiculo(type, plate, model);
            return veiculo;
        }

        private void outBoxButton_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            eventHandler.FileOut = fileDialog.FileName;
            outBox.DataSource = getOutList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourLabel.Text = DateTime.Now.ToString("HH:mm");

        }
    }
}