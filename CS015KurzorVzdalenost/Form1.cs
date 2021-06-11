using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS015KurzorVzdalenost
{
    public partial class VzdalenostForm : Form
    {
        private double kurzorVzdalenost = 0;
        //private int kurzorX = 0;
        //private int kurzorY = 0;
        private Point kurzorMinulaPozice;

        private double PxToCm(double pixels)
        {
            return pixels * (2.54/100);
        }

        public VzdalenostForm()
        {
            InitializeComponent();
        }

        private void VzdalenostForm_MouseEnter(object sender, EventArgs e)
        {
            //if (kurzorMinulaPozice.IsEmpty) kurzorMinulaPozice = this.PointToClient(Cursor.Position);
            kurzorMinulaPozice = this.PointToClient(Cursor.Position);
        }

        private void VzdalenostForm_MouseMove(object sender, MouseEventArgs e)
        {
            kurzorVzdalenost += Math.Sqrt(Math.Pow(kurzorMinulaPozice.X - e.X, 2) + Math.Pow(kurzorMinulaPozice.Y - e.Y, 2));
            vzdalenostLabel.Text = string.Format("Vzdálenost: {0:0.00} cm", PxToCm(kurzorVzdalenost));
            //kurzorX = e.X;
            //kurzorY = e.Y;
            kurzorMinulaPozice = e.Location;
            progressBar.Value = (int) PxToCm(kurzorVzdalenost);
        }
    }
}
