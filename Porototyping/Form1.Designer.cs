namespace Porototyping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DropDownbox = new System.Windows.Forms.ComboBox();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.BtnDb = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SintaxisLabel = new System.Windows.Forms.Label();
            this.CommandLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BoxLabel = new System.Windows.Forms.Label();
            this.CommandLabel2 = new System.Windows.Forms.Label();
            this.CommandLabel3 = new System.Windows.Forms.Label();
            this.Plabel = new System.Windows.Forms.TextBox();
            this.DgvTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DropDownbox
            // 
            this.DropDownbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownbox.FormattingEnabled = true;
            this.DropDownbox.Items.AddRange(new object[] {
            "MYSQL",
            "CREATE DB",
            "CREATE TABLE",
            "SELECT",
            "Nested SELECT",
            "WHERE",
            "AND/OR/ NOT",
            "ORDERBY",
            "INSERT INTO",
            "DELETE",
            "UPDATE",
            "MIN/MAX",
            "COUNT/AVG/SUM",
            "LIKE",
            "BETWEEN",
            "JOIN(S)",
            "Data Types",
            "Relations"});
            this.DropDownbox.Location = new System.Drawing.Point(12, 12);
            this.DropDownbox.Name = "DropDownbox";
            this.DropDownbox.Size = new System.Drawing.Size(150, 33);
            this.DropDownbox.TabIndex = 0;
            this.DropDownbox.DropDownClosed += new System.EventHandler(this.DropDownbox_DropDownClosed);
            this.DropDownbox.TextChanged += new System.EventHandler(this.DropDownbox_TextChanged);
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(12, 391);
            this.QueryBox.Multiline = true;
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(570, 192);
            this.QueryBox.TabIndex = 1;
            this.QueryBox.TextChanged += new System.EventHandler(this.QueryBox_TextChanged);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEjecutar.Location = new System.Drawing.Point(588, 429);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(120, 32);
            this.BtnEjecutar.TabIndex = 2;
            this.BtnEjecutar.Text = "Execute Query";
            this.BtnEjecutar.UseVisualStyleBackColor = false;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // BtnDb
            // 
            this.BtnDb.Location = new System.Drawing.Point(588, 391);
            this.BtnDb.Name = "BtnDb";
            this.BtnDb.Size = new System.Drawing.Size(120, 32);
            this.BtnDb.TabIndex = 3;
            this.BtnDb.Text = "Connect Db";
            this.BtnDb.UseVisualStyleBackColor = true;
            this.BtnDb.Click += new System.EventHandler(this.BtnDb_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(588, 551);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(120, 32);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Exit";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(168, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(80, 31);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title:";
            // 
            // SintaxisLabel
            // 
            this.SintaxisLabel.AutoSize = true;
            this.SintaxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SintaxisLabel.Location = new System.Drawing.Point(7, 188);
            this.SintaxisLabel.Name = "SintaxisLabel";
            this.SintaxisLabel.Size = new System.Drawing.Size(96, 29);
            this.SintaxisLabel.TabIndex = 9;
            this.SintaxisLabel.Text = "Syntax:";
            // 
            // CommandLabel1
            // 
            this.CommandLabel1.AutoSize = true;
            this.CommandLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandLabel1.Location = new System.Drawing.Point(12, 230);
            this.CommandLabel1.Name = "CommandLabel1";
            this.CommandLabel1.Size = new System.Drawing.Size(24, 20);
            this.CommandLabel1.TabIndex = 10;
            this.CommandLabel1.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BoxLabel
            // 
            this.BoxLabel.AutoSize = true;
            this.BoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLabel.Location = new System.Drawing.Point(7, 359);
            this.BoxLabel.Name = "BoxLabel";
            this.BoxLabel.Size = new System.Drawing.Size(141, 29);
            this.BoxLabel.TabIndex = 12;
            this.BoxLabel.Text = "Query Box:";
            // 
            // CommandLabel2
            // 
            this.CommandLabel2.AutoSize = true;
            this.CommandLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandLabel2.Location = new System.Drawing.Point(12, 271);
            this.CommandLabel2.Name = "CommandLabel2";
            this.CommandLabel2.Size = new System.Drawing.Size(24, 20);
            this.CommandLabel2.TabIndex = 13;
            this.CommandLabel2.Text = "...";
            // 
            // CommandLabel3
            // 
            this.CommandLabel3.AutoSize = true;
            this.CommandLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandLabel3.Location = new System.Drawing.Point(12, 313);
            this.CommandLabel3.Name = "CommandLabel3";
            this.CommandLabel3.Size = new System.Drawing.Size(24, 20);
            this.CommandLabel3.TabIndex = 14;
            this.CommandLabel3.Text = "...";
            // 
            // Plabel
            // 
            this.Plabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plabel.Location = new System.Drawing.Point(174, 53);
            this.Plabel.Multiline = true;
            this.Plabel.Name = "Plabel";
            this.Plabel.ReadOnly = true;
            this.Plabel.Size = new System.Drawing.Size(534, 164);
            this.Plabel.TabIndex = 15;
            // 
            // DgvTable
            // 
            this.DgvTable.AllowUserToAddRows = false;
            this.DgvTable.AllowUserToDeleteRows = false;
            this.DgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTable.Location = new System.Drawing.Point(12, 598);
            this.DgvTable.Name = "DgvTable";
            this.DgvTable.ReadOnly = true;
            this.DgvTable.Size = new System.Drawing.Size(695, 172);
            this.DgvTable.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(716, 782);
            this.Controls.Add(this.DgvTable);
            this.Controls.Add(this.Plabel);
            this.Controls.Add(this.CommandLabel3);
            this.Controls.Add(this.CommandLabel2);
            this.Controls.Add(this.BoxLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CommandLabel1);
            this.Controls.Add(this.SintaxisLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnDb);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.DropDownbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bruno\'s MysqlBasics notes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropDownbox;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Button BtnDb;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SintaxisLabel;
        private System.Windows.Forms.Label CommandLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BoxLabel;
        private System.Windows.Forms.Label CommandLabel2;
        private System.Windows.Forms.Label CommandLabel3;
        private System.Windows.Forms.TextBox Plabel;
        private System.Windows.Forms.DataGridView DgvTable;
    }
}

