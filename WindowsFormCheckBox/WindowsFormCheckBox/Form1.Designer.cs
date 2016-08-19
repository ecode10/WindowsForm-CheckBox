namespace WindowsFormCheckBox
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAceito = new System.Windows.Forms.CheckBox();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.txtAceito = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAceito);
            this.groupBox2.Controls.Add(this.chkAceito);
            this.groupBox2.Location = new System.Drawing.Point(32, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 393);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linguagens de Software";
            // 
            // chkAceito
            // 
            this.chkAceito.AutoSize = true;
            this.chkAceito.Location = new System.Drawing.Point(813, 364);
            this.chkAceito.Name = "chkAceito";
            this.chkAceito.Size = new System.Drawing.Size(109, 29);
            this.chkAceito.TabIndex = 0;
            this.chkAceito.Text = "Aceito";
            this.chkAceito.UseVisualStyleBackColor = true;
            this.chkAceito.CheckedChanged += new System.EventHandler(this.chkAceito_CheckedChanged);
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(751, 449);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(208, 65);
            this.cmdGravar.TabIndex = 1;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Visible = false;
            // 
            // txtAceito
            // 
            this.txtAceito.Location = new System.Drawing.Point(18, 32);
            this.txtAceito.Multiline = true;
            this.txtAceito.Name = "txtAceito";
            this.txtAceito.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAceito.Size = new System.Drawing.Size(883, 314);
            this.txtAceito.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1004, 543);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAceito;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.TextBox txtAceito;
    }
}

