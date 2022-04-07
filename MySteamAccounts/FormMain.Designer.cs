namespace MySteamAccounts
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.contextMenuStripListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.contextMenuStripListBox.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.listBoxAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAccounts.ContextMenuStrip = this.contextMenuStripListBox;
            this.listBoxAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAccounts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 25;
            this.listBoxAccounts.Location = new System.Drawing.Point(12, 12);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(166, 352);
            this.listBoxAccounts.TabIndex = 0;
            this.listBoxAccounts.Click += new System.EventHandler(this.listBoxAccounts_Click);
            this.listBoxAccounts.DoubleClick += new System.EventHandler(this.listBoxAccounts_DoubleClick);
            // 
            // contextMenuStripListBox
            // 
            this.contextMenuStripListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.contextMenuStripListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contextMenuStripListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.startSteamToolStripMenuItem});
            this.contextMenuStripListBox.Name = "contextMenuStripListBox";
            this.contextMenuStripListBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripListBox.ShowImageMargin = false;
            this.contextMenuStripListBox.Size = new System.Drawing.Size(140, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // startSteamToolStripMenuItem
            // 
            this.startSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startSteamToolStripMenuItem.Name = "startSteamToolStripMenuItem";
            this.startSteamToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.startSteamToolStripMenuItem.Text = "Start Steam";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(13, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInformation.Controls.Add(this.textBoxInformation);
            this.groupBoxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxInformation.Location = new System.Drawing.Point(213, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(300, 351);
            this.groupBoxInformation.TabIndex = 2;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInformation.Location = new System.Drawing.Point(7, 27);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.Size = new System.Drawing.Size(287, 308);
            this.textBoxInformation.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(534, 431);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "My Steam Accounts";
            this.contextMenuStripListBox.ResumeLayout(false);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListBox;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

