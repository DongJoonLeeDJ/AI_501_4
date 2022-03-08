namespace myBookManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_allDelayedBook = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_allBorrowedBook = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_allUserCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_allBookCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.button_borrow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_bookManager = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_userManager = new System.Windows.Forms.DataGridView();
            this.menuStrip_manager = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_now = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookManager)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userManager)).BeginInit();
            this.menuStrip_manager.SuspendLayout();
            this.statusStrip_now.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_allDelayedBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_allBorrowedBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_allUserCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_allBookCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관 현황";
            // 
            // label_allDelayedBook
            // 
            this.label_allDelayedBook.AutoSize = true;
            this.label_allDelayedBook.Location = new System.Drawing.Point(152, 113);
            this.label_allDelayedBook.Name = "label_allDelayedBook";
            this.label_allDelayedBook.Size = new System.Drawing.Size(11, 12);
            this.label_allDelayedBook.TabIndex = 7;
            this.label_allDelayedBook.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "연체 중인 도서의 수";
            // 
            // label_allBorrowedBook
            // 
            this.label_allBorrowedBook.AutoSize = true;
            this.label_allBorrowedBook.Location = new System.Drawing.Point(152, 87);
            this.label_allBorrowedBook.Name = "label_allBorrowedBook";
            this.label_allBorrowedBook.Size = new System.Drawing.Size(11, 12);
            this.label_allBorrowedBook.TabIndex = 5;
            this.label_allBorrowedBook.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "대출중인 도서의 수";
            // 
            // label_allUserCount
            // 
            this.label_allUserCount.AutoSize = true;
            this.label_allUserCount.Location = new System.Drawing.Point(152, 54);
            this.label_allUserCount.Name = "label_allUserCount";
            this.label_allUserCount.Size = new System.Drawing.Size(11, 12);
            this.label_allUserCount.TabIndex = 3;
            this.label_allUserCount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자 수";
            // 
            // label_allBookCount
            // 
            this.label_allBookCount.AutoSize = true;
            this.label_allBookCount.Location = new System.Drawing.Point(152, 33);
            this.label_allBookCount.Name = "label_allBookCount";
            this.label_allBookCount.Size = new System.Drawing.Size(11, 12);
            this.label_allBookCount.TabIndex = 1;
            this.label_allBookCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "전체 도서 수";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.textBox_bookName);
            this.groupBox2.Controls.Add(this.textBox_isbn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_return);
            this.groupBox2.Controls.Add(this.button_borrow);
            this.groupBox2.Location = new System.Drawing.Point(298, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여/반납";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(79, 90);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(519, 21);
            this.textBox_id.TabIndex = 8;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Location = new System.Drawing.Point(79, 54);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(519, 21);
            this.textBox_bookName.TabIndex = 7;
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(79, 20);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(519, 21);
            this.textBox_isbn.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "사용자 ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "도서 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "isbn";
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(613, 76);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 1;
            this.button_return.Text = "반납";
            this.button_return.UseVisualStyleBackColor = true;
            // 
            // button_borrow
            // 
            this.button_borrow.Location = new System.Drawing.Point(613, 37);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(75, 23);
            this.button_borrow.TabIndex = 0;
            this.button_borrow.Text = "대여";
            this.button_borrow.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_bookManager);
            this.groupBox3.Location = new System.Drawing.Point(23, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1071, 161);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // dataGridView_bookManager
            // 
            this.dataGridView_bookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookManager.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_bookManager.Name = "dataGridView_bookManager";
            this.dataGridView_bookManager.RowTemplate.Height = 23;
            this.dataGridView_bookManager.Size = new System.Drawing.Size(1059, 135);
            this.dataGridView_bookManager.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_userManager);
            this.groupBox4.Location = new System.Drawing.Point(23, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 117);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // dataGridView_userManager
            // 
            this.dataGridView_userManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userManager.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_userManager.Name = "dataGridView_userManager";
            this.dataGridView_userManager.RowTemplate.Height = 23;
            this.dataGridView_userManager.Size = new System.Drawing.Size(735, 91);
            this.dataGridView_userManager.TabIndex = 10;
            // 
            // menuStrip_manager
            // 
            this.menuStrip_manager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
            this.menuStrip_manager.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_manager.Name = "menuStrip_manager";
            this.menuStrip_manager.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip_manager.TabIndex = 3;
            this.menuStrip_manager.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.도서관리ToolStripMenuItem.Text = "도서관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.사용자관리ToolStripMenuItem.Text = "사용자관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // statusStrip_now
            // 
            this.statusStrip_now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_now});
            this.statusStrip_now.Location = new System.Drawing.Point(0, 460);
            this.statusStrip_now.Name = "statusStrip_now";
            this.statusStrip_now.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip_now.TabIndex = 4;
            this.statusStrip_now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_now
            // 
            this.toolStripStatusLabel_now.Name = "toolStripStatusLabel_now";
            this.toolStripStatusLabel_now.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_now.Text = "-";
            // 
            // timer_now
            // 
            this.timer_now.Enabled = true;
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 482);
            this.Controls.Add(this.statusStrip_now);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip_manager);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip_manager;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookManager)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userManager)).EndInit();
            this.menuStrip_manager.ResumeLayout(false);
            this.menuStrip_manager.PerformLayout();
            this.statusStrip_now.ResumeLayout(false);
            this.statusStrip_now.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip_manager;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private System.Windows.Forms.Label label_allDelayedBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_allBorrowedBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_allUserCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_allBookCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.DataGridView dataGridView_bookManager;
        private System.Windows.Forms.DataGridView dataGridView_userManager;
        private System.Windows.Forms.StatusStrip statusStrip_now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_now;
        private System.Windows.Forms.Timer timer_now;
    }
}

