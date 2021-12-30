
namespace isletim
{
    partial class system_resource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(system_resource));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarMEM = new System.Windows.Forms.ProgressBar();
            this.buttonStrart = new System.Windows.Forms.Button();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.islemler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPUusage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MemoryUsage:";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(288, 57);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(429, 28);
            this.progressBarCPU.Step = 1;
            this.progressBarCPU.TabIndex = 2;
            // 
            // progressBarMEM
            // 
            this.progressBarMEM.Location = new System.Drawing.Point(288, 123);
            this.progressBarMEM.Name = "progressBarMEM";
            this.progressBarMEM.Size = new System.Drawing.Size(429, 28);
            this.progressBarMEM.Step = 1;
            this.progressBarMEM.TabIndex = 3;
            // 
            // buttonStrart
            // 
            this.buttonStrart.BackColor = System.Drawing.Color.Lime;
            this.buttonStrart.FlatAppearance.BorderSize = 0;
            this.buttonStrart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStrart.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStrart.Location = new System.Drawing.Point(109, 171);
            this.buttonStrart.Name = "buttonStrart";
            this.buttonStrart.Size = new System.Drawing.Size(108, 28);
            this.buttonStrart.TabIndex = 4;
            this.buttonStrart.Text = "Start";
            this.buttonStrart.UseVisualStyleBackColor = false;
            this.buttonStrart.Click += new System.EventHandler(this.buttonStrart_Click);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Showcard Gothic", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpu.Location = new System.Drawing.Point(738, 65);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(29, 18);
            this.lblCpu.TabIndex = 5;
            this.lblCpu.Text = "0%";
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Font = new System.Drawing.Font("Showcard Gothic", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMem.Location = new System.Drawing.Point(738, 131);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(29, 18);
            this.lblMem.TabIndex = 6;
            this.lblMem.Text = "0%";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(321, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Uygulamalar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // islemler
            // 
            this.islemler.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.islemler.FormattingEnabled = true;
            this.islemler.ItemHeight = 19;
            this.islemler.Location = new System.Drawing.Point(172, 269);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(489, 175);
            this.islemler.TabIndex = 8;
            this.islemler.SelectedIndexChanged += new System.EventHandler(this.islemler_SelectedIndexChanged);
            // 
            // system_resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMem);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.buttonStrart);
            this.Controls.Add(this.progressBarMEM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "system_resource";
            this.Text = "system_resource";
            this.Load += new System.EventHandler(this.system_resource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarMEM;
        private System.Windows.Forms.Button buttonStrart;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox islemler;
    }
}