namespace GestionVentas.VISTA.GestionVentasVISTA
{
    partial class ListarVentasVista
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSalmon;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(467, 479);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 47;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSalmon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(315, 479);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 46;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(123, 479);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 45;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 188);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 117);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 51;
            label2.Text = "FECHA VENTA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 50;
            label1.Text = "TOTAL VENTA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.SeaShell;
            dateTimePicker1.Location = new Point(262, 159);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Location = new Point(262, 62);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 48;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSalmon;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(607, 479);
            button4.Name = "button4";
            button4.Size = new Size(138, 29);
            button4.TabIndex = 52;
            button4.Text = "DEATALLEVENTA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ListarVentasVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 555);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ListarVentasVista";
            Text = "ListarVentasVista";
            Load += ListarVentasVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button4;
    }
}