namespace svanTipuricZadaciZamjena2
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
            this.btnIExplorer = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnStartInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIExplorer
            // 
            this.btnIExplorer.Location = new System.Drawing.Point(187, 79);
            this.btnIExplorer.Name = "btnIExplorer";
            this.btnIExplorer.Size = new System.Drawing.Size(151, 36);
            this.btnIExplorer.TabIndex = 0;
            this.btnIExplorer.Text = "Internet Explorer";
            this.btnIExplorer.UseVisualStyleBackColor = true;
            this.btnIExplorer.Click += new System.EventHandler(this.BtnIExplorer_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(411, 79);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(161, 36);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(187, 190);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(151, 33);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnStartInfo
            // 
            this.btnStartInfo.Location = new System.Drawing.Point(411, 190);
            this.btnStartInfo.Name = "btnStartInfo";
            this.btnStartInfo.Size = new System.Drawing.Size(161, 33);
            this.btnStartInfo.TabIndex = 3;
            this.btnStartInfo.Text = "Start info";
            this.btnStartInfo.UseVisualStyleBackColor = true;
            this.btnStartInfo.Click += new System.EventHandler(this.BtnStartInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartInfo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnIExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIExplorer;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnStartInfo;
    }
}

