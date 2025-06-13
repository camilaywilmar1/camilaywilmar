namespace VERDE
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(172, 371);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(305, 371);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 201);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}
