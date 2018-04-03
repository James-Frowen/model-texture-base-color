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
            this.minColorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.minColorButton = new System.Windows.Forms.Button();
            this.minColorFormButton = new System.Windows.Forms.Button();
            this.alphaOnlyToggle = new System.Windows.Forms.CheckBox();
            this.tiledTextureToggle = new System.Windows.Forms.CheckBox();
            this.scaleY = new System.Windows.Forms.TextBox();
            this.scaleX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openResultDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.maxColorFormButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maxColorButton = new System.Windows.Forms.Button();
            this.maxColorDialog = new System.Windows.Forms.ColorDialog();
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
            this.resultBox.Location = new System.Drawing.Point(280, 96);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(512, 512);
            this.resultBox.TabIndex = 5;
            this.resultBox.TabStop = false;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(542, 12);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(256, 23);
            this.saveResultButton.TabIndex = 4;
            this.saveResultButton.Text = "Save Result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // createResultButton
            // 
            this.createResultButton.Location = new System.Drawing.Point(280, 12);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Threshold Min";
            // 
            // minColorButton
            // 
            this.minColorButton.Location = new System.Drawing.Point(718, 39);
            this.minColorButton.Name = "minColorButton";
            this.minColorButton.Size = new System.Drawing.Size(23, 23);
            this.minColorButton.TabIndex = 7;
            this.minColorButton.UseVisualStyleBackColor = true;
            this.minColorButton.Click += new System.EventHandler(this.minColorButton_Click);
            // 
            // minColorFormButton
            // 
            this.minColorFormButton.Location = new System.Drawing.Point(747, 41);
            this.minColorFormButton.Name = "minColorFormButton";
            this.minColorFormButton.Size = new System.Drawing.Size(45, 23);
            this.minColorFormButton.TabIndex = 9;
            this.minColorFormButton.Text = "RGBA";
            this.minColorFormButton.UseVisualStyleBackColor = true;
            this.minColorFormButton.Click += new System.EventHandler(this.minColorFormButton_Click);
            // 
            // alphaOnlyToggle
            // 
            this.alphaOnlyToggle.AutoSize = true;
            this.alphaOnlyToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alphaOnlyToggle.Location = new System.Drawing.Point(548, 45);
            this.alphaOnlyToggle.Name = "alphaOnlyToggle";
            this.alphaOnlyToggle.Size = new System.Drawing.Size(77, 17);
            this.alphaOnlyToggle.TabIndex = 10;
            this.alphaOnlyToggle.Text = "Alpha Only";
            this.alphaOnlyToggle.UseVisualStyleBackColor = true;
            // 
            // tiledTextureToggle
            // 
            this.tiledTextureToggle.AutoSize = true;
            this.tiledTextureToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tiledTextureToggle.Checked = true;
            this.tiledTextureToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tiledTextureToggle.Location = new System.Drawing.Point(283, 45);
            this.tiledTextureToggle.Name = "tiledTextureToggle";
            this.tiledTextureToggle.Size = new System.Drawing.Size(49, 17);
            this.tiledTextureToggle.TabIndex = 11;
            this.tiledTextureToggle.Text = "Tiled";
            this.tiledTextureToggle.UseVisualStyleBackColor = true;
            // 
            // scaleY
            // 
            this.scaleY.Location = new System.Drawing.Point(461, 43);
            this.scaleY.Name = "scaleY";
            this.scaleY.Size = new System.Drawing.Size(68, 20);
            this.scaleY.TabIndex = 12;
            this.scaleY.Text = "1";
            // 
            // scaleX
            // 
            this.scaleX.Location = new System.Drawing.Point(387, 43);
            this.scaleX.Name = "scaleX";
            this.scaleX.Size = new System.Drawing.Size(68, 20);
            this.scaleX.TabIndex = 13;
            this.scaleX.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scale";
            // 
            // openResultDialog
            // 
            this.openResultDialog.FileName = "openResultDialog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // maxColorFormButton
            // 
            this.maxColorFormButton.Location = new System.Drawing.Point(747, 69);
            this.maxColorFormButton.Name = "maxColorFormButton";
            this.maxColorFormButton.Size = new System.Drawing.Size(45, 23);
            this.maxColorFormButton.TabIndex = 18;
            this.maxColorFormButton.Text = "RGBA";
            this.maxColorFormButton.UseVisualStyleBackColor = true;
            this.maxColorFormButton.Click += new System.EventHandler(this.maxColorFormButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Threshold Max";
            // 
            // maxColorButton
            // 
            this.maxColorButton.Location = new System.Drawing.Point(718, 67);
            this.maxColorButton.Name = "maxColorButton";
            this.maxColorButton.Size = new System.Drawing.Size(23, 23);
            this.maxColorButton.TabIndex = 16;
            this.maxColorButton.UseVisualStyleBackColor = true;
            this.maxColorButton.Click += new System.EventHandler(this.maxColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 633);
            this.Controls.Add(this.maxColorFormButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxColorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleX);
            this.Controls.Add(this.scaleY);
            this.Controls.Add(this.tiledTextureToggle);
            this.Controls.Add(this.alphaOnlyToggle);
            this.Controls.Add(this.minColorFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minColorButton);
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
            this.PerformLayout();

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
        private System.Windows.Forms.ColorDialog minColorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minColorButton;
        private System.Windows.Forms.Button minColorFormButton;
        private System.Windows.Forms.CheckBox alphaOnlyToggle;
        private System.Windows.Forms.CheckBox tiledTextureToggle;
        private System.Windows.Forms.TextBox scaleY;
        private System.Windows.Forms.TextBox scaleX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openResultDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button maxColorFormButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button maxColorButton;
        private System.Windows.Forms.ColorDialog maxColorDialog;
    }
}

