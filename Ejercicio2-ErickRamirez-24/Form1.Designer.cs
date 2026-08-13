namespace Ejercicio2_ErickRamirez_24
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE ACCESO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 56);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(57, 54);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 62);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "Nivel Academico";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nivel Nursery", "Nivel Pre Primario", "Nivel Primario Inicial", "Nivel Primaria complementaria", "Nivel Básico", "Nivel Secundario" });
            comboBox1.Location = new Point(311, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Seleccione Un Nivel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 99);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 146);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 9;
            label6.Text = "Genero:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(73, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(159, 144);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 189);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Estudiante";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(486, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Acepto los terminos y condiciones, de que todos los datos estan bajo mi resposabilidad";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(17, 301);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 14;
            button1.Text = "Enviar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(588, 85);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 15;
            label7.Text = "Foto:";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(534, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(153, 306);
            progressBar1.Maximum = 50;
            progressBar1.Minimum = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(587, 18);
            progressBar1.Step = 5;
            progressBar1.TabIndex = 17;
            progressBar1.Value = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Datos de un Estudiante CSDB";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}
