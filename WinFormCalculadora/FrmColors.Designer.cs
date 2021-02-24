
namespace WinFormCalculadora
{
    partial class FrmColores
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
            this.LbRed = new System.Windows.Forms.Label();
            this.LbGreen = new System.Windows.Forms.Label();
            this.LbBlue = new System.Windows.Forms.Label();
            this.TBrRed = new System.Windows.Forms.TrackBar();
            this.TBrGreen = new System.Windows.Forms.TrackBar();
            this.TBrBlue = new System.Windows.Forms.TrackBar();
            this.TbRed = new System.Windows.Forms.TextBox();
            this.TbGreen = new System.Windows.Forms.TextBox();
            this.TbBlue = new System.Windows.Forms.TextBox();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BtAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBrBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // LbRed
            // 
            this.LbRed.AutoSize = true;
            this.LbRed.Location = new System.Drawing.Point(12, 9);
            this.LbRed.Name = "LbRed";
            this.LbRed.Size = new System.Drawing.Size(27, 13);
            this.LbRed.TabIndex = 0;
            this.LbRed.Text = "Red";
            // 
            // LbGreen
            // 
            this.LbGreen.AutoSize = true;
            this.LbGreen.Location = new System.Drawing.Point(12, 60);
            this.LbGreen.Name = "LbGreen";
            this.LbGreen.Size = new System.Drawing.Size(36, 13);
            this.LbGreen.TabIndex = 1;
            this.LbGreen.Text = "Green";
            // 
            // LbBlue
            // 
            this.LbBlue.AutoSize = true;
            this.LbBlue.Location = new System.Drawing.Point(12, 109);
            this.LbBlue.Name = "LbBlue";
            this.LbBlue.Size = new System.Drawing.Size(28, 13);
            this.LbBlue.TabIndex = 2;
            this.LbBlue.Text = "Blue";
            // 
            // TBrRed
            // 
            this.TBrRed.Location = new System.Drawing.Point(54, 9);
            this.TBrRed.Maximum = 255;
            this.TBrRed.Name = "TBrRed";
            this.TBrRed.Size = new System.Drawing.Size(167, 45);
            this.TBrRed.TabIndex = 3;
            this.TBrRed.Scroll += new System.EventHandler(this.TBrRed_Scroll);
            // 
            // TBrGreen
            // 
            this.TBrGreen.Location = new System.Drawing.Point(54, 60);
            this.TBrGreen.Maximum = 255;
            this.TBrGreen.Name = "TBrGreen";
            this.TBrGreen.Size = new System.Drawing.Size(167, 45);
            this.TBrGreen.TabIndex = 4;
            this.TBrGreen.Scroll += new System.EventHandler(this.TBrGreen_Scroll);
            // 
            // TBrBlue
            // 
            this.TBrBlue.Location = new System.Drawing.Point(54, 109);
            this.TBrBlue.Maximum = 255;
            this.TBrBlue.Name = "TBrBlue";
            this.TBrBlue.Size = new System.Drawing.Size(167, 45);
            this.TBrBlue.TabIndex = 5;
            this.TBrBlue.Scroll += new System.EventHandler(this.TBrBlue_Scroll);
            // 
            // TbRed
            // 
            this.TbRed.Location = new System.Drawing.Point(227, 12);
            this.TbRed.Name = "TbRed";
            this.TbRed.Size = new System.Drawing.Size(48, 20);
            this.TbRed.TabIndex = 6;
            // 
            // TbGreen
            // 
            this.TbGreen.Location = new System.Drawing.Point(227, 60);
            this.TbGreen.Name = "TbGreen";
            this.TbGreen.Size = new System.Drawing.Size(48, 20);
            this.TbGreen.TabIndex = 7;
            // 
            // TbBlue
            // 
            this.TbBlue.Location = new System.Drawing.Point(227, 109);
            this.TbBlue.Name = "TbBlue";
            this.TbBlue.Size = new System.Drawing.Size(48, 20);
            this.TbBlue.TabIndex = 8;
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(54, 161);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 9;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(161, 161);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 10;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // FrmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 193);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.TbBlue);
            this.Controls.Add(this.TbGreen);
            this.Controls.Add(this.TbRed);
            this.Controls.Add(this.TBrBlue);
            this.Controls.Add(this.TBrGreen);
            this.Controls.Add(this.TBrRed);
            this.Controls.Add(this.LbBlue);
            this.Controls.Add(this.LbGreen);
            this.Controls.Add(this.LbRed);
            this.Name = "FrmColores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmColores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBrBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbRed;
        private System.Windows.Forms.Label LbGreen;
        private System.Windows.Forms.Label LbBlue;
        private System.Windows.Forms.TrackBar TBrRed;
        private System.Windows.Forms.TrackBar TBrGreen;
        private System.Windows.Forms.TrackBar TBrBlue;
        private System.Windows.Forms.TextBox TbRed;
        private System.Windows.Forms.TextBox TbGreen;
        private System.Windows.Forms.TextBox TbBlue;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtAceptar;
    }
}