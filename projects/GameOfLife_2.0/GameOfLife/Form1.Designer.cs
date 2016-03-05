namespace GameOfLife
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._canvas = new System.Windows.Forms.Panel();
            this._btnGo = new System.Windows.Forms.Button();
            this._lblCount = new System.Windows.Forms.Label();
            this._btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _canvas
            // 
            this._canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._canvas.Location = new System.Drawing.Point(12, 41);
            this._canvas.Name = "_canvas";
            this._canvas.Size = new System.Drawing.Size(453, 457);
            this._canvas.TabIndex = 0;
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(12, 12);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(75, 23);
            this._btnGo.TabIndex = 1;
            this._btnGo.Text = "Go";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
            // 
            // _lblCount
            // 
            this._lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCount.ForeColor = System.Drawing.Color.Gray;
            this._lblCount.Location = new System.Drawing.Point(399, 17);
            this._lblCount.Name = "_lblCount";
            this._lblCount.Size = new System.Drawing.Size(66, 18);
            this._lblCount.TabIndex = 2;
            this._lblCount.Text = "0";
            this._lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _btnRestart
            // 
            this._btnRestart.Location = new System.Drawing.Point(93, 12);
            this._btnRestart.Name = "_btnRestart";
            this._btnRestart.Size = new System.Drawing.Size(75, 23);
            this._btnRestart.TabIndex = 3;
            this._btnRestart.Text = "Restart";
            this._btnRestart.UseVisualStyleBackColor = true;
            this._btnRestart.Click += new System.EventHandler(this._btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 510);
            this.Controls.Add(this._btnRestart);
            this.Controls.Add(this._lblCount);
            this.Controls.Add(this._btnGo);
            this.Controls.Add(this._canvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 490);
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _canvas;
        private System.Windows.Forms.Button _btnGo;
        private System.Windows.Forms.Label _lblCount;
        private System.Windows.Forms.Button _btnRestart;
    }
}

