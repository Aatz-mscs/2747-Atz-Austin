namespace BookstoreApp.UI
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            productsLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            customersLabel = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(productsLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 381);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 252);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 2;
            label2.Text = "Manage the catalog of products";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            productsLabel.Location = new Point(63, 198);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(190, 54);
            productsLabel.TabIndex = 1;
            productsLabel.Text = "Products";
            productsLabel.Click += productsLabel_Click;
            productsLabel.MouseLeave += productsLabel_MouseLeave;
            productsLabel.MouseHover += productsLabel_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 195);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(customersLabel);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(347, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 381);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 252);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 2;
            label3.Text = "Manage the list of customers";
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            customersLabel.Location = new Point(30, 198);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(223, 54);
            customersLabel.TabIndex = 1;
            customersLabel.Text = "Customers";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 195);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Bookstore Manager";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label productsLabel;
        private Panel panel2;
        private Label label3;
        private Label customersLabel;
        private PictureBox pictureBox2;
    }
}
