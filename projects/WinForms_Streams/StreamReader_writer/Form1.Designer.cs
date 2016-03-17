namespace StreamReader_writer
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
            this._txtInputOutput = new System.Windows.Forms.TextBox();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtInputOutput
            // 
            this._txtInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtInputOutput.Location = new System.Drawing.Point(0, 49);
            this._txtInputOutput.Multiline = true;
            this._txtInputOutput.Name = "_txtInputOutput";
            this._txtInputOutput.Size = new System.Drawing.Size(470, 346);
            this._txtInputOutput.TabIndex = 0;
            // 
            // _btnLoad
            // 
            this._btnLoad.Location = new System.Drawing.Point(13, 8);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(75, 35);
            this._btnLoad.TabIndex = 1;
            this._btnLoad.Text = "Load...";
            this._btnLoad.UseVisualStyleBackColor = true;
            this._btnLoad.Click += new System.EventHandler(this._btnLoad_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(94, 8);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 35);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save...";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 394);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnLoad);
            this.Controls.Add(this._txtInputOutput);
            this.Name = "Form1";
            this.Text = "My Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtInputOutput;
        private System.Windows.Forms.Button _btnLoad;
        private System.Windows.Forms.Button _btnSave;
    }
}

