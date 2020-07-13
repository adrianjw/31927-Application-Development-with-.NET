namespace Assignment_2 {
    partial class TextEditorWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.userLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.leftToolStrip = new System.Windows.Forms.ToolStrip();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.topToolStrip.SuspendLayout();
            this.leftToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStripTab,
            this.editMenuStripTab,
            this.fontMenuStripTab,
            this.helpMenuStripTab});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(990, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuStripTab
            // 
            this.fileMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuStripItem,
            this.openMenuStripItem,
            this.toolStripSeparator1,
            this.saveMenuStripItem,
            this.saveAsMenuStripItem,
            this.toolStripSeparator2,
            this.logOutMenuStripItem});
            this.fileMenuStripTab.Name = "fileMenuStripTab";
            this.fileMenuStripTab.Size = new System.Drawing.Size(37, 20);
            this.fileMenuStripTab.Text = "File";
            // 
            // newMenuStripItem
            // 
            this.newMenuStripItem.Image = global::Assignment_2.Properties.Resources.new_icon;
            this.newMenuStripItem.Name = "newMenuStripItem";
            this.newMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuStripItem.Size = new System.Drawing.Size(195, 22);
            this.newMenuStripItem.Text = "New";
            this.newMenuStripItem.Click += new System.EventHandler(this.NewMenuStripItem_Click);
            // 
            // openMenuStripItem
            // 
            this.openMenuStripItem.Image = global::Assignment_2.Properties.Resources.open_icon;
            this.openMenuStripItem.Name = "openMenuStripItem";
            this.openMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuStripItem.Size = new System.Drawing.Size(195, 22);
            this.openMenuStripItem.Text = "Open...";
            this.openMenuStripItem.Click += new System.EventHandler(this.OpenMenuStripItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // saveMenuStripItem
            // 
            this.saveMenuStripItem.Image = global::Assignment_2.Properties.Resources.save_icon;
            this.saveMenuStripItem.Name = "saveMenuStripItem";
            this.saveMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuStripItem.Size = new System.Drawing.Size(195, 22);
            this.saveMenuStripItem.Text = "Save";
            this.saveMenuStripItem.Click += new System.EventHandler(this.SaveMenuStripItem_Click);
            // 
            // saveAsMenuStripItem
            // 
            this.saveAsMenuStripItem.Image = global::Assignment_2.Properties.Resources.save_as_icon;
            this.saveAsMenuStripItem.Name = "saveAsMenuStripItem";
            this.saveAsMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuStripItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsMenuStripItem.Text = "Save As...";
            this.saveAsMenuStripItem.Click += new System.EventHandler(this.SaveAsMenuStripItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // logOutMenuStripItem
            // 
            this.logOutMenuStripItem.Image = global::Assignment_2.Properties.Resources.logout_icon;
            this.logOutMenuStripItem.Name = "logOutMenuStripItem";
            this.logOutMenuStripItem.Size = new System.Drawing.Size(195, 22);
            this.logOutMenuStripItem.Text = "Log Out";
            this.logOutMenuStripItem.Click += new System.EventHandler(this.LogOutMenuStripItem_Click);
            // 
            // editMenuStripTab
            // 
            this.editMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuStripItem,
            this.copyMenuStripItem,
            this.pasteMenuStripItem});
            this.editMenuStripTab.Name = "editMenuStripTab";
            this.editMenuStripTab.Size = new System.Drawing.Size(39, 20);
            this.editMenuStripTab.Text = "Edit";
            // 
            // cutMenuStripItem
            // 
            this.cutMenuStripItem.Image = global::Assignment_2.Properties.Resources.cut_icon;
            this.cutMenuStripItem.Name = "cutMenuStripItem";
            this.cutMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuStripItem.Size = new System.Drawing.Size(144, 22);
            this.cutMenuStripItem.Text = "Cut";
            this.cutMenuStripItem.Click += new System.EventHandler(this.CutMenuStripItem_Click);
            // 
            // copyMenuStripItem
            // 
            this.copyMenuStripItem.Image = global::Assignment_2.Properties.Resources.copy_icon;
            this.copyMenuStripItem.Name = "copyMenuStripItem";
            this.copyMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuStripItem.Size = new System.Drawing.Size(144, 22);
            this.copyMenuStripItem.Text = "Copy";
            this.copyMenuStripItem.Click += new System.EventHandler(this.CopyMenuStripItem_Click);
            // 
            // pasteMenuStripItem
            // 
            this.pasteMenuStripItem.Image = global::Assignment_2.Properties.Resources.paste_icon;
            this.pasteMenuStripItem.Name = "pasteMenuStripItem";
            this.pasteMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuStripItem.Size = new System.Drawing.Size(144, 22);
            this.pasteMenuStripItem.Text = "Paste";
            this.pasteMenuStripItem.Click += new System.EventHandler(this.PasteMenuStripItem_Click);
            // 
            // fontMenuStripTab
            // 
            this.fontMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuStripItem,
            this.boldMenuStripItem,
            this.italicMenuStripItem,
            this.underlineMenuStripItem});
            this.fontMenuStripTab.Name = "fontMenuStripTab";
            this.fontMenuStripTab.Size = new System.Drawing.Size(43, 20);
            this.fontMenuStripTab.Text = "Font";
            // 
            // fontMenuStripItem
            // 
            this.fontMenuStripItem.Name = "fontMenuStripItem";
            this.fontMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.fontMenuStripItem.Text = "Font...";
            this.fontMenuStripItem.Click += new System.EventHandler(this.FontMenuStripItem_Click);
            // 
            // boldMenuStripItem
            // 
            this.boldMenuStripItem.Image = global::Assignment_2.Properties.Resources.bold_icon;
            this.boldMenuStripItem.Name = "boldMenuStripItem";
            this.boldMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.boldMenuStripItem.Text = "Bold";
            this.boldMenuStripItem.Click += new System.EventHandler(this.BoldMenuStripItem_Click);
            // 
            // italicMenuStripItem
            // 
            this.italicMenuStripItem.Image = global::Assignment_2.Properties.Resources.italic_icon;
            this.italicMenuStripItem.Name = "italicMenuStripItem";
            this.italicMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.italicMenuStripItem.Text = "Italic";
            this.italicMenuStripItem.Click += new System.EventHandler(this.ItalicMenuStripItem_Click);
            // 
            // underlineMenuStripItem
            // 
            this.underlineMenuStripItem.Image = global::Assignment_2.Properties.Resources.underline_icon;
            this.underlineMenuStripItem.Name = "underlineMenuStripItem";
            this.underlineMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineMenuStripItem.Size = new System.Drawing.Size(167, 22);
            this.underlineMenuStripItem.Text = "Underline";
            this.underlineMenuStripItem.Click += new System.EventHandler(this.UnderlineMenuStripItem_Click);
            // 
            // helpMenuStripTab
            // 
            this.helpMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuStripItem});
            this.helpMenuStripTab.Name = "helpMenuStripTab";
            this.helpMenuStripTab.Size = new System.Drawing.Size(44, 20);
            this.helpMenuStripTab.Text = "Help";
            // 
            // aboutMenuStripItem
            // 
            this.aboutMenuStripItem.Name = "aboutMenuStripItem";
            this.aboutMenuStripItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuStripItem.Text = "About";
            this.aboutMenuStripItem.Click += new System.EventHandler(this.AboutMenuStripItem_Click);
            // 
            // topToolStrip
            // 
            this.topToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.saveAsToolStripButton,
            this.toolStripSeparator3,
            this.boldToolStripButton,
            this.italicToolStripButton,
            this.underlineToolStripButton,
            this.userLabel,
            this.fontSizeComboBox});
            this.topToolStrip.Location = new System.Drawing.Point(0, 24);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(990, 27);
            this.topToolStrip.TabIndex = 1;
            this.topToolStrip.Text = "topToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::Assignment_2.Properties.Resources.new_icon;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "New File";
            this.newToolStripButton.Click += new System.EventHandler(this.NewMenuStripItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::Assignment_2.Properties.Resources.open_icon;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "Open File";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenMenuStripItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::Assignment_2.Properties.Resources.save_icon;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveMenuStripItem_Click);
            // 
            // saveAsToolStripButton
            // 
            this.saveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsToolStripButton.Image = global::Assignment_2.Properties.Resources.save_as_icon;
            this.saveAsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripButton.Name = "saveAsToolStripButton";
            this.saveAsToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveAsToolStripButton.Text = "Save As";
            this.saveAsToolStripButton.Click += new System.EventHandler(this.SaveAsMenuStripItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.CheckOnClick = true;
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolStripButton.Image = global::Assignment_2.Properties.Resources.bold_icon;
            this.boldToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.boldToolStripButton.Text = "Bold";
            this.boldToolStripButton.Click += new System.EventHandler(this.BoldMenuStripItem_Click);
            // 
            // italicToolStripButton
            // 
            this.italicToolStripButton.CheckOnClick = true;
            this.italicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolStripButton.Image = global::Assignment_2.Properties.Resources.italic_icon;
            this.italicToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.italicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripButton.Name = "italicToolStripButton";
            this.italicToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.italicToolStripButton.Text = "Italic";
            this.italicToolStripButton.Click += new System.EventHandler(this.ItalicMenuStripItem_Click);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.CheckOnClick = true;
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolStripButton.Image = global::Assignment_2.Properties.Resources.underline_icon;
            this.underlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.underlineToolStripButton.Text = "Underline";
            this.underlineToolStripButton.Click += new System.EventHandler(this.UnderlineMenuStripItem_Click);
            // 
            // userLabel
            // 
            this.userLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userLabel.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(129, 24);
            this.userLabel.Text = "Currently logged in as: ";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.fontSizeComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 27);
            this.fontSizeComboBox.Text = "12";
            this.fontSizeComboBox.ToolTipText = "Font Size";
            this.fontSizeComboBox.TextChanged += new System.EventHandler(this.FontSizeComboBox_TextChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(31, 54);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(959, 660);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseClick);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox_KeyDown);
            // 
            // leftToolStrip
            // 
            this.leftToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.leftToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton});
            this.leftToolStrip.Location = new System.Drawing.Point(0, 51);
            this.leftToolStrip.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.leftToolStrip.Name = "leftToolStrip";
            this.leftToolStrip.Size = new System.Drawing.Size(28, 664);
            this.leftToolStrip.TabIndex = 3;
            this.leftToolStrip.Text = "leftToolStrip";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::Assignment_2.Properties.Resources.cut_icon;
            this.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(22, 24);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.Click += new System.EventHandler(this.CutMenuStripItem_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = global::Assignment_2.Properties.Resources.copy_icon;
            this.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(22, 24);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyMenuStripItem_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = global::Assignment_2.Properties.Resources.paste_icon;
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(22, 24);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.PasteMenuStripItem_Click);
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 715);
            this.Controls.Add(this.leftToolStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextEditorWindow";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.TextEditorWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.leftToolStrip.ResumeLayout(false);
            this.leftToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem newMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem cutMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuStripItem;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip leftToolStrip;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel userLabel;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fontMenuStripTab;
        private System.Windows.Forms.ToolStripMenuItem boldMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem italicMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem underlineMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuStripItem;
    }
}