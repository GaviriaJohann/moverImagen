using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 27 - Feb - 2024
// Johann Mauricio Gaviria Rodriguez
// este programa implementa un juego simple donde el jugador debe mover un objeto
// (el cerdo) horizontalmente para evitar colisionar con otro objeto (el hacha) que
// se mueve verticalmente. El jugador acumula puntos cada vez que el cerdo alcanza
// el borde derecho de la ventana. Si el cerdo colisiona con el hacha, el jugador
// pierde y se muestra la opción para reiniciar el juego.


namespace moveImage
{
    public partial class frmMoveImage : Form
    {
        private int direccionX = 1;
        private int direccionY = 1;
        private int velocidad = 10;
        private int puntos = 0;

        public frmMoveImage()
        {
            InitializeComponent();
            picPig.Left = 0;
            picHacha.Top = 0; 
            picHacha.Left = ClientSize.Width - picHacha.Width;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            tmrMover.Enabled = true;
            tmrHacha.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrMover.Enabled = false;
        }

        private void tmrMover_Tick(object sender, EventArgs e)
        {
            picPig.Left += direccionX * velocidad;

            if (picPig.Left <= 0 || picPig.Right >= ClientSize.Width)
            {
                direccionX *= -1;
            }

            if (picPig.Bounds.IntersectsWith(picHacha.Bounds))
            {
                picPig.Visible = false;
                lblPerdiste.Visible = true;
                btnReiniciar.Visible = true;

            }

            if (picPig.Right >= ClientSize.Width)
            {
                puntos++;
                lblPuntos.Text = "Puntos: " + puntos;
            }

        }

        private void tmrHacha_Tick(object sender, EventArgs e)
        {
            picHacha.Top += direccionY * (velocidad * 2);

            if (picHacha.Top <= 0 || picHacha.Bottom >= ClientSize.Height)
            {
                direccionY *= -1;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
