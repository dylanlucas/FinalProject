namespace M4HW1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attackDamageDisplayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oppFDLabel = new System.Windows.Forms.Label();
            this.oppADLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.npcADLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.npcFDDisplay = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.displayRTB = new System.Windows.Forms.RichTextBox();
            this.healthDisplayLabel = new System.Windows.Forms.Label();
            this.oppHealthLabel = new System.Windows.Forms.Label();
            this.npcHealthDisplay = new System.Windows.Forms.Label();
            this.playerStatusRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attack Damage :";
            // 
            // attackDamageDisplayLabel
            // 
            this.attackDamageDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attackDamageDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackDamageDisplayLabel.Location = new System.Drawing.Point(154, 93);
            this.attackDamageDisplayLabel.Name = "attackDamageDisplayLabel";
            this.attackDamageDisplayLabel.Size = new System.Drawing.Size(165, 30);
            this.attackDamageDisplayLabel.TabIndex = 5;
            this.attackDamageDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(651, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Opponent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Health :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Attack Damage :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Faction :";
            // 
            // oppFDLabel
            // 
            this.oppFDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oppFDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppFDLabel.Location = new System.Drawing.Point(730, 136);
            this.oppFDLabel.Name = "oppFDLabel";
            this.oppFDLabel.Size = new System.Drawing.Size(165, 30);
            this.oppFDLabel.TabIndex = 11;
            this.oppFDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppADLabel
            // 
            this.oppADLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oppADLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppADLabel.Location = new System.Drawing.Point(730, 93);
            this.oppADLabel.Name = "oppADLabel";
            this.oppADLabel.Size = new System.Drawing.Size(165, 30);
            this.oppADLabel.TabIndex = 12;
            this.oppADLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "NPC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Health :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Attack Damage :";
            // 
            // npcADLabel
            // 
            this.npcADLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcADLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcADLabel.Location = new System.Drawing.Point(138, 415);
            this.npcADLabel.Name = "npcADLabel";
            this.npcADLabel.Size = new System.Drawing.Size(165, 30);
            this.npcADLabel.TabIndex = 18;
            this.npcADLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Faction : ";
            // 
            // npcFDDisplay
            // 
            this.npcFDDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcFDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcFDDisplay.Location = new System.Drawing.Point(138, 475);
            this.npcFDDisplay.Name = "npcFDDisplay";
            this.npcFDDisplay.Size = new System.Drawing.Size(165, 30);
            this.npcFDDisplay.TabIndex = 20;
            this.npcFDDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(396, 259);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(103, 41);
            this.attackButton.TabIndex = 21;
            this.attackButton.Text = "ATTACK";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // displayRTB
            // 
            this.displayRTB.Location = new System.Drawing.Point(605, 328);
            this.displayRTB.Name = "displayRTB";
            this.displayRTB.ReadOnly = true;
            this.displayRTB.Size = new System.Drawing.Size(290, 227);
            this.displayRTB.TabIndex = 22;
            this.displayRTB.Text = "";
            // 
            // healthDisplayLabel
            // 
            this.healthDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthDisplayLabel.Location = new System.Drawing.Point(154, 50);
            this.healthDisplayLabel.Name = "healthDisplayLabel";
            this.healthDisplayLabel.Size = new System.Drawing.Size(165, 30);
            this.healthDisplayLabel.TabIndex = 23;
            this.healthDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppHealthLabel
            // 
            this.oppHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oppHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppHealthLabel.Location = new System.Drawing.Point(730, 43);
            this.oppHealthLabel.Name = "oppHealthLabel";
            this.oppHealthLabel.Size = new System.Drawing.Size(165, 30);
            this.oppHealthLabel.TabIndex = 24;
            this.oppHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcHealthDisplay
            // 
            this.npcHealthDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcHealthDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcHealthDisplay.Location = new System.Drawing.Point(138, 357);
            this.npcHealthDisplay.Name = "npcHealthDisplay";
            this.npcHealthDisplay.Size = new System.Drawing.Size(165, 30);
            this.npcHealthDisplay.TabIndex = 25;
            this.npcHealthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerStatusRTB
            // 
            this.playerStatusRTB.Location = new System.Drawing.Point(154, 143);
            this.playerStatusRTB.Name = "playerStatusRTB";
            this.playerStatusRTB.ReadOnly = true;
            this.playerStatusRTB.Size = new System.Drawing.Size(165, 81);
            this.playerStatusRTB.TabIndex = 26;
            this.playerStatusRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Player Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerStatusRTB);
            this.Controls.Add(this.npcHealthDisplay);
            this.Controls.Add(this.oppHealthLabel);
            this.Controls.Add(this.healthDisplayLabel);
            this.Controls.Add(this.displayRTB);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.npcFDDisplay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.npcADLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.oppADLabel);
            this.Controls.Add(this.oppFDLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attackDamageDisplayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attackDamageDisplayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label oppFDLabel;
        private System.Windows.Forms.Label oppADLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label npcADLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label npcFDDisplay;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.RichTextBox displayRTB;
        private System.Windows.Forms.Label healthDisplayLabel;
        private System.Windows.Forms.Label oppHealthLabel;
        private System.Windows.Forms.Label npcHealthDisplay;
        private System.Windows.Forms.RichTextBox playerStatusRTB;
        private System.Windows.Forms.Label label4;
    }
}

