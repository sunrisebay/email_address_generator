namespace email_address_generator
{
    partial class frm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2));
            this.lblintro = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblintro
            // 
            this.lblintro.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblintro.Location = new System.Drawing.Point(20, 10);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(452, 182);
            this.lblintro.TabIndex = 0;
            this.lblintro.Text = resources.GetString("lblintro.Text");
            this.lblintro.Click += new System.EventHandler(this.lblintro_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(207, 215);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblintro);
            this.Name = "frm2";
            this.Text = "About me";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblintro;
        public System.Windows.Forms.Button btnclose;
    }
}