namespace TURNOS_BANCARIOS
{
   partial class Filtro1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtro1));
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnSinTarjeta = new System.Windows.Forms.Button();
         this.btnTarjeta = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(399, 112);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(266, 30);
         this.label4.TabIndex = 15;
         this.label4.Text = "SELECCIONE UNA OPCION";
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(734, 409);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(192, 30);
         this.label3.TabIndex = 14;
         this.label3.Text = "Cliente Con Tarejta";
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(161, 409);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(182, 30);
         this.label2.TabIndex = 13;
         this.label2.Text = "Cliente Sin Tarejta";
         // 
         // btnSinTarjeta
         // 
         this.btnSinTarjeta.FlatAppearance.BorderSize = 0;
         this.btnSinTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
         this.btnSinTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSinTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnSinTarjeta.Image")));
         this.btnSinTarjeta.Location = new System.Drawing.Point(88, 175);
         this.btnSinTarjeta.Name = "btnSinTarjeta";
         this.btnSinTarjeta.Size = new System.Drawing.Size(351, 231);
         this.btnSinTarjeta.TabIndex = 12;
         this.btnSinTarjeta.UseVisualStyleBackColor = true;
         this.btnSinTarjeta.Click += new System.EventHandler(this.btnSinTarjeta_Click);
         // 
         // btnTarjeta
         // 
         this.btnTarjeta.FlatAppearance.BorderSize = 0;
         this.btnTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
         this.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnTarjeta.Image")));
         this.btnTarjeta.Location = new System.Drawing.Point(635, 175);
         this.btnTarjeta.Name = "btnTarjeta";
         this.btnTarjeta.Size = new System.Drawing.Size(351, 231);
         this.btnTarjeta.TabIndex = 11;
         this.btnTarjeta.UseVisualStyleBackColor = true;
         this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(387, 10);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(291, 30);
         this.label1.TabIndex = 10;
         this.label1.Text = "Banco Santander Mexico S.A.";
         // 
         // Filtro1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1093, 443);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnSinTarjeta);
         this.Controls.Add(this.btnTarjeta);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Filtro1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Filtro1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnSinTarjeta;
      private System.Windows.Forms.Button btnTarjeta;
      private System.Windows.Forms.Label label1;
   }
}