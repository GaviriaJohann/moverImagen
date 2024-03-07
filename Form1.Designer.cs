namespace moveImage
{
    partial class frmMoveImage
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
            this.components = new System.ComponentModel.Container();
            this.btnMover = new System.Windows.Forms.Button();
            this.tmrMover = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPerdiste = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.tmrHacha = new System.Windows.Forms.Timer(this.components);
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.picHacha = new System.Windows.Forms.PictureBox();
            this.picPig = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHacha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(12, 401);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(109, 51);
            this.btnMover.TabIndex = 0;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // tmrMover
            // 
            this.tmrMover.Tick += new System.EventHandler(this.tmrMover_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(136, 401);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 51);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPerdiste
            // 
            this.lblPerdiste.BackColor = System.Drawing.Color.Transparent;
            this.lblPerdiste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPerdiste.Location = new System.Drawing.Point(287, 210);
            this.lblPerdiste.Name = "lblPerdiste";
            this.lblPerdiste.Size = new System.Drawing.Size(78, 36);
            this.lblPerdiste.TabIndex = 40;
            this.lblPerdiste.Text = "Perdistes";
            this.lblPerdiste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPerdiste.Visible = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(13, 13);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(52, 13);
            this.lblPuntos.TabIndex = 41;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // tmrHacha
            // 
            this.tmrHacha.Tick += new System.EventHandler(this.tmrHacha_Tick);
            // 
            // picFondo
            // 
            this.picFondo.Image = global::moveImage.Properties.Resources.fondo;
            this.picFondo.Location = new System.Drawing.Point(1, 2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(671, 482);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 42;
            this.picFondo.TabStop = false;
            // 
            // picHacha
            // 
            this.picHacha.BackColor = System.Drawing.Color.Transparent;
            this.picHacha.Image = global::moveImage.Properties.Resources.hacha;
            this.picHacha.Location = new System.Drawing.Point(577, 81);
            this.picHacha.Name = "picHacha";
            this.picHacha.Size = new System.Drawing.Size(79, 74);
            this.picHacha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHacha.TabIndex = 3;
            this.picHacha.TabStop = false;
            // 
            // picPig
            // 
            this.picPig.BackColor = System.Drawing.Color.Transparent;
            this.picPig.ErrorImage = null;
            this.picPig.Image = global::moveImage.Properties.Resources.Pig;
            this.picPig.InitialImage = null;
            this.picPig.Location = new System.Drawing.Point(12, 81);
            this.picPig.Name = "picPig";
            this.picPig.Size = new System.Drawing.Size(141, 107);
            this.picPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPig.TabIndex = 1;
            this.picPig.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(290, 267);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 43;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // frmMoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(668, 483);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblPerdiste);
            this.Controls.Add(this.picHacha);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picPig);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.picFondo);
            this.Name = "frmMoveImage";
            this.Text = "Mover Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHacha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.PictureBox picPig;
        private System.Windows.Forms.Timer tmrMover;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox picHacha;
        private System.Windows.Forms.Label lblPerdiste;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer tmrHacha;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

