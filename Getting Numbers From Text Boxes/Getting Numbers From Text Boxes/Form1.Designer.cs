namespace Getting_Numbers_From_Text_Boxes
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAnswer = new System.Windows.Forms.Button();
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(12, 68);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(82, 35);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "+";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(12, 12);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(82, 22);
            this.tbFirstNumber.TabIndex = 1;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(12, 40);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(82, 22);
            this.tbSecondNumber.TabIndex = 2;
            this.tbSecondNumber.TextChanged += new System.EventHandler(this.tbSecondNumber_TextChanged);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(12, 109);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(82, 35);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(12, 150);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(82, 35);
            this.btMult.TabIndex = 4;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(12, 191);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(82, 35);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.Controls.Add(this.btnAnswer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
    }
}

