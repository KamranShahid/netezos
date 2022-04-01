namespace WinFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrivateKeytFromTransfer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublicKeyToTransfer = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNetwork = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "PrivateKeytFromTransfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PublicKeyToTransfer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // txtPrivateKeytFromTransfer
            // 
            this.txtPrivateKeytFromTransfer.Location = new System.Drawing.Point(216, 38);
            this.txtPrivateKeytFromTransfer.Name = "txtPrivateKeytFromTransfer";
            this.txtPrivateKeytFromTransfer.Size = new System.Drawing.Size(581, 23);
            this.txtPrivateKeytFromTransfer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "NetworkUrl";
            // 
            // txtPublicKeyToTransfer
            // 
            this.txtPublicKeyToTransfer.Location = new System.Drawing.Point(216, 67);
            this.txtPublicKeyToTransfer.Name = "txtPublicKeyToTransfer";
            this.txtPublicKeyToTransfer.Size = new System.Drawing.Size(581, 23);
            this.txtPublicKeyToTransfer.TabIndex = 6;
            this.txtPublicKeyToTransfer.Text = "tz1NpRgSe3RUWjJD1mYhHbzVNxhPaqK6XemJ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(216, 96);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 7;
            // 
            // txtNetwork
            // 
            this.txtNetwork.Location = new System.Drawing.Point(216, 122);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(581, 23);
            this.txtNetwork.TabIndex = 8;
            this.txtNetwork.Text = "https://rpc.tzkt.io/ithacanet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNetwork);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPublicKeyToTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivateKeytFromTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrivateKeytFromTransfer;
        private Label label4;
        private TextBox txtPublicKeyToTransfer;
        private TextBox txtAmount;
        private TextBox txtNetwork;
    }
}