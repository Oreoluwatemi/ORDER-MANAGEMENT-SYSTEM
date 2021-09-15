
namespace Project
{
    partial class FindTwoForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindClear = new System.Windows.Forms.Button();
            this.btnFindOk = new System.Windows.Forms.Button();
            this.txtFindOrderNo = new System.Windows.Forms.TextBox();
            this.txtFindTotalAmount = new System.Windows.Forms.TextBox();
            this.txtFindCustId = new System.Windows.Forms.TextBox();
            this.txtFindOrderIDate = new System.Windows.Forms.TextBox();
            this.txtFindOrderItemId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(67, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(555, 34);
            this.label12.TabIndex = 25;
            this.label12.Text = "FIND ORDER WITH TWO INPUT SECTION";
            // 
            // pnlFind
            // 
            this.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFind.Controls.Add(this.label5);
            this.pnlFind.Controls.Add(this.label4);
            this.pnlFind.Controls.Add(this.label3);
            this.pnlFind.Controls.Add(this.label2);
            this.pnlFind.Controls.Add(this.btnFindClear);
            this.pnlFind.Controls.Add(this.btnFindOk);
            this.pnlFind.Controls.Add(this.txtFindOrderNo);
            this.pnlFind.Controls.Add(this.txtFindTotalAmount);
            this.pnlFind.Controls.Add(this.txtFindCustId);
            this.pnlFind.Controls.Add(this.txtFindOrderIDate);
            this.pnlFind.Controls.Add(this.txtFindOrderItemId);
            this.pnlFind.Controls.Add(this.label11);
            this.pnlFind.Location = new System.Drawing.Point(41, 71);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(606, 284);
            this.pnlFind.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Order Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Order Date";
            // 
            // btnFindClear
            // 
            this.btnFindClear.BackColor = System.Drawing.Color.Silver;
            this.btnFindClear.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClear.Location = new System.Drawing.Point(352, 68);
            this.btnFindClear.Name = "btnFindClear";
            this.btnFindClear.Size = new System.Drawing.Size(104, 34);
            this.btnFindClear.TabIndex = 23;
            this.btnFindClear.Text = "Clear";
            this.btnFindClear.UseVisualStyleBackColor = false;
            this.btnFindClear.Click += new System.EventHandler(this.btnFindClear_Click);
            // 
            // btnFindOk
            // 
            this.btnFindOk.BackColor = System.Drawing.Color.Silver;
            this.btnFindOk.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOk.Location = new System.Drawing.Point(166, 68);
            this.btnFindOk.Name = "btnFindOk";
            this.btnFindOk.Size = new System.Drawing.Size(112, 34);
            this.btnFindOk.TabIndex = 22;
            this.btnFindOk.Text = "Find";
            this.btnFindOk.UseVisualStyleBackColor = false;
            this.btnFindOk.Click += new System.EventHandler(this.btnFindOk_Click);
            // 
            // txtFindOrderNo
            // 
            this.txtFindOrderNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindOrderNo.Location = new System.Drawing.Point(370, 28);
            this.txtFindOrderNo.Multiline = true;
            this.txtFindOrderNo.Name = "txtFindOrderNo";
            this.txtFindOrderNo.Size = new System.Drawing.Size(189, 30);
            this.txtFindOrderNo.TabIndex = 21;
            // 
            // txtFindTotalAmount
            // 
            this.txtFindTotalAmount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindTotalAmount.Location = new System.Drawing.Point(234, 179);
            this.txtFindTotalAmount.Multiline = true;
            this.txtFindTotalAmount.Name = "txtFindTotalAmount";
            this.txtFindTotalAmount.Size = new System.Drawing.Size(189, 30);
            this.txtFindTotalAmount.TabIndex = 20;
            // 
            // txtFindCustId
            // 
            this.txtFindCustId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCustId.Location = new System.Drawing.Point(234, 143);
            this.txtFindCustId.Multiline = true;
            this.txtFindCustId.Name = "txtFindCustId";
            this.txtFindCustId.Size = new System.Drawing.Size(189, 30);
            this.txtFindCustId.TabIndex = 19;
            // 
            // txtFindOrderIDate
            // 
            this.txtFindOrderIDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindOrderIDate.Location = new System.Drawing.Point(234, 216);
            this.txtFindOrderIDate.Multiline = true;
            this.txtFindOrderIDate.Name = "txtFindOrderIDate";
            this.txtFindOrderIDate.Size = new System.Drawing.Size(189, 30);
            this.txtFindOrderIDate.TabIndex = 18;
            // 
            // txtFindOrderItemId
            // 
            this.txtFindOrderItemId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindOrderItemId.Location = new System.Drawing.Point(122, 28);
            this.txtFindOrderItemId.Multiline = true;
            this.txtFindOrderItemId.Name = "txtFindOrderItemId";
            this.txtFindOrderItemId.Size = new System.Drawing.Size(126, 34);
            this.txtFindOrderItemId.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Order Item ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(316, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 34);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FindTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnlFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindTwoForm";
            this.Text = "FindTwoForm";
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindClear;
        private System.Windows.Forms.Button btnFindOk;
        private System.Windows.Forms.TextBox txtFindOrderNo;
        private System.Windows.Forms.TextBox txtFindTotalAmount;
        private System.Windows.Forms.TextBox txtFindCustId;
        private System.Windows.Forms.TextBox txtFindOrderIDate;
        private System.Windows.Forms.TextBox txtFindOrderItemId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
    }
}