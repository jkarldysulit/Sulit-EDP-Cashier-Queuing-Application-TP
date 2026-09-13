namespace Cashier_Queuing_Application_TP
{
    partial class CustomerView
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
            components = new System.ComponentModel.Container();
            lblNowServing = new Label();
            lblView = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblNowServing
            // 
            lblNowServing.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNowServing.ForeColor = Color.FromArgb(27, 94, 32);
            lblNowServing.Location = new Point(13, 31);
            lblNowServing.Margin = new Padding(4, 0, 4, 0);
            lblNowServing.Name = "lblNowServing";
            lblNowServing.Size = new Size(209, 35);
            lblNowServing.TabIndex = 2;
            lblNowServing.Text = "*Now Serving";
            // 
            // lblView
            // 
            lblView.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblView.ForeColor = Color.FromArgb(255, 193, 7);
            lblView.Location = new Point(142, 98);
            lblView.Margin = new Padding(4, 0, 4, 0);
            lblView.Name = "lblView";
            lblView.Size = new Size(257, 69);
            lblView.TabIndex = 3;
            lblView.Text = "P - 10000";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 231);
            Controls.Add(lblView);
            Controls.Add(lblNowServing);
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerView";
            ResumeLayout(false);
        }

        #endregion

        private Label lblNowServing;
        private Label lblView;
        private System.Windows.Forms.Timer timer1;
    }
}