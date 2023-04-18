using System;

namespace adventureGame
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
            this.textOutput = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.Location = new System.Drawing.Point(356, 104);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(291, 180);
            this.textOutput.TabIndex = 0;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.White;
            this.option1.FlatAppearance.BorderSize = 0;
            this.option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1.Location = new System.Drawing.Point(12, 298);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(304, 45);
            this.option1.TabIndex = 2;
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.White;
            this.option2.FlatAppearance.BorderSize = 0;
            this.option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2.Location = new System.Drawing.Point(343, 298);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(304, 45);
            this.option2.TabIndex = 3;
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.White;
            this.option3.FlatAppearance.BorderSize = 0;
            this.option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3.Location = new System.Drawing.Point(12, 349);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(304, 45);
            this.option3.TabIndex = 4;
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(635, 74);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Wendy\'s Bathroom";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Image = global::adventureGame.Properties.Resources.bathroom;
            this.imageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox.InitialImage")));
            this.imageBox.Location = new System.Drawing.Point(12, 104);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(304, 180);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 6;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(659, 406);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.textOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

