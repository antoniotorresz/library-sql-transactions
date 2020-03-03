namespace library_sql_transactions
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npags = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tvUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbISBN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbPais = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbTitulo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.npags);
            this.bunifuCards1.Controls.Add(this.listView2);
            this.bunifuCards1.Controls.Add(this.tvUrl);
            this.bunifuCards1.Controls.Add(this.dateTimePicker1);
            this.bunifuCards1.Controls.Add(this.btnadd);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.cmbAutores);
            this.bunifuCards1.Controls.Add(this.listView1);
            this.bunifuCards1.Controls.Add(this.tbISBN);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.tbPais);
            this.bunifuCards1.Controls.Add(this.tbEdit);
            this.bunifuCards1.Controls.Add(this.tbTitulo);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1061, 255);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(917, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Páginas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(724, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autores";
            // 
            // npags
            // 
            this.npags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.npags.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.npags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.npags.HintForeColor = System.Drawing.Color.DarkCyan;
            this.npags.HintText = "Num. Págs";
            this.npags.isPassword = false;
            this.npags.LineFocusedColor = System.Drawing.Color.Blue;
            this.npags.LineIdleColor = System.Drawing.Color.Gray;
            this.npags.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.npags.LineThickness = 3;
            this.npags.Location = new System.Drawing.Point(768, 17);
            this.npags.Margin = new System.Windows.Forms.Padding(4);
            this.npags.Name = "npags";
            this.npags.Size = new System.Drawing.Size(108, 55);
            this.npags.TabIndex = 15;
            this.npags.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(883, 100);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(115, 125);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // tvUrl
            // 
            this.tvUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tvUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tvUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvUrl.HintForeColor = System.Drawing.Color.DarkCyan;
            this.tvUrl.HintText = "Url Imagen";
            this.tvUrl.isPassword = false;
            this.tvUrl.LineFocusedColor = System.Drawing.Color.Blue;
            this.tvUrl.LineIdleColor = System.Drawing.Color.Gray;
            this.tvUrl.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tvUrl.LineThickness = 3;
            this.tvUrl.Location = new System.Drawing.Point(300, 180);
            this.tvUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tvUrl.Name = "tvUrl";
            this.tvUrl.Size = new System.Drawing.Size(244, 45);
            this.tvUrl.TabIndex = 6;
            this.tvUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(883, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 48);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "AGREGAR";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(617, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Autores";
            // 
            // cmbAutores
            // 
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(621, 41);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(140, 28);
            this.cmbAutores.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Autor});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(621, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 125);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 256;
            // 
            // tbISBN
            // 
            this.tbISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbISBN.HintForeColor = System.Drawing.Color.DarkCyan;
            this.tbISBN.HintText = "ISBN";
            this.tbISBN.isPassword = false;
            this.tbISBN.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbISBN.LineIdleColor = System.Drawing.Color.Gray;
            this.tbISBN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbISBN.LineThickness = 3;
            this.tbISBN.Location = new System.Drawing.Point(300, 100);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(244, 45);
            this.tbISBN.TabIndex = 4;
            this.tbISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 167);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 20);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Fecha de publicación";
            // 
            // tbPais
            // 
            this.tbPais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPais.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPais.HintForeColor = System.Drawing.Color.DarkCyan;
            this.tbPais.HintText = "Pais";
            this.tbPais.isPassword = false;
            this.tbPais.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPais.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPais.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPais.LineThickness = 3;
            this.tbPais.Location = new System.Drawing.Point(17, 100);
            this.tbPais.Margin = new System.Windows.Forms.Padding(4);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(244, 45);
            this.tbPais.TabIndex = 3;
            this.tbPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbEdit
            // 
            this.tbEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEdit.HintForeColor = System.Drawing.Color.DarkCyan;
            this.tbEdit.HintText = "Editorial";
            this.tbEdit.isPassword = false;
            this.tbEdit.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEdit.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEdit.LineThickness = 3;
            this.tbEdit.Location = new System.Drawing.Point(300, 24);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(244, 45);
            this.tbEdit.TabIndex = 2;
            this.tbEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitulo.HintForeColor = System.Drawing.Color.DarkCyan;
            this.tbTitulo.HintText = "Titulo";
            this.tbTitulo.isPassword = false;
            this.tbTitulo.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTitulo.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTitulo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTitulo.LineThickness = 3;
            this.tbTitulo.Location = new System.Drawing.Point(17, 24);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(244, 45);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.dataGridView1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 273);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1061, 244);
            this.bunifuCards2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 244);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(786, 523);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(234, 44);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "GUARDAR";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 577);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Autor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbISBN;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPais;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTitulo;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tvUrl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox npags;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

