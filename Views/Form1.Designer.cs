namespace AmbEmpleados
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
            tBoxName = new TextBox();
            tBoxLastName = new TextBox();
            tBoxLeg = new TextBox();
            tBoxOfice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            lblId = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tBoxName
            // 
            tBoxName.Location = new Point(135, 78);
            tBoxName.Name = "tBoxName";
            tBoxName.Size = new Size(155, 23);
            tBoxName.TabIndex = 0;
            // 
            // tBoxLastName
            // 
            tBoxLastName.Location = new Point(135, 125);
            tBoxLastName.Name = "tBoxLastName";
            tBoxLastName.Size = new Size(155, 23);
            tBoxLastName.TabIndex = 1;
            // 
            // tBoxLeg
            // 
            tBoxLeg.Location = new Point(135, 170);
            tBoxLeg.Name = "tBoxLeg";
            tBoxLeg.Size = new Size(155, 23);
            tBoxLeg.TabIndex = 2;
            // 
            // tBoxOfice
            // 
            tBoxOfice.Location = new Point(135, 213);
            tBoxOfice.Name = "tBoxOfice";
            tBoxOfice.Size = new Size(155, 23);
            tBoxOfice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 81);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 128);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(36, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(254, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Agregar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(353, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 219);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(36, 356);
            button1.Name = "button1";
            button1.Size = new Size(254, 23);
            button1.TabIndex = 9;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(36, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(254, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 29);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(135, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 13;
            label4.Text = "Legajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 221);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Oficina";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 502);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblId);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBoxOfice);
            Controls.Add(tBoxLeg);
            Controls.Add(tBoxLastName);
            Controls.Add(tBoxName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxName;
        private TextBox tBoxLastName;
        private TextBox tBoxLeg;
        private TextBox tBoxOfice;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnUpdate;
        private Label label3;
        private Label lblId;
        private Label label4;
        private Label label5;
    }
}
