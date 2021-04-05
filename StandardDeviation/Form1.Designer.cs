
namespace standarddeviation
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
            this.components = new System.ComponentModel.Container();
            this.btnSart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMaxSD = new System.Windows.Forms.Button();
            this.btnMaxSD_Array = new System.Windows.Forms.Button();
            this.listBoxMaxSD = new System.Windows.Forms.ListBox();
            this.listBoxMaxSdArray = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSart
            // 
            this.btnSart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSart.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSart.Location = new System.Drawing.Point(791, 29);
            this.btnSart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSart.Name = "btnSart";
            this.btnSart.Size = new System.Drawing.Size(110, 109);
            this.btnSart.TabIndex = 0;
            this.btnSart.Text = "START";
            this.btnSart.UseVisualStyleBackColor = false;
            this.btnSart.Click += new System.EventHandler(this.btnSart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Headline R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(791, 176);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 106);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(14, 29);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(745, 244);
            this.listBox.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMaxSD
            // 
            this.btnMaxSD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMaxSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaxSD.Location = new System.Drawing.Point(14, 324);
            this.btnMaxSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaxSD.Name = "btnMaxSD";
            this.btnMaxSD.Size = new System.Drawing.Size(109, 51);
            this.btnMaxSD.TabIndex = 3;
            this.btnMaxSD.Text = "MAX_SD";
            this.btnMaxSD.UseVisualStyleBackColor = false;
            this.btnMaxSD.Click += new System.EventHandler(this.btnMaxSD_Click);
            // 
            // btnMaxSD_Array
            // 
            this.btnMaxSD_Array.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMaxSD_Array.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaxSD_Array.Location = new System.Drawing.Point(319, 324);
            this.btnMaxSD_Array.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaxSD_Array.Name = "btnMaxSD_Array";
            this.btnMaxSD_Array.Size = new System.Drawing.Size(119, 52);
            this.btnMaxSD_Array.TabIndex = 4;
            this.btnMaxSD_Array.Text = "MAX_SD_Array";
            this.btnMaxSD_Array.UseVisualStyleBackColor = false;
            this.btnMaxSD_Array.Click += new System.EventHandler(this.btnMaxSD_Array_Click);
            // 
            // listBoxMaxSD
            // 
            this.listBoxMaxSD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBoxMaxSD.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxMaxSD.FormattingEnabled = true;
            this.listBoxMaxSD.ItemHeight = 23;
            this.listBoxMaxSD.Location = new System.Drawing.Point(143, 326);
            this.listBoxMaxSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMaxSD.Name = "listBoxMaxSD";
            this.listBoxMaxSD.Size = new System.Drawing.Size(126, 50);
            this.listBoxMaxSD.TabIndex = 5;
            // 
            // listBoxMaxSdArray
            // 
            this.listBoxMaxSdArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMaxSdArray.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxMaxSdArray.FormattingEnabled = true;
            this.listBoxMaxSdArray.ItemHeight = 20;
            this.listBoxMaxSdArray.Location = new System.Drawing.Point(485, 332);
            this.listBoxMaxSdArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMaxSdArray.Name = "listBoxMaxSdArray";
            this.listBoxMaxSdArray.Size = new System.Drawing.Size(205, 44);
            this.listBoxMaxSdArray.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 409);
            this.Controls.Add(this.listBoxMaxSdArray);
            this.Controls.Add(this.listBoxMaxSD);
            this.Controls.Add(this.btnMaxSD_Array);
            this.Controls.Add(this.btnMaxSD);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingAction);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMaxSD;
        private System.Windows.Forms.Button btnMaxSD_Array;
        private System.Windows.Forms.ListBox listBoxMaxSD;
        private System.Windows.Forms.ListBox listBoxMaxSdArray;
    }
}

