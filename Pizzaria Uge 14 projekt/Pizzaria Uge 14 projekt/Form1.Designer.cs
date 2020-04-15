namespace Pizzaria_Uge_14_projekt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pizza1 = new System.Windows.Forms.TextBox();
            this.Pizza2 = new System.Windows.Forms.TextBox();
            this.Pizza3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Pizza1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pizza2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Pizza3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Pizza1
            // 
            this.Pizza1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pizza1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza1.Location = new System.Drawing.Point(126, 3);
            this.Pizza1.Multiline = true;
            this.Pizza1.Name = "Pizza1";
            this.Pizza1.Size = new System.Drawing.Size(528, 79);
            this.Pizza1.TabIndex = 0;
            this.Pizza1.Text = "1. Pizza margherita\r\nGod italiensk pizza med bund, tomatsovs og ost.";
            // 
            // Pizza2
            // 
            this.Pizza2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pizza2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza2.Location = new System.Drawing.Point(126, 88);
            this.Pizza2.Multiline = true;
            this.Pizza2.Name = "Pizza2";
            this.Pizza2.Size = new System.Drawing.Size(528, 79);
            this.Pizza2.TabIndex = 1;
            this.Pizza2.Text = "2. Pizza skinke\r\nGod italiensk pizza med bund, tomatsovs, ost og skinke.";
            // 
            // Pizza3
            // 
            this.Pizza3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pizza3.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pizza3.Location = new System.Drawing.Point(126, 173);
            this.Pizza3.Multiline = true;
            this.Pizza3.Name = "Pizza3";
            this.Pizza3.Size = new System.Drawing.Size(528, 79);
            this.Pizza3.TabIndex = 2;
            this.Pizza3.Text = "3. Pizza pepperoni\r\nGod italiensk pizza med bund, tomatsovs, ost og pepperoni.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Pizza1;
        private System.Windows.Forms.TextBox Pizza2;
        private System.Windows.Forms.TextBox Pizza3;
    }
}

