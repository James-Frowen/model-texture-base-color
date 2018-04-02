namespace model_texture_base_color
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
            this.saveOutputDialog = new System.Windows.Forms.SaveFileDialog();
            this.openOutlineDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTextureDialog = new System.Windows.Forms.OpenFileDialog();
            this.openOutlineButton = new System.Windows.Forms.Button();
            this.outlineBox = new System.Windows.Forms.PictureBox();
            this.textureBox = new System.Windows.Forms.PictureBox();
            this.openTextureButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.createResultButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outlineBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOutputDialog
            // 
            this.saveOutputDialog.FileName = "saveOutput";
            // 
            // openOutlineDialog
            // 
            this.openOutlineDialog.FileName = "openOutline";
            // 
            // openTextureDialog
            // 
            this.openTextureDialog.FileName = "openTexture";
            // 
            // openOutlineButton
            // 
            this.openOutlineButton.Location = new System.Drawing.Point(12, 12);
            this.openOutlineButton.Name = "openOutlineButton";
            this.openOutlineButton.Size = new System.Drawing.Size(256, 23);
            this.openOutlineButton.TabIndex = 0;
            this.openOutlineButton.Text = "Open Outline";
            this.openOutlineButton.UseVisualStyleBackColor = true;
            this.openOutlineButton.Click += new System.EventHandler(this.openOutlineButton_Click);
            // 
            // outlineBox
            // 
            this.outlineBox.Location = new System.Drawing.Point(12, 41);
            this.outlineBox.Name = "outlineBox";
            this.outlineBox.Size = new System.Drawing.Size(256, 256);
            this.outlineBox.TabIndex = 1;
            this.outlineBox.TabStop = false;
            // 
            // textureBox
            // 
            this.textureBox.Location = new System.Drawing.Point(12, 332);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(256, 256);
            this.textureBox.TabIndex = 3;
            this.textureBox.TabStop = false;
            // 
            // openTextureButton
            // 
            this.openTextureButton.Location = new System.Drawing.Point(12, 303);
            this.openTextureButton.Name = "openTextureButton";
            this.openTextureButton.Size = new System.Drawing.Size(256, 23);
            this.openTextureButton.TabIndex = 2;
            this.openTextureButton.Text = "Open Texture";
            this.openTextureButton.UseVisualStyleBackColor = true;
            this.openTextureButton.Click += new System.EventHandler(this.openTextureButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(279, 59);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(512, 512);
            this.resultBox.TabIndex = 5;
            this.resultBox.TabStop = false;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(536, 12);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(256, 23);
            this.saveResultButton.TabIndex = 4;
            this.saveResultButton.Text = "Save Result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // createResultButton
            // 
            this.createResultButton.Location = new System.Drawing.Point(274, 12);
            this.createResultButton.Name = "createResultButton";
            this.createResultButton.Size = new System.Drawing.Size(256, 23);
            this.createResultButton.TabIndex = 6;
            this.createResultButton.Text = "Create Result";
            this.createResultButton.UseVisualStyleBackColor = true;
            this.createResultButton.Click += new System.EventHandler(this.createResultButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 604);
            this.Controls.Add(this.createResultButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.textureBox);
            this.Controls.Add(this.openTextureButton);
            this.Controls.Add(this.outlineBox);
            this.Controls.Add(this.openOutlineButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outlineBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveOutputDialog;
        private System.Windows.Forms.OpenFileDialog openOutlineDialog;
        private System.Windows.Forms.OpenFileDialog openTextureDialog;
        private System.Windows.Forms.Button openOutlineButton;
        private System.Windows.Forms.PictureBox outlineBox;
        private System.Windows.Forms.PictureBox textureBox;
        private System.Windows.Forms.Button openTextureButton;
        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button createResultButton;
        private System.Windows.Forms.Timer timer1;
    }
}

