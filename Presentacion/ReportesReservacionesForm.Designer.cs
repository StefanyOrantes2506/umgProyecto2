namespace Presentacion
{
    partial class ReportesReservacionesForm
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
            label4 = new Label();
            dgvReportes = new DataGridView();
            btnFiltrar = new Button();
            cmbTipoReporte = new ComboBox();
            label1 = new Label();
            cmbReporte = new ComboBox();
            btnX = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(178, 19);
            label4.Name = "label4";
            label4.Size = new Size(342, 37);
            label4.TabIndex = 64;
            label4.Text = "Reportes de reservaciones";
            // 
            // dgvReportes
            // 
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(12, 225);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(660, 324);
            dgvReportes.TabIndex = 63;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.Black;
            btnFiltrar.Location = new Point(498, 108);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(146, 55);
            btnFiltrar.TabIndex = 62;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Miembros", "Clases", "Entrenadores" });
            cmbTipoReporte.Location = new Point(116, 120);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(121, 23);
            cmbTipoReporte.TabIndex = 61;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(24, 128);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 60;
            label1.Text = "Reportar por:";
            // 
            // cmbReporte
            // 
            cmbReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReporte.FormattingEnabled = true;
            cmbReporte.Location = new Point(264, 120);
            cmbReporte.Name = "cmbReporte";
            cmbReporte.Size = new Size(207, 23);
            cmbReporte.TabIndex = 59;
            cmbReporte.SelectedIndexChanged += cmbReporte_SelectedIndexChanged;
            // 
            // btnX
            // 
            btnX.ForeColor = Color.Black;
            btnX.Location = new Point(24, 27);
            btnX.Name = "btnX";
            btnX.Size = new Size(84, 34);
            btnX.TabIndex = 65;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // ReportesReservacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(btnX);
            Controls.Add(label4);
            Controls.Add(dgvReportes);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbTipoReporte);
            Controls.Add(label1);
            Controls.Add(cmbReporte);
            Name = "ReportesReservacionesForm";
            Text = "ReportesReservacionesForm";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dgvReportes;
        private Button btnFiltrar;
        private ComboBox cmbTipoReporte;
        private Label label1;
        private ComboBox cmbReporte;
        private Button btnX;
    }
}