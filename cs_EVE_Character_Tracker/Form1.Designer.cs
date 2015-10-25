namespace cs_EVE_Character_Tracker
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSkill31 = new System.Windows.Forms.TextBox();
            this.txbTraining31 = new System.Windows.Forms.TextBox();
            this.txbWallet31 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSkill32 = new System.Windows.Forms.TextBox();
            this.txbTraining32 = new System.Windows.Forms.TextBox();
            this.txbWallet32 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSkillFThis = new System.Windows.Forms.TextBox();
            this.txbTrainingFThis = new System.Windows.Forms.TextBox();
            this.txbWalletFThis = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txbNextPull = new System.Windows.Forms.TextBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.timerAPICall = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbSkill31);
            this.groupBox1.Controls.Add(this.txbTraining31);
            this.groupBox1.Controls.Add(this.txbWallet31);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thirtyone Organism";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skill:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Training Ends:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wallet:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbSkill31
            // 
            this.txbSkill31.Location = new System.Drawing.Point(87, 13);
            this.txbSkill31.Name = "txbSkill31";
            this.txbSkill31.ReadOnly = true;
            this.txbSkill31.Size = new System.Drawing.Size(269, 20);
            this.txbSkill31.TabIndex = 4;
            // 
            // txbTraining31
            // 
            this.txbTraining31.Location = new System.Drawing.Point(87, 39);
            this.txbTraining31.Name = "txbTraining31";
            this.txbTraining31.ReadOnly = true;
            this.txbTraining31.Size = new System.Drawing.Size(269, 20);
            this.txbTraining31.TabIndex = 5;
            // 
            // txbWallet31
            // 
            this.txbWallet31.Location = new System.Drawing.Point(87, 65);
            this.txbWallet31.Name = "txbWallet31";
            this.txbWallet31.ReadOnly = true;
            this.txbWallet31.Size = new System.Drawing.Size(269, 20);
            this.txbWallet31.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbSkill32);
            this.groupBox2.Controls.Add(this.txbTraining32);
            this.groupBox2.Controls.Add(this.txbWallet32);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thirtytwo Organism";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skill:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Training Ends:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wallet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbSkill32
            // 
            this.txbSkill32.Location = new System.Drawing.Point(87, 13);
            this.txbSkill32.Name = "txbSkill32";
            this.txbSkill32.ReadOnly = true;
            this.txbSkill32.Size = new System.Drawing.Size(269, 20);
            this.txbSkill32.TabIndex = 10;
            // 
            // txbTraining32
            // 
            this.txbTraining32.Location = new System.Drawing.Point(87, 39);
            this.txbTraining32.Name = "txbTraining32";
            this.txbTraining32.ReadOnly = true;
            this.txbTraining32.Size = new System.Drawing.Size(269, 20);
            this.txbTraining32.TabIndex = 11;
            // 
            // txbWallet32
            // 
            this.txbWallet32.Location = new System.Drawing.Point(87, 65);
            this.txbWallet32.Name = "txbWallet32";
            this.txbWallet32.ReadOnly = true;
            this.txbWallet32.Size = new System.Drawing.Size(269, 20);
            this.txbWallet32.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbSkillFThis);
            this.groupBox3.Controls.Add(this.txbTrainingFThis);
            this.groupBox3.Controls.Add(this.txbWalletFThis);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "F This";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Skill:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Training Ends:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wallet:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbSkillFThis
            // 
            this.txbSkillFThis.Location = new System.Drawing.Point(87, 12);
            this.txbSkillFThis.Name = "txbSkillFThis";
            this.txbSkillFThis.ReadOnly = true;
            this.txbSkillFThis.Size = new System.Drawing.Size(269, 20);
            this.txbSkillFThis.TabIndex = 10;
            // 
            // txbTrainingFThis
            // 
            this.txbTrainingFThis.Location = new System.Drawing.Point(87, 38);
            this.txbTrainingFThis.Name = "txbTrainingFThis";
            this.txbTrainingFThis.ReadOnly = true;
            this.txbTrainingFThis.Size = new System.Drawing.Size(269, 20);
            this.txbTrainingFThis.TabIndex = 11;
            // 
            // txbWalletFThis
            // 
            this.txbWalletFThis.Location = new System.Drawing.Point(87, 64);
            this.txbWalletFThis.Name = "txbWalletFThis";
            this.txbWalletFThis.ReadOnly = true;
            this.txbWalletFThis.Size = new System.Drawing.Size(269, 20);
            this.txbWalletFThis.TabIndex = 12;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(156, 300);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txbNextPull
            // 
            this.txbNextPull.Location = new System.Drawing.Point(12, 353);
            this.txbNextPull.Name = "txbNextPull";
            this.txbNextPull.ReadOnly = true;
            this.txbNextPull.Size = new System.Drawing.Size(362, 20);
            this.txbNextPull.TabIndex = 2;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(12, 327);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(362, 20);
            this.txbStatus.TabIndex = 3;
            // 
            // timerAPICall
            // 
            this.timerAPICall.Tick += new System.EventHandler(this.timerAPICall_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 385);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.txbNextPull);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "EVE Character Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSkill31;
        private System.Windows.Forms.TextBox txbTraining31;
        private System.Windows.Forms.TextBox txbWallet31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSkill32;
        private System.Windows.Forms.TextBox txbTraining32;
        private System.Windows.Forms.TextBox txbWallet32;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSkillFThis;
        private System.Windows.Forms.TextBox txbTrainingFThis;
        private System.Windows.Forms.TextBox txbWalletFThis;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txbNextPull;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Timer timerAPICall;
    }
}

