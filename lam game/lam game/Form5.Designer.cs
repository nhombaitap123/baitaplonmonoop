namespace lam_game
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rANKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.diemlabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.DataGridView();
            this.board = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aBOUTToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.rANKToolStripMenuItem,
            this.sETTINGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGAMEToolStripMenuItem,
            this.sAVEGAMEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // nEWGAMEToolStripMenuItem
            // 
            this.nEWGAMEToolStripMenuItem.Name = "nEWGAMEToolStripMenuItem";
            this.nEWGAMEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nEWGAMEToolStripMenuItem.Text = "NEW GAME";
            this.nEWGAMEToolStripMenuItem.Click += new System.EventHandler(this.nEWGAMEToolStripMenuItem_Click);
            // 
            // sAVEGAMEToolStripMenuItem
            // 
            this.sAVEGAMEToolStripMenuItem.Name = "sAVEGAMEToolStripMenuItem";
            this.sAVEGAMEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sAVEGAMEToolStripMenuItem.Text = "SAVE GAME";
            this.sAVEGAMEToolStripMenuItem.Click += new System.EventHandler(this.sAVEGAMEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // rANKToolStripMenuItem
            // 
            this.rANKToolStripMenuItem.Name = "rANKToolStripMenuItem";
            this.rANKToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.rANKToolStripMenuItem.Text = "RANK";
            this.rANKToolStripMenuItem.Click += new System.EventHandler(this.rANKToolStripMenuItem_Click);
            // 
            // sETTINGToolStripMenuItem
            // 
            this.sETTINGToolStripMenuItem.Name = "sETTINGToolStripMenuItem";
            this.sETTINGToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sETTINGToolStripMenuItem.Text = "SETTING";
            this.sETTINGToolStripMenuItem.Click += new System.EventHandler(this.sETTINGToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lam_game.Properties.Resources.maxresdefault;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHint);
            this.panel1.Controls.Add(this.diemlabel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cross);
            this.panel1.Controls.Add(this.board);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 673);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(49, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 290);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(916, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Điểm số";
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(338, 493);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(119, 39);
            this.btnHint.TabIndex = 6;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // diemlabel
            // 
            this.diemlabel.AutoSize = true;
            this.diemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemlabel.Location = new System.Drawing.Point(965, 191);
            this.diemlabel.Name = "diemlabel";
            this.diemlabel.Size = new System.Drawing.Size(36, 39);
            this.diemlabel.TabIndex = 7;
            this.diemlabel.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cross
            // 
            this.cross.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cross.ColumnHeadersVisible = false;
            this.cross.Location = new System.Drawing.Point(49, 421);
            this.cross.Name = "cross";
            this.cross.RowHeadersVisible = false;
            this.cross.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cross.Size = new System.Drawing.Size(711, 23);
            this.cross.TabIndex = 3;
            this.cross.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cross_CellClick);
            // 
            // board
            // 
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.ColumnHeadersVisible = false;
            this.board.Location = new System.Drawing.Point(49, 343);
            this.board.Name = "board";
            this.board.RowHeadersVisible = false;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.board.Size = new System.Drawing.Size(711, 34);
            this.board.TabIndex = 0;
            this.board.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "GAME TIẾNG ANH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView board;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cross;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rANKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sETTINGToolStripMenuItem;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label diemlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

