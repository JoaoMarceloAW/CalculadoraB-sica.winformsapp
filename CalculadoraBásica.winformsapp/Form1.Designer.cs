namespace CalculadoraBásica.winformsapp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnMultiplicar = new Button();
            btnIgual = new Button();
            btnApagar = new Button();
            btn0 = new Button();
            btnSomar = new Button();
            botao1 = new Button();
            botao2 = new Button();
            botao3 = new Button();
            btnSubtrair = new Button();
            botao4 = new Button();
            botao5 = new Button();
            botao6 = new Button();
            btnDividir = new Button();
            botao7 = new Button();
            botao8 = new Button();
            botao9 = new Button();
            txtNumeros = new Panel();
            txtCalculo = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.10072F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5395679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnMultiplicar, 3, 3);
            tableLayoutPanel1.Controls.Add(btnIgual, 2, 3);
            tableLayoutPanel1.Controls.Add(btnApagar, 1, 3);
            tableLayoutPanel1.Controls.Add(btn0, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSomar, 3, 2);
            tableLayoutPanel1.Controls.Add(botao1, 2, 2);
            tableLayoutPanel1.Controls.Add(botao2, 1, 2);
            tableLayoutPanel1.Controls.Add(botao3, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSubtrair, 3, 1);
            tableLayoutPanel1.Controls.Add(botao4, 2, 1);
            tableLayoutPanel1.Controls.Add(botao5, 1, 1);
            tableLayoutPanel1.Controls.Add(botao6, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDividir, 3, 0);
            tableLayoutPanel1.Controls.Add(botao7, 2, 0);
            tableLayoutPanel1.Controls.Add(botao8, 1, 0);
            tableLayoutPanel1.Controls.Add(botao9, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 77);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(278, 216);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(210, 150);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(63, 43);
            btnMultiplicar.TabIndex = 15;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(139, 150);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(63, 43);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(72, 150);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(61, 43);
            btnApagar.TabIndex = 13;
            btnApagar.Text = "CC";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(3, 150);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 43);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(210, 101);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(63, 43);
            btnSomar.TabIndex = 11;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            // 
            // botao1
            // 
            botao1.Location = new Point(139, 101);
            botao1.Name = "botao1";
            botao1.Size = new Size(63, 43);
            botao1.TabIndex = 10;
            botao1.Text = "1";
            botao1.UseVisualStyleBackColor = true;
            // 
            // botao2
            // 
            botao2.Location = new Point(72, 101);
            botao2.Name = "botao2";
            botao2.Size = new Size(61, 43);
            botao2.TabIndex = 9;
            botao2.Text = "2";
            botao2.UseVisualStyleBackColor = true;
            // 
            // botao3
            // 
            botao3.Location = new Point(3, 101);
            botao3.Name = "botao3";
            botao3.Size = new Size(63, 43);
            botao3.TabIndex = 8;
            botao3.Text = "3";
            botao3.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(210, 52);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(63, 43);
            btnSubtrair.TabIndex = 7;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += button7_Click;
            // 
            // botao4
            // 
            botao4.Location = new Point(139, 52);
            botao4.Name = "botao4";
            botao4.Size = new Size(63, 43);
            botao4.TabIndex = 6;
            botao4.Text = "4";
            botao4.UseVisualStyleBackColor = true;
            // 
            // botao5
            // 
            botao5.Location = new Point(72, 52);
            botao5.Name = "botao5";
            botao5.Size = new Size(61, 43);
            botao5.TabIndex = 5;
            botao5.Text = "5";
            botao5.UseVisualStyleBackColor = true;
            // 
            // botao6
            // 
            botao6.Location = new Point(3, 52);
            botao6.Name = "botao6";
            botao6.Size = new Size(63, 43);
            botao6.TabIndex = 4;
            botao6.Text = "6";
            botao6.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(210, 3);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(63, 43);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // botao7
            // 
            botao7.Location = new Point(139, 3);
            botao7.Name = "botao7";
            botao7.Size = new Size(63, 43);
            botao7.TabIndex = 2;
            botao7.Text = "7";
            botao7.UseVisualStyleBackColor = true;
            // 
            // botao8
            // 
            botao8.Location = new Point(72, 3);
            botao8.Name = "botao8";
            botao8.Size = new Size(61, 43);
            botao8.TabIndex = 1;
            botao8.Text = "8";
            botao8.UseVisualStyleBackColor = true;
            // 
            // botao9
            // 
            botao9.Location = new Point(3, 3);
            botao9.Name = "botao9";
            botao9.Size = new Size(63, 43);
            botao9.TabIndex = 0;
            botao9.Text = "9";
            botao9.UseVisualStyleBackColor = true;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(18, 12);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(270, 23);
            txtNumeros.TabIndex = 16;
            // 
            // txtCalculo
            // 
            txtCalculo.Location = new Point(15, 31);
            txtCalculo.Name = "txtCalculo";
            txtCalculo.Size = new Size(275, 43);
            txtCalculo.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 372);
            Controls.Add(txtCalculo);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtNumeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnMultiplicar;
        private Button btnIgual;
        private Button btnApagar;
        private Button btn0;
        private Button btnSomar;
        private Button botao1;
        private Button botao2;
        private Button botao3;
        private Button btnSubtrair;
        private Button botao4;
        private Button botao5;
        private Button botao6;
        private Button btnDividir;
        private Button botao7;
        private Button botao8;
        private Button botao9;
        private Panel txtNumeros;
        private Panel txtCalculo;
    }
}