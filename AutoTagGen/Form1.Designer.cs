namespace AutoTagGen
{
    partial class autoTagGenForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.resetHTML_Bttn = new System.Windows.Forms.Button();
            this.outputHTML_TextField = new System.Windows.Forms.TextBox();
            this.htmlOutputLabel = new System.Windows.Forms.Label();
            this.ouputHTML_Bttn = new System.Windows.Forms.Button();
            this.headTab = new System.Windows.Forms.TabPage();
            this.titleTab = new System.Windows.Forms.TabPage();
            this.metaTab = new System.Windows.Forms.TabPage();
            this.bodyTab = new System.Windows.Forms.TabPage();
            this.resetBodyTagsBttn = new System.Windows.Forms.Button();
            this.outputBodyTagsTextField = new System.Windows.Forms.TextBox();
            this.bodyTags_OutputLabel = new System.Windows.Forms.Label();
            this.bodyContentBetweenTagsTextField = new System.Windows.Forms.TextBox();
            this.betweenTags_body_Label = new System.Windows.Forms.Label();
            this.getBodyTagsBttn = new System.Windows.Forms.Button();
            this.bodyStyleTextField = new System.Windows.Forms.TextBox();
            this.bodyStyleLabel = new System.Windows.Forms.Label();
            this.paragraphTab = new System.Windows.Forms.TabPage();
            this.resetParagraphButton = new System.Windows.Forms.Button();
            this.outputParagraphTextField = new System.Windows.Forms.TextBox();
            this.outputParagraphLabel = new System.Windows.Forms.Label();
            this.paragraphTagContentTextField = new System.Windows.Forms.TextBox();
            this.paragraphTagContentLabel = new System.Windows.Forms.Label();
            this.outputParagraphTagsButton = new System.Windows.Forms.Button();
            this.classParagraphTextField = new System.Windows.Forms.TextBox();
            this.classParagraphLabel = new System.Windows.Forms.Label();
            this.styleParagraphTextField = new System.Windows.Forms.TextBox();
            this.styleParagraphLabel = new System.Windows.Forms.Label();
            this.idParagraphTextField = new System.Windows.Forms.TextBox();
            this.idParagraphLabel = new System.Windows.Forms.Label();
            this.link_a_Tab = new System.Windows.Forms.TabPage();
            this.dir_a_TextField = new System.Windows.Forms.TextBox();
            this.dir_a_Label = new System.Windows.Forms.Label();
            this.title_a_TextField = new System.Windows.Forms.TextBox();
            this.title_a_Label = new System.Windows.Forms.Label();
            this.href_a_TextField = new System.Windows.Forms.TextBox();
            this.href_a_Label = new System.Windows.Forms.Label();
            this.target_a_TextField = new System.Windows.Forms.TextBox();
            this.target_a_Label = new System.Windows.Forms.Label();
            this.type_a_TextField = new System.Windows.Forms.TextBox();
            this.type_a_Label = new System.Windows.Forms.Label();
            this.resetBttn_a_tags = new System.Windows.Forms.Button();
            this.output_a_TextField = new System.Windows.Forms.TextBox();
            this.output_a_Label = new System.Windows.Forms.Label();
            this.betweenTags_a_TextField = new System.Windows.Forms.TextBox();
            this.betweenTags_a_Label = new System.Windows.Forms.Label();
            this.getTags_a = new System.Windows.Forms.Button();
            this.class_a_TextField = new System.Windows.Forms.TextBox();
            this.class_a_Label = new System.Windows.Forms.Label();
            this.style_a_TextField = new System.Windows.Forms.TextBox();
            this.style_a_Label = new System.Windows.Forms.Label();
            this.id_a_TextField = new System.Windows.Forms.TextBox();
            this.id_a_Label = new System.Windows.Forms.Label();
            this.h1_6Tab = new System.Windows.Forms.TabPage();
            this.tableTab = new System.Windows.Forms.TabPage();
            this.tableRowTab = new System.Windows.Forms.TabPage();
            this.tableHeaderTab = new System.Windows.Forms.TabPage();
            this.tableColTab = new System.Windows.Forms.TabPage();
            this.historyLog = new System.Windows.Forms.TabPage();
            this.autoCompleteTextField = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.htmlTab.SuspendLayout();
            this.bodyTab.SuspendLayout();
            this.paragraphTab.SuspendLayout();
            this.link_a_Tab.SuspendLayout();
            this.historyLog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.htmlTab);
            this.tab.Controls.Add(this.headTab);
            this.tab.Controls.Add(this.titleTab);
            this.tab.Controls.Add(this.metaTab);
            this.tab.Controls.Add(this.bodyTab);
            this.tab.Controls.Add(this.paragraphTab);
            this.tab.Controls.Add(this.link_a_Tab);
            this.tab.Controls.Add(this.h1_6Tab);
            this.tab.Controls.Add(this.tableTab);
            this.tab.Controls.Add(this.tableRowTab);
            this.tab.Controls.Add(this.tableHeaderTab);
            this.tab.Controls.Add(this.tableColTab);
            this.tab.Controls.Add(this.historyLog);
            this.tab.Location = new System.Drawing.Point(1, 43);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.ShowToolTips = true;
            this.tab.Size = new System.Drawing.Size(782, 407);
            this.tab.TabIndex = 0;
            // 
            // htmlTab
            // 
            this.htmlTab.Controls.Add(this.resetHTML_Bttn);
            this.htmlTab.Controls.Add(this.outputHTML_TextField);
            this.htmlTab.Controls.Add(this.htmlOutputLabel);
            this.htmlTab.Controls.Add(this.ouputHTML_Bttn);
            this.htmlTab.Location = new System.Drawing.Point(4, 22);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Size = new System.Drawing.Size(774, 381);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "<html>";
            this.htmlTab.UseVisualStyleBackColor = true;
            // 
            // resetHTML_Bttn
            // 
            this.resetHTML_Bttn.Location = new System.Drawing.Point(400, 29);
            this.resetHTML_Bttn.Name = "resetHTML_Bttn";
            this.resetHTML_Bttn.Size = new System.Drawing.Size(63, 36);
            this.resetHTML_Bttn.TabIndex = 68;
            this.resetHTML_Bttn.Text = "Reset All";
            this.resetHTML_Bttn.UseVisualStyleBackColor = true;
            this.resetHTML_Bttn.Click += new System.EventHandler(this.resetHTML_Bttn_Clicked);
            // 
            // outputHTML_TextField
            // 
            this.outputHTML_TextField.Location = new System.Drawing.Point(260, 71);
            this.outputHTML_TextField.Multiline = true;
            this.outputHTML_TextField.Name = "outputHTML_TextField";
            this.outputHTML_TextField.Size = new System.Drawing.Size(255, 280);
            this.outputHTML_TextField.TabIndex = 67;
            // 
            // htmlOutputLabel
            // 
            this.htmlOutputLabel.Location = new System.Drawing.Point(260, 55);
            this.htmlOutputLabel.Name = "htmlOutputLabel";
            this.htmlOutputLabel.Size = new System.Drawing.Size(65, 13);
            this.htmlOutputLabel.TabIndex = 66;
            this.htmlOutputLabel.Text = "Your Tag(s):";
            // 
            // ouputHTML_Bttn
            // 
            this.ouputHTML_Bttn.Location = new System.Drawing.Point(331, 29);
            this.ouputHTML_Bttn.Name = "ouputHTML_Bttn";
            this.ouputHTML_Bttn.Size = new System.Drawing.Size(63, 36);
            this.ouputHTML_Bttn.TabIndex = 65;
            this.ouputHTML_Bttn.Text = "Get Tag(s)";
            this.ouputHTML_Bttn.UseVisualStyleBackColor = true;
            this.ouputHTML_Bttn.Click += new System.EventHandler(this.getHTML_Tag_Bttn_Clicked);
            // 
            // headTab
            // 
            this.headTab.Location = new System.Drawing.Point(4, 22);
            this.headTab.Name = "headTab";
            this.headTab.Size = new System.Drawing.Size(774, 381);
            this.headTab.TabIndex = 2;
            this.headTab.Text = "<head>";
            this.headTab.UseVisualStyleBackColor = true;
            // 
            // titleTab
            // 
            this.titleTab.Location = new System.Drawing.Point(4, 22);
            this.titleTab.Name = "titleTab";
            this.titleTab.Size = new System.Drawing.Size(774, 381);
            this.titleTab.TabIndex = 13;
            this.titleTab.Text = "<title>";
            this.titleTab.UseVisualStyleBackColor = true;
            // 
            // metaTab
            // 
            this.metaTab.Location = new System.Drawing.Point(4, 22);
            this.metaTab.Name = "metaTab";
            this.metaTab.Size = new System.Drawing.Size(774, 381);
            this.metaTab.TabIndex = 12;
            this.metaTab.Text = "<meta />";
            this.metaTab.UseVisualStyleBackColor = true;
            // 
            // bodyTab
            // 
            this.bodyTab.Controls.Add(this.resetBodyTagsBttn);
            this.bodyTab.Controls.Add(this.outputBodyTagsTextField);
            this.bodyTab.Controls.Add(this.bodyTags_OutputLabel);
            this.bodyTab.Controls.Add(this.bodyContentBetweenTagsTextField);
            this.bodyTab.Controls.Add(this.betweenTags_body_Label);
            this.bodyTab.Controls.Add(this.getBodyTagsBttn);
            this.bodyTab.Controls.Add(this.bodyStyleTextField);
            this.bodyTab.Controls.Add(this.bodyStyleLabel);
            this.bodyTab.Location = new System.Drawing.Point(4, 22);
            this.bodyTab.Name = "bodyTab";
            this.bodyTab.Size = new System.Drawing.Size(774, 381);
            this.bodyTab.TabIndex = 4;
            this.bodyTab.Text = "<body>";
            this.bodyTab.UseVisualStyleBackColor = true;
            // 
            // resetBodyTagsBttn
            // 
            this.resetBodyTagsBttn.Location = new System.Drawing.Point(654, 15);
            this.resetBodyTagsBttn.Name = "resetBodyTagsBttn";
            this.resetBodyTagsBttn.Size = new System.Drawing.Size(63, 36);
            this.resetBodyTagsBttn.TabIndex = 72;
            this.resetBodyTagsBttn.Text = "Reset All";
            this.resetBodyTagsBttn.UseVisualStyleBackColor = true;
            this.resetBodyTagsBttn.Click += new System.EventHandler(this.resetBodyTagsBttnClicked);
            // 
            // outputBodyTagsTextField
            // 
            this.outputBodyTagsTextField.Location = new System.Drawing.Point(514, 57);
            this.outputBodyTagsTextField.Multiline = true;
            this.outputBodyTagsTextField.Name = "outputBodyTagsTextField";
            this.outputBodyTagsTextField.Size = new System.Drawing.Size(255, 280);
            this.outputBodyTagsTextField.TabIndex = 71;
            // 
            // bodyTags_OutputLabel
            // 
            this.bodyTags_OutputLabel.Location = new System.Drawing.Point(514, 41);
            this.bodyTags_OutputLabel.Name = "bodyTags_OutputLabel";
            this.bodyTags_OutputLabel.Size = new System.Drawing.Size(65, 13);
            this.bodyTags_OutputLabel.TabIndex = 70;
            this.bodyTags_OutputLabel.Text = "Your Tag(s):";
            // 
            // bodyContentBetweenTagsTextField
            // 
            this.bodyContentBetweenTagsTextField.Location = new System.Drawing.Point(279, 57);
            this.bodyContentBetweenTagsTextField.Multiline = true;
            this.bodyContentBetweenTagsTextField.Name = "bodyContentBetweenTagsTextField";
            this.bodyContentBetweenTagsTextField.Size = new System.Drawing.Size(229, 280);
            this.bodyContentBetweenTagsTextField.TabIndex = 69;
            // 
            // betweenTags_body_Label
            // 
            this.betweenTags_body_Label.Location = new System.Drawing.Point(276, 41);
            this.betweenTags_body_Label.Name = "betweenTags_body_Label";
            this.betweenTags_body_Label.Size = new System.Drawing.Size(56, 13);
            this.betweenTags_body_Label.TabIndex = 68;
            this.betweenTags_body_Label.Text = "Content = ";
            // 
            // getBodyTagsBttn
            // 
            this.getBodyTagsBttn.Location = new System.Drawing.Point(585, 15);
            this.getBodyTagsBttn.Name = "getBodyTagsBttn";
            this.getBodyTagsBttn.Size = new System.Drawing.Size(63, 36);
            this.getBodyTagsBttn.TabIndex = 67;
            this.getBodyTagsBttn.Text = "Get Tag(s)";
            this.getBodyTagsBttn.UseVisualStyleBackColor = true;
            this.getBodyTagsBttn.Click += new System.EventHandler(this.getBodyTagsBttnClicked);
            // 
            // bodyStyleTextField
            // 
            this.bodyStyleTextField.Location = new System.Drawing.Point(108, 50);
            this.bodyStyleTextField.MaxLength = 100;
            this.bodyStyleTextField.Name = "bodyStyleTextField";
            this.bodyStyleTextField.Size = new System.Drawing.Size(100, 20);
            this.bodyStyleTextField.TabIndex = 66;
            // 
            // bodyStyleLabel
            // 
            this.bodyStyleLabel.Location = new System.Drawing.Point(55, 57);
            this.bodyStyleLabel.Name = "bodyStyleLabel";
            this.bodyStyleLabel.Size = new System.Drawing.Size(40, 13);
            this.bodyStyleLabel.TabIndex = 65;
            this.bodyStyleLabel.Text = "style = ";
            // 
            // paragraphTab
            // 
            this.paragraphTab.Controls.Add(this.resetParagraphButton);
            this.paragraphTab.Controls.Add(this.outputParagraphTextField);
            this.paragraphTab.Controls.Add(this.outputParagraphLabel);
            this.paragraphTab.Controls.Add(this.paragraphTagContentTextField);
            this.paragraphTab.Controls.Add(this.paragraphTagContentLabel);
            this.paragraphTab.Controls.Add(this.outputParagraphTagsButton);
            this.paragraphTab.Controls.Add(this.classParagraphTextField);
            this.paragraphTab.Controls.Add(this.classParagraphLabel);
            this.paragraphTab.Controls.Add(this.styleParagraphTextField);
            this.paragraphTab.Controls.Add(this.styleParagraphLabel);
            this.paragraphTab.Controls.Add(this.idParagraphTextField);
            this.paragraphTab.Controls.Add(this.idParagraphLabel);
            this.paragraphTab.Location = new System.Drawing.Point(4, 22);
            this.paragraphTab.Name = "paragraphTab";
            this.paragraphTab.Padding = new System.Windows.Forms.Padding(3);
            this.paragraphTab.Size = new System.Drawing.Size(774, 381);
            this.paragraphTab.TabIndex = 0;
            this.paragraphTab.Text = "<p>";
            this.paragraphTab.ToolTipText = "Creates (X)HTML <p></p> tags.";
            this.paragraphTab.UseVisualStyleBackColor = true;
            // 
            // resetParagraphButton
            // 
            this.resetParagraphButton.Location = new System.Drawing.Point(649, 16);
            this.resetParagraphButton.Name = "resetParagraphButton";
            this.resetParagraphButton.Size = new System.Drawing.Size(63, 36);
            this.resetParagraphButton.TabIndex = 64;
            this.resetParagraphButton.Text = "Reset All";
            this.resetParagraphButton.UseVisualStyleBackColor = true;
            this.resetParagraphButton.Click += new System.EventHandler(this.resetParagraphTags);
            // 
            // outputParagraphTextField
            // 
            this.outputParagraphTextField.Location = new System.Drawing.Point(509, 58);
            this.outputParagraphTextField.Multiline = true;
            this.outputParagraphTextField.Name = "outputParagraphTextField";
            this.outputParagraphTextField.Size = new System.Drawing.Size(255, 280);
            this.outputParagraphTextField.TabIndex = 63;
            // 
            // outputParagraphLabel
            // 
            this.outputParagraphLabel.Location = new System.Drawing.Point(509, 42);
            this.outputParagraphLabel.Name = "outputParagraphLabel";
            this.outputParagraphLabel.Size = new System.Drawing.Size(65, 13);
            this.outputParagraphLabel.TabIndex = 62;
            this.outputParagraphLabel.Text = "Your Tag(s):";
            // 
            // paragraphTagContentTextField
            // 
            this.paragraphTagContentTextField.Location = new System.Drawing.Point(274, 58);
            this.paragraphTagContentTextField.Multiline = true;
            this.paragraphTagContentTextField.Name = "paragraphTagContentTextField";
            this.paragraphTagContentTextField.Size = new System.Drawing.Size(229, 280);
            this.paragraphTagContentTextField.TabIndex = 61;
            // 
            // paragraphTagContentLabel
            // 
            this.paragraphTagContentLabel.Location = new System.Drawing.Point(271, 42);
            this.paragraphTagContentLabel.Name = "paragraphTagContentLabel";
            this.paragraphTagContentLabel.Size = new System.Drawing.Size(56, 13);
            this.paragraphTagContentLabel.TabIndex = 60;
            this.paragraphTagContentLabel.Text = "Content = ";
            // 
            // outputParagraphTagsButton
            // 
            this.outputParagraphTagsButton.Location = new System.Drawing.Point(580, 16);
            this.outputParagraphTagsButton.Name = "outputParagraphTagsButton";
            this.outputParagraphTagsButton.Size = new System.Drawing.Size(63, 36);
            this.outputParagraphTagsButton.TabIndex = 59;
            this.outputParagraphTagsButton.Text = "Get Tag(s)";
            this.outputParagraphTagsButton.UseVisualStyleBackColor = true;
            this.outputParagraphTagsButton.Click += new System.EventHandler(this.getParagraphTagsBttnClicked);
            // 
            // classParagraphTextField
            // 
            this.classParagraphTextField.Location = new System.Drawing.Point(103, 77);
            this.classParagraphTextField.MaxLength = 100;
            this.classParagraphTextField.Name = "classParagraphTextField";
            this.classParagraphTextField.Size = new System.Drawing.Size(100, 20);
            this.classParagraphTextField.TabIndex = 58;
            // 
            // classParagraphLabel
            // 
            this.classParagraphLabel.Location = new System.Drawing.Point(50, 80);
            this.classParagraphLabel.Name = "classParagraphLabel";
            this.classParagraphLabel.Size = new System.Drawing.Size(45, 13);
            this.classParagraphLabel.TabIndex = 57;
            this.classParagraphLabel.Text = "class = ";
            // 
            // styleParagraphTextField
            // 
            this.styleParagraphTextField.Location = new System.Drawing.Point(103, 51);
            this.styleParagraphTextField.MaxLength = 100;
            this.styleParagraphTextField.Name = "styleParagraphTextField";
            this.styleParagraphTextField.Size = new System.Drawing.Size(100, 20);
            this.styleParagraphTextField.TabIndex = 15;
            // 
            // styleParagraphLabel
            // 
            this.styleParagraphLabel.Location = new System.Drawing.Point(50, 58);
            this.styleParagraphLabel.Name = "styleParagraphLabel";
            this.styleParagraphLabel.Size = new System.Drawing.Size(40, 13);
            this.styleParagraphLabel.TabIndex = 14;
            this.styleParagraphLabel.Text = "style = ";
            // 
            // idParagraphTextField
            // 
            this.idParagraphTextField.Location = new System.Drawing.Point(103, 25);
            this.idParagraphTextField.MaxLength = 100;
            this.idParagraphTextField.Name = "idParagraphTextField";
            this.idParagraphTextField.Size = new System.Drawing.Size(100, 20);
            this.idParagraphTextField.TabIndex = 6;
            // 
            // idParagraphLabel
            // 
            this.idParagraphLabel.Location = new System.Drawing.Point(50, 32);
            this.idParagraphLabel.Name = "idParagraphLabel";
            this.idParagraphLabel.Size = new System.Drawing.Size(27, 13);
            this.idParagraphLabel.TabIndex = 5;
            this.idParagraphLabel.Text = "id = ";
            // 
            // link_a_Tab
            // 
            this.link_a_Tab.Controls.Add(this.dir_a_TextField);
            this.link_a_Tab.Controls.Add(this.dir_a_Label);
            this.link_a_Tab.Controls.Add(this.title_a_TextField);
            this.link_a_Tab.Controls.Add(this.title_a_Label);
            this.link_a_Tab.Controls.Add(this.href_a_TextField);
            this.link_a_Tab.Controls.Add(this.href_a_Label);
            this.link_a_Tab.Controls.Add(this.target_a_TextField);
            this.link_a_Tab.Controls.Add(this.target_a_Label);
            this.link_a_Tab.Controls.Add(this.type_a_TextField);
            this.link_a_Tab.Controls.Add(this.type_a_Label);
            this.link_a_Tab.Controls.Add(this.resetBttn_a_tags);
            this.link_a_Tab.Controls.Add(this.output_a_TextField);
            this.link_a_Tab.Controls.Add(this.output_a_Label);
            this.link_a_Tab.Controls.Add(this.betweenTags_a_TextField);
            this.link_a_Tab.Controls.Add(this.betweenTags_a_Label);
            this.link_a_Tab.Controls.Add(this.getTags_a);
            this.link_a_Tab.Controls.Add(this.class_a_TextField);
            this.link_a_Tab.Controls.Add(this.class_a_Label);
            this.link_a_Tab.Controls.Add(this.style_a_TextField);
            this.link_a_Tab.Controls.Add(this.style_a_Label);
            this.link_a_Tab.Controls.Add(this.id_a_TextField);
            this.link_a_Tab.Controls.Add(this.id_a_Label);
            this.link_a_Tab.Location = new System.Drawing.Point(4, 22);
            this.link_a_Tab.Name = "link_a_Tab";
            this.link_a_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.link_a_Tab.Size = new System.Drawing.Size(774, 381);
            this.link_a_Tab.TabIndex = 1;
            this.link_a_Tab.Text = "<a>";
            this.link_a_Tab.UseVisualStyleBackColor = true;
            // 
            // dir_a_TextField
            // 
            this.dir_a_TextField.Location = new System.Drawing.Point(83, 220);
            this.dir_a_TextField.MaxLength = 100;
            this.dir_a_TextField.Name = "dir_a_TextField";
            this.dir_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.dir_a_TextField.TabIndex = 86;
            // 
            // dir_a_Label
            // 
            this.dir_a_Label.Location = new System.Drawing.Point(30, 223);
            this.dir_a_Label.Name = "dir_a_Label";
            this.dir_a_Label.Size = new System.Drawing.Size(45, 13);
            this.dir_a_Label.TabIndex = 85;
            this.dir_a_Label.Text = "dir = ";
            // 
            // title_a_TextField
            // 
            this.title_a_TextField.Location = new System.Drawing.Point(83, 194);
            this.title_a_TextField.MaxLength = 100;
            this.title_a_TextField.Name = "title_a_TextField";
            this.title_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.title_a_TextField.TabIndex = 84;
            // 
            // title_a_Label
            // 
            this.title_a_Label.Location = new System.Drawing.Point(30, 197);
            this.title_a_Label.Name = "title_a_Label";
            this.title_a_Label.Size = new System.Drawing.Size(45, 13);
            this.title_a_Label.TabIndex = 83;
            this.title_a_Label.Text = "title = ";
            // 
            // href_a_TextField
            // 
            this.href_a_TextField.Location = new System.Drawing.Point(83, 168);
            this.href_a_TextField.MaxLength = 100;
            this.href_a_TextField.Name = "href_a_TextField";
            this.href_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.href_a_TextField.TabIndex = 82;
            // 
            // href_a_Label
            // 
            this.href_a_Label.Location = new System.Drawing.Point(30, 171);
            this.href_a_Label.Name = "href_a_Label";
            this.href_a_Label.Size = new System.Drawing.Size(45, 13);
            this.href_a_Label.TabIndex = 81;
            this.href_a_Label.Text = "href = ";
            // 
            // target_a_TextField
            // 
            this.target_a_TextField.Location = new System.Drawing.Point(83, 142);
            this.target_a_TextField.MaxLength = 100;
            this.target_a_TextField.Name = "target_a_TextField";
            this.target_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.target_a_TextField.TabIndex = 80;
            // 
            // target_a_Label
            // 
            this.target_a_Label.Location = new System.Drawing.Point(30, 145);
            this.target_a_Label.Name = "target_a_Label";
            this.target_a_Label.Size = new System.Drawing.Size(45, 13);
            this.target_a_Label.TabIndex = 79;
            this.target_a_Label.Text = "target = ";
            // 
            // type_a_TextField
            // 
            this.type_a_TextField.Location = new System.Drawing.Point(83, 116);
            this.type_a_TextField.MaxLength = 100;
            this.type_a_TextField.Name = "type_a_TextField";
            this.type_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.type_a_TextField.TabIndex = 78;
            // 
            // type_a_Label
            // 
            this.type_a_Label.Location = new System.Drawing.Point(30, 119);
            this.type_a_Label.Name = "type_a_Label";
            this.type_a_Label.Size = new System.Drawing.Size(45, 13);
            this.type_a_Label.TabIndex = 77;
            this.type_a_Label.Text = "type = ";
            // 
            // resetBttn_a_tags
            // 
            this.resetBttn_a_tags.Location = new System.Drawing.Point(629, 29);
            this.resetBttn_a_tags.Name = "resetBttn_a_tags";
            this.resetBttn_a_tags.Size = new System.Drawing.Size(63, 36);
            this.resetBttn_a_tags.TabIndex = 76;
            this.resetBttn_a_tags.Text = "Reset All";
            this.resetBttn_a_tags.UseVisualStyleBackColor = true;
            // 
            // output_a_TextField
            // 
            this.output_a_TextField.Location = new System.Drawing.Point(489, 71);
            this.output_a_TextField.Multiline = true;
            this.output_a_TextField.Name = "output_a_TextField";
            this.output_a_TextField.Size = new System.Drawing.Size(255, 280);
            this.output_a_TextField.TabIndex = 75;
            // 
            // output_a_Label
            // 
            this.output_a_Label.Location = new System.Drawing.Point(489, 55);
            this.output_a_Label.Name = "output_a_Label";
            this.output_a_Label.Size = new System.Drawing.Size(65, 13);
            this.output_a_Label.TabIndex = 74;
            this.output_a_Label.Text = "Your Tag(s):";
            // 
            // betweenTags_a_TextField
            // 
            this.betweenTags_a_TextField.Location = new System.Drawing.Point(254, 71);
            this.betweenTags_a_TextField.Multiline = true;
            this.betweenTags_a_TextField.Name = "betweenTags_a_TextField";
            this.betweenTags_a_TextField.Size = new System.Drawing.Size(229, 280);
            this.betweenTags_a_TextField.TabIndex = 73;
            // 
            // betweenTags_a_Label
            // 
            this.betweenTags_a_Label.Location = new System.Drawing.Point(251, 55);
            this.betweenTags_a_Label.Name = "betweenTags_a_Label";
            this.betweenTags_a_Label.Size = new System.Drawing.Size(56, 13);
            this.betweenTags_a_Label.TabIndex = 72;
            this.betweenTags_a_Label.Text = "Content = ";
            // 
            // getTags_a
            // 
            this.getTags_a.Location = new System.Drawing.Point(560, 29);
            this.getTags_a.Name = "getTags_a";
            this.getTags_a.Size = new System.Drawing.Size(63, 36);
            this.getTags_a.TabIndex = 71;
            this.getTags_a.Text = "Get Tag(s)";
            this.getTags_a.UseVisualStyleBackColor = true;
            this.getTags_a.Click += new System.EventHandler(this.get_a_TagsBttnClicked);
            // 
            // class_a_TextField
            // 
            this.class_a_TextField.Location = new System.Drawing.Point(83, 90);
            this.class_a_TextField.MaxLength = 100;
            this.class_a_TextField.Name = "class_a_TextField";
            this.class_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.class_a_TextField.TabIndex = 70;
            // 
            // class_a_Label
            // 
            this.class_a_Label.Location = new System.Drawing.Point(30, 93);
            this.class_a_Label.Name = "class_a_Label";
            this.class_a_Label.Size = new System.Drawing.Size(45, 13);
            this.class_a_Label.TabIndex = 69;
            this.class_a_Label.Text = "class = ";
            // 
            // style_a_TextField
            // 
            this.style_a_TextField.Location = new System.Drawing.Point(83, 64);
            this.style_a_TextField.MaxLength = 100;
            this.style_a_TextField.Name = "style_a_TextField";
            this.style_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.style_a_TextField.TabIndex = 68;
            // 
            // style_a_Label
            // 
            this.style_a_Label.Location = new System.Drawing.Point(30, 71);
            this.style_a_Label.Name = "style_a_Label";
            this.style_a_Label.Size = new System.Drawing.Size(40, 13);
            this.style_a_Label.TabIndex = 67;
            this.style_a_Label.Text = "style = ";
            // 
            // id_a_TextField
            // 
            this.id_a_TextField.Location = new System.Drawing.Point(83, 38);
            this.id_a_TextField.MaxLength = 100;
            this.id_a_TextField.Name = "id_a_TextField";
            this.id_a_TextField.Size = new System.Drawing.Size(100, 20);
            this.id_a_TextField.TabIndex = 66;
            // 
            // id_a_Label
            // 
            this.id_a_Label.Location = new System.Drawing.Point(30, 45);
            this.id_a_Label.Name = "id_a_Label";
            this.id_a_Label.Size = new System.Drawing.Size(27, 13);
            this.id_a_Label.TabIndex = 65;
            this.id_a_Label.Text = "id = ";
            // 
            // h1_6Tab
            // 
            this.h1_6Tab.Location = new System.Drawing.Point(4, 22);
            this.h1_6Tab.Name = "h1_6Tab";
            this.h1_6Tab.Size = new System.Drawing.Size(774, 381);
            this.h1_6Tab.TabIndex = 6;
            this.h1_6Tab.Text = "<h1-6>";
            this.h1_6Tab.UseVisualStyleBackColor = true;
            // 
            // tableTab
            // 
            this.tableTab.Location = new System.Drawing.Point(4, 22);
            this.tableTab.Name = "tableTab";
            this.tableTab.Size = new System.Drawing.Size(774, 381);
            this.tableTab.TabIndex = 7;
            this.tableTab.Text = "<table>";
            this.tableTab.UseVisualStyleBackColor = true;
            // 
            // tableRowTab
            // 
            this.tableRowTab.Location = new System.Drawing.Point(4, 22);
            this.tableRowTab.Name = "tableRowTab";
            this.tableRowTab.Size = new System.Drawing.Size(774, 381);
            this.tableRowTab.TabIndex = 8;
            this.tableRowTab.Text = "<tr>";
            this.tableRowTab.UseVisualStyleBackColor = true;
            // 
            // tableHeaderTab
            // 
            this.tableHeaderTab.Location = new System.Drawing.Point(4, 22);
            this.tableHeaderTab.Name = "tableHeaderTab";
            this.tableHeaderTab.Size = new System.Drawing.Size(774, 381);
            this.tableHeaderTab.TabIndex = 9;
            this.tableHeaderTab.Text = "<th>";
            this.tableHeaderTab.UseVisualStyleBackColor = true;
            // 
            // tableColTab
            // 
            this.tableColTab.Location = new System.Drawing.Point(4, 22);
            this.tableColTab.Name = "tableColTab";
            this.tableColTab.Size = new System.Drawing.Size(774, 381);
            this.tableColTab.TabIndex = 10;
            this.tableColTab.Text = "<td>";
            this.tableColTab.UseVisualStyleBackColor = true;
            // 
            // historyLog
            // 
            this.historyLog.Controls.Add(this.autoCompleteTextField);
            this.historyLog.Location = new System.Drawing.Point(4, 22);
            this.historyLog.Name = "historyLog";
            this.historyLog.Size = new System.Drawing.Size(774, 381);
            this.historyLog.TabIndex = 14;
            this.historyLog.Text = "History";
            this.historyLog.UseVisualStyleBackColor = true;
            // 
            // autoCompleteTextField
            // 
            this.autoCompleteTextField.BackColor = System.Drawing.SystemColors.InfoText;
            this.autoCompleteTextField.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompleteTextField.ForeColor = System.Drawing.Color.White;
            this.autoCompleteTextField.Location = new System.Drawing.Point(3, 21);
            this.autoCompleteTextField.Name = "autoCompleteTextField";
            this.autoCompleteTextField.Size = new System.Drawing.Size(764, 357);
            this.autoCompleteTextField.TabIndex = 0;
            this.autoCompleteTextField.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.exit_File_MenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exit_File_MenuItem
            // 
            this.exit_File_MenuItem.Name = "exit_File_MenuItem";
            this.exit_File_MenuItem.Size = new System.Drawing.Size(133, 22);
            this.exit_File_MenuItem.Text = "Exit";
            this.exit_File_MenuItem.ToolTipText = "Closes the interface.";
            this.exit_File_MenuItem.Click += new System.EventHandler(this.exitClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.readMeToolStripMenuItem.Text = "Read Me";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // autoTagGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(400, 390);
            this.Name = "autoTagGenForm";
            this.Text = "Automated Tag Generator";
            this.tab.ResumeLayout(false);
            this.htmlTab.ResumeLayout(false);
            this.htmlTab.PerformLayout();
            this.bodyTab.ResumeLayout(false);
            this.bodyTab.PerformLayout();
            this.paragraphTab.ResumeLayout(false);
            this.paragraphTab.PerformLayout();
            this.link_a_Tab.ResumeLayout(false);
            this.link_a_Tab.PerformLayout();
            this.historyLog.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage paragraphTab;
        private System.Windows.Forms.TabPage link_a_Tab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage headTab;
        private System.Windows.Forms.TabPage htmlTab;
        private System.Windows.Forms.TabPage bodyTab;
        private System.Windows.Forms.TabPage h1_6Tab;
        private System.Windows.Forms.TabPage tableTab;
        private System.Windows.Forms.TabPage tableRowTab;
        private System.Windows.Forms.TabPage tableHeaderTab;
        private System.Windows.Forms.TabPage tableColTab;
        private System.Windows.Forms.TabPage metaTab;
        private System.Windows.Forms.TextBox idParagraphTextField;
        private System.Windows.Forms.Label idParagraphLabel;
        private System.Windows.Forms.TextBox classParagraphTextField;
        private System.Windows.Forms.Label classParagraphLabel;
        private System.Windows.Forms.TextBox styleParagraphTextField;
        private System.Windows.Forms.Label styleParagraphLabel;
        private System.Windows.Forms.Button resetParagraphButton;
        private System.Windows.Forms.TextBox outputParagraphTextField;
        private System.Windows.Forms.Label outputParagraphLabel;
        private System.Windows.Forms.TextBox paragraphTagContentTextField;
        private System.Windows.Forms.Label paragraphTagContentLabel;
        private System.Windows.Forms.Button outputParagraphTagsButton;
        private System.Windows.Forms.TabPage titleTab;
        private System.Windows.Forms.Button resetHTML_Bttn;
        private System.Windows.Forms.TextBox outputHTML_TextField;
        private System.Windows.Forms.Label htmlOutputLabel;
        private System.Windows.Forms.Button ouputHTML_Bttn;
        private System.Windows.Forms.TabPage historyLog;
        private System.Windows.Forms.RichTextBox autoCompleteTextField;
        private System.Windows.Forms.Button resetBodyTagsBttn;
        private System.Windows.Forms.TextBox outputBodyTagsTextField;
        private System.Windows.Forms.Label bodyTags_OutputLabel;
        private System.Windows.Forms.TextBox bodyContentBetweenTagsTextField;
        private System.Windows.Forms.Label betweenTags_body_Label;
        private System.Windows.Forms.Button getBodyTagsBttn;
        private System.Windows.Forms.TextBox bodyStyleTextField;
        private System.Windows.Forms.Label bodyStyleLabel;
        private System.Windows.Forms.Button resetBttn_a_tags;
        private System.Windows.Forms.TextBox output_a_TextField;
        private System.Windows.Forms.Label output_a_Label;
        private System.Windows.Forms.TextBox betweenTags_a_TextField;
        private System.Windows.Forms.Label betweenTags_a_Label;
        private System.Windows.Forms.Button getTags_a;
        private System.Windows.Forms.TextBox class_a_TextField;
        private System.Windows.Forms.Label class_a_Label;
        private System.Windows.Forms.TextBox style_a_TextField;
        private System.Windows.Forms.Label style_a_Label;
        private System.Windows.Forms.TextBox id_a_TextField;
        private System.Windows.Forms.Label id_a_Label;
        #endregion
        private System.Windows.Forms.TextBox type_a_TextField;
        private System.Windows.Forms.Label type_a_Label;
        private System.Windows.Forms.TextBox target_a_TextField;
        private System.Windows.Forms.Label target_a_Label;
        private System.Windows.Forms.TextBox href_a_TextField;
        private System.Windows.Forms.Label href_a_Label;
        private System.Windows.Forms.TextBox title_a_TextField;
        private System.Windows.Forms.Label title_a_Label;
        private System.Windows.Forms.TextBox dir_a_TextField;
        private System.Windows.Forms.Label dir_a_Label;
    }
}

