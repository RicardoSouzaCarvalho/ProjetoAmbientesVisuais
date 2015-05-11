namespace AgendaDeTarefas
{
    partial class frmCalendario
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
            this.calendarioMensal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // calendarioMensal
            // 
            this.calendarioMensal.Location = new System.Drawing.Point(404, 18);
            this.calendarioMensal.Name = "calendarioMensal";
            this.calendarioMensal.TabIndex = 0;
            this.calendarioMensal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 547);
            this.Controls.Add(this.calendarioMensal);
            this.Name = "frmCalendario";
            this.Text = "Calendário";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioMensal;
    }
}

