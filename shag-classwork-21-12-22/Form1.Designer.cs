namespace shag_classwork_21_12_22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddComputerBtn = new System.Windows.Forms.Button();
            this.AddProcessorBtn = new System.Windows.Forms.Button();
            this.processorsBox = new System.Windows.Forms.ComboBox();
            this.videoadaptersBox = new System.Windows.Forms.ComboBox();
            this.memoryBox = new System.Windows.Forms.ComboBox();
            this.AddVideoadapterBtn = new System.Windows.Forms.Button();
            this.AddMemoryBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(305, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(353, 364);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Видеокарта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процессор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оперативная память";
            // 
            // AddComputerBtn
            // 
            this.AddComputerBtn.Enabled = false;
            this.AddComputerBtn.Location = new System.Drawing.Point(12, 235);
            this.AddComputerBtn.Name = "AddComputerBtn";
            this.AddComputerBtn.Size = new System.Drawing.Size(271, 23);
            this.AddComputerBtn.TabIndex = 3;
            this.AddComputerBtn.Text = "Добавить компьютер";
            this.AddComputerBtn.UseVisualStyleBackColor = true;
            this.AddComputerBtn.Click += new System.EventHandler(this.AddComputerBtn_Click);
            // 
            // AddProcessorBtn
            // 
            this.AddProcessorBtn.Enabled = false;
            this.AddProcessorBtn.Location = new System.Drawing.Point(12, 355);
            this.AddProcessorBtn.Name = "AddProcessorBtn";
            this.AddProcessorBtn.Size = new System.Drawing.Size(271, 23);
            this.AddProcessorBtn.TabIndex = 5;
            this.AddProcessorBtn.Text = "Добавить процессор в БД";
            this.AddProcessorBtn.UseVisualStyleBackColor = true;
            this.AddProcessorBtn.Click += new System.EventHandler(this.AddProcessorBtn_Click);
            // 
            // processorsBox
            // 
            this.processorsBox.FormattingEnabled = true;
            this.processorsBox.Location = new System.Drawing.Point(12, 88);
            this.processorsBox.Name = "processorsBox";
            this.processorsBox.Size = new System.Drawing.Size(271, 23);
            this.processorsBox.TabIndex = 6;
            // 
            // videoadaptersBox
            // 
            this.videoadaptersBox.FormattingEnabled = true;
            this.videoadaptersBox.Location = new System.Drawing.Point(12, 147);
            this.videoadaptersBox.Name = "videoadaptersBox";
            this.videoadaptersBox.Size = new System.Drawing.Size(271, 23);
            this.videoadaptersBox.TabIndex = 6;
            // 
            // memoryBox
            // 
            this.memoryBox.FormattingEnabled = true;
            this.memoryBox.Location = new System.Drawing.Point(12, 206);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(271, 23);
            this.memoryBox.TabIndex = 6;
            // 
            // AddVideoadapterBtn
            // 
            this.AddVideoadapterBtn.Enabled = false;
            this.AddVideoadapterBtn.Location = new System.Drawing.Point(12, 384);
            this.AddVideoadapterBtn.Name = "AddVideoadapterBtn";
            this.AddVideoadapterBtn.Size = new System.Drawing.Size(271, 23);
            this.AddVideoadapterBtn.TabIndex = 5;
            this.AddVideoadapterBtn.Text = "Добавить видеокарту в БД";
            this.AddVideoadapterBtn.UseVisualStyleBackColor = true;
            this.AddVideoadapterBtn.Click += new System.EventHandler(this.AddVideoadapterBtn_Click);
            // 
            // AddMemoryBtn
            // 
            this.AddMemoryBtn.Enabled = false;
            this.AddMemoryBtn.Location = new System.Drawing.Point(12, 413);
            this.AddMemoryBtn.Name = "AddMemoryBtn";
            this.AddMemoryBtn.Size = new System.Drawing.Size(271, 23);
            this.AddMemoryBtn.TabIndex = 5;
            this.AddMemoryBtn.Text = "Добавить оперативную память в БД";
            this.AddMemoryBtn.UseVisualStyleBackColor = true;
            this.AddMemoryBtn.Click += new System.EventHandler(this.AddMemoryBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(271, 23);
            this.nameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введите имя компьютера:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(504, 404);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(154, 27);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(600, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(504, 404);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(31, 15);
            this.name.TabIndex = 10;
            this.name.Text = "Имя";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.videoadaptersBox);
            this.Controls.Add(this.processorsBox);
            this.Controls.Add(this.AddMemoryBtn);
            this.Controls.Add(this.AddVideoadapterBtn);
            this.Controls.Add(this.AddProcessorBtn);
            this.Controls.Add(this.AddComputerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Computer Database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox list;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddComputerBtn;
        private Button AddProcessorBtn;
        private ComboBox processorsBox;
        private ComboBox videoadaptersBox;
        private ComboBox memoryBox;
        private Button AddVideoadapterBtn;
        private Button AddMemoryBtn;
        private TextBox nameBox;
        private Label label4;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private Label name;
    }
}