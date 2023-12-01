namespace Lottery_Picker
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
            this.titlelable = new System.Windows.Forms.Label();
            this.instructionlable = new System.Windows.Forms.Label();
            this.outputlable = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelable
            // 
            this.titlelable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlelable.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.Location = new System.Drawing.Point(0, 0);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(801, 78);
            this.titlelable.TabIndex = 0;
            this.titlelable.Text = "Lottery Picker ";
            this.titlelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionlable
            // 
            this.instructionlable.BackColor = System.Drawing.Color.Gray;
            this.instructionlable.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionlable.ForeColor = System.Drawing.Color.White;
            this.instructionlable.Location = new System.Drawing.Point(237, 102);
            this.instructionlable.Name = "instructionlable";
            this.instructionlable.Size = new System.Drawing.Size(304, 69);
            this.instructionlable.TabIndex = 1;
            this.instructionlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputlable
            // 
            this.outputlable.BackColor = System.Drawing.Color.Transparent;
            this.outputlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlable.ForeColor = System.Drawing.Color.White;
            this.outputlable.Location = new System.Drawing.Point(130, 301);
            this.outputlable.Name = "outputlable";
            this.outputlable.Size = new System.Drawing.Size(542, 67);
            this.outputlable.TabIndex = 2;
            this.outputlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(332, 209);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(114, 46);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generate ";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.outputlable);
            this.Controls.Add(this.instructionlable);
            this.Controls.Add(this.titlelable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Label instructionlable;
        private System.Windows.Forms.Label outputlable;
        private System.Windows.Forms.Button Generate;
    }
}

