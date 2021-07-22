
namespace Snake
{
    partial class Snake
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
            this.PictureBoxDrawer = new System.Windows.Forms.PictureBox();
            this.Frametick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxDrawer
            // 
            this.PictureBoxDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxDrawer.Location = new System.Drawing.Point(-2, 0);
            this.PictureBoxDrawer.Name = "PictureBoxDrawer";
            this.PictureBoxDrawer.Size = new System.Drawing.Size(1379, 552);
            this.PictureBoxDrawer.TabIndex = 0;
            this.PictureBoxDrawer.TabStop = false;
            this.PictureBoxDrawer.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxDrawer_Paint);
            // 
            // Frametick
            // 
            this.Frametick.Tick += new System.EventHandler(this.Frametick_Tick);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 552);
            this.Controls.Add(this.PictureBoxDrawer);
            this.Name = "Snake";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDrawer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxDrawer;
        private System.Windows.Forms.Timer Frametick;
    }
}

