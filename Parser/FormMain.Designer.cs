namespace Parser
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListParagraphs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericStartPart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericEndPart = new System.Windows.Forms.NumericUpDown();
            this.NumericStartArticle = new System.Windows.Forms.NumericUpDown();
            this.NumericEndArticle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxGuide = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEndPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEndArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // ListParagraphs
            // 
            this.ListParagraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListParagraphs.FormattingEnabled = true;
            this.ListParagraphs.Location = new System.Drawing.Point(12, 12);
            this.ListParagraphs.Name = "ListParagraphs";
            this.ListParagraphs.Size = new System.Drawing.Size(228, 251);
            this.ListParagraphs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная глава";
            // 
            // NumericStartPart
            // 
            this.NumericStartPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStartPart.Location = new System.Drawing.Point(253, 28);
            this.NumericStartPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStartPart.Name = "NumericStartPart";
            this.NumericStartPart.Size = new System.Drawing.Size(120, 20);
            this.NumericStartPart.TabIndex = 2;
            this.NumericStartPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечная глава";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Начальная статья";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Конечная статья";
            // 
            // NumericEndPart
            // 
            this.NumericEndPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEndPart.Location = new System.Drawing.Point(253, 67);
            this.NumericEndPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEndPart.Name = "NumericEndPart";
            this.NumericEndPart.Size = new System.Drawing.Size(120, 20);
            this.NumericEndPart.TabIndex = 6;
            this.NumericEndPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericStartArticle
            // 
            this.NumericStartArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStartArticle.Location = new System.Drawing.Point(253, 106);
            this.NumericStartArticle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStartArticle.Name = "NumericStartArticle";
            this.NumericStartArticle.Size = new System.Drawing.Size(120, 20);
            this.NumericStartArticle.TabIndex = 7;
            this.NumericStartArticle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericEndArticle
            // 
            this.NumericEndArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEndArticle.Location = new System.Drawing.Point(253, 145);
            this.NumericEndArticle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEndArticle.Name = "NumericEndArticle";
            this.NumericEndArticle.Size = new System.Drawing.Size(120, 20);
            this.NumericEndArticle.TabIndex = 8;
            this.NumericEndArticle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Категория";
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCategory.Location = new System.Drawing.Point(382, 28);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCategory.TabIndex = 10;
            // 
            // TextBoxGuide
            // 
            this.TextBoxGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGuide.Location = new System.Drawing.Point(382, 67);
            this.TextBoxGuide.Name = "TextBoxGuide";
            this.TextBoxGuide.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGuide.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Руководство";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(253, 208);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(229, 23);
            this.ButtonStart.TabIndex = 13;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonAbort
            // 
            this.ButtonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAbort.Location = new System.Drawing.Point(253, 237);
            this.ButtonAbort.Name = "ButtonAbort";
            this.ButtonAbort.Size = new System.Drawing.Size(229, 23);
            this.ButtonAbort.TabIndex = 14;
            this.ButtonAbort.Text = "Завершить";
            this.ButtonAbort.UseVisualStyleBackColor = true;
            this.ButtonAbort.Click += new System.EventHandler(this.ButtonAbort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 272);
            this.Controls.Add(this.ButtonAbort);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxGuide);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumericEndArticle);
            this.Controls.Add(this.NumericStartArticle);
            this.Controls.Add(this.NumericEndPart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericStartPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListParagraphs);
            this.Name = "FormMain";
            this.Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEndPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStartArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEndArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListParagraphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericStartPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericEndPart;
        private System.Windows.Forms.NumericUpDown NumericStartArticle;
        private System.Windows.Forms.NumericUpDown NumericEndArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxGuide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonAbort;
    }
}

