namespace programacionII_estadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTpica = new System.Windows.Forms.Button();
            this.grdEstadistica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalF1 = new System.Windows.Forms.Label();
            this.lblTotalXifi = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2ixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalx2xFi = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblEstandar = new System.Windows.Forms.Label();
            this.lblTipica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(12, 30);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(60, 27);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(184, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(22, 109);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(79, 32);
            this.btnMediaAritmetica.TabIndex = 2;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(19, 75);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "X";
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(107, 109);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(105, 32);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTpica
            // 
            this.btnCalcularTpica.Location = new System.Drawing.Point(218, 109);
            this.btnCalcularTpica.Name = "btnCalcularTpica";
            this.btnCalcularTpica.Size = new System.Drawing.Size(86, 32);
            this.btnCalcularTpica.TabIndex = 5;
            this.btnCalcularTpica.Text = "Calcular Tipica";
            this.btnCalcularTpica.UseVisualStyleBackColor = true;
            this.btnCalcularTpica.Click += new System.EventHandler(this.btnCalcularTpica_Click);
            // 
            // grdEstadistica
            // 
            this.grdEstadistica.AllowUserToDeleteRows = false;
            this.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.f1,
            this.fi,
            this.xixfi,
            this.x2ixfi});
            this.grdEstadistica.Location = new System.Drawing.Point(21, 180);
            this.grdEstadistica.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grdEstadistica.Name = "grdEstadistica";
            this.grdEstadistica.RowHeadersWidth = 102;
            this.grdEstadistica.RowTemplate.Height = 40;
            this.grdEstadistica.Size = new System.Drawing.Size(495, 221);
            this.grdEstadistica.TabIndex = 6;
            this.grdEstadistica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdEstadistica_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTALES:";
            // 
            // lblTotalF1
            // 
            this.lblTotalF1.AutoSize = true;
            this.lblTotalF1.Location = new System.Drawing.Point(177, 421);
            this.lblTotalF1.Name = "lblTotalF1";
            this.lblTotalF1.Size = new System.Drawing.Size(43, 13);
            this.lblTotalF1.TabIndex = 8;
            this.lblTotalF1.Text = "TotalF1";
            // 
            // lblTotalXifi
            // 
            this.lblTotalXifi.AutoSize = true;
            this.lblTotalXifi.Location = new System.Drawing.Point(286, 421);
            this.lblTotalXifi.Name = "lblTotalXifi";
            this.lblTotalXifi.Size = new System.Drawing.Size(48, 13);
            this.lblTotalXifi.TabIndex = 9;
            this.lblTotalXifi.Text = "TotalXiFi";
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 12;
            this.x1.Name = "x1";
            this.x1.Width = 50;
            // 
            // f1
            // 
            this.f1.HeaderText = "F1";
            this.f1.MinimumWidth = 12;
            this.f1.Name = "f1";
            this.f1.Width = 50;
            // 
            // fi
            // 
            this.fi.HeaderText = "Fi";
            this.fi.MinimumWidth = 12;
            this.fi.Name = "fi";
            this.fi.Width = 50;
            // 
            // xixfi
            // 
            this.xixfi.HeaderText = "Xi * Fi";
            this.xixfi.MinimumWidth = 12;
            this.xixfi.Name = "xixfi";
            // 
            // x2ixfi
            // 
            this.x2ixfi.HeaderText = "X2i * Fi";
            this.x2ixfi.MinimumWidth = 12;
            this.x2ixfi.Name = "x2ixfi";
            // 
            // lblTotalx2xFi
            // 
            this.lblTotalx2xFi.AutoSize = true;
            this.lblTotalx2xFi.Location = new System.Drawing.Point(399, 420);
            this.lblTotalx2xFi.Name = "lblTotalx2xFi";
            this.lblTotalx2xFi.Size = new System.Drawing.Size(56, 13);
            this.lblTotalx2xFi.TabIndex = 10;
            this.lblTotalx2xFi.Text = "TotalX2*Fi";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(24, 477);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(14, 13);
            this.lblMedia.TabIndex = 11;
            this.lblMedia.Text = "X";
            // 
            // lblEstandar
            // 
            this.lblEstandar.AutoSize = true;
            this.lblEstandar.Location = new System.Drawing.Point(180, 477);
            this.lblEstandar.Name = "lblEstandar";
            this.lblEstandar.Size = new System.Drawing.Size(49, 13);
            this.lblEstandar.TabIndex = 12;
            this.lblEstandar.Text = "Estandar";
            // 
            // lblTipica
            // 
            this.lblTipica.AutoSize = true;
            this.lblTipica.Location = new System.Drawing.Point(289, 476);
            this.lblTipica.Name = "lblTipica";
            this.lblTipica.Size = new System.Drawing.Size(36, 13);
            this.lblTipica.TabIndex = 13;
            this.lblTipica.Text = "Tipica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 515);
            this.Controls.Add(this.lblTipica);
            this.Controls.Add(this.lblEstandar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblTotalx2xFi);
            this.Controls.Add(this.lblTotalXifi);
            this.Controls.Add(this.lblTotalF1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEstadistica);
            this.Controls.Add(this.btnCalcularTpica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Calculos basicos Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTpica;
        private System.Windows.Forms.DataGridView grdEstadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2ixfi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalF1;
        private System.Windows.Forms.Label lblTotalXifi;
        private System.Windows.Forms.Label lblTotalx2xFi;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblEstandar;
        private System.Windows.Forms.Label lblTipica;
    }
}

