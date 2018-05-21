namespace SortingArray
{
    partial class frmSortingArray
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortingArray));
            this.btnSortingArray = new System.Windows.Forms.Button();
            this.btnSortingArrayBad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortingArray
            // 
            this.btnSortingArray.Location = new System.Drawing.Point(114, 22);
            this.btnSortingArray.Name = "btnSortingArray";
            this.btnSortingArray.Size = new System.Drawing.Size(192, 30);
            this.btnSortingArray.TabIndex = 0;
            this.btnSortingArray.Text = "1. Города для посещения";
            this.btnSortingArray.UseVisualStyleBackColor = true;
            this.btnSortingArray.Click += new System.EventHandler(this.btnSortingArray_Click);
            // 
            // btnSortingArrayBad
            // 
            this.btnSortingArrayBad.Location = new System.Drawing.Point(114, 69);
            this.btnSortingArrayBad.Name = "btnSortingArrayBad";
            this.btnSortingArrayBad.Size = new System.Drawing.Size(192, 66);
            this.btnSortingArrayBad.TabIndex = 0;
            this.btnSortingArrayBad.Text = "2. Города для посещения (контроль достоверности данных)";
            this.btnSortingArrayBad.UseVisualStyleBackColor = true;
            this.btnSortingArrayBad.Click += new System.EventHandler(this.btnSortingArrayBad_Click);
            // 
            // frmSortingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 153);
            this.Controls.Add(this.btnSortingArrayBad);
            this.Controls.Add(this.btnSortingArray);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSortingArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Путешествие по Европе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortingArray;
        private System.Windows.Forms.Button btnSortingArrayBad;
    }
}

