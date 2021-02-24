
namespace WinFormCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbMemory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btSimbolo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPunto);
            this.groupBox1.Controls.Add(this.Btn8);
            this.groupBox1.Controls.Add(this.Btn9);
            this.groupBox1.Controls.Add(this.BtnIgual);
            this.groupBox1.Controls.Add(this.Btn0);
            this.groupBox1.Controls.Add(this.Btn7);
            this.groupBox1.Controls.Add(this.Btn6);
            this.groupBox1.Controls.Add(this.Btn5);
            this.groupBox1.Controls.Add(this.Btn4);
            this.groupBox1.Controls.Add(this.Btn3);
            this.groupBox1.Controls.Add(this.Btn2);
            this.groupBox1.Controls.Add(this.Btn1);
            this.groupBox1.Location = new System.Drawing.Point(15, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numeros";
            // 
            // BtnPunto
            // 
            this.BtnPunto.Location = new System.Drawing.Point(64, 193);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(52, 52);
            this.BtnPunto.TabIndex = 8;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(64, 19);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(52, 52);
            this.Btn8.TabIndex = 7;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(122, 19);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(52, 52);
            this.Btn9.TabIndex = 2;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Location = new System.Drawing.Point(122, 193);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(52, 52);
            this.BtnIgual.TabIndex = 1;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(6, 193);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(52, 52);
            this.Btn0.TabIndex = 0;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(6, 19);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(52, 52);
            this.Btn7.TabIndex = 6;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(122, 77);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(52, 52);
            this.Btn6.TabIndex = 5;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(64, 77);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(52, 52);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(6, 77);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(52, 52);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(122, 135);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(52, 52);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(64, 135);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(52, 52);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(6, 135);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(52, 52);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(15, 27);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(254, 49);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(6, 19);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(52, 52);
            this.BtnSuma.TabIndex = 8;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDivision);
            this.groupBox2.Controls.Add(this.BtnSuma);
            this.groupBox2.Controls.Add(this.BtnMulti);
            this.groupBox2.Controls.Add(this.BtnResta);
            this.groupBox2.Location = new System.Drawing.Point(204, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(65, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operador";
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(6, 193);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(52, 52);
            this.BtnDivision.TabIndex = 9;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(6, 135);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(52, 52);
            this.BtnMulti.TabIndex = 4;
            this.BtnMulti.Text = "*";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.Location = new System.Drawing.Point(6, 77);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(52, 52);
            this.BtnResta.TabIndex = 3;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondoToolStripMenuItem,
            this.botonesToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fondoToolStripMenuItem
            // 
            this.fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
            this.fondoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.fondoToolStripMenuItem.Text = "Fondo";
            this.fondoToolStripMenuItem.Click += new System.EventHandler(this.fondoToolStripMenuItem_Click);
            // 
            // botonesToolStripMenuItem
            // 
            this.botonesToolStripMenuItem.Name = "botonesToolStripMenuItem";
            this.botonesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.botonesToolStripMenuItem.Text = "Botones";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // LbMemory
            // 
            this.LbMemory.AutoSize = true;
            this.LbMemory.Location = new System.Drawing.Point(216, 9);
            this.LbMemory.Name = "LbMemory";
            this.LbMemory.Size = new System.Drawing.Size(0, 13);
            this.LbMemory.TabIndex = 4;
            this.LbMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btClear);
            this.groupBox3.Controls.Add(this.btSimbolo);
            this.groupBox3.Location = new System.Drawing.Point(16, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(63, 19);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(52, 52);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSimbolo
            // 
            this.btSimbolo.Location = new System.Drawing.Point(5, 20);
            this.btSimbolo.Name = "btSimbolo";
            this.btSimbolo.Size = new System.Drawing.Size(52, 52);
            this.btSimbolo.TabIndex = 10;
            this.btSimbolo.Text = "+/-";
            this.btSimbolo.UseVisualStyleBackColor = true;
            this.btSimbolo.Click += new System.EventHandler(this.btSimbolo_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LbMemory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label LbMemory;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSimbolo;
    }
}

