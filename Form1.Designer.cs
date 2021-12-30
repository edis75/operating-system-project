
namespace isletim
{
    partial class PCinfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pc = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.Button();
            this.hdd = new System.Windows.Forms.Button();
            this.cpu = new System.Windows.Forms.Button();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.txtHdd = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.resourceButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pc);
            this.panel1.Controls.Add(this.ram);
            this.panel1.Controls.Add(this.hdd);
            this.panel1.Controls.Add(this.cpu);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.SystemColors.Info;
            this.pc.FlatAppearance.BorderSize = 0;
            this.pc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pc.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pc.Location = new System.Drawing.Point(743, 44);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(90, 28);
            this.pc.TabIndex = 3;
            this.pc.Text = "PCINFO";
            this.pc.UseVisualStyleBackColor = false;
            this.pc.Click += new System.EventHandler(this.pc_Click);
            // 
            // ram
            // 
            this.ram.BackColor = System.Drawing.SystemColors.Info;
            this.ram.FlatAppearance.BorderSize = 0;
            this.ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ram.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ram.Location = new System.Drawing.Point(512, 44);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(90, 28);
            this.ram.TabIndex = 2;
            this.ram.Text = "RAM";
            this.ram.UseVisualStyleBackColor = false;
            this.ram.Click += new System.EventHandler(this.ram_Click);
            // 
            // hdd
            // 
            this.hdd.BackColor = System.Drawing.SystemColors.Info;
            this.hdd.FlatAppearance.BorderSize = 0;
            this.hdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdd.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdd.Location = new System.Drawing.Point(291, 44);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(90, 28);
            this.hdd.TabIndex = 1;
            this.hdd.Text = "HDD";
            this.hdd.UseVisualStyleBackColor = false;
            this.hdd.Click += new System.EventHandler(this.hdd_Click);
            // 
            // cpu
            // 
            this.cpu.AllowDrop = true;
            this.cpu.BackColor = System.Drawing.SystemColors.Info;
            this.cpu.FlatAppearance.BorderSize = 0;
            this.cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpu.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpu.Location = new System.Drawing.Point(68, 44);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(90, 28);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "CPU";
            this.cpu.UseVisualStyleBackColor = false;
            this.cpu.Click += new System.EventHandler(this.cpu_Click);
            // 
            // txtCpu
            // 
            this.txtCpu.BackColor = System.Drawing.SystemColors.Info;
            this.txtCpu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCpu.Location = new System.Drawing.Point(45, 151);
            this.txtCpu.Multiline = true;
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(172, 236);
            this.txtCpu.TabIndex = 1;
            this.txtCpu.TextChanged += new System.EventHandler(this.txtCpu_TextChanged);
            // 
            // txtHdd
            // 
            this.txtHdd.BackColor = System.Drawing.SystemColors.Info;
            this.txtHdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHdd.Location = new System.Drawing.Point(280, 151);
            this.txtHdd.Multiline = true;
            this.txtHdd.Name = "txtHdd";
            this.txtHdd.Size = new System.Drawing.Size(172, 236);
            this.txtHdd.TabIndex = 2;
            // 
            // txtRam
            // 
            this.txtRam.BackColor = System.Drawing.SystemColors.Info;
            this.txtRam.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRam.Location = new System.Drawing.Point(515, 151);
            this.txtRam.Multiline = true;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(172, 236);
            this.txtRam.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.Location = new System.Drawing.Point(754, 151);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(172, 236);
            this.txtInfo.TabIndex = 4;
            // 
            // resourceButton
            // 
            this.resourceButton.BackColor = System.Drawing.Color.Red;
            this.resourceButton.FlatAppearance.BorderSize = 0;
            this.resourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourceButton.Font = new System.Drawing.Font("Showcard Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resourceButton.Location = new System.Drawing.Point(874, 413);
            this.resourceButton.Name = "resourceButton";
            this.resourceButton.Size = new System.Drawing.Size(158, 65);
            this.resourceButton.TabIndex = 5;
            this.resourceButton.Text = "Resource";
            this.resourceButton.UseVisualStyleBackColor = false;
            this.resourceButton.Click += new System.EventHandler(this.resourceButton_Click);
            // 
            // PCinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1078, 523);
            this.Controls.Add(this.resourceButton);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtHdd);
            this.Controls.Add(this.txtCpu);
            this.Controls.Add(this.panel1);
            this.Name = "PCinfo";
            this.Text = "Pcinfo";
            this.Load += new System.EventHandler(this.PCinfo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pc;
        private System.Windows.Forms.Button ram;
        private System.Windows.Forms.Button hdd;
        private System.Windows.Forms.Button cpu;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtHdd;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button resourceButton;
    }
}

