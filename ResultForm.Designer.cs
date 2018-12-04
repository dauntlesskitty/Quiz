namespace Assignment2Windows
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conList = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Candidates ";
            // 
            // conList
            // 
            this.conList.FormattingEnabled = true;
            this.conList.Location = new System.Drawing.Point(275, 138);
            this.conList.Name = "conList";
            this.conList.Size = new System.Drawing.Size(206, 28);
            this.conList.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(238, 184);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 37);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Result";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.label8);
            this.resultBox.Controls.Add(this.lblPer);
            this.resultBox.Controls.Add(this.txtTime);
            this.resultBox.Controls.Add(this.label7);
            this.resultBox.Controls.Add(this.txtAns);
            this.resultBox.Controls.Add(this.label6);
            this.resultBox.Controls.Add(this.txtScore);
            this.resultBox.Controls.Add(this.label5);
            this.resultBox.Controls.Add(this.countryPic);
            this.resultBox.Controls.Add(this.label4);
            this.resultBox.Controls.Add(this.txtName);
            this.resultBox.Controls.Add(this.label3);
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(107, 242);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(506, 662);
            this.resultBox.TabIndex = 4;
            this.resultBox.TabStop = false;
            this.resultBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "s";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.ForeColor = System.Drawing.Color.Maroon;
            this.lblPer.Location = new System.Drawing.Point(353, 578);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(95, 36);
            this.lblPer.TabIndex = 10;
            this.lblPer.Text = "label8";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(199, 293);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(89, 41);
            this.txtTime.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time Used : ";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(199, 377);
            this.txtAns.Multiline = true;
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(238, 107);
            this.txtAns.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Answers : ";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(199, 503);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(160, 41);
            this.txtScore.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Score : ";
            // 
            // countryPic
            // 
            this.countryPic.Location = new System.Drawing.Point(199, 115);
            this.countryPic.Name = "countryPic";
            this.countryPic.Size = new System.Drawing.Size(215, 145);
            this.countryPic.TabIndex = 3;
            this.countryPic.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Country : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 50);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(215, 41);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Winner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 947);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.conList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "RestultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox conList;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox countryPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label8;
    }
}