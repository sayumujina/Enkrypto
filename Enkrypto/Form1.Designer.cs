namespace Enkrypto
{
    partial class Enkrypto
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
            components = new System.ComponentModel.Container();
            StringContainer = new TextBox();
            IntegerContainer = new TextBox();
            StringLabel = new Label();
            IntegerLabel = new Label();
            SubmitButton = new Button();
            SubmitLabel = new Label();
            StringErrorLabel = new Label();
            IntegerErrorLabel = new Label();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            OutputTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // StringContainer
            // 
            StringContainer.Location = new Point(248, 68);
            StringContainer.Name = "StringContainer";
            StringContainer.PlaceholderText = "Capital letters only, maximum 40 letters...";
            StringContainer.Size = new Size(435, 27);
            StringContainer.TabIndex = 0;
            // 
            // IntegerContainer
            // 
            IntegerContainer.Location = new Point(248, 128);
            IntegerContainer.Name = "IntegerContainer";
            IntegerContainer.PlaceholderText = "Integer range [-25, 25]";
            IntegerContainer.Size = new Size(435, 27);
            IntegerContainer.TabIndex = 1;
            // 
            // StringLabel
            // 
            StringLabel.AutoSize = true;
            StringLabel.Location = new Point(128, 71);
            StringLabel.Name = "StringLabel";
            StringLabel.Size = new Size(114, 20);
            StringLabel.TabIndex = 2;
            StringLabel.Text = "Type string here";
            // 
            // IntegerLabel
            // 
            IntegerLabel.AutoSize = true;
            IntegerLabel.Location = new Point(114, 131);
            IntegerLabel.Name = "IntegerLabel";
            IntegerLabel.Size = new Size(128, 20);
            IntegerLabel.TabIndex = 3;
            IntegerLabel.Text = "Type number here";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(414, 191);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // SubmitLabel
            // 
            SubmitLabel.Anchor = AnchorStyles.None;
            SubmitLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SubmitLabel.Location = new Point(514, 195);
            SubmitLabel.Name = "SubmitLabel";
            SubmitLabel.Size = new Size(169, 60);
            SubmitLabel.TabIndex = 9;
            SubmitLabel.Text = "Success or Not?";
            // 
            // StringErrorLabel
            // 
            StringErrorLabel.Anchor = AnchorStyles.None;
            StringErrorLabel.ImageAlign = ContentAlignment.MiddleLeft;
            StringErrorLabel.Location = new Point(248, 102);
            StringErrorLabel.Name = "StringErrorLabel";
            StringErrorLabel.Size = new Size(435, 20);
            StringErrorLabel.TabIndex = 10;
            StringErrorLabel.Text = "Error message?";
            StringErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IntegerErrorLabel
            // 
            IntegerErrorLabel.Anchor = AnchorStyles.None;
            IntegerErrorLabel.ImageAlign = ContentAlignment.MiddleLeft;
            IntegerErrorLabel.Location = new Point(248, 163);
            IntegerErrorLabel.Name = "IntegerErrorLabel";
            IntegerErrorLabel.Size = new Size(435, 20);
            IntegerErrorLabel.TabIndex = 11;
            IntegerErrorLabel.Text = "Error message?";
            IntegerErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 46);
            label1.TabIndex = 12;
            label1.Text = "Enkrypto";
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(248, 250);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(425, 149);
            OutputTextBox.TabIndex = 14;
            // 
            // DecipherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(809, 450);
            Controls.Add(OutputTextBox);
            Controls.Add(label1);
            Controls.Add(IntegerErrorLabel);
            Controls.Add(StringErrorLabel);
            Controls.Add(SubmitLabel);
            Controls.Add(SubmitButton);
            Controls.Add(IntegerLabel);
            Controls.Add(StringLabel);
            Controls.Add(IntegerContainer);
            Controls.Add(StringContainer);
            Name = "DecipherForm";
            Text = "Enkrypto";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StringContainer;
        private TextBox IntegerContainer;
        private Label StringLabel;
        private Label IntegerLabel;
        private Button SubmitButton;
        private Label SubmitLabel;
        private Label StringErrorLabel;
        private Label IntegerErrorLabel;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox OutputTextBox;
    }
}
