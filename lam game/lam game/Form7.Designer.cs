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
            "Có 1 hình ảnh, nhiều ô chữ, mỗi ô chứa một letter và có 10 letters gợi ý trong bả" +
                "ng chữ cái tiếng Anh nằm ở dưới hình ảnh và những ô chữ này.",
            "",
            "Nhiệm vụ của người chơi là lựa chọn trong 10 letters cho sẵn và điền vào ô chữ ch" +
                "o phù hợp với nội dung của hình ảnh. ",
            "",
            "Người chơi khi chọn letters cho sẵn thì letters sẽ được xếp vào ô chữ lần lượt th" +
                "eo thứ tự từ đầu tới cuối. ",
            "",
            resources.GetString("listBox1.Items"),
            "",
            "Sau khi điền đầy đủ hết ô chữ thì người chơi bấm nút Next. ",
            "",
            "Nếu đáp án đúng thì qua câu tiếp theo. ",
            "",
            resources.GetString("listBox1.Items1"),
            "",
            "Người chơi nhấn nút Exit để kết thúc trò chơi và nhấn nút chơi lại để chơi lại tr" +
                "ò chơi.",
            "",
            resources.GetString("listBox1.Items2")});
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