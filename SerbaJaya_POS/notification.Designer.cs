
namespace SerbaJaya_POS
{
    partial class notification
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
            this.tbNotif = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbNotif
            // 
            this.tbNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotif.Location = new System.Drawing.Point(12, 12);
            this.tbNotif.Name = "tbNotif";
            this.tbNotif.Size = new System.Drawing.Size(465, 345);
            this.tbNotif.TabIndex = 0;
            this.tbNotif.Text = "";
            // 
            // notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.tbNotif);
            this.MaximizeBox = false;
            this.Name = "notification";
            this.Text = "notification";
            this.Load += new System.EventHandler(this.notification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbNotif;
    }
}