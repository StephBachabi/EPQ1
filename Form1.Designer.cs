namespace EPQ1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FunctionOpener = new Button();
            SampleViewer = new Button();
            YAxis = new Panel();
            XAxis = new Panel();
            SuspendLayout();
            // 
            // FunctionOpener
            // 
            FunctionOpener.AutoSize = true;
            FunctionOpener.BackColor = Color.DimGray;
            FunctionOpener.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FunctionOpener.ForeColor = Color.Red;
            FunctionOpener.Location = new Point(12, 12);
            FunctionOpener.Name = "FunctionOpener";
            FunctionOpener.Size = new Size(100, 55);
            FunctionOpener.TabIndex = 1;
            FunctionOpener.Text = "Function";
            FunctionOpener.UseVisualStyleBackColor = false;
            FunctionOpener.Click += FunctionOpener_Click;
            // 
            // SampleViewer
            // 
            SampleViewer.AutoSize = true;
            SampleViewer.BackColor = Color.DimGray;
            SampleViewer.Font = new Font("Gabriola", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SampleViewer.ForeColor = Color.Red;
            SampleViewer.Location = new Point(12, 66);
            SampleViewer.Name = "SampleViewer";
            SampleViewer.Size = new Size(100, 55);
            SampleViewer.TabIndex = 2;
            SampleViewer.Text = "Sample";
            SampleViewer.UseVisualStyleBackColor = false;
            SampleViewer.Click += SampleViewer_Click;
            // 
            // YAxis
            // 
            YAxis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            YAxis.BackColor = SystemColors.ControlDarkDark;
            YAxis.Location = new Point(408, 0);
            YAxis.Name = "YAxis";
            YAxis.Size = new Size(1, 487);
            YAxis.TabIndex = 3;
            // 
            // XAxis
            // 
            XAxis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            XAxis.BackColor = SystemColors.ControlDarkDark;
            XAxis.Location = new Point(0, 244);
            XAxis.Name = "XAxis";
            XAxis.Size = new Size(800, 1);
            XAxis.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(XAxis);
            Controls.Add(YAxis);
            Controls.Add(SampleViewer);
            Controls.Add(FunctionOpener);
            Name = "Form1";
            Text = "Extended Project Qualification";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button FunctionOpener;
        private Button SampleViewer;
        private Panel YAxis;
        private Panel XAxis;
    }
}
