﻿namespace Dziennik_nauczyciela_obiektowy
{
    partial class fWalidacjaHasla
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
            this.b_polacz = new System.Windows.Forms.Button();
            this.t_haslo = new System.Windows.Forms.TextBox();
            this.b_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_polacz
            // 
            this.b_polacz.Location = new System.Drawing.Point(93, 37);
            this.b_polacz.Name = "b_polacz";
            this.b_polacz.Size = new System.Drawing.Size(75, 23);
            this.b_polacz.TabIndex = 5;
            this.b_polacz.Text = "OK";
            this.b_polacz.UseVisualStyleBackColor = true;
            this.b_polacz.Click += new System.EventHandler(this.b_polacz_Click);
            // 
            // t_haslo
            // 
            this.t_haslo.Location = new System.Drawing.Point(12, 11);
            this.t_haslo.Name = "t_haslo";
            this.t_haslo.Size = new System.Drawing.Size(156, 20);
            this.t_haslo.TabIndex = 4;
            this.t_haslo.TextChanged += new System.EventHandler(this.t_haslo_TextChanged);
            // 
            // b_anuluj
            // 
            this.b_anuluj.Location = new System.Drawing.Point(12, 37);
            this.b_anuluj.Name = "b_anuluj";
            this.b_anuluj.Size = new System.Drawing.Size(75, 23);
            this.b_anuluj.TabIndex = 6;
            this.b_anuluj.Text = "Anuluj";
            this.b_anuluj.UseVisualStyleBackColor = true;
            this.b_anuluj.Click += new System.EventHandler(this.b_anuluj_Click);
            // 
            // fWalidacjaHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 72);
            this.Controls.Add(this.b_anuluj);
            this.Controls.Add(this.b_polacz);
            this.Controls.Add(this.t_haslo);
            this.Name = "fWalidacjaHasla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fWalidacjaHasla";
            this.Load += new System.EventHandler(this.fWalidacjaHasla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_polacz;
        private System.Windows.Forms.TextBox t_haslo;
        private System.Windows.Forms.Button b_anuluj;
    }
}