
namespace VonDollen_Thomas_Assignment_11A
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.sizeListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeListBox
            // 
            this.sizeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sizeListBox.FormattingEnabled = true;
            this.sizeListBox.ItemHeight = 20;
            this.sizeListBox.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.sizeListBox.Location = new System.Drawing.Point(113, 17);
            this.sizeListBox.Name = "sizeListBox";
            this.sizeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sizeListBox.Size = new System.Drawing.Size(81, 124);
            this.sizeListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(79, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 32);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add to Order";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reviewButton.Location = new System.Drawing.Point(219, 195);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(119, 32);
            this.reviewButton.TabIndex = 3;
            this.reviewButton.Text = "Review Order";
            this.reviewButton.UseVisualStyleBackColor = false;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(155, 233);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 35);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear Order";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantityInput.Location = new System.Drawing.Point(218, 158);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(57, 26);
            this.quantityInput.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantityLabel.Location = new System.Drawing.Point(140, 158);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 20);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sizeLabel.Location = new System.Drawing.Point(214, 19);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(93, 120);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "XS $10.00\r\nS $10.00\r\nM $12.00\r\nL $12.00\r\nXL $14.00\r\nXXL $14.00";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.helpPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(427, 322);
            this.tabControl.TabIndex = 8;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.sizeListBox);
            this.mainPage.Controls.Add(this.sizeLabel);
            this.mainPage.Controls.Add(this.addButton);
            this.mainPage.Controls.Add(this.quantityLabel);
            this.mainPage.Controls.Add(this.quantityInput);
            this.mainPage.Controls.Add(this.reviewButton);
            this.mainPage.Controls.Add(this.clearButton);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(419, 296);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Order Form";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.label2);
            this.helpPage.Controls.Add(this.label1);
            this.helpPage.Location = new System.Drawing.Point(4, 22);
            this.helpPage.Name = "helpPage";
            this.helpPage.Padding = new System.Windows.Forms.Padding(3);
            this.helpPage.Size = new System.Drawing.Size(419, 296);
            this.helpPage.TabIndex = 1;
            this.helpPage.Text = "Help";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by Thomas Von Dollen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 153);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(425, 318);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderForm";
            this.Text = "T-Shirt Order Form - Thomas Von Dollen";
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sizeListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

