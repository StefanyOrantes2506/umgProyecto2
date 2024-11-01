namespace Presentacion
{
    partial class MiembroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiembroForm));
            btnActualizar = new Button();
            label4 = new Label();
            btnX = new Button();
            btnAgregar = new Button();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMiembros = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            cmbTipoMembresia = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).BeginInit();
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
            btnActualizar.Text = "Actualizar Miembro";
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
            label4.Size = new Size(353, 37);
            label4.TabIndex = 20;
            label4.Text = "Movimientos de miembros";
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
            btnAgregar.Text = "Agregar Miembro";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(119, 178);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(160, 23);
            txtEdad.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(119, 140);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(284, 23);
            txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(36, 186);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(36, 148);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(36, 110);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // dgvMiembros
            // 
            dgvMiembros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiembros.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvMiembros.Location = new Point(12, 254);
            dgvMiembros.Name = "dgvMiembros";
            dgvMiembros.ReadOnly = true;
            dgvMiembros.Size = new Size(650, 295);
            dgvMiembros.TabIndex = 11;
            dgvMiembros.CellClick += dgvMiembros_CellClick;
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
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.Location = new Point(153, 210);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(160, 23);
            cmbTipoMembresia.TabIndex = 22;
            cmbTipoMembresia.SelectedIndexChanged += cmbTipoMembresia_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(36, 218);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 23;
            label5.Text = "Tipo de membresía:";
            // 
            // MiembroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(label5);
            Controls.Add(cmbTipoMembresia);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(btnX);
            Controls.Add(btnAgregar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMiembros);
            Name = "MiembroForm";
            Text = "MiembroForm";
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Label label4;
        private Button btnX;
        private Button btnAgregar;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMiembros;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private ComboBox cmbTipoMembresia;
        private Label label5;
    }
}