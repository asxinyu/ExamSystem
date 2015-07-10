namespace ExamSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.txtDisp1 = new System.Windows.Forms.TextBox();
            this.txtDisp2 = new System.Windows.Forms.TextBox();
            this.lblTypeName1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTypeName2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入题库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(13, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyValue.Location = new System.Drawing.Point(97, 42);
            this.txtKeyValue.Multiline = true;
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(253, 81);
            this.txtKeyValue.TabIndex = 1;
            // 
            // txtDisp1
            // 
            this.txtDisp1.Location = new System.Drawing.Point(13, 154);
            this.txtDisp1.Multiline = true;
            this.txtDisp1.Name = "txtDisp1";
            this.txtDisp1.Size = new System.Drawing.Size(337, 78);
            this.txtDisp1.TabIndex = 2;
            // 
            // txtDisp2
            // 
            this.txtDisp2.Location = new System.Drawing.Point(13, 262);
            this.txtDisp2.Multiline = true;
            this.txtDisp2.Name = "txtDisp2";
            this.txtDisp2.Size = new System.Drawing.Size(337, 91);
            this.txtDisp2.TabIndex = 3;
            // 
            // lblTypeName1
            // 
            this.lblTypeName1.AutoSize = true;
            this.lblTypeName1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeName1.Location = new System.Drawing.Point(11, 134);
            this.lblTypeName1.Name = "lblTypeName1";
            this.lblTypeName1.Size = new System.Drawing.Size(56, 16);
            this.lblTypeName1.TabIndex = 4;
            this.lblTypeName1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "答案：";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAnswer1.Location = new System.Drawing.Point(134, 134);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(56, 16);
            this.lblAnswer1.TabIndex = 6;
            this.lblAnswer1.Text = "label1";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAnswer2.Location = new System.Drawing.Point(135, 242);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(56, 16);
            this.lblAnswer2.TabIndex = 10;
            this.lblAnswer2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(86, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "答案：";
            // 
            // lblTypeName2
            // 
            this.lblTypeName2.AutoSize = true;
            this.lblTypeName2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeName2.Location = new System.Drawing.Point(12, 242);
            this.lblTypeName2.Name = "lblTypeName2";
            this.lblTypeName2.Size = new System.Drawing.Size(56, 16);
            this.lblTypeName2.TabIndex = 8;
            this.lblTypeName2.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入题库ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入题库ToolStripMenuItem
            // 
            this.导入题库ToolStripMenuItem.Name = "导入题库ToolStripMenuItem";
            this.导入题库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入题库ToolStripMenuItem.Text = "导入题库";
            this.导入题库ToolStripMenuItem.Click += new System.EventHandler(this.导入题库ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 358);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTypeName2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTypeName1);
            this.Controls.Add(this.txtDisp2);
            this.Controls.Add(this.txtDisp1);
            this.Controls.Add(this.txtKeyValue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试辅助";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.TextBox txtDisp1;
        private System.Windows.Forms.TextBox txtDisp2;
        private System.Windows.Forms.Label lblTypeName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTypeName2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入题库ToolStripMenuItem;
    }
}

