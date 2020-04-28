namespace ControlSum
{
    partial class ControlSum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSum));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrbInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nrbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nrbInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "PL",
            "DE",
            "SK"});
            this.country.Location = new System.Drawing.Point(25, 48);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(51, 24);
            this.country.TabIndex = 2;
            this.country.Text = "PL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rachunek w formacie NRB";
            // 
            // nrbInput
            // 
            this.nrbInput.Location = new System.Drawing.Point(82, 48);
            this.nrbInput.Name = "nrbInput";
            this.nrbInput.Size = new System.Drawing.Size(349, 22);
            this.nrbInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nrbOutput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // nrbOutput
            // 
            this.nrbOutput.Location = new System.Drawing.Point(25, 48);
            this.nrbOutput.Name = "nrbOutput";
            this.nrbOutput.Size = new System.Drawing.Size(406, 22);
            this.nrbOutput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rachunek z sumą kontrolną";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(475, 13);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(92, 177);
            this.convert.TabIndex = 2;
            this.convert.Text = "Konwertuj";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // ControlSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 199);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlSum";
            this.Text = "ConstrolSum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nrbInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nrbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.ComboBox country;
    }
}

