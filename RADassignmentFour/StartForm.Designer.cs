namespace RADassignmentFour
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CenterLogoPicture = new System.Windows.Forms.PictureBox();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.StartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLayoutPanel
            // 
            this.StartLayoutPanel.ColumnCount = 1;
            this.StartLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartLayoutPanel.Controls.Add(this.CenterLogoPicture, 0, 1);
            this.StartLayoutPanel.Controls.Add(this.WelcomLabel, 0, 0);
            this.StartLayoutPanel.Controls.Add(this.StartNewOrderButton, 0, 2);
            this.StartLayoutPanel.Controls.Add(this.OpenSavedOrderButton, 0, 3);
            this.StartLayoutPanel.Controls.Add(this.Exitbutton, 0, 4);
            this.StartLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.StartLayoutPanel.Name = "StartLayoutPanel";
            this.StartLayoutPanel.RowCount = 5;
            this.StartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartLayoutPanel.Size = new System.Drawing.Size(209, 299);
            this.StartLayoutPanel.TabIndex = 0;
            // 
            // CenterLogoPicture
            // 
            this.CenterLogoPicture.Location = new System.Drawing.Point(3, 33);
            this.CenterLogoPicture.Name = "CenterLogoPicture";
            this.CenterLogoPicture.Size = new System.Drawing.Size(203, 173);
            this.CenterLogoPicture.TabIndex = 0;
            this.CenterLogoPicture.TabStop = false;
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.AutoSize = true;
            this.WelcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLabel.Location = new System.Drawing.Point(3, 0);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(196, 15);
            this.WelcomLabel.TabIndex = 1;
            this.WelcomLabel.Text = "Order Your Computer Today~!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(3, 212);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(203, 23);
            this.StartNewOrderButton.TabIndex = 2;
            this.StartNewOrderButton.Text = "Start New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(3, 242);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(203, 23);
            this.OpenSavedOrderButton.TabIndex = 2;
            this.OpenSavedOrderButton.Text = "Open Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(3, 272);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(203, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 312);
            this.ControlBox = false;
            this.Controls.Add(this.StartLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computers";
            this.StartLayoutPanel.ResumeLayout(false);
            this.StartLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StartLayoutPanel;
        private System.Windows.Forms.PictureBox CenterLogoPicture;
        private System.Windows.Forms.Label WelcomLabel;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}