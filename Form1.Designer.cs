namespace CHABLOCK
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            this.btnAddTran = new System.Windows.Forms.Button();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.rtbxAllBlocks = new System.Windows.Forms.RichTextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnGetVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbxInfo.Location = new System.Drawing.Point(0, 229);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.Size = new System.Drawing.Size(264, 298);
            this.rtbxInfo.TabIndex = 0;
            this.rtbxInfo.Text = "";
            // 
            // btnAddTran
            // 
            this.btnAddTran.Location = new System.Drawing.Point(341, 365);
            this.btnAddTran.Name = "btnAddTran";
            this.btnAddTran.Size = new System.Drawing.Size(100, 29);
            this.btnAddTran.TabIndex = 2;
            this.btnAddTran.Text = "트랜잭션 추가";
            this.btnAddTran.UseVisualStyleBackColor = true;
            this.btnAddTran.Click += new System.EventHandler(this.btnAddTran_Click);
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(341, 290);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(100, 21);
            this.tbxFrom.TabIndex = 5;
            this.tbxFrom.Text = "채굴자";
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(341, 314);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(100, 21);
            this.tbxTo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "보내는주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "받는주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "수량";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(341, 338);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 21);
            this.tbxAmount.TabIndex = 10;
            this.tbxAmount.Text = "10";
            // 
            // rtbxAllBlocks
            // 
            this.rtbxAllBlocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbxAllBlocks.Location = new System.Drawing.Point(0, 0);
            this.rtbxAllBlocks.Name = "rtbxAllBlocks";
            this.rtbxAllBlocks.Size = new System.Drawing.Size(602, 229);
            this.rtbxAllBlocks.TabIndex = 11;
            this.rtbxAllBlocks.Text = "";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(270, 235);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(78, 29);
            this.btnVerify.TabIndex = 12;
            this.btnVerify.Text = "검증";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnGetVal
            // 
            this.btnGetVal.Location = new System.Drawing.Point(447, 290);
            this.btnGetVal.Name = "btnGetVal";
            this.btnGetVal.Size = new System.Drawing.Size(65, 30);
            this.btnGetVal.TabIndex = 14;
            this.btnGetVal.Text = "잔액검색";
            this.btnGetVal.UseVisualStyleBackColor = true;
            this.btnGetVal.Click += new System.EventHandler(this.btnGetVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 527);
            this.Controls.Add(this.rtbxInfo);
            this.Controls.Add(this.btnGetVal);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.rtbxAllBlocks);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.btnAddTran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxInfo;
        private System.Windows.Forms.Button btnAddTran;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.RichTextBox rtbxAllBlocks;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnGetVal;
    }
}

