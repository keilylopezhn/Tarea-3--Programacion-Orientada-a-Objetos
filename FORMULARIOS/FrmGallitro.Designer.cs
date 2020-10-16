namespace Programacion_Orientada_a_Objetos.FORMULARIOS
{
    partial class FrmGallitro
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConv = new System.Windows.Forms.Button();
            this.TxtGal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(171, 209);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 31);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(282, 209);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 31);
            this.BtnSalir.TabIndex = 22;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtRes
            // 
            this.TxtRes.Location = new System.Drawing.Point(320, 150);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(92, 25);
            this.TxtRes.TabIndex = 21;
            this.TxtRes.TextChanged += new System.EventHandler(this.TxtRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "EL TOTAL DE LITROS ES:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnConv
            // 
            this.BtnConv.Location = new System.Drawing.Point(23, 112);
            this.BtnConv.Name = "BtnConv";
            this.BtnConv.Size = new System.Drawing.Size(114, 31);
            this.BtnConv.TabIndex = 19;
            this.BtnConv.Text = "CONVERTIR";
            this.BtnConv.UseVisualStyleBackColor = true;
            this.BtnConv.Click += new System.EventHandler(this.BtnConv_Click);
            // 
            // TxtGal
            // 
            this.TxtGal.Location = new System.Drawing.Point(320, 72);
            this.TxtGal.Name = "TxtGal";
            this.TxtGal.Size = new System.Drawing.Size(92, 25);
            this.TxtGal.TabIndex = 18;
            this.TxtGal.TextChanged += new System.EventHandler(this.TxtMilla_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "INGRESE CANTIDAD EN GALONES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "INGRESE VALORES A CONVERTIR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmGallitro
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(424, 274);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnConv);
            this.Controls.Add(this.TxtGal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGallitro";
            this.Text = "CONVERSOR DE GALONES A LITROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConv;
        private System.Windows.Forms.TextBox TxtGal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}