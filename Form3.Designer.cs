namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFindProfiles = new System.Windows.Forms.Button();
            this.buttonFindYoungest = new System.Windows.Forms.Button();
            this.buttonFindUnderage = new System.Windows.Forms.Button();
            this.buttonFindHighInvestment = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(668, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "Телефон";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(745, 128);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(132, 22);
            this.textBox10.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(687, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "Адрес";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(745, 96);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(132, 22);
            this.textBox9.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(892, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "Поставщики";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(592, 207);
            this.dataGridViewSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(443, 225);
            this.dataGridViewSuppliers.TabIndex = 54;
            this.dataGridViewSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(897, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 28);
            this.button2.TabIndex = 53;
            this.button2.Text = "Добавить поставщика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(745, 64);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Название поставщика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(708, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 31);
            this.label8.TabIndex = 47;
            this.label8.Text = "Поставщики";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(745, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Стоимость поставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 66);
            this.button1.TabIndex = 62;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFindProfiles
            // 
            this.buttonFindProfiles.Location = new System.Drawing.Point(16, 15);
            this.buttonFindProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindProfiles.Name = "buttonFindProfiles";
            this.buttonFindProfiles.Size = new System.Drawing.Size(256, 94);
            this.buttonFindProfiles.TabIndex = 63;
            this.buttonFindProfiles.Text = "\"Кузнецов\' в порядке убывания вложенного в них капитала";
            this.buttonFindProfiles.UseVisualStyleBackColor = true;
            this.buttonFindProfiles.Click += new System.EventHandler(this.buttonFindProfiles_Click_1);
            // 
            // buttonFindYoungest
            // 
            this.buttonFindYoungest.Location = new System.Drawing.Point(280, 15);
            this.buttonFindYoungest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindYoungest.Name = "buttonFindYoungest";
            this.buttonFindYoungest.Size = new System.Drawing.Size(256, 94);
            this.buttonFindYoungest.TabIndex = 64;
            this.buttonFindYoungest.Text = "Поиск самого молодого предпринимателя в Киевском районе";
            this.buttonFindYoungest.UseVisualStyleBackColor = true;
            this.buttonFindYoungest.Click += new System.EventHandler(this.buttonFindYoungest_Click_1);
            // 
            // buttonFindUnderage
            // 
            this.buttonFindUnderage.Location = new System.Drawing.Point(16, 110);
            this.buttonFindUnderage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindUnderage.Name = "buttonFindUnderage";
            this.buttonFindUnderage.Size = new System.Drawing.Size(256, 94);
            this.buttonFindUnderage.TabIndex = 65;
            this.buttonFindUnderage.Text = "Младше 18 лет";
            this.buttonFindUnderage.UseVisualStyleBackColor = true;
            this.buttonFindUnderage.Click += new System.EventHandler(this.buttonFindUnderage_Click_1);
            // 
            // buttonFindHighInvestment
            // 
            this.buttonFindHighInvestment.Location = new System.Drawing.Point(280, 110);
            this.buttonFindHighInvestment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindHighInvestment.Name = "buttonFindHighInvestment";
            this.buttonFindHighInvestment.Size = new System.Drawing.Size(256, 94);
            this.buttonFindHighInvestment.TabIndex = 66;
            this.buttonFindHighInvestment.Text = " больше 50% уставного капитала магазина внесено предпринимателем, проживающим в д" +
    "ругом районе";
            this.buttonFindHighInvestment.UseVisualStyleBackColor = true;
            this.buttonFindHighInvestment.Click += new System.EventHandler(this.buttonFindHighInvestment_Click_1);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(16, 210);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.Size = new System.Drawing.Size(520, 222);
            this.dataGridViewResults.TabIndex = 67;
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonFindHighInvestment);
            this.Controls.Add(this.buttonFindUnderage);
            this.Controls.Add(this.buttonFindYoungest);
            this.Controls.Add(this.buttonFindProfiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFindProfiles;
        private System.Windows.Forms.Button buttonFindYoungest;
        private System.Windows.Forms.Button buttonFindUnderage;
        private System.Windows.Forms.Button buttonFindHighInvestment;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}