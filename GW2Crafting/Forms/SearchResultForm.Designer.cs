namespace GW2Crafting.Forms
{
    partial class SearchResultForm
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(13, 13);
            this.lbResult.Name = "lbResult";
            this.lbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbResult.Size = new System.Drawing.Size(549, 381);
            this.lbResult.TabIndex = 0;
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Location = new System.Drawing.Point(394, 401);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(87, 23);
            this.btnAddSelected.TabIndex = 1;
            this.btnAddSelected.Text = "Add Selected";
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(487, 401);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 445);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddSelected);
            this.Controls.Add(this.lbResult);
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.Button btnAddAll;
    }
}