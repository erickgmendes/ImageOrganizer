namespace ImageOrganizer
{
    partial class FormPrincipal
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblOrigin = new System.Windows.Forms.Label();
            this.LblTarget = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOrganize = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtOrigin = new System.Windows.Forms.TextBox();
            this.BtnOrigin = new System.Windows.Forms.Button();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnTarget = new System.Windows.Forms.Button();
            this.LstStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(824, 28);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // LblOrigin
            // 
            this.LblOrigin.AutoSize = true;
            this.LblOrigin.Location = new System.Drawing.Point(12, 9);
            this.LblOrigin.Name = "LblOrigin";
            this.LblOrigin.Size = new System.Drawing.Size(50, 20);
            this.LblOrigin.TabIndex = 0;
            this.LblOrigin.Text = "Origin";
            // 
            // LblTarget
            // 
            this.LblTarget.AutoSize = true;
            this.LblTarget.Location = new System.Drawing.Point(12, 75);
            this.LblTarget.Name = "LblTarget";
            this.LblTarget.Size = new System.Drawing.Size(50, 20);
            this.LblTarget.TabIndex = 1;
            this.LblTarget.Text = "Target";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(692, 361);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 40);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOrganize
            // 
            this.BtnOrganize.Location = new System.Drawing.Point(566, 361);
            this.BtnOrganize.Name = "BtnOrganize";
            this.BtnOrganize.Size = new System.Drawing.Size(120, 40);
            this.BtnOrganize.TabIndex = 0;
            this.BtnOrganize.Text = "Organize";
            this.BtnOrganize.UseVisualStyleBackColor = true;
            this.BtnOrganize.Click += new System.EventHandler(this.BtnOrganize_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(13, 140);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(49, 20);
            this.LblStatus.TabIndex = 5;
            this.LblStatus.Text = "Status";
            // 
            // TxtOrigin
            // 
            this.TxtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOrigin.Location = new System.Drawing.Point(12, 32);
            this.TxtOrigin.Name = "TxtOrigin";
            this.TxtOrigin.ReadOnly = true;
            this.TxtOrigin.Size = new System.Drawing.Size(773, 27);
            this.TxtOrigin.TabIndex = 2;
            // 
            // BtnOrigin
            // 
            this.BtnOrigin.Location = new System.Drawing.Point(785, 31);
            this.BtnOrigin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOrigin.Name = "BtnOrigin";
            this.BtnOrigin.Size = new System.Drawing.Size(27, 27);
            this.BtnOrigin.TabIndex = 3;
            this.BtnOrigin.Text = "!";
            this.BtnOrigin.UseVisualStyleBackColor = true;
            this.BtnOrigin.Click += new System.EventHandler(this.BtnOrigin_Click);
            // 
            // TxtTarget
            // 
            this.TxtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarget.Location = new System.Drawing.Point(12, 100);
            this.TxtTarget.Margin = new System.Windows.Forms.Padding(0);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.ReadOnly = true;
            this.TxtTarget.Size = new System.Drawing.Size(773, 27);
            this.TxtTarget.TabIndex = 3;
            // 
            // BtnTarget
            // 
            this.BtnTarget.Location = new System.Drawing.Point(785, 99);
            this.BtnTarget.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTarget.Name = "BtnTarget";
            this.BtnTarget.Size = new System.Drawing.Size(27, 27);
            this.BtnTarget.TabIndex = 2;
            this.BtnTarget.Text = "!";
            this.BtnTarget.UseVisualStyleBackColor = true;
            this.BtnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // LstStatus
            // 
            this.LstStatus.FormattingEnabled = true;
            this.LstStatus.ItemHeight = 20;
            this.LstStatus.Location = new System.Drawing.Point(13, 163);
            this.LstStatus.Name = "LstStatus";
            this.LstStatus.Size = new System.Drawing.Size(799, 184);
            this.LstStatus.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 440);
            this.Controls.Add(this.LstStatus);
            this.Controls.Add(this.BtnTarget);
            this.Controls.Add(this.BtnOrigin);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnOrganize);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.TxtOrigin);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblTarget);
            this.Controls.Add(this.LblOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private ProgressBar progressBar1;
        private Label LblOrigin;
        private Label LblTarget;
        private Button BtnClose;
        private Button BtnOrganize;
        private Label LblStatus;
        private TextBox TxtOrigin;
        private Button BtnOrigin;
        private TextBox TxtTarget;
        private Button BtnTarget;
        private ListBox LstStatus;
    }
}