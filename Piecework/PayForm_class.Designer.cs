namespace Piecework
{
    partial class PayForm_class
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
            this.labelvalue = new System.Windows.Forms.Label();
            this.labelamountEarned = new System.Windows.Forms.Label();
            this.buttonclearAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxNumberOfPieces = new System.Windows.Forms.TextBox();
            this.labelNumberofPieces = new System.Windows.Forms.Label();
            this.labelWorkersName = new System.Windows.Forms.Label();
            this.textBoxWorkersName = new System.Windows.Forms.TextBox();
            this.checkBoxSeniorPay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelvalue
            // 
            this.labelvalue.AutoSize = true;
            this.labelvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalue.Location = new System.Drawing.Point(897, 373);
            this.labelvalue.Name = "labelvalue";
            this.labelvalue.Size = new System.Drawing.Size(92, 37);
            this.labelvalue.TabIndex = 21;
            this.labelvalue.Text = "value";
            // 
            // labelamountEarned
            // 
            this.labelamountEarned.AutoSize = true;
            this.labelamountEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamountEarned.Location = new System.Drawing.Point(897, 253);
            this.labelamountEarned.Name = "labelamountEarned";
            this.labelamountEarned.Size = new System.Drawing.Size(237, 37);
            this.labelamountEarned.TabIndex = 20;
            this.labelamountEarned.Text = "Amount earned";
            // 
            // buttonclearAll
            // 
            this.buttonclearAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonclearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclearAll.Location = new System.Drawing.Point(562, 348);
            this.buttonclearAll.Name = "buttonclearAll";
            this.buttonclearAll.Size = new System.Drawing.Size(276, 86);
            this.buttonclearAll.TabIndex = 19;
            this.buttonclearAll.Text = "Clear All";
            this.buttonclearAll.UseVisualStyleBackColor = false;
            this.buttonclearAll.Click += new System.EventHandler(this.buttonclearAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(224, 337);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(291, 86);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummary.Location = new System.Drawing.Point(562, 204);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(276, 86);
            this.buttonSummary.TabIndex = 17;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(224, 204);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(291, 86);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxNumberOfPieces
            // 
            this.textBoxNumberOfPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfPieces.Location = new System.Drawing.Point(650, 124);
            this.textBoxNumberOfPieces.Name = "textBoxNumberOfPieces";
            this.textBoxNumberOfPieces.Size = new System.Drawing.Size(322, 44);
            this.textBoxNumberOfPieces.TabIndex = 15;
            // 
            // labelNumberofPieces
            // 
            this.labelNumberofPieces.AutoSize = true;
            this.labelNumberofPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberofPieces.Location = new System.Drawing.Point(131, 131);
            this.labelNumberofPieces.Name = "labelNumberofPieces";
            this.labelNumberofPieces.Size = new System.Drawing.Size(450, 37);
            this.labelNumberofPieces.TabIndex = 14;
            this.labelNumberofPieces.Text = "Number Of Pieces Completed:";
            // 
            // labelWorkersName
            // 
            this.labelWorkersName.AutoSize = true;
            this.labelWorkersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkersName.Location = new System.Drawing.Point(333, 40);
            this.labelWorkersName.Name = "labelWorkersName";
            this.labelWorkersName.Size = new System.Drawing.Size(248, 37);
            this.labelWorkersName.TabIndex = 13;
            this.labelWorkersName.Text = "Worker\'s Name:";
            // 
            // textBoxWorkersName
            // 
            this.textBoxWorkersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkersName.Location = new System.Drawing.Point(650, 28);
            this.textBoxWorkersName.Name = "textBoxWorkersName";
            this.textBoxWorkersName.Size = new System.Drawing.Size(322, 49);
            this.textBoxWorkersName.TabIndex = 12;
            // 
            // checkBoxSeniorPay
            // 
            this.checkBoxSeniorPay.AutoSize = true;
            this.checkBoxSeniorPay.Location = new System.Drawing.Point(77, 45);
            this.checkBoxSeniorPay.Name = "checkBoxSeniorPay";
            this.checkBoxSeniorPay.Size = new System.Drawing.Size(155, 29);
            this.checkBoxSeniorPay.TabIndex = 22;
            this.checkBoxSeniorPay.Text = "Senior PAY";
            this.checkBoxSeniorPay.UseVisualStyleBackColor = true;
            // 
            // PayForm_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 566);
            this.Controls.Add(this.checkBoxSeniorPay);
            this.Controls.Add(this.labelvalue);
            this.Controls.Add(this.labelamountEarned);
            this.Controls.Add(this.buttonclearAll);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxNumberOfPieces);
            this.Controls.Add(this.labelNumberofPieces);
            this.Controls.Add(this.labelWorkersName);
            this.Controls.Add(this.textBoxWorkersName);
            this.Name = "PayForm_class";
            this.Text = "PayForm_class";
            this.Load += new System.EventHandler(this.PayForm_class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelvalue;
        private System.Windows.Forms.Label labelamountEarned;
        private System.Windows.Forms.Button buttonclearAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxNumberOfPieces;
        private System.Windows.Forms.Label labelNumberofPieces;
        private System.Windows.Forms.Label labelWorkersName;
        private System.Windows.Forms.TextBox textBoxWorkersName;
        private System.Windows.Forms.CheckBox checkBoxSeniorPay;
    }
}