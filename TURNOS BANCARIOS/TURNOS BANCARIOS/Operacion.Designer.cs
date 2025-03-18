namespace TURNOS_BANCARIOS
{
   partial class Operacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion));
            this.btnCajas = new System.Windows.Forms.Button();
            this.btnEjecutivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCajas
            // 
            this.btnCajas.FlatAppearance.BorderSize = 0;
            this.btnCajas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCajas.Image = ((System.Drawing.Image)(resources.GetObject("btnCajas.Image")));
            this.btnCajas.Location = new System.Drawing.Point(138, 200);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(267, 169);
            this.btnCajas.TabIndex = 0;
            this.btnCajas.UseVisualStyleBackColor = true;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // btnEjecutivo
            // 
            this.btnEjecutivo.FlatAppearance.BorderSize = 0;
            this.btnEjecutivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEjecutivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutivo.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutivo.Image")));
            this.btnEjecutivo.Location = new System.Drawing.Point(642, 175);
            this.btnEjecutivo.Name = "btnEjecutivo";
            this.btnEjecutivo.Size = new System.Drawing.Size(281, 194);
            this.btnEjecutivo.TabIndex = 1;
            this.btnEjecutivo.UseVisualStyleBackColor = true;
            this.btnEjecutivo.Click += new System.EventHandler(this.btnEjecutivo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Banco Santander Mexico S.A.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "SELECCIONE UNA OPCION";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ejecutivo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cajas";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_regresar.BackgroundImage = global::TURNOS_BANCARIOS.Properties.Resources.regresar;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(-1, 0);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(58, 58);
            this.btn_regresar.TabIndex = 19;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 443);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutivo);
            this.Controls.Add(this.btnCajas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion";
            this.Opacity = 0D;
            this.Text = "Filtro2";
            this.Load += new System.EventHandler(this.Filtro2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCajas;
      private System.Windows.Forms.Button btnEjecutivo;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_regresar;
    }
}