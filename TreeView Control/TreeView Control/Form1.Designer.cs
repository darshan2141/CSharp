namespace TreeView_Control
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
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Agatrai");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Kehsod", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Vanthali");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Junagadh", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Rajkot");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Gujrat", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Maharastra");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.root = new System.Windows.Forms.Button();
            this.child = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode36.Name = "Node4";
            treeNode36.Text = "Agatrai";
            treeNode37.Name = "Node2";
            treeNode37.Text = "Kehsod";
            treeNode38.Name = "Node3";
            treeNode38.Text = "Vanthali";
            treeNode39.Name = "Node1";
            treeNode39.Text = "Junagadh";
            treeNode40.Name = "Node5";
            treeNode40.Text = "Rajkot";
            treeNode41.Name = "Node0";
            treeNode41.Text = "Gujrat";
            treeNode42.Name = "Node6";
            treeNode42.Text = "Maharastra";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42});
            this.treeView1.Size = new System.Drawing.Size(361, 426);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(401, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 40);
            this.textBox1.TabIndex = 1;
            // 
            // root
            // 
            this.root.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.root.Location = new System.Drawing.Point(401, 133);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(169, 57);
            this.root.TabIndex = 2;
            this.root.Text = "Root";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // child
            // 
            this.child.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.child.Location = new System.Drawing.Point(605, 133);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(169, 57);
            this.child.TabIndex = 3;
            this.child.Text = "Child";
            this.child.UseVisualStyleBackColor = true;
            this.child.Click += new System.EventHandler(this.child_Click);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(401, 230);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(169, 57);
            this.Count.TabIndex = 4;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(605, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Expand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(401, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Collapse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(605, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.child);
            this.Controls.Add(this.root);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private TextBox textBox1;
        private Button root;
        private Button child;
        private Button Count;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}