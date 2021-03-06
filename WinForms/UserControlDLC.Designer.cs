
namespace GameStore.WinForms
{
    partial class UserControlDLC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDLC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelReleaseDate);
            this.panel1.Controls.Add(this.labelPublisher);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 165);
            this.panel1.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrice.Location = new System.Drawing.Point(723, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(117, 165);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "60.00$";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::GameStore.Resource.cart;
            this.buttonAdd.Location = new System.Drawing.Point(840, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 165);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelReleaseDate.Location = new System.Drawing.Point(318, 53);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(399, 24);
            this.labelReleaseDate.TabIndex = 5;
            this.labelReleaseDate.Text = "ReleaseDate :  ";
            // 
            // labelPublisher
            // 
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPublisher.Location = new System.Drawing.Point(318, 95);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(399, 24);
            this.labelPublisher.TabIndex = 3;
            this.labelPublisher.Text = "Publisher : ";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(316, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(401, 33);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Red Dead Redemption 2";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(310, 165);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // UserControlDLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlDLC";
            this.Size = new System.Drawing.Size(918, 174);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
