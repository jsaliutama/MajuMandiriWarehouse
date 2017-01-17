namespace MajuMandiriGudang
{
    partial class FormInput
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
            this.buttonInSupplier = new System.Windows.Forms.Button();
            this.buttonInReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInSupplier
            // 
            this.buttonInSupplier.Location = new System.Drawing.Point(28, 87);
            this.buttonInSupplier.Name = "buttonInSupplier";
            this.buttonInSupplier.Size = new System.Drawing.Size(147, 64);
            this.buttonInSupplier.TabIndex = 0;
            this.buttonInSupplier.Text = "Dari Supplier";
            this.buttonInSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonInReturn
            // 
            this.buttonInReturn.Location = new System.Drawing.Point(273, 86);
            this.buttonInReturn.Name = "buttonInReturn";
            this.buttonInReturn.Size = new System.Drawing.Size(140, 65);
            this.buttonInReturn.TabIndex = 1;
            this.buttonInReturn.Text = "Dari Retur";
            this.buttonInReturn.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.buttonInReturn);
            this.Controls.Add(this.buttonInSupplier);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInSupplier;
        private System.Windows.Forms.Button buttonInReturn;
    }
}