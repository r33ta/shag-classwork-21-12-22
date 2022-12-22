namespace shag_classwork_21_12_22
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.cores = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(245, 23);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество ядер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тактовая частота";
            // 
            // freq
            // 
            this.freq.Location = new System.Drawing.Point(12, 71);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(245, 23);
            this.freq.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(182, 144);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Добавить";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // cores
            // 
            this.cores.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cores.Location = new System.Drawing.Point(12, 115);
            this.cores.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.cores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cores.Name = "cores";
            this.cores.Size = new System.Drawing.Size(245, 23);
            this.cores.TabIndex = 3;
            this.cores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 178);
            this.Controls.Add(this.cores);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Добавить процессор в БД";
            ((System.ComponentModel.ISupportInitialize)(this.cores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private Label label3;
        private TextBox freq;
        private Button btn;
        private NumericUpDown cores;
    }
}