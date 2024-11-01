namespace Presentacion
{
    partial class MembresiaForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembresiaForn));
            btnActualizar = new Button();
            label4 = new Label();
            btnX = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            dgvMembresias = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.White;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(516, 178);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(146, 55);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar Membresía";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(184, 23);
            label4.Name = "label4";
            label4.Size = new Size(379, 37);
            label4.TabIndex = 20;
            label4.Text = "Movimientos de membresías";
            // 
            // btnX
            // 
            btnX.ForeColor = Color.Black;
            btnX.Location = new Point(36, 23);
            btnX.Name = "btnX";
            btnX.Size = new Size(84, 34);
            btnX.TabIndex = 19;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.White;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(516, 102);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 55);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar Membresía";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(42, 110);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // dgvMembresias
            // 
            dgvMembresias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresias.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvMembresias.Location = new Point(12, 254);
            dgvMembresias.Name = "dgvMembresias";
            dgvMembresias.ReadOnly = true;
            dgvMembresias.Size = new Size(650, 295);
            dgvMembresias.TabIndex = 11;
            dgvMembresias.CellClick += dgvMembresias_CellClick;
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
            // MembresiaForn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(btnX);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dgvMembresias);
            Name = "MembresiaForn";
            Text = "MembresiaForn";
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Label label4;
        private Button btnX;
        private Button btnAgregar;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMembresias;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}