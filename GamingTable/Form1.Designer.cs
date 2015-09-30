namespace GamingTable
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ButtonHost = new System.Windows.Forms.Button();
            this.ButtonJoin = new System.Windows.Forms.Button();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.72811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.27189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.ErrMsg, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonHost, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ButtonJoin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.IPAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Nickname, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.65517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.34483F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ErrMsg, 3);
            this.ErrMsg.Location = new System.Drawing.Point(3, 143);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 8);
            this.ErrMsg.TabIndex = 2;
            this.ErrMsg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Title, 4);
            this.Title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(25, 0);
            this.Title.Name = "Title";
            this.tableLayoutPanel1.SetRowSpan(this.Title, 2);
            this.Title.Size = new System.Drawing.Size(228, 37);
            this.Title.TabIndex = 3;
            this.Title.Text = "Table Gaming";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonHost
            // 
            this.ButtonHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonHost, 2);
            this.ButtonHost.Location = new System.Drawing.Point(77, 154);
            this.ButtonHost.Name = "ButtonHost";
            this.ButtonHost.Size = new System.Drawing.Size(148, 29);
            this.ButtonHost.TabIndex = 1;
            this.ButtonHost.Text = "Host";
            this.ButtonHost.UseVisualStyleBackColor = true;
            this.ButtonHost.Click += new System.EventHandler(this.ButtonHost_Click);
            // 
            // ButtonJoin
            // 
            this.ButtonJoin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonJoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonJoin.Location = new System.Drawing.Point(177, 108);
            this.ButtonJoin.Name = "ButtonJoin";
            this.ButtonJoin.Size = new System.Drawing.Size(77, 30);
            this.ButtonJoin.TabIndex = 0;
            this.ButtonJoin.Text = "Join";
            this.ButtonJoin.UseVisualStyleBackColor = true;
            this.ButtonJoin.Click += new System.EventHandler(this.ButtonJoin_Click);
            // 
            // IPAddress
            // 
            this.IPAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPAddress.Location = new System.Drawing.Point(49, 113);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(122, 20);
            this.IPAddress.TabIndex = 4;
            this.IPAddress.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nickname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nickname
            // 
            this.Nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nickname.Location = new System.Drawing.Point(49, 56);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(122, 20);
            this.Nickname.TabIndex = 6;
            this.Nickname.Text = "Guest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Table Gaming";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonJoin;
        private System.Windows.Forms.Button ButtonHost;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nickname;
    }
}

