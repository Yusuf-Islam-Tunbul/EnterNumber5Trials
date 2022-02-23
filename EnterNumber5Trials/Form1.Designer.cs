
namespace EnterNumber5Trials
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.number_label = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.trial_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_label.Location = new System.Drawing.Point(12, 9);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(0, 29);
            this.number_label.TabIndex = 0;
            // 
            // number_textbox
            // 
            this.number_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_textbox.Location = new System.Drawing.Point(26, 63);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(221, 34);
            this.number_textbox.TabIndex = 1;
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enter_button.Location = new System.Drawing.Point(253, 63);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(38, 38);
            this.enter_button.TabIndex = 2;
            this.enter_button.Text = "⌅";
            this.enter_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // trial_label
            // 
            this.trial_label.AutoSize = true;
            this.trial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trial_label.Location = new System.Drawing.Point(21, 110);
            this.trial_label.Name = "trial_label";
            this.trial_label.Size = new System.Drawing.Size(181, 29);
            this.trial_label.TabIndex = 3;
            this.trial_label.Text = "5 hakkınız kaldı.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trial_label);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.number_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox number_textbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label trial_label;
    }
}

