﻿namespace MercuryBOT
{
    partial class CommentsGather
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsGather));
            this.combox_GatherProfileOrGroup = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_doTask = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chck_containsWords = new MetroFramework.Controls.MetroCheckBox();
            this.txtBox_filterWords = new MetroFramework.Controls.MetroTextBox();
            this.GridCommentsData = new MetroFramework.Controls.MetroGrid();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_totalCommentsInGrid = new MetroFramework.Controls.MetroLabel();
            this.MongoToolTip = new MetroFramework.Components.MetroToolTip();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.txtBox_Comments2GetCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ProgressSpinner_LoadComments = new MetroFramework.Controls.MetroProgressSpinner();
            this.CollectComments = new System.ComponentModel.BackgroundWorker();
            this.CommentsList_ScrollBar = new MetroFramework.Controls.MetroScrollBar();
            this.combox_ProfileURLorGroupID = new MetroFramework.Controls.MetroComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCommentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // combox_GatherProfileOrGroup
            // 
            this.combox_GatherProfileOrGroup.ForeColor = System.Drawing.Color.White;
            this.combox_GatherProfileOrGroup.FormattingEnabled = true;
            this.combox_GatherProfileOrGroup.ItemHeight = 23;
            this.combox_GatherProfileOrGroup.Items.AddRange(new object[] {
            "My Profile",
            "My Group"});
            this.combox_GatherProfileOrGroup.Location = new System.Drawing.Point(197, 569);
            this.combox_GatherProfileOrGroup.Name = "combox_GatherProfileOrGroup";
            this.combox_GatherProfileOrGroup.Size = new System.Drawing.Size(232, 29);
            this.combox_GatherProfileOrGroup.TabIndex = 2;
            this.combox_GatherProfileOrGroup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.combox_GatherProfileOrGroup.UseCustomForeColor = true;
            this.combox_GatherProfileOrGroup.UseSelectable = true;
            this.combox_GatherProfileOrGroup.UseStyleColors = true;
            this.combox_GatherProfileOrGroup.SelectedIndexChanged += new System.EventHandler(this.Combox_profileOrClan_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(87, 574);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Where to gather:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btn_doTask
            // 
            this.btn_doTask.DisplayFocus = true;
            this.btn_doTask.ForeColor = System.Drawing.Color.White;
            this.btn_doTask.Location = new System.Drawing.Point(848, 575);
            this.btn_doTask.Name = "btn_doTask";
            this.btn_doTask.Size = new System.Drawing.Size(154, 97);
            this.btn_doTask.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_doTask.TabIndex = 5;
            this.btn_doTask.Text = "GATHER COMMENTS!";
            this.btn_doTask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_doTask.UseCustomForeColor = true;
            this.btn_doTask.UseSelectable = true;
            this.btn_doTask.UseStyleColors = true;
            this.btn_doTask.Click += new System.EventHandler(this.Btn_doTask_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(468, 569);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Delete options:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // chck_containsWords
            // 
            this.chck_containsWords.AutoSize = true;
            this.chck_containsWords.Location = new System.Drawing.Point(509, 618);
            this.chck_containsWords.Name = "chck_containsWords";
            this.chck_containsWords.Size = new System.Drawing.Size(108, 15);
            this.chck_containsWords.TabIndex = 8;
            this.chck_containsWords.Text = "Contains words:";
            this.MongoToolTip.SetToolTip(this.chck_containsWords, "This will delete your comments based on words");
            this.chck_containsWords.UseCustomBackColor = true;
            this.chck_containsWords.UseSelectable = true;
            this.chck_containsWords.UseStyleColors = true;
            // 
            // txtBox_filterWords
            // 
            this.txtBox_filterWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // 
            // 
            this.txtBox_filterWords.CustomButton.Image = null;
            this.txtBox_filterWords.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtBox_filterWords.CustomButton.Name = "";
            this.txtBox_filterWords.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtBox_filterWords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_filterWords.CustomButton.TabIndex = 1;
            this.txtBox_filterWords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_filterWords.CustomButton.UseSelectable = true;
            this.txtBox_filterWords.CustomButton.Visible = false;
            this.txtBox_filterWords.ForeColor = System.Drawing.Color.White;
            this.txtBox_filterWords.Lines = new string[0];
            this.txtBox_filterWords.Location = new System.Drawing.Point(619, 617);
            this.txtBox_filterWords.MaxLength = 32767;
            this.txtBox_filterWords.Multiline = true;
            this.txtBox_filterWords.Name = "txtBox_filterWords";
            this.txtBox_filterWords.PasswordChar = '\0';
            this.txtBox_filterWords.PromptText = "FREE,CASE,GIVEAWAY";
            this.txtBox_filterWords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_filterWords.SelectedText = "";
            this.txtBox_filterWords.SelectionLength = 0;
            this.txtBox_filterWords.SelectionStart = 0;
            this.txtBox_filterWords.ShortcutsEnabled = true;
            this.txtBox_filterWords.Size = new System.Drawing.Size(167, 41);
            this.txtBox_filterWords.TabIndex = 9;
            this.txtBox_filterWords.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MongoToolTip.SetToolTip(this.txtBox_filterWords, "Use comma to separate all words");
            this.txtBox_filterWords.UseCustomBackColor = true;
            this.txtBox_filterWords.UseCustomForeColor = true;
            this.txtBox_filterWords.UseSelectable = true;
            this.txtBox_filterWords.UseStyleColors = true;
            this.txtBox_filterWords.WaterMark = "FREE,CASE,GIVEAWAY";
            this.txtBox_filterWords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_filterWords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GridCommentsData
            // 
            this.GridCommentsData.AllowUserToAddRows = false;
            this.GridCommentsData.AllowUserToDeleteRows = false;
            this.GridCommentsData.AllowUserToOrderColumns = true;
            this.GridCommentsData.AllowUserToResizeColumns = false;
            this.GridCommentsData.AllowUserToResizeRows = false;
            this.GridCommentsData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.GridCommentsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCommentsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridCommentsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCommentsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCommentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCommentsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.content,
            this.autor,
            this.time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCommentsData.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridCommentsData.EnableHeadersVisualStyles = false;
            this.GridCommentsData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridCommentsData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.GridCommentsData.Location = new System.Drawing.Point(-41, 65);
            this.GridCommentsData.MultiSelect = false;
            this.GridCommentsData.Name = "GridCommentsData";
            this.GridCommentsData.ReadOnly = true;
            this.GridCommentsData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCommentsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridCommentsData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridCommentsData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridCommentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCommentsData.Size = new System.Drawing.Size(1054, 478);
            this.GridCommentsData.TabIndex = 13;
            this.GridCommentsData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GridCommentsData.UseCustomBackColor = true;
            this.GridCommentsData.UseCustomForeColor = true;
            this.GridCommentsData.UseStyleColors = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "COMMENT ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 130;
            // 
            // content
            // 
            this.content.HeaderText = "CONTENT";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Width = 625;
            // 
            // autor
            // 
            this.autor.HeaderText = "AUTHOR";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Width = 130;
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 130;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(105, 613);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Profile/Group:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(-1, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 10);
            this.panel1.TabIndex = 16;
            // 
            // lbl_totalCommentsInGrid
            // 
            this.lbl_totalCommentsInGrid.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_totalCommentsInGrid.ForeColor = System.Drawing.Color.White;
            this.lbl_totalCommentsInGrid.Location = new System.Drawing.Point(726, 46);
            this.lbl_totalCommentsInGrid.Name = "lbl_totalCommentsInGrid";
            this.lbl_totalCommentsInGrid.Size = new System.Drawing.Size(286, 19);
            this.lbl_totalCommentsInGrid.TabIndex = 17;
            this.lbl_totalCommentsInGrid.Text = "Total Deleted: ...";
            this.lbl_totalCommentsInGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_totalCommentsInGrid.UseCustomBackColor = true;
            this.lbl_totalCommentsInGrid.UseCustomForeColor = true;
            this.lbl_totalCommentsInGrid.UseStyleColors = true;
            // 
            // MongoToolTip
            // 
            this.MongoToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.MongoToolTip.StyleManager = null;
            this.MongoToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(509, 595);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(66, 15);
            this.metroCheckBox1.TabIndex = 26;
            this.metroCheckBox1.Text = "Any link";
            this.MongoToolTip.SetToolTip(this.metroCheckBox1, "This will delete your comments based on words");
            this.metroCheckBox1.UseCustomBackColor = true;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            // 
            // txtBox_Comments2GetCount
            // 
            // 
            // 
            // 
            this.txtBox_Comments2GetCount.CustomButton.Image = null;
            this.txtBox_Comments2GetCount.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtBox_Comments2GetCount.CustomButton.Name = "";
            this.txtBox_Comments2GetCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_Comments2GetCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_Comments2GetCount.CustomButton.TabIndex = 1;
            this.txtBox_Comments2GetCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_Comments2GetCount.CustomButton.UseSelectable = true;
            this.txtBox_Comments2GetCount.CustomButton.Visible = false;
            this.txtBox_Comments2GetCount.ForeColor = System.Drawing.Color.White;
            this.txtBox_Comments2GetCount.Lines = new string[] {
        "5000"};
            this.txtBox_Comments2GetCount.Location = new System.Drawing.Point(197, 649);
            this.txtBox_Comments2GetCount.MaxLength = 4;
            this.txtBox_Comments2GetCount.Name = "txtBox_Comments2GetCount";
            this.txtBox_Comments2GetCount.PasswordChar = '\0';
            this.txtBox_Comments2GetCount.PromptText = "Max: 5000 per Task! (for now)";
            this.txtBox_Comments2GetCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_Comments2GetCount.SelectedText = "";
            this.txtBox_Comments2GetCount.SelectionLength = 0;
            this.txtBox_Comments2GetCount.SelectionStart = 0;
            this.txtBox_Comments2GetCount.ShortcutsEnabled = true;
            this.txtBox_Comments2GetCount.Size = new System.Drawing.Size(232, 23);
            this.txtBox_Comments2GetCount.TabIndex = 18;
            this.txtBox_Comments2GetCount.Text = "5000";
            this.txtBox_Comments2GetCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBox_Comments2GetCount.UseCustomBackColor = true;
            this.txtBox_Comments2GetCount.UseCustomForeColor = true;
            this.txtBox_Comments2GetCount.UseSelectable = true;
            this.txtBox_Comments2GetCount.UseStyleColors = true;
            this.txtBox_Comments2GetCount.WaterMark = "Max: 5000 per Task! (for now)";
            this.txtBox_Comments2GetCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_Comments2GetCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(19, 646);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(178, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "How much comments to get:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // ProgressSpinner_LoadComments
            // 
            this.ProgressSpinner_LoadComments.Location = new System.Drawing.Point(327, 23);
            this.ProgressSpinner_LoadComments.Maximum = 100;
            this.ProgressSpinner_LoadComments.Name = "ProgressSpinner_LoadComments";
            this.ProgressSpinner_LoadComments.Size = new System.Drawing.Size(29, 30);
            this.ProgressSpinner_LoadComments.TabIndex = 20;
            this.ProgressSpinner_LoadComments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressSpinner_LoadComments.UseCustomBackColor = true;
            this.ProgressSpinner_LoadComments.UseCustomForeColor = true;
            this.ProgressSpinner_LoadComments.UseSelectable = true;
            this.ProgressSpinner_LoadComments.UseStyleColors = true;
            // 
            // CollectComments
            // 
            this.CollectComments.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CollectComments_DoWork);
            // 
            // CommentsList_ScrollBar
            // 
            this.CommentsList_ScrollBar.LargeChange = 10;
            this.CommentsList_ScrollBar.Location = new System.Drawing.Point(997, 80);
            this.CommentsList_ScrollBar.Maximum = 100;
            this.CommentsList_ScrollBar.Minimum = 0;
            this.CommentsList_ScrollBar.MouseWheelBarPartitions = 10;
            this.CommentsList_ScrollBar.Name = "CommentsList_ScrollBar";
            this.CommentsList_ScrollBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.CommentsList_ScrollBar.ScrollbarSize = 15;
            this.CommentsList_ScrollBar.Size = new System.Drawing.Size(15, 463);
            this.CommentsList_ScrollBar.Style = MetroFramework.MetroColorStyle.Purple;
            this.CommentsList_ScrollBar.TabIndex = 22;
            this.CommentsList_ScrollBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CommentsList_ScrollBar.UseBarColor = true;
            this.CommentsList_ScrollBar.UseSelectable = true;
            this.CommentsList_ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CommentsList_ScrollBar_Scroll);
            // 
            // combox_ProfileURLorGroupID
            // 
            this.combox_ProfileURLorGroupID.ForeColor = System.Drawing.Color.White;
            this.combox_ProfileURLorGroupID.FormattingEnabled = true;
            this.combox_ProfileURLorGroupID.ItemHeight = 23;
            this.combox_ProfileURLorGroupID.Location = new System.Drawing.Point(197, 609);
            this.combox_ProfileURLorGroupID.Name = "combox_ProfileURLorGroupID";
            this.combox_ProfileURLorGroupID.Size = new System.Drawing.Size(232, 29);
            this.combox_ProfileURLorGroupID.TabIndex = 24;
            this.combox_ProfileURLorGroupID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.combox_ProfileURLorGroupID.UseCustomForeColor = true;
            this.combox_ProfileURLorGroupID.UseSelectable = true;
            this.combox_ProfileURLorGroupID.UseStyleColors = true;
            this.combox_ProfileURLorGroupID.SelectedIndexChanged += new System.EventHandler(this.combox_ProfileURLorGroupID_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.richTextBox1.Location = new System.Drawing.Point(470, 593);
            this.richTextBox1.MaxLength = 50;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(42, 14);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "└───";
            // 
            // CommentsGather
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.chck_containsWords);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.combox_ProfileURLorGroupID);
            this.Controls.Add(this.CommentsList_ScrollBar);
            this.Controls.Add(this.ProgressSpinner_LoadComments);
            this.Controls.Add(this.txtBox_Comments2GetCount);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbl_totalCommentsInGrid);
            this.Controls.Add(this.GridCommentsData);
            this.Controls.Add(this.txtBox_filterWords);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_doTask);
            this.Controls.Add(this.combox_GatherProfileOrGroup);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CommentsGather";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Mercury - Comments Gather";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommentsGather_FormClosed);
            this.Load += new System.EventHandler(this.CommentsGather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCommentsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox combox_GatherProfileOrGroup;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_doTask;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chck_containsWords;
        private MetroFramework.Controls.MetroTextBox txtBox_filterWords;
        private MetroFramework.Controls.MetroGrid GridCommentsData;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbl_totalCommentsInGrid;
        private MetroFramework.Components.MetroToolTip MongoToolTip;
        private MetroFramework.Controls.MetroTextBox txtBox_Comments2GetCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroProgressSpinner ProgressSpinner_LoadComments;
        private System.ComponentModel.BackgroundWorker CollectComments;
        private MetroFramework.Controls.MetroScrollBar CommentsList_ScrollBar;
        private MetroFramework.Controls.MetroComboBox combox_ProfileURLorGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private MetroFramework.Controls.MetroLabel lbl_cDeletedLive;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}