namespace CodeReference
{
    partial class Form1
    {
        private RichTextBoxEx richTextBoxEx1;
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Homepage");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Code Snippets");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("C#", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Customization");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("BAQ\'s");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dashboards");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BPM\'s");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Epicor", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.richTextBoxEx1 = new CodeReference.RichTextBoxEx();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.addNodeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.heyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.canvas = new System.Windows.Forms.Panel();
            this.addLinkBtn = new System.Windows.Forms.Button();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.colorbtn = new System.Windows.Forms.Button();
            this.FontSizeCombo = new System.Windows.Forms.ComboBox();
            this.fontsizeComboLbl = new System.Windows.Forms.Label();
            this.formatBtn1 = new System.Windows.Forms.Button();
            this.mainRichTextBox = new CodeReference.RichTextBoxEx();
            this.saveNodeBtn = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.getRTFBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxEx1
            // 
            this.richTextBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxEx1.TabIndex = 0;
            this.richTextBoxEx1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchBox,
            this.addNodeBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 25);
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addNodeBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNodeBtn.Image")));
            this.addNodeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(65, 22);
            this.addNodeBtn.Text = "Add Node";
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton1.Text = "Delete Node";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heyToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // heyToolStripMenuItem
            // 
            this.heyToolStripMenuItem.Name = "heyToolStripMenuItem";
            this.heyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.heyToolStripMenuItem.Text = "hey :)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "8";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Name = "treeView";
            treeNode1.Name = "homeNode";
            treeNode1.Text = "Homepage";
            treeNode2.Name = "CodeSnippetNode";
            treeNode2.Text = "Code Snippets";
            treeNode3.Name = "Csharp";
            treeNode3.Text = "C#";
            treeNode4.Name = "GeneralNode";
            treeNode4.Text = "General";
            treeNode5.Name = "CustomizationNode";
            treeNode5.Text = "Customization";
            treeNode6.Name = "BAQNode";
            treeNode6.Text = "BAQ\'s";
            treeNode7.Name = "DashboardNode";
            treeNode7.Text = "Dashboards";
            treeNode8.Name = "BPMNode";
            treeNode8.Text = "BPM\'s";
            treeNode9.Name = "Epicor";
            treeNode9.Text = "Epicor";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode9});
            this.treeView.Size = new System.Drawing.Size(155, 437);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.getRTFBtn);
            this.canvas.Controls.Add(this.addLinkBtn);
            this.canvas.Controls.Add(this.underlineBtn);
            this.canvas.Controls.Add(this.colorbtn);
            this.canvas.Controls.Add(this.FontSizeCombo);
            this.canvas.Controls.Add(this.fontsizeComboLbl);
            this.canvas.Controls.Add(this.formatBtn1);
            this.canvas.Controls.Add(this.mainRichTextBox);
            this.canvas.Controls.Add(this.saveNodeBtn);
            this.canvas.Controls.Add(this.headerLabel);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(155, 25);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(829, 437);
            this.canvas.TabIndex = 3;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // addLinkBtn
            // 
            this.addLinkBtn.Location = new System.Drawing.Point(639, 19);
            this.addLinkBtn.Name = "addLinkBtn";
            this.addLinkBtn.Size = new System.Drawing.Size(49, 21);
            this.addLinkBtn.TabIndex = 9;
            this.addLinkBtn.Text = "Linkify";
            this.addLinkBtn.UseVisualStyleBackColor = true;
            this.addLinkBtn.Click += new System.EventHandler(this.addLinkBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.Location = new System.Drawing.Point(517, 19);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(60, 21);
            this.underlineBtn.TabIndex = 8;
            this.underlineBtn.Text = "Underline";
            this.underlineBtn.UseVisualStyleBackColor = true;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // colorbtn
            // 
            this.colorbtn.Location = new System.Drawing.Point(583, 19);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(50, 21);
            this.colorbtn.TabIndex = 7;
            this.colorbtn.Text = "Color";
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // FontSizeCombo
            // 
            this.FontSizeCombo.FormattingEnabled = true;
            this.FontSizeCombo.Items.AddRange(new object[] {
            "8.5",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.FontSizeCombo.Location = new System.Drawing.Point(405, 19);
            this.FontSizeCombo.Name = "FontSizeCombo";
            this.FontSizeCombo.Size = new System.Drawing.Size(50, 21);
            this.FontSizeCombo.TabIndex = 5;
            this.FontSizeCombo.SelectionChangeCommitted += new System.EventHandler(this.FontSizeCombo_SelectionChangeCommitted);
            // 
            // fontsizeComboLbl
            // 
            this.fontsizeComboLbl.AutoSize = true;
            this.fontsizeComboLbl.Location = new System.Drawing.Point(354, 22);
            this.fontsizeComboLbl.Name = "fontsizeComboLbl";
            this.fontsizeComboLbl.Size = new System.Drawing.Size(54, 13);
            this.fontsizeComboLbl.TabIndex = 6;
            this.fontsizeComboLbl.Text = "Font Size:";
            // 
            // formatBtn1
            // 
            this.formatBtn1.Location = new System.Drawing.Point(461, 19);
            this.formatBtn1.Name = "formatBtn1";
            this.formatBtn1.Size = new System.Drawing.Size(50, 21);
            this.formatBtn1.TabIndex = 4;
            this.formatBtn1.Text = "Bold";
            this.formatBtn1.UseVisualStyleBackColor = true;
            this.formatBtn1.Click += new System.EventHandler(this.formatBtn1_Click);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.AcceptsTab = true;
            this.mainRichTextBox.HideSelection = false;
            this.mainRichTextBox.Location = new System.Drawing.Point(12, 43);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(805, 385);
            this.mainRichTextBox.TabIndex = 3;
            this.mainRichTextBox.Text = "";
            this.mainRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.mainRichTextBox_LinkClicked);
            // 
            // saveNodeBtn
            // 
            this.saveNodeBtn.Location = new System.Drawing.Point(717, 9);
            this.saveNodeBtn.Name = "saveNodeBtn";
            this.saveNodeBtn.Size = new System.Drawing.Size(100, 31);
            this.saveNodeBtn.TabIndex = 2;
            this.saveNodeBtn.Text = "Save Node";
            this.saveNodeBtn.UseVisualStyleBackColor = true;
            this.saveNodeBtn.Click += new System.EventHandler(this.saveNodeBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(6, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(86, 31);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "label1";
            // 
            // getRTFBtn
            // 
            this.getRTFBtn.Location = new System.Drawing.Point(236, 18);
            this.getRTFBtn.Name = "getRTFBtn";
            this.getRTFBtn.Size = new System.Drawing.Size(75, 23);
            this.getRTFBtn.TabIndex = 10;
            this.getRTFBtn.Text = "Show RTF";
            this.getRTFBtn.UseVisualStyleBackColor = true;
            this.getRTFBtn.Click += new System.EventHandler(this.getRTFBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ToolStripButton addNodeBtn;
        private System.Windows.Forms.Button saveNodeBtn;
        //private System.Windows.Forms.RichTextBox mainRichTextBox;
        private RichTextBoxEx mainRichTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button formatBtn1;
        private System.Windows.Forms.ComboBox FontSizeCombo;
        private System.Windows.Forms.Label fontsizeComboLbl;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.Button addLinkBtn;
        private System.Windows.Forms.Button getRTFBtn;
    }
}

