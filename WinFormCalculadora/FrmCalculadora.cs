using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_LibCalc;

namespace WinFormCalculadora
{
    public partial class FrmCalculadora : Form
    {
        Operacion oper = null;
        string operador = "";
        private double _op1 = 0;
        private double _op2 = 0;
        private String[] Memory = new String[10];
        private int cont = 0;
        private int txtSize= 14;
        public static Color colorFondo = Color.LightGray;
        


        public FrmCalculadora()
        {
            InitializeComponent();

        }
        public void UpdateFrm() {
            this.BackColor = FrmCalculadora.colorFondo;
            this.Font = (new Font("Arial", txtSize));

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            UpdateFrm();
        }

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColores ClrFondo = new FrmColores();
            ClrFondo.SetValues(this.BackColor);
            ClrFondo.ShowDialog();
            this.BackColor = FrmCalculadora.colorFondo;

        }

        private void ValidInput(String input)
        {

            if (LbMemory.Text != "")
            {
                LbMemory.Text = "";
                txtDisplay.Text = "0";
            }
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = input;
            }
            else if (input == "." && txtDisplay.Text.Contains("."))
            {
            }
            else
            {
                txtDisplay.Text += input;
            }

        }

        //botones numeros
        private void Btn1_Click(object sender, EventArgs e)
        {
            ValidInput("1");
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ValidInput("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            ValidInput("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ValidInput("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ValidInput("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            ValidInput("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            ValidInput("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ValidInput("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            ValidInput("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            ValidInput("0");
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            ValidInput(".");
        }

        // Operaciones igual, suma, resta, multiplicacion, division

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            //capturamos op2
            this._op2 = double.Parse(txtDisplay.Text);
            //instanciamos la clase de la operacion seleccionada
            switch (this.operador)
            {
                case "+":
                    oper = new Suma(this._op1, this._op2);
                    break;
                case "-":
                    oper = new Resta(this._op1, this._op2);
                    break;
                case "*":
                    oper = new Multiplicacion(this._op1, this._op2);
                    break;
                case "/":
                    oper = new Division(this._op1, this._op2);
                    break;
                default:
                    operador = "";
                    break;
            }
            //se guarda en memoria
            LbMemory.Text = _op1 + " " + operador + " " + _op2 + " =";
            //ejecutamos la operacion
            txtDisplay.Text = oper.ejecutar().ToString();
            this.operador = "";
            cont++;
        }
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar display
            txtDisplay.Clear();
        }
        private void BtnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar display
            txtDisplay.Clear();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar display
            txtDisplay.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar display
            txtDisplay.Clear();
        }

        // Reset
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oper = null;
            operador = "";
            _op1 = 0;
            _op2 = 0;
            txtDisplay.Text = "0";
            LbMemory.Text = "";
            cont = 0;
        }

        private void btSimbolo_Click(object sender, EventArgs e)
        {
            if (!(txtDisplay.Text[0] == '-'))
            {
                txtDisplay.Text = "-" + txtDisplay.Text;

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(1, 1);

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            oper = null;
            operador = "";
            _op1 = 0;
            _op2 = 0;
            txtDisplay.Text = "0";
            LbMemory.Text = "";
            cont = 0;
            UpdateFrm();
        }
    }
}
