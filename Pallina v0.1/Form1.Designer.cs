namespace Pallina_v0._1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numRaggio = new System.Windows.Forms.NumericUpDown();
            this.numVel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cDPalla = new System.Windows.Forms.ColorDialog();
            this.cDSfondo = new System.Windows.Forms.ColorDialog();
            this.btnPalla = new System.Windows.Forms.Button();
            this.btnSfondo = new System.Windows.Forms.Button();
            this.lbErrore = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(139, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.muovi_Tick);
            // 
            // numRaggio
            // 
            this.numRaggio.BackColor = System.Drawing.Color.White;
            this.numRaggio.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRaggio.Location = new System.Drawing.Point(23, 61);
            this.numRaggio.Name = "numRaggio";
            this.numRaggio.ReadOnly = true;
            this.numRaggio.Size = new System.Drawing.Size(84, 25);
            this.numRaggio.TabIndex = 1;
            this.numRaggio.ValueChanged += new System.EventHandler(this.numRaggio_ValueChanged);
            // 
            // numVel
            // 
            this.numVel.BackColor = System.Drawing.Color.White;
            this.numVel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVel.Location = new System.Drawing.Point(23, 122);
            this.numVel.Name = "numVel";
            this.numVel.ReadOnly = true;
            this.numVel.Size = new System.Drawing.Size(84, 25);
            this.numVel.TabIndex = 2;
            this.numVel.ValueChanged += new System.EventHandler(this.numVel_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raggio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Velocità";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGreen;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(28, 333);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Pausa";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.BackColor = System.Drawing.Color.Lime;
            this.btnCancella.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancella.ForeColor = System.Drawing.Color.Black;
            this.btnCancella.Location = new System.Drawing.Point(28, 382);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 0;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = false;
            this.btnCancella.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(23, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Cambio colore \r\nautomatico";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnPalla
            // 
            this.btnPalla.BackColor = System.Drawing.Color.Lime;
            this.btnPalla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalla.Location = new System.Drawing.Point(23, 188);
            this.btnPalla.Name = "btnPalla";
            this.btnPalla.Size = new System.Drawing.Size(96, 23);
            this.btnPalla.TabIndex = 7;
            this.btnPalla.Text = "Colore palla";
            this.btnPalla.UseVisualStyleBackColor = false;
            this.btnPalla.Click += new System.EventHandler(this.btnPalla_Click);
            // 
            // btnSfondo
            // 
            this.btnSfondo.BackColor = System.Drawing.Color.Lime;
            this.btnSfondo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSfondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSfondo.Location = new System.Drawing.Point(23, 234);
            this.btnSfondo.Name = "btnSfondo";
            this.btnSfondo.Size = new System.Drawing.Size(96, 23);
            this.btnSfondo.TabIndex = 8;
            this.btnSfondo.Text = "Colore Sfondo";
            this.btnSfondo.UseVisualStyleBackColor = false;
            this.btnSfondo.Click += new System.EventHandler(this.btnSfondo_Click);
            // 
            // lbErrore
            // 
            this.lbErrore.AutoSize = true;
            this.lbErrore.ForeColor = System.Drawing.Color.Red;
            this.lbErrore.Location = new System.Drawing.Point(20, 150);
            this.lbErrore.Name = "lbErrore";
            this.lbErrore.Size = new System.Drawing.Size(0, 13);
            this.lbErrore.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(28, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(574, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbErrore);
            this.Controls.Add(this.btnSfondo);
            this.Controls.Add(this.btnPalla);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numVel);
            this.Controls.Add(this.numRaggio);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pallina Rimbalzante";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numRaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numRaggio;
        private System.Windows.Forms.NumericUpDown numVel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColorDialog cDPalla;
        private System.Windows.Forms.ColorDialog cDSfondo;
        private System.Windows.Forms.Button btnPalla;
        private System.Windows.Forms.Button btnSfondo;
        private System.Windows.Forms.Label lbErrore;
        private System.Windows.Forms.Button btnClose;
    }
}

