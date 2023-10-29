namespace THECRIMS_BOT
{
    partial class web
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button_webwiev_gizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 37);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(984, 680);
            this.webView21.Source = new System.Uri("https://www.thecrims.com/#/", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // button_webwiev_gizle
            // 
            this.button_webwiev_gizle.Location = new System.Drawing.Point(12, 8);
            this.button_webwiev_gizle.Name = "button_webwiev_gizle";
            this.button_webwiev_gizle.Size = new System.Drawing.Size(119, 23);
            this.button_webwiev_gizle.TabIndex = 1;
            this.button_webwiev_gizle.Text = "GİZLE";
            this.button_webwiev_gizle.UseVisualStyleBackColor = true;
            this.button_webwiev_gizle.Click += new System.EventHandler(this.button_webwiev_gizle_Click);
            // 
            // web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.button_webwiev_gizle);
            this.Controls.Add(this.webView21);
            this.Name = "web";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "web";
            this.Load += new System.EventHandler(this.web_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        public System.Windows.Forms.Button button_webwiev_gizle;
    }
}