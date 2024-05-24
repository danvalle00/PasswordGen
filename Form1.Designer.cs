namespace PasswordGen
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
            yesBtn = new Button();
            mainLabel = new Label();
            noBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // yesBtn
            // 
            yesBtn.Font = new Font("JetBrains Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yesBtn.Location = new Point(58, 304);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(220, 70);
            yesBtn.TabIndex = 0;
            yesBtn.Text = "Sim";
            yesBtn.UseVisualStyleBackColor = true;
            yesBtn.Click += button1_Click;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("JetBrains Mono", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainLabel.Location = new Point(58, 19);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(684, 43);
            mainLabel.TabIndex = 1;
            mainLabel.Text = "Deseja gerar uma senha aleatória?";
            
            // 
            // noBtn
            // 
            noBtn.Font = new Font("JetBrains Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noBtn.Location = new Point(522, 304);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(220, 70);
            noBtn.TabIndex = 2;
            noBtn.Text = "Não";
            noBtn.UseVisualStyleBackColor = true;
            noBtn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 178);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 3;
            label1.Text = "Sua nova senha é: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 175);
            label2.Name = "label2";
            label2.Size = new Size(0, 36);
            label2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(657, 173);
            button1.Name = "button1";
            button1.Size = new Size(85, 35);
            button1.TabIndex = 5;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 386);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noBtn);
            Controls.Add(mainLabel);
            Controls.Add(yesBtn);
            Name = "Form1";
            Text = "GeNeRaToR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yesBtn;
        private Label mainLabel;
        private Button noBtn;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
