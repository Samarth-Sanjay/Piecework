namespace Piecework
{
    partial class summaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAveragePay = new System.Windows.Forms.Label();
            this.labelTotalPay = new System.Windows.Forms.Label();
            this.labeltotalPieces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total number of pieces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total pay of all workers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average pay per person ";
            // 
            // labelAveragePay
            // 
            this.labelAveragePay.AutoSize = true;
            this.labelAveragePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAveragePay.Location = new System.Drawing.Point(533, 311);
            this.labelAveragePay.Name = "labelAveragePay";
            this.labelAveragePay.Size = new System.Drawing.Size(0, 37);
            this.labelAveragePay.TabIndex = 3;
            // 
            // labelTotalPay
            // 
            this.labelTotalPay.AutoSize = true;
            this.labelTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPay.Location = new System.Drawing.Point(533, 186);
            this.labelTotalPay.Name = "labelTotalPay";
            this.labelTotalPay.Size = new System.Drawing.Size(0, 37);
            this.labelTotalPay.TabIndex = 4;
            // 
            // labeltotalPieces
            // 
            this.labeltotalPieces.AutoSize = true;
            this.labeltotalPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalPieces.Location = new System.Drawing.Point(533, 54);
            this.labeltotalPieces.Name = "labeltotalPieces";
            this.labeltotalPieces.Size = new System.Drawing.Size(0, 37);
            this.labeltotalPieces.TabIndex = 5;
            // 
            // summaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 512);
            this.Controls.Add(this.labeltotalPieces);
            this.Controls.Add(this.labelTotalPay);
            this.Controls.Add(this.labelAveragePay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "summaryForm";
            this.Text = "Summary Form";
            this.Load += new System.EventHandler(this.summaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAveragePay;
        private System.Windows.Forms.Label labelTotalPay;
        private System.Windows.Forms.Label labeltotalPieces;
    }
}