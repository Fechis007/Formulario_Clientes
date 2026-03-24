namespace Formulario_Clientes
{
    partial class FormTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablas));
            dgvDatos = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label43 = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(10, 89);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(734, 508);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvDatos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(754, 607);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label43);
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(635, 10);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(106, 73);
            panel2.TabIndex = 1;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Arial", 7F, FontStyle.Bold);
            label43.Location = new Point(34, 51);
            label43.Margin = new Padding(2, 0, 2, 0);
            label43.Name = "label43";
            label43.Size = new Size(37, 12);
            label43.TabIndex = 29;
            label43.Text = "Volver";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(25, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 45);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // FormTablas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 607);
            Controls.Add(panel1);
            Name = "FormTablas";
            Text = "FormTablas";
            Load += FormTablas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Panel panel1;
        private Panel panel2;
        private Label label43;
        private PictureBox pictureBox6;
    }
}