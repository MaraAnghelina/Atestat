namespace Proiect_Gelatarie
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.buttonGuest = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGuest
            // 
            this.buttonGuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuest.Location = new System.Drawing.Point(112, 808);
            this.buttonGuest.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(214, 41);
            this.buttonGuest.TabIndex = 0;
            this.buttonGuest.Text = "Log in as a guest";
            this.buttonGuest.UseVisualStyleBackColor = false;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmployee.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEmployee.Location = new System.Drawing.Point(910, 803);
            this.buttonEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(214, 41);
            this.buttonEmployee.TabIndex = 1;
            this.buttonEmployee.Text = "Log in as an employee";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonGuest);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGuest;
        private System.Windows.Forms.Button buttonEmployee;
    }
}

