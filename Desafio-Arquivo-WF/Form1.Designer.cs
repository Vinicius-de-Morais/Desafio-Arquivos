namespace Desafio_Arquivo_WF
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
            fileButton = new Button();
            fileDialog = new OpenFileDialog();
            listBox = new ListBox();
            information = new Label();
            SuspendLayout();
            // 
            // fileButton
            // 
            fileButton.Location = new Point(331, 247);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(182, 23);
            fileButton.TabIndex = 1;
            fileButton.Text = "Escolher Arquivo";
            fileButton.UseVisualStyleBackColor = true;
            fileButton.Click += fileButton_Click;
            // 
            // fileDialog
            // 
            fileDialog.FileName = "Pessoas.txt";
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(501, 229);
            listBox.TabIndex = 2;
            // 
            // information
            // 
            information.AutoSize = true;
            information.Location = new Point(19, 249);
            information.Name = "information";
            information.Size = new Size(0, 15);
            information.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 276);
            Controls.Add(information);
            Controls.Add(listBox);
            Controls.Add(fileButton);
            Name = "Form1";
            Text = "Lista de Pessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button fileButton;
        private OpenFileDialog fileDialog;
        private ListBox listBox;
        private Label information;
    }
}