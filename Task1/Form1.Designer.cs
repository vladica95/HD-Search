namespace Task1
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
            this.lbxDrives = new System.Windows.Forms.ListBox();
            this.lblDriveInfo = new System.Windows.Forms.Label();
            this.txtDriveInfo = new System.Windows.Forms.TextBox();
            this.tvTree = new System.Windows.Forms.TreeView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.btnFileFilter = new System.Windows.Forms.Button();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.txtItemAttribute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxDrives
            // 
            this.lbxDrives.FormattingEnabled = true;
            this.lbxDrives.Location = new System.Drawing.Point(12, 12);
            this.lbxDrives.Name = "lbxDrives";
            this.lbxDrives.Size = new System.Drawing.Size(151, 82);
            this.lbxDrives.TabIndex = 0;
            this.lbxDrives.SelectedIndexChanged += new System.EventHandler(this.lbxDrives_SelectedIndexChanged);
            // 
            // lblDriveInfo
            // 
            this.lblDriveInfo.AutoSize = true;
            this.lblDriveInfo.Location = new System.Drawing.Point(182, 15);
            this.lblDriveInfo.Name = "lblDriveInfo";
            this.lblDriveInfo.Size = new System.Drawing.Size(64, 26);
            this.lblDriveInfo.TabIndex = 1;
            this.lblDriveInfo.Text = "Drive\r\ninformation :";
            // 
            // txtDriveInfo
            // 
            this.txtDriveInfo.AcceptsTab = true;
            this.txtDriveInfo.Location = new System.Drawing.Point(252, 12);
            this.txtDriveInfo.Multiline = true;
            this.txtDriveInfo.Name = "txtDriveInfo";
            this.txtDriveInfo.ReadOnly = true;
            this.txtDriveInfo.Size = new System.Drawing.Size(214, 36);
            this.txtDriveInfo.TabIndex = 2;
            // 
            // tvTree
            // 
            this.tvTree.Location = new System.Drawing.Point(12, 100);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(151, 123);
            this.tvTree.TabIndex = 3;
            this.tvTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTree_AfterSelect);
            this.tvTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTree_NodeMouseDoubleClick);
            // 
            // txtItemName
            // 
            this.txtItemName.AcceptsReturn = true;
            this.txtItemName.AcceptsTab = true;
            this.txtItemName.Location = new System.Drawing.Point(252, 54);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemName.Size = new System.Drawing.Size(214, 59);
            this.txtItemName.TabIndex = 4;
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Location = new System.Drawing.Point(182, 100);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(52, 26);
            this.lblItemInfo.TabIndex = 5;
            this.lblItemInfo.Text = "Selected \r\nitem info :";
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(182, 182);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(52, 13);
            this.lblFileType.TabIndex = 6;
            this.lblFileType.Text = "File type :";
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(252, 179);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(81, 20);
            this.txtFileType.TabIndex = 7;
            // 
            // btnFileFilter
            // 
            this.btnFileFilter.Location = new System.Drawing.Point(362, 168);
            this.btnFileFilter.Name = "btnFileFilter";
            this.btnFileFilter.Size = new System.Drawing.Size(104, 31);
            this.btnFileFilter.TabIndex = 8;
            this.btnFileFilter.Text = "Use filter";
            this.btnFileFilter.UseVisualStyleBackColor = true;
            this.btnFileFilter.Click += new System.EventHandler(this.btnFileFilter_Click);
            // 
            // txtItemSize
            // 
            this.txtItemSize.AcceptsReturn = true;
            this.txtItemSize.AcceptsTab = true;
            this.txtItemSize.Location = new System.Drawing.Point(252, 110);
            this.txtItemSize.Multiline = true;
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.ReadOnly = true;
            this.txtItemSize.Size = new System.Drawing.Size(214, 28);
            this.txtItemSize.TabIndex = 9;
            // 
            // txtItemAttribute
            // 
            this.txtItemAttribute.AcceptsReturn = true;
            this.txtItemAttribute.AcceptsTab = true;
            this.txtItemAttribute.Location = new System.Drawing.Point(252, 135);
            this.txtItemAttribute.Multiline = true;
            this.txtItemAttribute.Name = "txtItemAttribute";
            this.txtItemAttribute.ReadOnly = true;
            this.txtItemAttribute.Size = new System.Drawing.Size(214, 27);
            this.txtItemAttribute.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please be patient while tree is loaded.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemAttribute);
            this.Controls.Add(this.txtItemSize);
            this.Controls.Add(this.btnFileFilter);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.lblFileType);
            this.Controls.Add(this.lblItemInfo);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.tvTree);
            this.Controls.Add(this.txtDriveInfo);
            this.Controls.Add(this.lblDriveInfo);
            this.Controls.Add(this.lbxDrives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDrives;
        private System.Windows.Forms.Label lblDriveInfo;
        private System.Windows.Forms.TextBox txtDriveInfo;
        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Button btnFileFilter;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.TextBox txtItemAttribute;
        private System.Windows.Forms.Label label1;
    }
}

