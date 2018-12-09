namespace Piecework
{
    partial class PayForm
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
            this.textBoxWorkersName = new System.Windows.Forms.TextBox();
            this.labelWorkersName = new System.Windows.Forms.Label();
            this.labelNumberofPieces = new System.Windows.Forms.Label();
            this.textBoxNumberOfPieces = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonclearAll = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatePayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculatePayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelamountEarned = new System.Windows.Forms.Label();
            this.labelvalue = new System.Windows.Forms.Label();
            this.buttonPayform = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWorkersName
            // 
            this.textBoxWorkersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkersName.Location = new System.Drawing.Point(573, 66);
            this.textBoxWorkersName.Name = "textBoxWorkersName";
            this.textBoxWorkersName.Size = new System.Drawing.Size(322, 49);
            this.textBoxWorkersName.TabIndex = 0;
            this.textBoxWorkersName.TextChanged += new System.EventHandler(this.textBoxWorkersName_TextChanged);
            // 
            // labelWorkersName
            // 
            this.labelWorkersName.AutoSize = true;
            this.labelWorkersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkersName.Location = new System.Drawing.Point(256, 78);
            this.labelWorkersName.Name = "labelWorkersName";
            this.labelWorkersName.Size = new System.Drawing.Size(248, 37);
            this.labelWorkersName.TabIndex = 1;
            this.labelWorkersName.Text = "Worker\'s Name:";
            // 
            // labelNumberofPieces
            // 
            this.labelNumberofPieces.AutoSize = true;
            this.labelNumberofPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberofPieces.Location = new System.Drawing.Point(54, 169);
            this.labelNumberofPieces.Name = "labelNumberofPieces";
            this.labelNumberofPieces.Size = new System.Drawing.Size(450, 37);
            this.labelNumberofPieces.TabIndex = 2;
            this.labelNumberofPieces.Text = "Number Of Pieces Completed:";
            // 
            // textBoxNumberOfPieces
            // 
            this.textBoxNumberOfPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfPieces.Location = new System.Drawing.Point(573, 162);
            this.textBoxNumberOfPieces.Name = "textBoxNumberOfPieces";
            this.textBoxNumberOfPieces.Size = new System.Drawing.Size(322, 44);
            this.textBoxNumberOfPieces.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(97, 281);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(291, 86);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummary.Location = new System.Drawing.Point(449, 281);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(276, 86);
            this.buttonSummary.TabIndex = 5;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(97, 411);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(291, 86);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonclearAll
            // 
            this.buttonclearAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonclearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclearAll.Location = new System.Drawing.Point(449, 411);
            this.buttonclearAll.Name = "buttonclearAll";
            this.buttonclearAll.Size = new System.Drawing.Size(276, 86);
            this.buttonclearAll.TabIndex = 7;
            this.buttonclearAll.Text = "Clear All";
            this.buttonclearAll.UseVisualStyleBackColor = false;
            this.buttonclearAll.Click += new System.EventHandler(this.buttonclearAll_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(304, 36);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 40);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatePayToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(64, 36);
            this.toolStripMenuItem2.Text = "File";
            // 
            // calculatePayToolStripMenuItem
            // 
            this.calculatePayToolStripMenuItem.Name = "calculatePayToolStripMenuItem";
            this.calculatePayToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.calculatePayToolStripMenuItem.Text = "Calculate Pay";
            this.calculatePayToolStripMenuItem.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.buttonclearAll_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatePayToolStripMenuItem1,
            this.summaryToolStripMenuItem1,
            this.exitToolStripMenuItem1,
            this.clearToolStripMenuItem1,
            this.clearAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 184);
            // 
            // calculatePayToolStripMenuItem1
            // 
            this.calculatePayToolStripMenuItem1.Name = "calculatePayToolStripMenuItem1";
            this.calculatePayToolStripMenuItem1.Size = new System.Drawing.Size(230, 36);
            this.calculatePayToolStripMenuItem1.Text = "Calculate Pay";
            this.calculatePayToolStripMenuItem1.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // summaryToolStripMenuItem1
            // 
            this.summaryToolStripMenuItem1.Name = "summaryToolStripMenuItem1";
            this.summaryToolStripMenuItem1.Size = new System.Drawing.Size(230, 36);
            this.summaryToolStripMenuItem1.Text = "Summary";
            this.summaryToolStripMenuItem1.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(230, 36);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(230, 36);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // clearAllToolStripMenuItem1
            // 
            this.clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            this.clearAllToolStripMenuItem1.Size = new System.Drawing.Size(230, 36);
            this.clearAllToolStripMenuItem1.Text = "Clear All";
            this.clearAllToolStripMenuItem1.Click += new System.EventHandler(this.buttonclearAll_Click);
            // 
            // labelamountEarned
            // 
            this.labelamountEarned.AutoSize = true;
            this.labelamountEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamountEarned.Location = new System.Drawing.Point(788, 281);
            this.labelamountEarned.Name = "labelamountEarned";
            this.labelamountEarned.Size = new System.Drawing.Size(246, 37);
            this.labelamountEarned.TabIndex = 10;
            this.labelamountEarned.Text = "Amount earned:\r\n";
            // 
            // labelvalue
            // 
            this.labelvalue.AutoSize = true;
            this.labelvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalue.Location = new System.Drawing.Point(848, 330);
            this.labelvalue.Name = "labelvalue";
            this.labelvalue.Size = new System.Drawing.Size(113, 37);
            this.labelvalue.TabIndex = 11;
            this.labelvalue.Text = "$ 0.00";
            // 
            // buttonPayform
            // 
            this.buttonPayform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayform.Location = new System.Drawing.Point(768, 411);
            this.buttonPayform.Name = "buttonPayform";
            this.buttonPayform.Size = new System.Drawing.Size(276, 86);
            this.buttonPayform.TabIndex = 12;
            this.buttonPayform.Text = "Pay Form";
            this.buttonPayform.UseVisualStyleBackColor = true;
            this.buttonPayform.Click += new System.EventHandler(this.buttonPayform_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 536);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonPayform);
            this.Controls.Add(this.labelvalue);
            this.Controls.Add(this.labelamountEarned);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonclearAll);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxNumberOfPieces);
            this.Controls.Add(this.labelNumberofPieces);
            this.Controls.Add(this.labelWorkersName);
            this.Controls.Add(this.textBoxWorkersName);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWorkersName;
        private System.Windows.Forms.Label labelWorkersName;
        private System.Windows.Forms.Label labelNumberofPieces;
        private System.Windows.Forms.TextBox textBoxNumberOfPieces;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonclearAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem calculatePayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatePayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem1;
        private System.Windows.Forms.Label labelamountEarned;
        private System.Windows.Forms.Label labelvalue;
        private System.Windows.Forms.Button buttonPayform;
    }
}

