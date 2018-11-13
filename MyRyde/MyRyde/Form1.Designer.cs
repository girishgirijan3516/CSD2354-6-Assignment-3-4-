namespace MyRyde
{
    partial class frm_start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_start));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_ryde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_direct = new System.Windows.Forms.RadioButton();
            this.rb_pool = new System.Windows.Forms.RadioButton();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_from = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(304, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(-6, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 420);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.Location = new System.Drawing.Point(-4, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 8);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.GreenYellow;
            this.panel4.Location = new System.Drawing.Point(0, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 10);
            this.panel4.TabIndex = 3;
            // 
            // lb_ryde
            // 
            this.lb_ryde.AutoSize = true;
            this.lb_ryde.BackColor = System.Drawing.Color.Transparent;
            this.lb_ryde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ryde.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb_ryde.Location = new System.Drawing.Point(133, 17);
            this.lb_ryde.Name = "lb_ryde";
            this.lb_ryde.Size = new System.Drawing.Size(58, 24);
            this.lb_ryde.TabIndex = 4;
            this.lb_ryde.Text = "Ryde";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::MyRyde.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(86, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 113);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_direct);
            this.groupBox1.Controls.Add(this.rb_pool);
            this.groupBox1.Controls.Add(this.txt_to);
            this.groupBox1.Controls.Add(this.txt_from);
            this.groupBox1.Controls.Add(this.lb_to);
            this.groupBox1.Controls.Add(this.lb_from);
            this.groupBox1.Location = new System.Drawing.Point(19, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rb_direct
            // 
            this.rb_direct.AutoSize = true;
            this.rb_direct.Location = new System.Drawing.Point(161, 79);
            this.rb_direct.Name = "rb_direct";
            this.rb_direct.Size = new System.Drawing.Size(81, 17);
            this.rb_direct.TabIndex = 5;
            this.rb_direct.TabStop = true;
            this.rb_direct.Text = "Ryde Direct";
            this.rb_direct.UseVisualStyleBackColor = true;
            // 
            // rb_pool
            // 
            this.rb_pool.AutoSize = true;
            this.rb_pool.Location = new System.Drawing.Point(41, 79);
            this.rb_pool.Name = "rb_pool";
            this.rb_pool.Size = new System.Drawing.Size(74, 17);
            this.rb_pool.TabIndex = 4;
            this.rb_pool.TabStop = true;
            this.rb_pool.Text = "Ryde Pool";
            this.rb_pool.UseVisualStyleBackColor = true;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(145, 42);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(114, 20);
            this.txt_to.TabIndex = 3;
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(14, 42);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(125, 20);
            this.txt_from.TabIndex = 2;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb_to.Location = new System.Drawing.Point(145, 17);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(31, 15);
            this.lb_to.TabIndex = 1;
            this.lb_to.Text = "To :";
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb_from.Location = new System.Drawing.Point(11, 18);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(48, 15);
            this.lb_from.TabIndex = 0;
            this.lb_from.Text = "From :";
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.White;
            this.btn_book.Location = new System.Drawing.Point(19, 330);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(272, 31);
            this.btn_book.TabIndex = 7;
            this.btn_book.Text = "Find My Ryde";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(19, 369);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(272, 31);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 420);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_ryde);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryde";
            this.Load += new System.EventHandler(this.frm_start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_ryde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.RadioButton rb_direct;
        private System.Windows.Forms.RadioButton rb_pool;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.TextBox txt_from;
        public System.Windows.Forms.TextBox txt_to;
    }
}

