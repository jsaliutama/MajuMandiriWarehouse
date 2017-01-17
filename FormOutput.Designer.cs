namespace MajuMandiriGudang
{
    partial class FormOutput
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
            this.buttonOutDelivery = new System.Windows.Forms.Button();
            this.buttonOutReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOutDelivery
            // 
            this.buttonOutDelivery.Location = new System.Drawing.Point(22, 95);
            this.buttonOutDelivery.Name = "buttonOutDelivery";
            this.buttonOutDelivery.Size = new System.Drawing.Size(133, 66);
            this.buttonOutDelivery.TabIndex = 0;
            this.buttonOutDelivery.Text = "Keluar Kirim";
            this.buttonOutDelivery.UseVisualStyleBackColor = true;
            this.buttonOutDelivery.Click += new System.EventHandler(this.buttonOutDelivery_Click);
            // 
            // buttonOutReturn
            // 
            this.buttonOutReturn.Location = new System.Drawing.Point(289, 95);
            this.buttonOutReturn.Name = "buttonOutReturn";
            this.buttonOutReturn.Size = new System.Drawing.Size(137, 65);
            this.buttonOutReturn.TabIndex = 1;
            this.buttonOutReturn.Text = "Keluar Retur";
            this.buttonOutReturn.UseVisualStyleBackColor = true;
            this.buttonOutReturn.Click += new System.EventHandler(this.buttonOutReturn_Click);
            // 
            // FormOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.buttonOutReturn);
            this.Controls.Add(this.buttonOutDelivery);
            this.Name = "FormOutput";
            this.Text = "FormOutput";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOutDelivery;
        private System.Windows.Forms.Button buttonOutReturn;
    }
}