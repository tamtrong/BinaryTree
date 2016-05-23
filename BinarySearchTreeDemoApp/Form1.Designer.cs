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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbCreation = new System.Windows.Forms.GroupBox();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.btnEmptyTree = new System.Windows.Forms.Button();
            this.btnRandomTree = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsertNode = new System.Windows.Forms.TextBox();
            this.txtDeleteNode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbTraversal = new System.Windows.Forms.ComboBox();
            this.btnTraversal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbCreation.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbInformation);
            this.splitContainer1.Panel1.Controls.Add(this.grbAction);
            this.splitContainer1.Panel1.Controls.Add(this.grbCreation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 593);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grbCreation
            // 
            this.grbCreation.Controls.Add(this.btnRandomTree);
            this.grbCreation.Controls.Add(this.btnEmptyTree);
            this.grbCreation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCreation.Location = new System.Drawing.Point(0, 0);
            this.grbCreation.Name = "grbCreation";
            this.grbCreation.Size = new System.Drawing.Size(284, 69);
            this.grbCreation.TabIndex = 0;
            this.grbCreation.TabStop = false;
            this.grbCreation.Text = "Creation";
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnTraversal);
            this.grbAction.Controls.Add(this.cbTraversal);
            this.grbAction.Controls.Add(this.btnDelete);
            this.grbAction.Controls.Add(this.txtDeleteNode);
            this.grbAction.Controls.Add(this.txtInsertNode);
            this.grbAction.Controls.Add(this.btnInsert);
            this.grbAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAction.Location = new System.Drawing.Point(0, 69);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(284, 524);
            this.grbAction.TabIndex = 1;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // grbInformation
            // 
            this.grbInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbInformation.Location = new System.Drawing.Point(0, 378);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(284, 215);
            this.grbInformation.TabIndex = 2;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Information";
            // 
            // btnEmptyTree
            // 
            this.btnEmptyTree.Location = new System.Drawing.Point(31, 20);
            this.btnEmptyTree.Name = "btnEmptyTree";
            this.btnEmptyTree.Size = new System.Drawing.Size(75, 23);
            this.btnEmptyTree.TabIndex = 2;
            this.btnEmptyTree.Text = "Empty Tree";
            this.btnEmptyTree.UseVisualStyleBackColor = true;
            // 
            // btnRandomTree
            // 
            this.btnRandomTree.Location = new System.Drawing.Point(159, 19);
            this.btnRandomTree.Name = "btnRandomTree";
            this.btnRandomTree.Size = new System.Drawing.Size(75, 23);
            this.btnRandomTree.TabIndex = 4;
            this.btnRandomTree.Text = "Random Tree";
            this.btnRandomTree.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(159, 34);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Node";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtInsertNode
            // 
            this.txtInsertNode.Location = new System.Drawing.Point(31, 37);
            this.txtInsertNode.Name = "txtInsertNode";
            this.txtInsertNode.Size = new System.Drawing.Size(100, 20);
            this.txtInsertNode.TabIndex = 2;
            // 
            // txtDeleteNode
            // 
            this.txtDeleteNode.Location = new System.Drawing.Point(31, 80);
            this.txtDeleteNode.Name = "txtDeleteNode";
            this.txtDeleteNode.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteNode.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Node";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbTraversal
            // 
            this.cbTraversal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTraversal.FormattingEnabled = true;
            this.cbTraversal.Items.AddRange(new object[] {
            "Left-Node-Right",
            "Node-Left-Right",
            "Left-Right-Node"});
            this.cbTraversal.Location = new System.Drawing.Point(31, 122);
            this.cbTraversal.Name = "cbTraversal";
            this.cbTraversal.Size = new System.Drawing.Size(100, 21);
            this.cbTraversal.TabIndex = 5;
            // 
            // btnTraversal
            // 
            this.btnTraversal.Location = new System.Drawing.Point(159, 119);
            this.btnTraversal.Name = "btnTraversal";
            this.btnTraversal.Size = new System.Drawing.Size(75, 23);
            this.btnTraversal.TabIndex = 6;
            this.btnTraversal.Text = "Traversal";
            this.btnTraversal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 593);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbCreation.ResumeLayout(false);
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox grbCreation;
        private System.Windows.Forms.Button btnRandomTree;
        private System.Windows.Forms.Button btnEmptyTree;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteNode;
        private System.Windows.Forms.TextBox txtInsertNode;
        private System.Windows.Forms.Button btnTraversal;
        private System.Windows.Forms.ComboBox cbTraversal;
    }
}

