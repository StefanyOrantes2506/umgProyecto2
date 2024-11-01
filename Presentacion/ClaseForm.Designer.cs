namespace Presentacion
{
    partial class ClaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaseForm));
            btnActualizar = new Button();
            label4 = new Label();
            btnX = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClases = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            cmbEntrenador = new ComboBox();
            cmbGimnasio = new ComboBox();
            dtpHorario = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
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
            btnActualizar.Text = "Actualizar Clase";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(194, 20);
            label4.Name = "label4";
            label4.Size = new Size(300, 37);
            label4.TabIndex = 20;
            label4.Text = "Movimientos de clases";
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
            btnAgregar.Text = "Agregar Clase";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(36, 159);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 14;
            label3.Text = "Entrenador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(36, 122);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 13;
            label2.Text = "Horario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(36, 86);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // dgvClases
            // 
            dgvClases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClases.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dgvClases.Location = new Point(12, 254);
            dgvClases.Name = "dgvClases";
            dgvClases.ReadOnly = true;
            dgvClases.Size = new Size(650, 295);
            dgvClases.TabIndex = 11;
            dgvClases.CellClick += dgvClases_CellClick;
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
            // cmbEntrenador
            // 
            cmbEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(119, 151);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(284, 23);
            cmbEntrenador.TabIndex = 22;
            cmbEntrenador.SelectedIndexChanged += cmbEntrenador_SelectedIndexChanged;
            // 
            // cmbGimnasio
            // 
            cmbGimnasio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGimnasio.FormattingEnabled = true;
            cmbGimnasio.Location = new Point(119, 191);
            cmbGimnasio.Name = "cmbGimnasio";
            cmbGimnasio.Size = new Size(284, 23);
            cmbGimnasio.TabIndex = 23;
            cmbGimnasio.SelectedIndexChanged += cmbGimnasio_SelectedIndexChanged;
            // 
            // dtpHorario
            // 
            dtpHorario.Format = DateTimePickerFormat.Short;
            dtpHorario.Location = new Point(119, 112);
            dtpHorario.Name = "dtpHorario";
            dtpHorario.ShowCheckBox = true;
            dtpHorario.Size = new Size(284, 23);
            dtpHorario.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(36, 199);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 25;
            label5.Text = "Gimnasio:";
            // 
            // ClaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(label5);
            Controls.Add(dtpHorario);
            Controls.Add(cmbGimnasio);
            Controls.Add(cmbEntrenador);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(btnX);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClases);
            Name = "ClaseForm";
            Text = "ClaseForm";
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Label label4;
        private Button btnX;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClases;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private ComboBox cmbEntrenador;
        private ComboBox cmbGimnasio;
        private DateTimePicker dtpHorario;
        private Label label5;
    }
}