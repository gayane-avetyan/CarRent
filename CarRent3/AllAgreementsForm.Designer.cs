namespace CarRent3
{
    partial class AllAgreementsForm
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
            this.dgvAllAgreements = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAgreements)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAgreements
            // 
            this.dgvAllAgreements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllAgreements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllAgreements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAgreements.Location = new System.Drawing.Point(12, 12);
            this.dgvAllAgreements.Name = "dgvAllAgreements";
            this.dgvAllAgreements.RowTemplate.Height = 28;
            this.dgvAllAgreements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAgreements.Size = new System.Drawing.Size(1160, 496);
            this.dgvAllAgreements.TabIndex = 0;
            this.dgvAllAgreements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllAgreements_CellContentClick);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOk.Location = new System.Drawing.Point(593, 540);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 44);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Cancel";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSelect.Location = new System.Drawing.Point(419, 540);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(141, 44);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AllAgreementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 617);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvAllAgreements);
            this.Name = "AllAgreementsForm";
            this.Text = "AllAgreementsForm";
            this.Load += new System.EventHandler(this.AllAgreementsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAgreements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAgreements;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSelect;
    }
}