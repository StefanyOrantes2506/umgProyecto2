namespace Presentacion
{
    partial class AsistenciaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaForm));
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            cmbClase = new ComboBox();
            cmbEntrenador = new ComboBox();
            btnActualizar = new Button();
            label4 = new Label();
            btnX = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAsistencias = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            cmbMiembro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(36, 159);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 38;
            label5.Text = "Clase:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(119, 80);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.ShowCheckBox = true;
            dtpFecha.Size = new Size(284, 23);
            dtpFecha.TabIndex = 37;
            // 
            // cmbClase
            // 
            cmbClase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClase.FormattingEnabled = true;
            cmbClase.Location = new Point(119, 151);
            cmbClase.Name = "cmbClase";
            cmbClase.Size = new Size(284, 23);
            cmbClase.TabIndex = 36;
            cmbClase.SelectedIndexChanged += cmbClase_SelectedIndexChanged;
            // 
            // cmbEntrenador
            // 
            cmbEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(119, 191);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(284, 23);
            cmbEntrenador.TabIndex = 35;
            cmbEntrenador.SelectedIndexChanged += cmbEntrenador_SelectedIndexChanged;
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
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "Actualizar Asistencia";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(187, 20);
            label4.Name = "label4";
            label4.Size = new Size(363, 37);
            label4.TabIndex = 33;
            label4.Text = "Movimientos de asistencias";
            // 
            // btnX
            // 
            btnX.ForeColor = Color.Black;
            btnX.Location = new Point(36, 23);
            btnX.Name = "btnX";
            btnX.Size = new Size(84, 34);
            btnX.TabIndex = 32;
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
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar Asistencia";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(36, 199);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 29;
            label3.Text = "Entrenador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(39, 86);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 28;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(36, 122);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 27;
            label1.Text = "Miembro:";
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvAsistencias.Location = new Point(12, 254);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.Size = new Size(650, 295);
            dgvAsistencias.TabIndex = 26;
            dgvAsistencias.CellClick += dgvAsistencias_CellClick;
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
            // cmbMiembro
            // 
            cmbMiembro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMiembro.FormattingEnabled = true;
            cmbMiembro.Location = new Point(119, 114);
            cmbMiembro.Name = "cmbMiembro";
            cmbMiembro.Size = new Size(284, 23);
            cmbMiembro.TabIndex = 39;
            cmbMiembro.SelectedIndexChanged += cmbMiembro_SelectedIndexChanged;
            // 
            // AsistenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(cmbMiembro);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(cmbClase);
            Controls.Add(cmbEntrenador);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(btnX);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAsistencias);
            Name = "AsistenciaForm";
            Text = "AsistenciaForm";
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dtpFecha;
        private ComboBox cmbClase;
        private ComboBox cmbEntrenador;
        private Button btnActualizar;
        private Label label4;
        private Button btnX;
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvAsistencias;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private ComboBox cmbMiembro;
    }
}