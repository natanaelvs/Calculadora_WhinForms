namespace Calculadora
{
    partial class frmcalculadora
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
            groupBox1 = new GroupBox();
            btponto = new Button();
            btigual = new Button();
            btzero = new Button();
            button11 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button10 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            bt1 = new Button();
            btmult = new Button();
            btdiv = new Button();
            btsubtracao = new Button();
            btsomar = new Button();
            Resultado = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btponto);
            groupBox1.Controls.Add(btigual);
            groupBox1.Controls.Add(btzero);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(bt1);
            groupBox1.Controls.Add(btmult);
            groupBox1.Controls.Add(btdiv);
            groupBox1.Controls.Add(btsubtracao);
            groupBox1.Controls.Add(btsomar);
            groupBox1.Controls.Add(Resultado);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(393, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btponto
            // 
            btponto.Location = new Point(6, 252);
            btponto.Name = "btponto";
            btponto.Size = new Size(35, 23);
            btponto.TabIndex = 26;
            btponto.Text = ".";
            btponto.UseVisualStyleBackColor = true;
            // 
            // btigual
            // 
            btigual.Location = new Point(91, 252);
            btigual.Name = "btigual";
            btigual.Size = new Size(35, 23);
            btigual.TabIndex = 25;
            btigual.Text = "=";
            btigual.UseVisualStyleBackColor = true;
            // 
            // btzero
            // 
            btzero.Location = new Point(49, 252);
            btzero.Name = "btzero";
            btzero.Size = new Size(33, 23);
            btzero.TabIndex = 24;
            btzero.Text = "0";
            btzero.UseVisualStyleBackColor = true;
            btzero.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(176, 95);
            button11.Name = "button11";
            button11.Size = new Size(34, 23);
            button11.TabIndex = 23;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(255, 32);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            textBox1.Text = "Histórico";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(93, 123);
            button1.Name = "button1";
            button1.Size = new Size(35, 23);
            button1.TabIndex = 21;
            button1.Text = "%";
            button1.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(136, 136);
            button10.Name = "button10";
            button10.Size = new Size(55, 23);
            button10.TabIndex = 20;
            button10.Text = "Limpar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button7
            // 
            button7.Location = new Point(93, 165);
            button7.Name = "button7";
            button7.Size = new Size(33, 23);
            button7.TabIndex = 19;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(49, 165);
            button8.Name = "button8";
            button8.Size = new Size(38, 23);
            button8.TabIndex = 18;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(6, 165);
            button9.Name = "button9";
            button9.Size = new Size(37, 23);
            button9.TabIndex = 17;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Location = new Point(95, 194);
            button4.Name = "button4";
            button4.Size = new Size(33, 23);
            button4.TabIndex = 16;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(49, 194);
            button5.Name = "button5";
            button5.Size = new Size(38, 23);
            button5.TabIndex = 15;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 194);
            button6.Name = "button6";
            button6.Size = new Size(37, 23);
            button6.TabIndex = 14;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 223);
            button3.Name = "button3";
            button3.Size = new Size(33, 23);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 223);
            button2.Name = "button2";
            button2.Size = new Size(38, 23);
            button2.TabIndex = 12;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(6, 223);
            bt1.Name = "bt1";
            bt1.Size = new Size(37, 23);
            bt1.TabIndex = 11;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += button1_Click;
            // 
            // btmult
            // 
            btmult.Location = new Point(137, 223);
            btmult.Name = "btmult";
            btmult.Size = new Size(35, 23);
            btmult.TabIndex = 7;
            btmult.Text = "*";
            btmult.UseVisualStyleBackColor = true;
            btmult.Click += btmult_Click;
            // 
            // btdiv
            // 
            btdiv.Location = new Point(137, 252);
            btdiv.Name = "btdiv";
            btdiv.Size = new Size(35, 23);
            btdiv.TabIndex = 6;
            btdiv.Text = "/";
            btdiv.UseVisualStyleBackColor = true;
            btdiv.Click += btdiv_Click;
            // 
            // btsubtracao
            // 
            btsubtracao.Location = new Point(137, 194);
            btsubtracao.Name = "btsubtracao";
            btsubtracao.Size = new Size(35, 23);
            btsubtracao.TabIndex = 5;
            btsubtracao.Text = "-";
            btsubtracao.UseVisualStyleBackColor = true;
            btsubtracao.Click += btsubtracao_Click;
            // 
            // btsomar
            // 
            btsomar.Location = new Point(137, 165);
            btsomar.Name = "btsomar";
            btsomar.Size = new Size(35, 23);
            btsomar.TabIndex = 4;
            btsomar.Text = "+";
            btsomar.UseVisualStyleBackColor = true;
            btsomar.Click += btsomar_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(12, 39);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(160, 23);
            Resultado.TabIndex = 1;
            Resultado.TextAlign = HorizontalAlignment.Right;
            // 
            // frmcalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 289);
            Controls.Add(groupBox1);
            Name = "frmcalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora - Natanael";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Resultado;
        private Button btsomar;
        private Button btmult;
        private Button btdiv;
        private Button btsubtracao;
        private Button button3;
        private Button button2;
        private Button bt1;
        private Button button10;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button11;
        private TextBox textBox1;
        private Button button1;
        private Button btzero;
        private Button btponto;
        private Button btigual;
    }
}
