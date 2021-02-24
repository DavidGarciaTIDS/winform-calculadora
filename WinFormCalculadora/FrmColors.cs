using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculadora
{
    public partial class FrmColores : Form
    {
        private int RedValue = 0;
        private int GreenValue = 0;
        private int BlueValue = 0;
        FrmCalculadora obj = new FrmCalculadora();


        public FrmColores()
        {
            InitializeComponent();
        }

        public void SetValues(Color col) {
            this.RedValue = col.R;
            this.GreenValue = col.G;
            this.BlueValue = col.B;
        }
        private void FrmColores_Load(object sender, EventArgs e)
        {
            this.BackColor=FrmCalculadora.DefaultBackColor;

            this.TBrRed.Value = this.RedValue;
            this.TBrGreen.Value = this.GreenValue;
            this.TBrBlue.Value = this.BlueValue;

            this.TbRed.Text = this.RedValue.ToString();
            this.TbGreen.Text = this.GreenValue.ToString();
            this.TbBlue.Text = this.BlueValue.ToString();

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            FrmCalculadora.colorFondo=Color.FromArgb(this.RedValue, this.GreenValue, this.BlueValue);
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {

        }

        private void TBrRed_Scroll(object sender, EventArgs e)
        {
            this.RedValue = this.TBrRed.Value;
            this.TbRed.Text = this.RedValue.ToString();
        }

        private void TBrGreen_Scroll(object sender, EventArgs e)
        {
            this.GreenValue = this.TBrGreen.Value;
            this.TbGreen.Text = this.GreenValue.ToString();

        }

        private void TBrBlue_Scroll(object sender, EventArgs e)
        {
            this.BlueValue = this.TBrBlue.Value;
            this.TbBlue.Text = this.BlueValue.ToString();

        }
    }
}
