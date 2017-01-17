namespace MajuMandiriGudang
{
    partial class MainEdit
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
            this.buttonEditInput = new System.Windows.Forms.Button();
            this.buttonEditOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditInput
            // 
            this.buttonEditInput.Location = new System.Drawing.Point(14, 98);
            this.buttonEditInput.Name = "buttonEditInput";
            this.buttonEditInput.Size = new System.Drawing.Size(133, 61);
            this.buttonEditInput.TabIndex = 0;
            this.buttonEditInput.Text = "Edit Barang Masuk";
            this.buttonEditInput.UseVisualStyleBackColor = true;
            // 
            // buttonEditOutput
            // 
            this.buttonEditOutput.Location = new System.Drawing.Point(219, 102);
            this.buttonEditOutput.Name = "buttonEditOutput";
            this.buttonEditOutput.Size = new System.Drawing.Size(141, 56);
            this.buttonEditOutput.TabIndex = 1;
            this.buttonEditOutput.Text = "Edit Barang Keluar";
            this.buttonEditOutput.UseVisualStyleBackColor = true;
            // 
            // MainEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.buttonEditOutput);
            this.Controls.Add(this.buttonEditInput);
            this.Name = "MainEdit";
            this.Text = "MainEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditInput;
        private System.Windows.Forms.Button buttonEditOutput;
    }
}