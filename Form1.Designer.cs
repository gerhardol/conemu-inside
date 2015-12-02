﻿namespace ConEmuInside
{
    partial class ChildTerminal
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
            this.termPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.macroBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.promptBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.termPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal";
            // 
            // termPanel
            // 
            this.termPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.termPanel.Location = new System.Drawing.Point(6, 19);
            this.termPanel.Name = "termPanel";
            this.termPanel.Size = new System.Drawing.Size(570, 313);
            this.termPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.macroBtn);
            this.groupBox2.Controls.Add(this.printBtn);
            this.groupBox2.Controls.Add(this.promptBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controlling box";
            // 
            // macroBtn
            // 
            this.macroBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.macroBtn.Location = new System.Drawing.Point(501, 17);
            this.macroBtn.Name = "macroBtn";
            this.macroBtn.Size = new System.Drawing.Size(75, 23);
            this.macroBtn.TabIndex = 2;
            this.macroBtn.Text = "Gui&Macro";
            this.macroBtn.UseVisualStyleBackColor = true;
            this.macroBtn.Click += new System.EventHandler(this.macroBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.printBtn.Location = new System.Drawing.Point(420, 17);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "&Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // promptBox
            // 
            this.promptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.promptBox.Location = new System.Drawing.Point(6, 19);
            this.promptBox.Name = "promptBox";
            this.promptBox.Size = new System.Drawing.Size(408, 20);
            this.promptBox.TabIndex = 0;
            this.promptBox.Enter += new System.EventHandler(this.promptBox_Enter);
            this.promptBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.promptBox_KeyDown);
            this.promptBox.Leave += new System.EventHandler(this.promptBox_Leave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChildTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChildTerminal";
            this.Text = "ConEmu Inside";
            this.Load += new System.EventHandler(this.ChildTerminal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel termPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button macroBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox promptBox;
        private System.Windows.Forms.Timer timer1;
    }
}

