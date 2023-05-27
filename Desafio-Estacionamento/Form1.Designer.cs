namespace Desafio_Estacionamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fileButton = new Button();
            fileDialog = new OpenFileDialog();
            entryBox = new ListBox();
            information = new Label();
            plate = new Label();
            plateInput = new TextBox();
            model = new Label();
            modelInput = new TextBox();
            typeInput = new ComboBox();
            type = new Label();
            register = new Button();
            remove = new Button();
            labelAction = new Label();
            outBox = new ListBox();
            outBoxButton = new Button();
            outLabel = new Label();
            entryLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            hourLabel = new Label();
            dateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fileButton
            // 
            fileButton.Location = new Point(11, 428);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(251, 23);
            fileButton.TabIndex = 1;
            fileButton.Text = "Escolher Arquivo";
            fileButton.UseVisualStyleBackColor = true;
            fileButton.Click += fileButton_Click;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "Pessoas.txt";
            // 
            // entryBox
            // 
            entryBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            entryBox.FormattingEnabled = true;
            entryBox.ItemHeight = 15;
            entryBox.Location = new Point(11, 223);
            entryBox.Name = "entryBox";
            entryBox.Size = new Size(251, 199);
            entryBox.TabIndex = 2;
            // 
            // information
            // 
            information.AutoSize = true;
            information.Location = new Point(281, 254);
            information.Name = "information";
            information.Size = new Size(0, 15);
            information.TabIndex = 3;
            // 
            // plate
            // 
            plate.AutoSize = true;
            plate.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            plate.Location = new Point(12, 85);
            plate.Name = "plate";
            plate.Size = new Size(45, 17);
            plate.TabIndex = 4;
            plate.Text = "Placa";
            // 
            // plateInput
            // 
            plateInput.Location = new Point(78, 83);
            plateInput.Name = "plateInput";
            plateInput.Size = new Size(148, 23);
            plateInput.TabIndex = 5;
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            model.Location = new Point(12, 114);
            model.Name = "model";
            model.Size = new Size(57, 17);
            model.TabIndex = 6;
            model.Text = "Modelo";
            // 
            // modelInput
            // 
            modelInput.Location = new Point(78, 112);
            modelInput.Name = "modelInput";
            modelInput.Size = new Size(148, 23);
            modelInput.TabIndex = 7;
            // 
            // typeInput
            // 
            typeInput.FormattingEnabled = true;
            typeInput.Items.AddRange(new object[] { "Carro", "Caminhão", "Moto" });
            typeInput.Location = new Point(78, 141);
            typeInput.Name = "typeInput";
            typeInput.Size = new Size(148, 23);
            typeInput.TabIndex = 8;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            type.Location = new Point(12, 148);
            type.Name = "type";
            type.Size = new Size(34, 17);
            type.TabIndex = 9;
            type.Text = "Tipo";
            // 
            // register
            // 
            register.Location = new Point(86, 177);
            register.Name = "register";
            register.Size = new Size(62, 23);
            register.TabIndex = 10;
            register.Text = "Entrada";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // remove
            // 
            remove.Location = new Point(164, 177);
            remove.Name = "remove";
            remove.Size = new Size(62, 23);
            remove.TabIndex = 11;
            remove.Text = "Saida";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // labelAction
            // 
            labelAction.AutoSize = true;
            labelAction.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAction.Location = new Point(12, 180);
            labelAction.Name = "labelAction";
            labelAction.Size = new Size(71, 17);
            labelAction.TabIndex = 12;
            labelAction.Text = "Registrar: ";
            // 
            // outBox
            // 
            outBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outBox.FormattingEnabled = true;
            outBox.ItemHeight = 15;
            outBox.Location = new Point(267, 225);
            outBox.Name = "outBox";
            outBox.Size = new Size(251, 199);
            outBox.TabIndex = 13;
            // 
            // outBoxButton
            // 
            outBoxButton.Location = new Point(268, 428);
            outBoxButton.Name = "outBoxButton";
            outBoxButton.Size = new Size(251, 23);
            outBoxButton.TabIndex = 14;
            outBoxButton.Text = "Escolher Arquivo";
            outBoxButton.UseVisualStyleBackColor = true;
            outBoxButton.Click += outBoxButton_Click;
            // 
            // outLabel
            // 
            outLabel.AutoSize = true;
            outLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            outLabel.Location = new Point(267, 205);
            outLabel.Name = "outLabel";
            outLabel.Size = new Size(48, 17);
            outLabel.TabIndex = 15;
            outLabel.Text = "Saida:";
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            entryLabel.Location = new Point(9, 205);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(63, 17);
            entryLabel.TabIndex = 15;
            entryLabel.Text = "Entrada:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Magneto", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(410, 35);
            label1.TabIndex = 16;
            label1.Text = "Estacionamento Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "E:\\Desafio04\\Desafio-Estacionamento\\icon.png";
            pictureBox1.Location = new Point(0, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Font = new Font("MS Reference Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            hourLabel.Location = new Point(297, 112);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(176, 60);
            hourLabel.TabIndex = 18;
            hourLabel.Text = "00:00";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("MS Reference Sans Serif", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dateLabel.Location = new Point(288, 83);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(195, 35);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "01/01/2023";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(524, 458);
            Controls.Add(dateLabel);
            Controls.Add(hourLabel);
            Controls.Add(register);
            Controls.Add(label1);
            Controls.Add(entryLabel);
            Controls.Add(outLabel);
            Controls.Add(outBoxButton);
            Controls.Add(outBox);
            Controls.Add(labelAction);
            Controls.Add(remove);
            Controls.Add(type);
            Controls.Add(typeInput);
            Controls.Add(modelInput);
            Controls.Add(model);
            Controls.Add(plateInput);
            Controls.Add(plate);
            Controls.Add(information);
            Controls.Add(entryBox);
            Controls.Add(fileButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Estacionamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button fileButton;
        private OpenFileDialog fileDialog;
        private ListBox entryBox;
        private Label information;
        private Label plate;
        private TextBox plateInput;
        private Label model;
        private TextBox modelInput;
        private ComboBox typeInput;
        private Label type;
        private Button register;
        private Button remove;
        private Label labelAction;
        private ListBox outBox;
        private Button outBoxButton;
        private Label outLabel;
        private Label entryLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label hourLabel;
        private Label dateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}