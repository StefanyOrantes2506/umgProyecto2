namespace Presentacion
{
    partial class GimnasioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GimnasioForm));
            dgvGimnasios = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            button1 = new Button();
            btnX = new Button();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGimnasios).BeginInit();
            SuspendLayout();
            // 
            // dgvGimnasios
            // 
            dgvGimnasios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGimnasios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGimnasios.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvGimnasios.Location = new Point(12, 254);
            dgvGimnasios.Name = "dgvGimnasios";
            dgvGimnasios.ReadOnly = true;
            dgvGimnasios.Size = new Size(650, 295);
            dgvGimnasios.TabIndex = 0;
            dgvGimnasios.CellClick += dgvGimnasios_CellClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.False;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(42, 110);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(36, 148);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(41, 186);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(119, 140);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(284, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(119, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(160, 23);
            txtTelefono.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(516, 102);
            button1.Name = "button1";
            button1.Size = new Size(146, 55);
            button1.TabIndex = 7;
            button1.Text = "Agregar Gimnasio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnX
            // 
            btnX.ForeColor = Color.Black;
            btnX.Location = new Point(36, 23);
            btnX.Name = "btnX";
            btnX.Size = new Size(84, 34);
            btnX.TabIndex = 8;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(184, 23);
            label4.Name = "label4";
            label4.Size = new Size(356, 37);
            label4.TabIndex = 9;
            label4.Text = "Movimientos de gimnasios";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(516, 178);
            button2.Name = "button2";
            button2.Size = new Size(146, 55);
            button2.TabIndex = 10;
            button2.Text = "Actualizar Gimnasio";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GimnasioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(btnX);
            Controls.Add(button1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGimnasios);
            ForeColor = Color.Black;
            Name = "GimnasioForm";
            Text = "GimnasioForm";
            ((System.ComponentModel.ISupportInitialize)dgvGimnasios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGimnasios;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Button button1;
        private Button btnX;
        private Label label4;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button button2;
    }
}