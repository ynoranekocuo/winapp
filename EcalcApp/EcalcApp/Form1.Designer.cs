namespace EcalcApp
{
    partial class EcalcMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcalcMain));
            this.eVtobutton = new System.Windows.Forms.Button();
            this.ftobutton = new System.Windows.Forms.Button();
            this.lambdatobutton = new System.Windows.Forms.Button();
            this.Ttobutton = new System.Windows.Forms.Button();
            this.Jtobutton = new System.Windows.Forms.Button();
            this.VirualKeyboardcheckBox = new System.Windows.Forms.CheckBox();
            this.numPad1 = new EcalcApp.NumPad();
            this.easyEcalc1 = new easyEcalc.EasyEcalc();
            this.SuspendLayout();
            // 
            // eVtobutton
            // 
            this.eVtobutton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.eVtobutton.Location = new System.Drawing.Point(490, 49);
            this.eVtobutton.Name = "eVtobutton";
            this.eVtobutton.Size = new System.Drawing.Size(100, 80);
            this.eVtobutton.TabIndex = 1;
            this.eVtobutton.Text = "eV ->";
            this.eVtobutton.UseVisualStyleBackColor = true;
            this.eVtobutton.Click += new System.EventHandler(this.eVtobutton_Click);
            // 
            // ftobutton
            // 
            this.ftobutton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.ftobutton.Location = new System.Drawing.Point(490, 139);
            this.ftobutton.Name = "ftobutton";
            this.ftobutton.Size = new System.Drawing.Size(100, 80);
            this.ftobutton.TabIndex = 2;
            this.ftobutton.Text = "Hz ->";
            this.ftobutton.UseVisualStyleBackColor = true;
            this.ftobutton.Click += new System.EventHandler(this.ftobutton_Click);
            // 
            // lambdatobutton
            // 
            this.lambdatobutton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lambdatobutton.Location = new System.Drawing.Point(490, 229);
            this.lambdatobutton.Name = "lambdatobutton";
            this.lambdatobutton.Size = new System.Drawing.Size(100, 80);
            this.lambdatobutton.TabIndex = 3;
            this.lambdatobutton.Text = "λ ->";
            this.lambdatobutton.UseVisualStyleBackColor = true;
            this.lambdatobutton.Click += new System.EventHandler(this.lambdatobutton_Click);
            // 
            // Ttobutton
            // 
            this.Ttobutton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Ttobutton.Location = new System.Drawing.Point(490, 319);
            this.Ttobutton.Name = "Ttobutton";
            this.Ttobutton.Size = new System.Drawing.Size(100, 80);
            this.Ttobutton.TabIndex = 4;
            this.Ttobutton.Text = "K ->";
            this.Ttobutton.UseVisualStyleBackColor = true;
            this.Ttobutton.Click += new System.EventHandler(this.Ttobutton_Click);
            // 
            // Jtobutton
            // 
            this.Jtobutton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Jtobutton.Location = new System.Drawing.Point(490, 409);
            this.Jtobutton.Name = "Jtobutton";
            this.Jtobutton.Size = new System.Drawing.Size(100, 80);
            this.Jtobutton.TabIndex = 5;
            this.Jtobutton.Text = "J ->";
            this.Jtobutton.UseVisualStyleBackColor = true;
            this.Jtobutton.Click += new System.EventHandler(this.Jtobutton_Click);
            // 
            // VirualKeyboardcheckBox
            // 
            this.VirualKeyboardcheckBox.AutoSize = true;
            this.VirualKeyboardcheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.VirualKeyboardcheckBox.Location = new System.Drawing.Point(196, 362);
            this.VirualKeyboardcheckBox.Name = "VirualKeyboardcheckBox";
            this.VirualKeyboardcheckBox.Size = new System.Drawing.Size(199, 28);
            this.VirualKeyboardcheckBox.TabIndex = 6;
            this.VirualKeyboardcheckBox.Text = "Virtual Keyboard";
            this.VirualKeyboardcheckBox.UseVisualStyleBackColor = true;
            this.VirualKeyboardcheckBox.CheckedChanged += new System.EventHandler(this.VirualKeyboardcheckBox_CheckedChanged);
            // 
            // numPad1
            // 
            this.numPad1.Location = new System.Drawing.Point(620, 12);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(614, 508);
            this.numPad1.TabIndex = 7;
            // 
            // easyEcalc1
            // 
            this.easyEcalc1.Location = new System.Drawing.Point(17, 76);
            this.easyEcalc1.Name = "easyEcalc1";
            this.easyEcalc1.Size = new System.Drawing.Size(445, 280);
            this.easyEcalc1.TabIndex = 0;
            // 
            // EcalcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 524);
            this.Controls.Add(this.numPad1);
            this.Controls.Add(this.VirualKeyboardcheckBox);
            this.Controls.Add(this.Jtobutton);
            this.Controls.Add(this.Ttobutton);
            this.Controls.Add(this.lambdatobutton);
            this.Controls.Add(this.ftobutton);
            this.Controls.Add(this.eVtobutton);
            this.Controls.Add(this.easyEcalc1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcalcMain";
            this.Text = "EasyEcalc";
            this.Load += new System.EventHandler(this.EcalcMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private easyEcalc.EasyEcalc easyEcalc1;
        private System.Windows.Forms.Button eVtobutton;
        private System.Windows.Forms.Button ftobutton;
        private System.Windows.Forms.Button lambdatobutton;
        private System.Windows.Forms.Button Ttobutton;
        private System.Windows.Forms.Button Jtobutton;
        private System.Windows.Forms.CheckBox VirualKeyboardcheckBox;
        private NumPad numPad1;
    }
}

