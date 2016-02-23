namespace AntivirusForm
{
    partial class AntivirusMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.virustotal = new System.Windows.Forms.TabPage();
            this.dataGridVTResult = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analizarVTbtn = new System.Windows.Forms.Button();
            this.crearDump = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.scan = new System.Windows.Forms.TabPage();
            this.manualbtn = new System.Windows.Forms.Button();
            this.fullscanbtn = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.cuarentenaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infectedLbl = new System.Windows.Forms.Label();
            this.scannedLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.listVirus = new System.Windows.Forms.CheckedListBox();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.virustotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVTResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.scan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // virustotal
            // 
            this.virustotal.Controls.Add(this.volverBtn);
            this.virustotal.Controls.Add(this.crearDump);
            this.virustotal.Controls.Add(this.analizarVTbtn);
            this.virustotal.Controls.Add(this.dataGridView1);
            this.virustotal.Controls.Add(this.dataGridVTResult);
            this.virustotal.Location = new System.Drawing.Point(4, 22);
            this.virustotal.Name = "virustotal";
            this.virustotal.Padding = new System.Windows.Forms.Padding(3);
            this.virustotal.Size = new System.Drawing.Size(794, 299);
            this.virustotal.TabIndex = 2;
            this.virustotal.Text = "VirusTotal";
            this.virustotal.UseVisualStyleBackColor = true;
            // 
            // dataGridVTResult
            // 
            this.dataGridVTResult.AllowUserToAddRows = false;
            this.dataGridVTResult.AllowUserToDeleteRows = false;
            this.dataGridVTResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVTResult.Location = new System.Drawing.Point(7, 6);
            this.dataGridVTResult.Name = "dataGridVTResult";
            this.dataGridVTResult.ReadOnly = true;
            this.dataGridVTResult.Size = new System.Drawing.Size(409, 292);
            this.dataGridVTResult.TabIndex = 0;
            this.dataGridVTResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVTResult_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(307, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // analizarVTbtn
            // 
            this.analizarVTbtn.Location = new System.Drawing.Point(482, 259);
            this.analizarVTbtn.Name = "analizarVTbtn";
            this.analizarVTbtn.Size = new System.Drawing.Size(132, 23);
            this.analizarVTbtn.TabIndex = 2;
            this.analizarVTbtn.Text = "Analizar Procesos";
            this.analizarVTbtn.UseVisualStyleBackColor = true;
            this.analizarVTbtn.Click += new System.EventHandler(this.analizarVTbtn_Click);
            // 
            // crearDump
            // 
            this.crearDump.Location = new System.Drawing.Point(630, 258);
            this.crearDump.Name = "crearDump";
            this.crearDump.Size = new System.Drawing.Size(104, 23);
            this.crearDump.TabIndex = 3;
            this.crearDump.Text = "Crear Dump";
            this.crearDump.UseVisualStyleBackColor = true;
            this.crearDump.Click += new System.EventHandler(this.crearDump_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(482, 258);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(132, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Visible = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // scan
            // 
            this.scan.Controls.Add(this.monitorBtn);
            this.scan.Controls.Add(this.panel1);
            this.scan.Controls.Add(this.cuarentenaBtn);
            this.scan.Controls.Add(this.deletebtn);
            this.scan.Controls.Add(this.lblFolder);
            this.scan.Controls.Add(this.fullscanbtn);
            this.scan.Controls.Add(this.manualbtn);
            this.scan.Location = new System.Drawing.Point(4, 22);
            this.scan.Name = "scan";
            this.scan.Padding = new System.Windows.Forms.Padding(3);
            this.scan.Size = new System.Drawing.Size(794, 299);
            this.scan.TabIndex = 1;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            // 
            // manualbtn
            // 
            this.manualbtn.Location = new System.Drawing.Point(669, 19);
            this.manualbtn.Name = "manualbtn";
            this.manualbtn.Size = new System.Drawing.Size(75, 23);
            this.manualbtn.TabIndex = 1;
            this.manualbtn.Text = "Seleccionar";
            this.manualbtn.UseVisualStyleBackColor = true;
            this.manualbtn.Click += new System.EventHandler(this.manualbtn_Click);
            // 
            // fullscanbtn
            // 
            this.fullscanbtn.Enabled = false;
            this.fullscanbtn.Location = new System.Drawing.Point(669, 74);
            this.fullscanbtn.Name = "fullscanbtn";
            this.fullscanbtn.Size = new System.Drawing.Size(75, 23);
            this.fullscanbtn.TabIndex = 2;
            this.fullscanbtn.Text = "Fullscan";
            this.fullscanbtn.UseVisualStyleBackColor = true;
            this.fullscanbtn.Click += new System.EventHandler(this.fullscanbtn_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(33, 274);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(0, 13);
            this.lblFolder.TabIndex = 6;
            // 
            // deletebtn
            // 
            this.deletebtn.Enabled = false;
            this.deletebtn.Location = new System.Drawing.Point(669, 125);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // cuarentenaBtn
            // 
            this.cuarentenaBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cuarentenaBtn.Enabled = false;
            this.cuarentenaBtn.Location = new System.Drawing.Point(669, 177);
            this.cuarentenaBtn.Name = "cuarentenaBtn";
            this.cuarentenaBtn.Size = new System.Drawing.Size(75, 23);
            this.cuarentenaBtn.TabIndex = 8;
            this.cuarentenaBtn.Text = "Cuarentena";
            this.cuarentenaBtn.UseVisualStyleBackColor = true;
            this.cuarentenaBtn.Click += new System.EventHandler(this.cuarentenaBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listVirus);
            this.panel1.Controls.Add(this.totalLbl);
            this.panel1.Controls.Add(this.scannedLbl);
            this.panel1.Controls.Add(this.infectedLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 256);
            this.panel1.TabIndex = 9;
            // 
            // infectedLbl
            // 
            this.infectedLbl.AutoSize = true;
            this.infectedLbl.Location = new System.Drawing.Point(292, 49);
            this.infectedLbl.Name = "infectedLbl";
            this.infectedLbl.Size = new System.Drawing.Size(70, 13);
            this.infectedLbl.TabIndex = 3;
            this.infectedLbl.Text = "Infected Files";
            // 
            // scannedLbl
            // 
            this.scannedLbl.AutoSize = true;
            this.scannedLbl.Location = new System.Drawing.Point(24, 16);
            this.scannedLbl.Name = "scannedLbl";
            this.scannedLbl.Size = new System.Drawing.Size(74, 13);
            this.scannedLbl.TabIndex = 4;
            this.scannedLbl.Text = "Files Scanned";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(24, 49);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(55, 13);
            this.totalLbl.TabIndex = 5;
            this.totalLbl.Text = "Total Files";
            // 
            // listVirus
            // 
            this.listVirus.FormattingEnabled = true;
            this.listVirus.Location = new System.Drawing.Point(27, 88);
            this.listVirus.Name = "listVirus";
            this.listVirus.Size = new System.Drawing.Size(518, 124);
            this.listVirus.TabIndex = 0;
            // 
            // monitorBtn
            // 
            this.monitorBtn.Location = new System.Drawing.Point(669, 233);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(75, 23);
            this.monitorBtn.TabIndex = 10;
            this.monitorBtn.Text = "Monitor";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.scan);
            this.tabControl1.Controls.Add(this.virustotal);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Antivirus";
            this.virustotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVTResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.scan.ResumeLayout(false);
            this.scan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage virustotal;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button crearDump;
        private System.Windows.Forms.Button analizarVTbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridVTResult;
        private System.Windows.Forms.TabPage scan;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox listVirus;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label scannedLbl;
        private System.Windows.Forms.Label infectedLbl;
        private System.Windows.Forms.Button cuarentenaBtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button fullscanbtn;
        private System.Windows.Forms.Button manualbtn;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

