namespace Good_News_Bot_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusLabelCurrent = new System.Windows.Forms.Label();
            this.NotifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifCB = new System.Windows.Forms.CheckBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.startStopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 13);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusLabelCurrent
            // 
            this.StatusLabelCurrent.AutoSize = true;
            this.StatusLabelCurrent.Location = new System.Drawing.Point(50, 13);
            this.StatusLabelCurrent.Name = "StatusLabelCurrent";
            this.StatusLabelCurrent.Size = new System.Drawing.Size(47, 13);
            this.StatusLabelCurrent.TabIndex = 1;
            this.StatusLabelCurrent.Text = "Stopped";
            // 
            // NotifIcon
            // 
            this.NotifIcon.ContextMenuStrip = this.NotifContextMenu;
            this.NotifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifIcon.Icon")));
            this.NotifIcon.Text = "Good News Bot UI";
            this.NotifIcon.Visible = true;
            this.NotifIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifIcon_MouseDoubleClick);
            // 
            // NotifContextMenu
            // 
            this.NotifContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopMenu,
            this.exitMenu});
            this.NotifContextMenu.Name = "NotifContextMenu";
            this.NotifContextMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // NotifCB
            // 
            this.NotifCB.AutoSize = true;
            this.NotifCB.Location = new System.Drawing.Point(16, 38);
            this.NotifCB.Name = "NotifCB";
            this.NotifCB.Size = new System.Drawing.Size(120, 17);
            this.NotifCB.TabIndex = 4;
            this.NotifCB.Text = "Enable Notifications";
            this.NotifCB.UseVisualStyleBackColor = true;
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(87, 76);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(75, 23);
            this.MainButton.TabIndex = 5;
            this.MainButton.Text = "Start";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click_1);
            // 
            // startStopMenu
            // 
            this.startStopMenu.Name = "startStopMenu";
            this.startStopMenu.Size = new System.Drawing.Size(152, 22);
            this.startStopMenu.Text = "Start";
            this.startStopMenu.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 111);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.NotifCB);
            this.Controls.Add(this.StatusLabelCurrent);
            this.Controls.Add(this.StatusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Good News Bot UI";
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.NotifContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusLabelCurrent;
        private System.Windows.Forms.NotifyIcon NotifIcon;
        private System.Windows.Forms.CheckBox NotifCB;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.ContextMenuStrip NotifContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem startStopMenu;
    }
}

