namespace kliens_alkalmazas
{
    partial class FormAdd
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
            bindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            checkBox1 = new CheckBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            buttonSearchProductbvin = new Button();
            buttonSearchOrderbvin = new Button();
            buttonMentes = new Button();
            buttonNo = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Foglala);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox1.Location = new Point(48, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 0;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            textBox2.Location = new Point(48, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 1;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Telefon", true));
            textBox3.Location = new Point(48, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "Lokacio", true));
            textBox4.Location = new Point(48, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "ErkezesDatum", true));
            textBox5.Location = new Point(48, 397);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 5;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(48, 119);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(48, 207);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(48, 295);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Lokáció";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(48, 374);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 9;
            label5.Text = "Érkezés dátuma (M/DD/YYYY)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(48, 452);
            label6.Name = "label6";
            label6.Size = new Size(208, 20);
            label6.TabIndex = 11;
            label6.Text = "Távozás dátuma (M/DD/YYYY)";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "TavozasDatum", true));
            textBox6.Location = new Point(48, 475);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(373, 533);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 13;
            label7.Text = "Vendégszám";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "VendegSzam", true));
            textBox7.Location = new Point(373, 556);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 27);
            textBox7.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(48, 533);
            label8.Name = "label8";
            label8.Size = new Size(228, 20);
            label8.TabIndex = 15;
            label8.Text = "Létrehozás dátuma (M/DD/YYYY)";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "LetrehozasDatuma", true));
            textBox8.Location = new Point(48, 556);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(244, 27);
            textBox8.TabIndex = 14;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(51, 612);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 17;
            label9.Text = "Státusz";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "Status", true));
            textBox9.Location = new Point(51, 635);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(244, 27);
            textBox9.TabIndex = 16;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(373, 40);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 19;
            label10.Text = "Product bvin";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "ProductBvin", true));
            textBox10.Location = new Point(373, 63);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(309, 27);
            textBox10.TabIndex = 18;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(373, 119);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 21;
            label11.Text = "Order bvin";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox11.DataBindings.Add(new Binding("Text", bindingSource1, "OrderBvin", true));
            textBox11.Location = new Point(373, 142);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(309, 27);
            textBox11.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(404, 637);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "IsCancelled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(373, 207);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 24;
            label12.Text = "Törlés oka";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox12.DataBindings.Add(new Binding("Text", bindingSource1, "CancellationReason", true));
            textBox12.Location = new Point(373, 230);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(309, 123);
            textBox12.TabIndex = 23;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(373, 374);
            label13.Name = "label13";
            label13.Size = new Size(137, 20);
            label13.TabIndex = 26;
            label13.Text = "Foglalási azonosító";
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox13.DataBindings.Add(new Binding("Text", bindingSource1, "BookingReference", true));
            textBox13.Location = new Point(373, 397);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(244, 27);
            textBox13.TabIndex = 25;
            textBox13.Validating += textBox13_Validating;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(373, 452);
            label14.Name = "label14";
            label14.Size = new Size(110, 20);
            label14.TabIndex = 28;
            label14.Text = "Éjszakák száma";
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox14.DataBindings.Add(new Binding("Text", bindingSource1, "EjszakakSzama", true));
            textBox14.Location = new Point(373, 475);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(244, 27);
            textBox14.TabIndex = 27;
            textBox14.Validating += textBox14_Validating;
            // 
            // buttonSearchProductbvin
            // 
            buttonSearchProductbvin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearchProductbvin.Location = new Point(708, 63);
            buttonSearchProductbvin.Name = "buttonSearchProductbvin";
            buttonSearchProductbvin.Size = new Size(117, 37);
            buttonSearchProductbvin.TabIndex = 29;
            buttonSearchProductbvin.Text = "Keresés";
            buttonSearchProductbvin.UseVisualStyleBackColor = true;
            buttonSearchProductbvin.Click += buttonSearchProductbvin_Click;
            // 
            // buttonSearchOrderbvin
            // 
            buttonSearchOrderbvin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearchOrderbvin.Location = new Point(708, 142);
            buttonSearchOrderbvin.Name = "buttonSearchOrderbvin";
            buttonSearchOrderbvin.Size = new Size(117, 37);
            buttonSearchOrderbvin.TabIndex = 30;
            buttonSearchOrderbvin.Text = "Keresés";
            buttonSearchOrderbvin.UseVisualStyleBackColor = true;
            buttonSearchOrderbvin.Click += buttonSearchOrderbvin_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMentes.DialogResult = DialogResult.OK;
            buttonMentes.Location = new Point(619, 680);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(179, 76);
            buttonMentes.TabIndex = 31;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNo.DialogResult = DialogResult.Cancel;
            buttonNo.Location = new Point(397, 680);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(179, 76);
            buttonNo.TabIndex = 32;
            buttonNo.Text = "Mégse";
            buttonNo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 823);
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
            Controls.Add(textBox9);
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
            Name = "FormAdd";
            Text = "Vendégszám";
            Load += FormAdd_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private CheckBox checkBox1;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox14;
        private Button buttonSearchProductbvin;
        private Button buttonSearchOrderbvin;
        private Button buttonMentes;
        private Button buttonNo;
        private ErrorProvider errorProvider1;
    }
}