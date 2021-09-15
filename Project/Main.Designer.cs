
namespace Project
{
    partial class Main
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
            this.btnExit = new System.Windows.Forms.Label();
            this.btnDisplayAllOrder = new System.Windows.Forms.Button();
            this.btnFindOne = new System.Windows.Forms.Button();
            this.btnAddModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindTwo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAIN MENU";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(747, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayAllOrder
            // 
            this.btnDisplayAllOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btnDisplayAllOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayAllOrder.FlatAppearance.BorderSize = 5;
            this.btnDisplayAllOrder.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllOrder.Location = new System.Drawing.Point(45, 22);
            this.btnDisplayAllOrder.Name = "btnDisplayAllOrder";
            this.btnDisplayAllOrder.Size = new System.Drawing.Size(214, 96);
            this.btnDisplayAllOrder.TabIndex = 4;
            this.btnDisplayAllOrder.Text = "Display All Orders";
            this.btnDisplayAllOrder.UseVisualStyleBackColor = false;
            this.btnDisplayAllOrder.Click += new System.EventHandler(this.btnDisplayAllOrder_Click);
            // 
            // btnFindOne
            // 
            this.btnFindOne.BackColor = System.Drawing.Color.DarkGray;
            this.btnFindOne.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFindOne.FlatAppearance.BorderSize = 5;
            this.btnFindOne.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOne.Location = new System.Drawing.Point(45, 160);
            this.btnFindOne.Name = "btnFindOne";
            this.btnFindOne.Size = new System.Drawing.Size(214, 96);
            this.btnFindOne.TabIndex = 5;
            this.btnFindOne.Text = "Find Order With One Input";
            this.btnFindOne.UseVisualStyleBackColor = false;
            this.btnFindOne.Click += new System.EventHandler(this.btnFindOne_Click);
            // 
            // btnAddModify
            // 
            this.btnAddModify.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddModify.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddModify.FlatAppearance.BorderSize = 5;
            this.btnAddModify.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModify.Location = new System.Drawing.Point(429, 22);
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Size = new System.Drawing.Size(214, 96);
            this.btnAddModify.TabIndex = 6;
            this.btnAddModify.Text = "Add/Modify Order ";
            this.btnAddModify.UseVisualStyleBackColor = false;
            this.btnAddModify.Click += new System.EventHandler(this.btnAddModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(235, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 96);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindTwo
            // 
            this.btnFindTwo.BackColor = System.Drawing.Color.DarkGray;
            this.btnFindTwo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFindTwo.FlatAppearance.BorderSize = 5;
            this.btnFindTwo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTwo.Location = new System.Drawing.Point(429, 160);
            this.btnFindTwo.Name = "btnFindTwo";
            this.btnFindTwo.Size = new System.Drawing.Size(214, 96);
            this.btnFindTwo.TabIndex = 8;
            this.btnFindTwo.Text = "Find Order With Two Input";
            this.btnFindTwo.UseVisualStyleBackColor = false;
            this.btnFindTwo.Click += new System.EventHandler(this.btnFindTwo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDisplayAllOrder);
            this.panel1.Controls.Add(this.btnAddModify);
            this.panel1.Controls.Add(this.btnFindTwo);
            this.panel1.Controls.Add(this.btnFindOne);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(41, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 407);
            this.panel1.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(777, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Button btnDisplayAllOrder;
        private System.Windows.Forms.Button btnFindOne;
        private System.Windows.Forms.Button btnAddModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindTwo;
        private System.Windows.Forms.Panel panel1;
    }
}