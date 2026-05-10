namespace kliens_alkalmazas
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonNo = new Button();
            buttonMentes = new Button();
            buttonSearchOrderbvin = new Button();
            buttonSearchProductbvin = new Button();
            label14 = new Label();
            textBox14 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            checkBox1 = new CheckBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNo.DialogResult = DialogResult.Cancel;
            buttonNo.Location = new Point(374, 697);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(179, 76);
            buttonNo.TabIndex = 65;
            buttonNo.Text = "Mégse";
            buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonMentes
            // 
            buttonMentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMentes.DialogResult = DialogResult.OK;
            buttonMentes.Location = new Point(596, 697);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(179, 76);
            buttonMentes.TabIndex = 64;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            // 
            // buttonSearchOrderbvin
            // 
            buttonSearchOrderbvin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearchOrderbvin.Location = new Point(685, 159);
            buttonSearchOrderbvin.Name = "buttonSearchOrderbvin";
            buttonSearchOrderbvin.Size = new Size(117, 37);
            buttonSearchOrderbvin.TabIndex = 63;
            buttonSearchOrderbvin.Text = "Keresés";
            buttonSearchOrderbvin.UseVisualStyleBackColor = true;
            // 
            // buttonSearchProductbvin
            // 
            buttonSearchProductbvin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearchProductbvin.Location = new Point(685, 80);
            buttonSearchProductbvin.Name = "buttonSearchProductbvin";
            buttonSearchProductbvin.Size = new Size(117, 37);
            buttonSearchProductbvin.TabIndex = 62;
            buttonSearchProductbvin.Text = "Keresés";
            buttonSearchProductbvin.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(350, 469);
            label14.Name = "label14";
            label14.Size = new Size(110, 20);
            label14.TabIndex = 61;
            label14.Text = "Éjszakák száma";
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox14.Location = new Point(350, 492);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(244, 27);
            textBox14.TabIndex = 60;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(350, 391);
            label13.Name = "label13";
            label13.Size = new Size(137, 20);
            label13.TabIndex = 59;
            label13.Text = "Foglalási azonosító";
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox13.Location = new Point(350, 414);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(244, 27);
            textBox13.TabIndex = 58;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(350, 224);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 57;
            label12.Text = "Törlés oka";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox12.Location = new Point(350, 247);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(309, 123);
            textBox12.TabIndex = 56;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(381, 654);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 55;
            checkBox1.Text = "IsCancelled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(350, 136);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 54;
            label11.Text = "Order bvin";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox11.Location = new Point(350, 159);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(309, 27);
            textBox11.TabIndex = 53;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(350, 57);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 52;
            label10.Text = "Product bvin";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox10.Location = new Point(350, 80);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(309, 27);
            textBox10.TabIndex = 51;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(28, 629);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 50;
            label9.Text = "Státusz";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(25, 550);
            label8.Name = "label8";
            label8.Size = new Size(228, 20);
            label8.TabIndex = 48;
            label8.Text = "Létrehozás dátuma (M/DD/YYYY)";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox8.Location = new Point(25, 573);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(244, 27);
            textBox8.TabIndex = 47;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(350, 550);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 46;
            label7.Text = "Vendégszám";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox7.Location = new Point(350, 573);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 27);
            textBox7.TabIndex = 45;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(25, 469);
            label6.Name = "label6";
            label6.Size = new Size(208, 20);
            label6.TabIndex = 44;
            label6.Text = "Távozás dátuma (M/DD/YYYY)";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox6.Location = new Point(25, 492);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 43;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(25, 391);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 42;
            label5.Text = "Érkezés dátuma (M/DD/YYYY)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(25, 312);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 41;
            label4.Text = "Lokáció";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(25, 224);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 40;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(25, 136);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 39;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 38;
            label1.Text = "Név";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox5.Location = new Point(25, 414);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 27);
            textBox5.TabIndex = 37;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox4.Location = new Point(25, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 36;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox3.Location = new Point(25, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Location = new Point(25, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(25, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 33;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 654);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 66;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 830);
            Controls.Add(comboBox1);
            Controls.Add(buttonNo);
            Controls.Add(buttonMentes);
            Controls.Add(buttonSearchOrderbvin);
            Controls.Add(buttonSearchProductbvin);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label13);
            Controls.Add(textBox13);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(textBox11);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormEdit";
            Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNo;
        private Button buttonMentes;
        private Button buttonSearchOrderbvin;
        private Button buttonSearchProductbvin;
        private Label label14;
        private TextBox textBox14;
        private Label label13;
        private TextBox textBox13;
        private Label label12;
        private TextBox textBox12;
        private CheckBox checkBox1;
        private Label label11;
        private TextBox textBox11;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private BindingSource bindingSource1;
        private ErrorProvider errorProvider1;
        private ComboBox comboBox1;
    }
}