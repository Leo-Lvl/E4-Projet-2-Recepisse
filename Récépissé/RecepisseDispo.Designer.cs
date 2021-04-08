
namespace Récépissé
{
    partial class RecepisseDispo
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
            this.labelRecepisseDispo = new System.Windows.Forms.Label();
            this.lb_RecepisseDispo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelRecepisseDispo
            // 
            this.labelRecepisseDispo.AutoSize = true;
            this.labelRecepisseDispo.Location = new System.Drawing.Point(343, 107);
            this.labelRecepisseDispo.Name = "labelRecepisseDispo";
            this.labelRecepisseDispo.Size = new System.Drawing.Size(123, 13);
            this.labelRecepisseDispo.TabIndex = 0;
            this.labelRecepisseDispo.Text = "Récépissés disponibles :";
            this.labelRecepisseDispo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_RecepisseDispo
            // 
            this.lb_RecepisseDispo.FormattingEnabled = true;
            this.lb_RecepisseDispo.Items.AddRange(new object[] {
            "Récépissé n°1",
            "Récépissé n°2",
            "Récépissé n°3",
            "Récépissé n°4",
            "Récépissé n°5"});
            this.lb_RecepisseDispo.Location = new System.Drawing.Point(359, 147);
            this.lb_RecepisseDispo.Name = "lb_RecepisseDispo";
            this.lb_RecepisseDispo.Size = new System.Drawing.Size(86, 69);
            this.lb_RecepisseDispo.TabIndex = 2;
            this.lb_RecepisseDispo.SelectedIndexChanged += new System.EventHandler(this.lb_RecepisseDispo_SelectedIndexChanged);
            // 
            // RecepisseDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_RecepisseDispo);
            this.Controls.Add(this.labelRecepisseDispo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RecepisseDispo";
            this.Text = "Matricule";
            this.Load += new System.EventHandler(this.RecepisseDispo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecepisseDispo;
        private System.Windows.Forms.ListBox lb_RecepisseDispo;
    }
}