namespace UI
{
    public partial class FormComments
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
            System.Windows.Forms.Label created_timeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label senderLabel;
            System.Windows.Forms.Label userCommentLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonComment = new System.Windows.Forms.Button();
            this.created_timeLabel1 = new System.Windows.Forms.Label();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.senderLabel1 = new System.Windows.Forms.Label();
            this.userCommentTextBox = new System.Windows.Forms.TextBox();
            created_timeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            senderLabel = new System.Windows.Forms.Label();
            userCommentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // created_timeLabel
            // 
            created_timeLabel.AutoSize = true;
            created_timeLabel.Location = new System.Drawing.Point(10, 20);
            created_timeLabel.Name = "created_timeLabel";
            created_timeLabel.Size = new System.Drawing.Size(140, 25);
            created_timeLabel.TabIndex = 0;
            created_timeLabel.Text = "Created time:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(10, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(10, 195);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(106, 25);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.Location = new System.Drawing.Point(10, 125);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new System.Drawing.Size(87, 25);
            senderLabel.TabIndex = 6;
            senderLabel.Text = "Sender:";
            // 
            // userCommentLabel
            // 
            userCommentLabel.AutoSize = true;
            userCommentLabel.Location = new System.Drawing.Point(10, 364);
            userCommentLabel.Name = "userCommentLabel";
            userCommentLabel.Size = new System.Drawing.Size(160, 25);
            userCommentLabel.TabIndex = 8;
            userCommentLabel.Text = "User Comment:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.commentBindingSource;
            this.listBox1.DisplayMember = "Sender";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(23, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 454);
            this.listBox1.TabIndex = 0;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(Logic.Comment);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonComment);
            this.panel1.Controls.Add(created_timeLabel);
            this.panel1.Controls.Add(this.created_timeLabel1);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idLabel1);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageLabel1);
            this.panel1.Controls.Add(senderLabel);
            this.panel1.Controls.Add(this.senderLabel1);
            this.panel1.Controls.Add(userCommentLabel);
            this.panel1.Controls.Add(this.userCommentTextBox);
            this.panel1.Location = new System.Drawing.Point(509, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 454);
            this.panel1.TabIndex = 1;
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(507, 384);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(130, 46);
            this.buttonComment.TabIndex = 12;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // created_timeLabel1
            // 
            this.created_timeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "Created_time", true));
            this.created_timeLabel1.Location = new System.Drawing.Point(183, 20);
            this.created_timeLabel1.Name = "created_timeLabel1";
            this.created_timeLabel1.Size = new System.Drawing.Size(219, 36);
            this.created_timeLabel1.TabIndex = 1;
            this.created_timeLabel1.Text = "label1";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(183, 69);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(250, 23);
            this.idLabel1.TabIndex = 3;
            this.idLabel1.Text = "label1";
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(183, 195);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(406, 130);
            this.messageLabel1.TabIndex = 5;
            this.messageLabel1.Text = "label1";
            // 
            // senderLabel1
            // 
            this.senderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "Sender", true));
            this.senderLabel1.Location = new System.Drawing.Point(183, 127);
            this.senderLabel1.Name = "senderLabel1";
            this.senderLabel1.Size = new System.Drawing.Size(250, 23);
            this.senderLabel1.TabIndex = 7;
            this.senderLabel1.Text = "label1";
            // 
            // userCommentTextBox
            // 
            this.userCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "UserComment", true));
            this.userCommentTextBox.Location = new System.Drawing.Point(176, 364);
            this.userCommentTextBox.Multiline = true;
            this.userCommentTextBox.Name = "userCommentTextBox";
            this.userCommentTextBox.Size = new System.Drawing.Size(309, 66);
            this.userCommentTextBox.TabIndex = 9;
            // 
            // comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "comments";
            this.Text = "comments";
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.Label created_timeLabel1;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.Label senderLabel1;
        private System.Windows.Forms.TextBox userCommentTextBox;
        private System.Windows.Forms.Button buttonComment;
    }
}