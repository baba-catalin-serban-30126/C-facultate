namespace ex3lab2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inmultireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impartireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plusToolStripMenuItem,
            this.minusToolStripMenuItem,
            this.inmultireToolStripMenuItem,
            this.impartireToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Operatori";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // plusToolStripMenuItem
            // 
            this.plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            this.plusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.plusToolStripMenuItem.Text = "Plus";
            this.plusToolStripMenuItem.Click += new System.EventHandler(this.plusToolStripMenuItem_Click);
            // 
            // minusToolStripMenuItem
            // 
            this.minusToolStripMenuItem.Name = "minusToolStripMenuItem";
            this.minusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minusToolStripMenuItem.Text = "Minus";
            this.minusToolStripMenuItem.Click += new System.EventHandler(this.minusToolStripMenuItem_Click);
            // 
            // inmultireToolStripMenuItem
            // 
            this.inmultireToolStripMenuItem.Name = "inmultireToolStripMenuItem";
            this.inmultireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inmultireToolStripMenuItem.Text = "Inmultire";
            this.inmultireToolStripMenuItem.Click += new System.EventHandler(this.inmultireToolStripMenuItem_Click);
            // 
            // impartireToolStripMenuItem
            // 
            this.impartireToolStripMenuItem.Name = "impartireToolStripMenuItem";
            this.impartireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.impartireToolStripMenuItem.Text = "Impartire";
            this.impartireToolStripMenuItem.Click += new System.EventHandler(this.impartireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inmultireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impartireToolStripMenuItem;
    }
}

