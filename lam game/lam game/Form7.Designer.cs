namespace lam_game
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\t\t\t\tHƯỚNG DẪN CHƠI GAME",
            "Có một số lượng từ vựng tiếng Anh trong các chủ đề khác nhau. ",
            "",
            "Có 1 ô chữ và có 15 chữ cái trong bảng chữ cái tiếng Anh nằm ở dưới ô chữ này.",
            "",
            "Nhiệm vụ của người chơi là lựa chọn trong 15 chữ cho sẵn và điền vào ô chữ. ",
            "",
            "Có 3 trợ giúp, trợ giúp là mở 1 ô chữ bất kì một cách ngẫu nhiên trong ô chữ. ",
            "",
            "Người chơi khi chọn các chữ cho sẵn thì các chữ này sẽ được xếp vào ô chữ lần lượ" +
                "t theo thứ tự từ đầu tới cuối. ",
            "",
            "Nếu ô đó đã được mở bằng quyền trợ giúp thì bỏ qua ô đó và điền vào ô kế tiếp. Sa" +
                "u khi điền đầy đủ hết ô chữ thì người chơi bấm nút finish để kết thúc. ",
            "",
            "Nếu đáp án đúng thì qua câu tiếp theo. ",
            "",
            "Nếu đáp án sai thì dừng trò chơi. Chương trình sẽ hiện lên bảng thông báo là ngườ" +
                "i chơi đã thua. ",
            "",
            "Nếu thắng được 10 câu thì hiện lên bảng thông báo khen ngợi người chơi. ",
            "",
            "Nếu chiến thắng hết các câu hỏi thì hiện bảng thông báo người chơi đã chiến thắng" +
                "."});
            this.listBox1.Location = new System.Drawing.Point(8, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(740, 160);
            this.listBox1.TabIndex = 1;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 174);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "GAME TIẾNG ANH";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
    }
}