namespace CrapsGame
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblDie1Title = new System.Windows.Forms.Label();
            this.lblDie2Result = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(179, 151);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(0, 13);
            this.lblDie1.TabIndex = 0;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(291, 151);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(0, 13);
            this.lblDie2.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(104, 308);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(97, 17);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: $100";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(104, 249);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 31);
            this.lblResults.TabIndex = 3;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(104, 43);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(166, 29);
            this.txtBet.TabIndex = 4;
            this.txtBet.Text = "Enter your bet";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(104, 78);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 30);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblDie1Title
            // 
            this.lblDie1Title.AutoSize = true;
            this.lblDie1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1Title.Location = new System.Drawing.Point(101, 115);
            this.lblDie1Title.Name = "lblDie1Title";
            this.lblDie1Title.Size = new System.Drawing.Size(141, 25);
            this.lblDie1Title.TabIndex = 6;
            this.lblDie1Title.Text = "Die 1 Result";
            this.lblDie1Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDie2Result
            // 
            this.lblDie2Result.AutoSize = true;
            this.lblDie2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2Result.Location = new System.Drawing.Point(236, 115);
            this.lblDie2Result.Name = "lblDie2Result";
            this.lblDie2Result.Size = new System.Drawing.Size(141, 25);
            this.lblDie2Result.TabIndex = 7;
            this.lblDie2Result.Text = "Die 2 Result";
            this.lblDie2Result.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.Location = new System.Drawing.Point(104, 216);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(159, 25);
            this.lblGameResult.TabIndex = 8;
            this.lblGameResult.Text = "Game Results\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 389);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblDie2Result);
            this.Controls.Add(this.lblDie1Title);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblDie1Title;
        private System.Windows.Forms.Label lblDie2Result;
        private System.Windows.Forms.Label lblGameResult;
    }
}

