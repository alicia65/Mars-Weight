namespace Mars_Weight
{
    partial class Form1
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
            this.txtWeightOnEarth = new System.Windows.Forms.TextBox();
            this.lblEarth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeightMars = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWeightOnEarth
            // 
            this.txtWeightOnEarth.Location = new System.Drawing.Point(209, 85);
            this.txtWeightOnEarth.Name = "txtWeightOnEarth";
            this.txtWeightOnEarth.Size = new System.Drawing.Size(178, 22);
            this.txtWeightOnEarth.TabIndex = 0;
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Location = new System.Drawing.Point(42, 90);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(110, 17);
            this.lblEarth.TabIndex = 1;
            this.lblEarth.Text = "Weight on Earth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight on Mars";
            // 
            // txtWeightMars
            // 
            this.txtWeightMars.Location = new System.Drawing.Point(209, 120);
            this.txtWeightMars.Name = "txtWeightMars";
            this.txtWeightMars.ReadOnly = true;
            this.txtWeightMars.Size = new System.Drawing.Size(178, 22);
            this.txtWeightMars.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(110, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of object";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(209, 40);
            this.txtObject.MaxLength = 50;
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(178, 22);
            this.txtObject.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 262);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeightMars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEarth);
            this.Controls.Add(this.txtWeightOnEarth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeightOnEarth;
        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeightMars;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObject;
    }
}

