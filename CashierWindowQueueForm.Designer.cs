namespace Cashier_Queuing_Application_TP
{
    partial class CashierWindowQueueForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;

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
            components = new System.ComponentModel.Container();
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 193, 7);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.FromArgb(27, 94, 32);
            btnRefresh.Location = new Point(23, 23);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(27, 94, 32);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(23, 69);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(105, 35);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = Color.White;
            listCashierQueue.BorderStyle = BorderStyle.FixedSingle;
            listCashierQueue.Font = new Font("Segoe UI", 10F);
            listCashierQueue.ForeColor = Color.FromArgb(27, 94, 32);
            listCashierQueue.Location = new Point(152, 23);
            listCashierQueue.Margin = new Padding(4, 3, 4, 3);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(233, 254);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(467, 346);
            Controls.Add(btnRefresh);
            Controls.Add(btnNext);
            Controls.Add(listCashierQueue);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CashierWindowQueueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }
    }
}