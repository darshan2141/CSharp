namespace ContextMenu_Control
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oddEvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positiveNegativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oddEvenToolStripMenuItem,
            this.positiveNegativeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // oddEvenToolStripMenuItem
            // 
            this.oddEvenToolStripMenuItem.Name = "oddEvenToolStripMenuItem";
            this.oddEvenToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.oddEvenToolStripMenuItem.Text = "Odd Even";
            this.oddEvenToolStripMenuItem.Click += new System.EventHandler(this.oddEvenToolStripMenuItem_Click);
            // 
            // positiveNegativeToolStripMenuItem
            // 
            this.positiveNegativeToolStripMenuItem.Name = "positiveNegativeToolStripMenuItem";
            this.positiveNegativeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.positiveNegativeToolStripMenuItem.Text = "Positive Negative";
            this.positiveNegativeToolStripMenuItem.Click += new System.EventHandler(this.positiveNegativeToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(236, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 44);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem oddEvenToolStripMenuItem;
        private ToolStripMenuItem positiveNegativeToolStripMenuItem;
        private TextBox textBox1;
    }
}