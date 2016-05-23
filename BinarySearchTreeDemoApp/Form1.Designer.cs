namespace BinarySearchTreeDemoApp
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtRemoveNode = new MetroFramework.Controls.MetroTextBox();
            this.btnRemoveNode = new MetroFramework.Controls.MetroTile();
            this.txtInsertNode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnInsertNode = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnRandomTree = new MetroFramework.Controls.MetroTile();
            this.btnEmptyTree = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.panelRight = new MetroFramework.Controls.MetroPanel();
            this.cbTraversalTypes = new MetroFramework.Controls.MetroComboBox();
            this.btnTraversal = new MetroFramework.Controls.MetroTile();
            this.btnFindNode = new MetroFramework.Controls.MetroTile();
            this.txtFindNode = new MetroFramework.Controls.MetroTextBox();
            this.btnFindMinNode = new MetroFramework.Controls.MetroTile();
            this.btnFindMaxNode = new MetroFramework.Controls.MetroTile();
            this.btnFindMinNodeOfLeftSubTree = new MetroFramework.Controls.MetroTile();
            this.btnFindMaxNodeOfRightSubTree = new MetroFramework.Controls.MetroTile();
            this.lblNodesCount = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblNodeHave1Child = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblNodeHaveOnly1RightSubTree = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblNodeHaveOnly1LeftSubTree = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblNodeHave2SubTrees = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblLeavesCount = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblNodesOnEachLevel = new MetroFramework.Controls.MetroTile();
            this.metroTile18 = new MetroFramework.Controls.MetroTile();
            this.panelLeft.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.metroTabControl1);
            this.panelLeft.HorizontalScrollbarBarColor = true;
            this.panelLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLeft.HorizontalScrollbarSize = 10;
            this.panelLeft.Location = new System.Drawing.Point(23, 63);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(260, 507);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.VerticalScrollbarBarColor = true;
            this.panelLeft.VerticalScrollbarHighlightOnWheel = false;
            this.panelLeft.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(252, 501);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtRemoveNode);
            this.metroTabPage1.Controls.Add(this.btnRemoveNode);
            this.metroTabPage1.Controls.Add(this.txtInsertNode);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.btnInsertNode);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.btnRandomTree);
            this.metroTabPage1.Controls.Add(this.btnEmptyTree);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(244, 459);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Creation";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtRemoveNode
            // 
            this.txtRemoveNode.Lines = new string[0];
            this.txtRemoveNode.Location = new System.Drawing.Point(122, 151);
            this.txtRemoveNode.MaxLength = 32767;
            this.txtRemoveNode.Name = "txtRemoveNode";
            this.txtRemoveNode.PasswordChar = '\0';
            this.txtRemoveNode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemoveNode.SelectedText = "";
            this.txtRemoveNode.Size = new System.Drawing.Size(122, 33);
            this.txtRemoveNode.TabIndex = 10;
            this.txtRemoveNode.UseSelectable = true;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.ActiveControl = null;
            this.btnRemoveNode.Location = new System.Drawing.Point(0, 151);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(116, 32);
            this.btnRemoveNode.TabIndex = 9;
            this.btnRemoveNode.Text = "Remove Node";
            this.btnRemoveNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveNode.UseSelectable = true;
            // 
            // txtInsertNode
            // 
            this.txtInsertNode.Lines = new string[0];
            this.txtInsertNode.Location = new System.Drawing.Point(122, 107);
            this.txtInsertNode.MaxLength = 32767;
            this.txtInsertNode.Name = "txtInsertNode";
            this.txtInsertNode.PasswordChar = '\0';
            this.txtInsertNode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInsertNode.SelectedText = "";
            this.txtInsertNode.Size = new System.Drawing.Size(122, 33);
            this.txtInsertNode.TabIndex = 8;
            this.txtInsertNode.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Node";
            // 
            // btnInsertNode
            // 
            this.btnInsertNode.ActiveControl = null;
            this.btnInsertNode.Location = new System.Drawing.Point(0, 107);
            this.btnInsertNode.Name = "btnInsertNode";
            this.btnInsertNode.Size = new System.Drawing.Size(116, 32);
            this.btnInsertNode.TabIndex = 5;
            this.btnInsertNode.Text = "Insert Node";
            this.btnInsertNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertNode.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tree";
            // 
            // btnRandomTree
            // 
            this.btnRandomTree.ActiveControl = null;
            this.btnRandomTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRandomTree.Location = new System.Drawing.Point(122, 34);
            this.btnRandomTree.Name = "btnRandomTree";
            this.btnRandomTree.Size = new System.Drawing.Size(123, 32);
            this.btnRandomTree.TabIndex = 3;
            this.btnRandomTree.Text = "Random Tree";
            this.btnRandomTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRandomTree.UseSelectable = true;
            // 
            // btnEmptyTree
            // 
            this.btnEmptyTree.ActiveControl = null;
            this.btnEmptyTree.Location = new System.Drawing.Point(0, 34);
            this.btnEmptyTree.Name = "btnEmptyTree";
            this.btnEmptyTree.Size = new System.Drawing.Size(116, 32);
            this.btnEmptyTree.TabIndex = 2;
            this.btnEmptyTree.Text = "Empty Tree";
            this.btnEmptyTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmptyTree.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage2.Controls.Add(this.btnFindMaxNodeOfRightSubTree);
            this.metroTabPage2.Controls.Add(this.btnFindMinNodeOfLeftSubTree);
            this.metroTabPage2.Controls.Add(this.btnFindMaxNode);
            this.metroTabPage2.Controls.Add(this.btnFindMinNode);
            this.metroTabPage2.Controls.Add(this.txtFindNode);
            this.metroTabPage2.Controls.Add(this.btnFindNode);
            this.metroTabPage2.Controls.Add(this.btnTraversal);
            this.metroTabPage2.Controls.Add(this.cbTraversalTypes);
            this.metroTabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(244, 459);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Action";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lblNodesOnEachLevel);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.lblLeavesCount);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.lblNodeHave2SubTrees);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.lblNodeHaveOnly1LeftSubTree);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.lblNodeHaveOnly1RightSubTree);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.lblNodeHave1Child);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.lblNodesCount);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(244, 459);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Tree Info";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroTile18);
            this.metroTabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(244, 459);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "About";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // panelRight
            // 
            this.panelRight.HorizontalScrollbarBarColor = true;
            this.panelRight.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRight.HorizontalScrollbarSize = 10;
            this.panelRight.Location = new System.Drawing.Point(289, 63);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(810, 507);
            this.panelRight.TabIndex = 1;
            this.panelRight.VerticalScrollbarBarColor = true;
            this.panelRight.VerticalScrollbarHighlightOnWheel = false;
            this.panelRight.VerticalScrollbarSize = 10;
            // 
            // cbTraversalTypes
            // 
            this.cbTraversalTypes.FormattingEnabled = true;
            this.cbTraversalTypes.ItemHeight = 23;
            this.cbTraversalTypes.Items.AddRange(new object[] {
            "Left-Node-Right",
            "Node-Left-Right",
            "Left-Right-Node"});
            this.cbTraversalTypes.Location = new System.Drawing.Point(123, 14);
            this.cbTraversalTypes.Name = "cbTraversalTypes";
            this.cbTraversalTypes.Size = new System.Drawing.Size(112, 29);
            this.cbTraversalTypes.TabIndex = 2;
            this.cbTraversalTypes.UseSelectable = true;
            // 
            // btnTraversal
            // 
            this.btnTraversal.ActiveControl = null;
            this.btnTraversal.Location = new System.Drawing.Point(0, 14);
            this.btnTraversal.Name = "btnTraversal";
            this.btnTraversal.Size = new System.Drawing.Size(117, 29);
            this.btnTraversal.TabIndex = 3;
            this.btnTraversal.Text = "Traversal";
            this.btnTraversal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTraversal.UseSelectable = true;
            // 
            // btnFindNode
            // 
            this.btnFindNode.ActiveControl = null;
            this.btnFindNode.Location = new System.Drawing.Point(0, 59);
            this.btnFindNode.Name = "btnFindNode";
            this.btnFindNode.Size = new System.Drawing.Size(117, 29);
            this.btnFindNode.TabIndex = 5;
            this.btnFindNode.Text = "Find Node";
            this.btnFindNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindNode.UseSelectable = true;
            // 
            // txtFindNode
            // 
            this.txtFindNode.Lines = new string[0];
            this.txtFindNode.Location = new System.Drawing.Point(124, 59);
            this.txtFindNode.MaxLength = 32767;
            this.txtFindNode.Name = "txtFindNode";
            this.txtFindNode.PasswordChar = '\0';
            this.txtFindNode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindNode.SelectedText = "";
            this.txtFindNode.Size = new System.Drawing.Size(111, 30);
            this.txtFindNode.TabIndex = 6;
            this.txtFindNode.UseSelectable = true;
            // 
            // btnFindMinNode
            // 
            this.btnFindMinNode.ActiveControl = null;
            this.btnFindMinNode.Location = new System.Drawing.Point(0, 104);
            this.btnFindMinNode.Name = "btnFindMinNode";
            this.btnFindMinNode.Size = new System.Drawing.Size(117, 29);
            this.btnFindMinNode.TabIndex = 7;
            this.btnFindMinNode.Text = "Find Min Node";
            this.btnFindMinNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindMinNode.UseSelectable = true;
            // 
            // btnFindMaxNode
            // 
            this.btnFindMaxNode.ActiveControl = null;
            this.btnFindMaxNode.Location = new System.Drawing.Point(124, 104);
            this.btnFindMaxNode.Name = "btnFindMaxNode";
            this.btnFindMaxNode.Size = new System.Drawing.Size(111, 29);
            this.btnFindMaxNode.TabIndex = 8;
            this.btnFindMaxNode.Text = "Find Max Node";
            this.btnFindMaxNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindMaxNode.UseSelectable = true;
            // 
            // btnFindMinNodeOfLeftSubTree
            // 
            this.btnFindMinNodeOfLeftSubTree.ActiveControl = null;
            this.btnFindMinNodeOfLeftSubTree.Location = new System.Drawing.Point(0, 149);
            this.btnFindMinNodeOfLeftSubTree.Name = "btnFindMinNodeOfLeftSubTree";
            this.btnFindMinNodeOfLeftSubTree.Size = new System.Drawing.Size(235, 29);
            this.btnFindMinNodeOfLeftSubTree.TabIndex = 9;
            this.btnFindMinNodeOfLeftSubTree.Text = "Find Min Node Of Left SubTree";
            this.btnFindMinNodeOfLeftSubTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindMinNodeOfLeftSubTree.UseSelectable = true;
            // 
            // btnFindMaxNodeOfRightSubTree
            // 
            this.btnFindMaxNodeOfRightSubTree.ActiveControl = null;
            this.btnFindMaxNodeOfRightSubTree.Location = new System.Drawing.Point(0, 194);
            this.btnFindMaxNodeOfRightSubTree.Name = "btnFindMaxNodeOfRightSubTree";
            this.btnFindMaxNodeOfRightSubTree.Size = new System.Drawing.Size(235, 29);
            this.btnFindMaxNodeOfRightSubTree.TabIndex = 10;
            this.btnFindMaxNodeOfRightSubTree.Text = "Find Max Node Of Right SubTree";
            this.btnFindMaxNodeOfRightSubTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindMaxNodeOfRightSubTree.UseSelectable = true;
            // 
            // lblNodesCount
            // 
            this.lblNodesCount.ActiveControl = null;
            this.lblNodesCount.Location = new System.Drawing.Point(162, 15);
            this.lblNodesCount.Name = "lblNodesCount";
            this.lblNodesCount.Size = new System.Drawing.Size(72, 27);
            this.lblNodesCount.TabIndex = 2;
            this.lblNodesCount.Text = "2";
            this.lblNodesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodesCount.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(4, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Nodes Count:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(4, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Nodes Have 1 Child:";
            // 
            // lblNodeHave1Child
            // 
            this.lblNodeHave1Child.ActiveControl = null;
            this.lblNodeHave1Child.Location = new System.Drawing.Point(162, 101);
            this.lblNodeHave1Child.Name = "lblNodeHave1Child";
            this.lblNodeHave1Child.Size = new System.Drawing.Size(72, 27);
            this.lblNodeHave1Child.TabIndex = 4;
            this.lblNodeHave1Child.Text = "2";
            this.lblNodeHave1Child.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodeHave1Child.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(4, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 38);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Nodes Have Only\r\n1 Right SubTree";
            // 
            // lblNodeHaveOnly1RightSubTree
            // 
            this.lblNodeHaveOnly1RightSubTree.ActiveControl = null;
            this.lblNodeHaveOnly1RightSubTree.Location = new System.Drawing.Point(162, 145);
            this.lblNodeHaveOnly1RightSubTree.Name = "lblNodeHaveOnly1RightSubTree";
            this.lblNodeHaveOnly1RightSubTree.Size = new System.Drawing.Size(72, 27);
            this.lblNodeHaveOnly1RightSubTree.TabIndex = 6;
            this.lblNodeHaveOnly1RightSubTree.Text = "2";
            this.lblNodeHaveOnly1RightSubTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodeHaveOnly1RightSubTree.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(4, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 38);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Nodes Have Only\r\n1 Left SubTree";
            // 
            // lblNodeHaveOnly1LeftSubTree
            // 
            this.lblNodeHaveOnly1LeftSubTree.ActiveControl = null;
            this.lblNodeHaveOnly1LeftSubTree.Location = new System.Drawing.Point(162, 189);
            this.lblNodeHaveOnly1LeftSubTree.Name = "lblNodeHaveOnly1LeftSubTree";
            this.lblNodeHaveOnly1LeftSubTree.Size = new System.Drawing.Size(72, 27);
            this.lblNodeHaveOnly1LeftSubTree.TabIndex = 8;
            this.lblNodeHaveOnly1LeftSubTree.Text = "2";
            this.lblNodeHaveOnly1LeftSubTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodeHaveOnly1LeftSubTree.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel7.Location = new System.Drawing.Point(4, 236);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(149, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Nodes Have 2 SubTrees:";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // lblNodeHave2SubTrees
            // 
            this.lblNodeHave2SubTrees.ActiveControl = null;
            this.lblNodeHave2SubTrees.Location = new System.Drawing.Point(162, 233);
            this.lblNodeHave2SubTrees.Name = "lblNodeHave2SubTrees";
            this.lblNodeHave2SubTrees.Size = new System.Drawing.Size(72, 27);
            this.lblNodeHave2SubTrees.TabIndex = 10;
            this.lblNodeHave2SubTrees.Text = "2";
            this.lblNodeHave2SubTrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodeHave2SubTrees.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(4, 61);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(89, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Leaves Count:";
            // 
            // lblLeavesCount
            // 
            this.lblLeavesCount.ActiveControl = null;
            this.lblLeavesCount.Location = new System.Drawing.Point(162, 58);
            this.lblLeavesCount.Name = "lblLeavesCount";
            this.lblLeavesCount.Size = new System.Drawing.Size(72, 27);
            this.lblLeavesCount.TabIndex = 12;
            this.lblLeavesCount.Text = "2";
            this.lblLeavesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeavesCount.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(4, 277);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(136, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Nodes On Each Level:";
            // 
            // lblNodesOnEachLevel
            // 
            this.lblNodesOnEachLevel.ActiveControl = null;
            this.lblNodesOnEachLevel.Location = new System.Drawing.Point(4, 313);
            this.lblNodesOnEachLevel.Name = "lblNodesOnEachLevel";
            this.lblNodesOnEachLevel.Size = new System.Drawing.Size(228, 107);
            this.lblNodesOnEachLevel.TabIndex = 15;
            this.lblNodesOnEachLevel.Text = "Level 1:     1 Nodes\r\nLevel 2:     1 Nodes\r\nLevel 3:     1 Nodes\r\nLevel 4:     1 " +
    "Nodes";
            this.lblNodesOnEachLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNodesOnEachLevel.UseSelectable = true;
            // 
            // metroTile18
            // 
            this.metroTile18.ActiveControl = null;
            this.metroTile18.Location = new System.Drawing.Point(0, 16);
            this.metroTile18.Name = "metroTile18";
            this.metroTile18.Size = new System.Drawing.Size(244, 443);
            this.metroTile18.TabIndex = 2;
            this.metroTile18.Text = "Final Project\r\n\r\n1212326 - Vo Nhat Sinh\r\n1212350 - Vu Trong Tam\r\n1212357 - Pham T" +
    "hanh Tan";
            this.metroTile18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile18.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 593);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Demo Binary Search Tree";
            this.panelLeft.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel panelLeft;
        private MetroFramework.Controls.MetroPanel panelRight;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTile btnRandomTree;
        private MetroFramework.Controls.MetroTile btnEmptyTree;
        private MetroFramework.Controls.MetroTextBox txtRemoveNode;
        private MetroFramework.Controls.MetroTile btnRemoveNode;
        private MetroFramework.Controls.MetroTextBox txtInsertNode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnInsertNode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnTraversal;
        private MetroFramework.Controls.MetroComboBox cbTraversalTypes;
        private MetroFramework.Controls.MetroTile btnFindMaxNodeOfRightSubTree;
        private MetroFramework.Controls.MetroTile btnFindMinNodeOfLeftSubTree;
        private MetroFramework.Controls.MetroTile btnFindMaxNode;
        private MetroFramework.Controls.MetroTile btnFindMinNode;
        private MetroFramework.Controls.MetroTextBox txtFindNode;
        private MetroFramework.Controls.MetroTile btnFindNode;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile lblNodeHave2SubTrees;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile lblNodeHaveOnly1LeftSubTree;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile lblNodeHaveOnly1RightSubTree;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile lblNodeHave1Child;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile lblNodesCount;
        private MetroFramework.Controls.MetroTile metroTile18;
        private MetroFramework.Controls.MetroTile lblNodesOnEachLevel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile lblLeavesCount;
    }
}

