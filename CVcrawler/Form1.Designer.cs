
namespace CVcrawler
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultList = new System.Windows.Forms.ListView();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tutBtn = new System.Windows.Forms.Button();
            this.AnalyzeBtn = new System.Windows.Forms.Button();
            this.extractBtn = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader});
            this.ResultList.FullRowSelect = true;
            this.ResultList.GridLines = true;
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(12, 12);
            this.ResultList.MultiSelect = false;
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(226, 259);
            this.ResultList.TabIndex = 1;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name of CV";
            this.NameColumnHeader.Width = 203;
            // 
            // tutBtn
            // 
            this.tutBtn.Location = new System.Drawing.Point(244, 41);
            this.tutBtn.Name = "tutBtn";
            this.tutBtn.Size = new System.Drawing.Size(75, 23);
            this.tutBtn.TabIndex = 3;
            this.tutBtn.Text = "Tutorial";
            this.tutBtn.UseVisualStyleBackColor = true;
            this.tutBtn.Click += new System.EventHandler(this.tutBtn_Click);
            // 
            // AnalyzeBtn
            // 
            this.AnalyzeBtn.Location = new System.Drawing.Point(244, 70);
            this.AnalyzeBtn.Name = "AnalyzeBtn";
            this.AnalyzeBtn.Size = new System.Drawing.Size(75, 23);
            this.AnalyzeBtn.TabIndex = 4;
            this.AnalyzeBtn.Text = "Analyze";
            this.AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AnalyzeBtn.Click += new System.EventHandler(this.AnalyzeBtn_Click);
            // 
            // extractBtn
            // 
            this.extractBtn.Location = new System.Drawing.Point(244, 99);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(75, 23);
            this.extractBtn.TabIndex = 5;
            this.extractBtn.Text = "Extract Text";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(244, 147);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(75, 20);
            this.keyTextBox.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(244, 173);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search Key";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(244, 202);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 8;
            this.openBtn.Text = "Open Selected";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 280);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.AnalyzeBtn);
            this.Controls.Add(this.tutBtn);
            this.Controls.Add(this.ResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CVcrawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.Button tutBtn;
        private System.Windows.Forms.Button AnalyzeBtn;
        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button openBtn;
    }
}

