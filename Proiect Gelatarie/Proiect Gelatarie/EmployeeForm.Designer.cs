namespace Proiect_Gelatarie
{
    partial class EmployeeForm
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
            this.parentDataView = new System.Windows.Forms.DataGridView();
            this.childDataView = new System.Windows.Forms.DataGridView();
            this.displayChildrenButton = new System.Windows.Forms.Button();
            this.displayParentsButton = new System.Windows.Forms.Button();
            this.addChildBox = new System.Windows.Forms.GroupBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.addId = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateChildBox = new System.Windows.Forms.GroupBox();
            this.updateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataView)).BeginInit();
            this.addChildBox.SuspendLayout();
            this.updateChildBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentDataView
            // 
            this.parentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentDataView.Location = new System.Drawing.Point(40, 28);
            this.parentDataView.Name = "parentDataView";
            this.parentDataView.RowHeadersWidth = 51;
            this.parentDataView.RowTemplate.Height = 24;
            this.parentDataView.Size = new System.Drawing.Size(361, 285);
            this.parentDataView.TabIndex = 0;
            this.parentDataView.Visible = false;
            this.parentDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentDataView_CellContentClick);
            // 
            // childDataView
            // 
            this.childDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childDataView.Location = new System.Drawing.Point(464, 28);
            this.childDataView.Name = "childDataView";
            this.childDataView.RowHeadersWidth = 51;
            this.childDataView.RowTemplate.Height = 24;
            this.childDataView.Size = new System.Drawing.Size(374, 285);
            this.childDataView.TabIndex = 1;
            this.childDataView.Visible = false;
            this.childDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childDataView_CellContentClick);
            // 
            // displayChildrenButton
            // 
            this.displayChildrenButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayChildrenButton.Location = new System.Drawing.Point(71, 437);
            this.displayChildrenButton.Name = "displayChildrenButton";
            this.displayChildrenButton.Size = new System.Drawing.Size(207, 51);
            this.displayChildrenButton.TabIndex = 2;
            this.displayChildrenButton.Text = "Display all programmes of an employee";
            this.displayChildrenButton.UseVisualStyleBackColor = true;
            this.displayChildrenButton.Click += new System.EventHandler(this.displayChildrenButton_Click);
            // 
            // displayParentsButton
            // 
            this.displayParentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayParentsButton.Location = new System.Drawing.Point(71, 352);
            this.displayParentsButton.Name = "displayParentsButton";
            this.displayParentsButton.Size = new System.Drawing.Size(207, 51);
            this.displayParentsButton.TabIndex = 3;
            this.displayParentsButton.Text = "Display all employees";
            this.displayParentsButton.UseVisualStyleBackColor = true;
            this.displayParentsButton.Click += new System.EventHandler(this.displayParentsButton_Click);
            // 
            // addChildBox
            // 
            this.addChildBox.Controls.Add(this.addName);
            this.addChildBox.Controls.Add(this.addId);
            this.addChildBox.Controls.Add(this.add);
            this.addChildBox.Controls.Add(this.label2);
            this.addChildBox.Controls.Add(this.label1);
            this.addChildBox.Location = new System.Drawing.Point(378, 344);
            this.addChildBox.Name = "addChildBox";
            this.addChildBox.Size = new System.Drawing.Size(212, 160);
            this.addChildBox.TabIndex = 4;
            this.addChildBox.TabStop = false;
            this.addChildBox.Text = "groupBox1";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(86, 90);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(100, 22);
            this.addName.TabIndex = 4;
            // 
            // addId
            // 
            this.addId.Location = new System.Drawing.Point(106, 42);
            this.addId.Name = "addId";
            this.addId.Size = new System.Drawing.Size(80, 22);
            this.addId.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(61, 131);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programme Id";
            // 
            // updateChildBox
            // 
            this.updateChildBox.Controls.Add(this.updateName);
            this.updateChildBox.Controls.Add(this.label3);
            this.updateChildBox.Controls.Add(this.update);
            this.updateChildBox.Location = new System.Drawing.Point(631, 344);
            this.updateChildBox.Name = "updateChildBox";
            this.updateChildBox.Size = new System.Drawing.Size(207, 160);
            this.updateChildBox.TabIndex = 5;
            this.updateChildBox.TabStop = false;
            this.updateChildBox.Text = "groupBox2";
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(86, 74);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(100, 22);
            this.updateName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duration";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(62, 131);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(92, 23);
            this.update.TabIndex = 0;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 524);
            this.Controls.Add(this.updateChildBox);
            this.Controls.Add(this.addChildBox);
            this.Controls.Add(this.displayParentsButton);
            this.Controls.Add(this.displayChildrenButton);
            this.Controls.Add(this.childDataView);
            this.Controls.Add(this.parentDataView);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.parentDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataView)).EndInit();
            this.addChildBox.ResumeLayout(false);
            this.addChildBox.PerformLayout();
            this.updateChildBox.ResumeLayout(false);
            this.updateChildBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentDataView;
        private System.Windows.Forms.DataGridView childDataView;
        private System.Windows.Forms.Button displayChildrenButton;
        private System.Windows.Forms.Button displayParentsButton;
        private System.Windows.Forms.GroupBox addChildBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.TextBox addId;
        private System.Windows.Forms.GroupBox updateChildBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.Label label3;
    }
}
