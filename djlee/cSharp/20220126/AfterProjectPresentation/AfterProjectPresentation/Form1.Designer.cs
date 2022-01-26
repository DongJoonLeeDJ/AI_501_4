namespace AfterProjectPresentation
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entpNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drwtNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNoDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "감자",
            "고구마",
            "튀김",
            "김밥"});
            this.listBox1.Location = new System.Drawing.Point(13, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(755, 64);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 21);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.entpNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(775, 160);
            this.dataGridView1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drwtNo1DataGridViewTextBoxColumn,
            this.drwtNo2DataGridViewTextBoxColumn,
            this.drwtNo3DataGridViewTextBoxColumn,
            this.drwtNo4DataGridViewTextBoxColumn,
            this.drwtNo5DataGridViewTextBoxColumn,
            this.drwtNo6DataGridViewTextBoxColumn,
            this.drwNoDataGridViewTextBoxColumn,
            this.drwNoDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lottoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 352);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(876, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entpNameDataGridViewTextBoxColumn
            // 
            this.entpNameDataGridViewTextBoxColumn.DataPropertyName = "entpName";
            this.entpNameDataGridViewTextBoxColumn.HeaderText = "entpName";
            this.entpNameDataGridViewTextBoxColumn.Name = "entpNameDataGridViewTextBoxColumn";
            this.entpNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(AfterProjectPresentation.Drug);
            // 
            // lottoBindingSource
            // 
            this.lottoBindingSource.DataSource = typeof(AfterProjectPresentation.Lotto);
            // 
            // drwtNo1DataGridViewTextBoxColumn
            // 
            this.drwtNo1DataGridViewTextBoxColumn.DataPropertyName = "drwtNo1";
            this.drwtNo1DataGridViewTextBoxColumn.HeaderText = "drwtNo1";
            this.drwtNo1DataGridViewTextBoxColumn.Name = "drwtNo1DataGridViewTextBoxColumn";
            // 
            // drwtNo2DataGridViewTextBoxColumn
            // 
            this.drwtNo2DataGridViewTextBoxColumn.DataPropertyName = "drwtNo2";
            this.drwtNo2DataGridViewTextBoxColumn.HeaderText = "drwtNo2";
            this.drwtNo2DataGridViewTextBoxColumn.Name = "drwtNo2DataGridViewTextBoxColumn";
            // 
            // drwtNo3DataGridViewTextBoxColumn
            // 
            this.drwtNo3DataGridViewTextBoxColumn.DataPropertyName = "drwtNo3";
            this.drwtNo3DataGridViewTextBoxColumn.HeaderText = "drwtNo3";
            this.drwtNo3DataGridViewTextBoxColumn.Name = "drwtNo3DataGridViewTextBoxColumn";
            // 
            // drwtNo4DataGridViewTextBoxColumn
            // 
            this.drwtNo4DataGridViewTextBoxColumn.DataPropertyName = "drwtNo4";
            this.drwtNo4DataGridViewTextBoxColumn.HeaderText = "drwtNo4";
            this.drwtNo4DataGridViewTextBoxColumn.Name = "drwtNo4DataGridViewTextBoxColumn";
            // 
            // drwtNo5DataGridViewTextBoxColumn
            // 
            this.drwtNo5DataGridViewTextBoxColumn.DataPropertyName = "drwtNo5";
            this.drwtNo5DataGridViewTextBoxColumn.HeaderText = "drwtNo5";
            this.drwtNo5DataGridViewTextBoxColumn.Name = "drwtNo5DataGridViewTextBoxColumn";
            // 
            // drwtNo6DataGridViewTextBoxColumn
            // 
            this.drwtNo6DataGridViewTextBoxColumn.DataPropertyName = "drwtNo6";
            this.drwtNo6DataGridViewTextBoxColumn.HeaderText = "drwtNo6";
            this.drwtNo6DataGridViewTextBoxColumn.Name = "drwtNo6DataGridViewTextBoxColumn";
            // 
            // drwNoDataGridViewTextBoxColumn
            // 
            this.drwNoDataGridViewTextBoxColumn.DataPropertyName = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.HeaderText = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.Name = "drwNoDataGridViewTextBoxColumn";
            // 
            // drwNoDateDataGridViewTextBoxColumn
            // 
            this.drwNoDateDataGridViewTextBoxColumn.DataPropertyName = "drwNoDate";
            this.drwNoDateDataGridViewTextBoxColumn.HeaderText = "drwNoDate";
            this.drwNoDateDataGridViewTextBoxColumn.Name = "drwNoDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 587);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entpNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNoDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lottoBindingSource;
    }
}

