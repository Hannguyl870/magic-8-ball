namespace magic_8_ball
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
            this.Titlelable = new System.Windows.Forms.Label();
            this.shakebutton = new System.Windows.Forms.Button();
            this.answeroutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelable
            // 
            this.Titlelable.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelable.Location = new System.Drawing.Point(254, 27);
            this.Titlelable.Name = "Titlelable";
            this.Titlelable.Size = new System.Drawing.Size(363, 50);
            this.Titlelable.TabIndex = 0;
            this.Titlelable.Text = "Think of a question";
            this.Titlelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shakebutton
            // 
            this.shakebutton.BackColor = System.Drawing.Color.Teal;
            this.shakebutton.Image = global::magic_8_ball.Properties.Resources.clickBall;
            this.shakebutton.Location = new System.Drawing.Point(191, 95);
            this.shakebutton.Name = "shakebutton";
            this.shakebutton.Size = new System.Drawing.Size(505, 530);
            this.shakebutton.TabIndex = 1;
            this.shakebutton.UseVisualStyleBackColor = false;
            this.shakebutton.Click += new System.EventHandler(this.shakebutton_Click);
            // 
            // answeroutput
            // 
            this.answeroutput.Location = new System.Drawing.Point(281, 654);
            this.answeroutput.Name = "answeroutput";
            this.answeroutput.Size = new System.Drawing.Size(317, 50);
            this.answeroutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(926, 755);
            this.Controls.Add(this.answeroutput);
            this.Controls.Add(this.shakebutton);
            this.Controls.Add(this.Titlelable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlelable;
        private System.Windows.Forms.Button shakebutton;
        private System.Windows.Forms.Label answeroutput;
    }
}

