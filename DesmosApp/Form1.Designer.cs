namespace DesmosApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GoBtn = new System.Windows.Forms.Button();
            this.inputFunctionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphImgBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBtn
            // 
            this.GoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.GoBtn.FlatAppearance.BorderSize = 0;
            this.GoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBtn.ForeColor = System.Drawing.Color.White;
            this.GoBtn.Location = new System.Drawing.Point(531, 603);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(93, 31);
            this.GoBtn.TabIndex = 0;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = false;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // inputFunctionBox
            // 
            this.inputFunctionBox.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFunctionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.inputFunctionBox.Location = new System.Drawing.Point(241, 603);
            this.inputFunctionBox.Name = "inputFunctionBox";
            this.inputFunctionBox.Size = new System.Drawing.Size(244, 31);
            this.inputFunctionBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(305, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dansmos";
            // 
            // graphImgBox
            // 
            this.graphImgBox.Image = global::DesmosApp.Properties.Resources.white;
            this.graphImgBox.Location = new System.Drawing.Point(158, 68);
            this.graphImgBox.Margin = new System.Windows.Forms.Padding(0);
            this.graphImgBox.Name = "graphImgBox";
            this.graphImgBox.Size = new System.Drawing.Size(500, 500);
            this.graphImgBox.TabIndex = 2;
            this.graphImgBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(194, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "y = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphImgBox);
            this.Controls.Add(this.inputFunctionBox);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dansmos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox inputFunctionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox graphImgBox;
        private System.Windows.Forms.Label label2;
    }
}

