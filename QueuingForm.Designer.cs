namespace Cashier_Queuing_Application_TP
{
    partial class QueuingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQueue = new Label();
            lblTitle = new Label();
            lblHint = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.FromArgb(27, 94, 32);
            btnCashier.FlatAppearance.BorderSize = 0;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(23, 81);
            btnCashier.Margin = new Padding(4, 3, 4, 3);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(117, 69);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblQueue.ForeColor = Color.FromArgb(255, 193, 7);
            lblQueue.Location = new Point(175, 69);
            lblQueue.Margin = new Padding(4, 0, 4, 0);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(257, 69);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10000";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 94, 32);
            lblTitle.Location = new Point(175, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Position in Queue";
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblHint.ForeColor = Color.Firebrick;
            lblHint.Location = new Point(23, 162);
            lblHint.Margin = new Padding(4, 0, 4, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(175, 23);
            lblHint.TabIndex = 3;
            lblHint.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(467, 231);
            Controls.Add(btnCashier);
            Controls.Add(lblTitle);
            Controls.Add(lblQueue);
            Controls.Add(lblHint);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            ResumeLayout(false);
        }
    }
}
