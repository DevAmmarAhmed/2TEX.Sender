using SentEmailApp.Controls;

namespace SentEmailApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        panelRoot = new Panel();
        panelMain = new Panel();
        layoutContent = new TableLayoutPanel();
        cardSmtp = new CardPanel();
        headerSmtp = new Panel();
        lblSmtpTitle = new Label();
        lblSmtpIcon = new Label();
        layoutSmtp = new TableLayoutPanel();
        panelSmtpServer = new Panel();
        lblSmtpServer = new Label();
        txtSmtpServer = new TextBox();
        lblErrSmtpServer = new Label();
        panelPort = new Panel();
        lblPort = new Label();
        numPort = new NumericUpDown();
        lblErrPort = new Label();
        panelSenderEmail = new Panel();
        lblSenderEmail = new Label();
        txtSenderEmail = new TextBox();
        lblErrSenderEmail = new Label();
        panelPassword = new Panel();
        lblPassword = new Label();
        txtPassword = new TextBox();
        lblErrPassword = new Label();
        chkUseSslTls = new CheckBox();
        panelAttachments = new Panel();
        panelAttachmentsHeader = new Panel();
        panelAttachmentButtons = new FlowLayoutPanel();
        btnAddFiles = new Button();
        btnRemoveSelected = new Button();
        btnClearAttachments = new Button();
        listViewAttachments = new ListView();
        lblAttachmentCount = new Label();
        lblAttachmentsTitle = new Label();
        lblErrAttachments = new Label();
        cardMessage = new CardPanel();
        headerMessage = new Panel();
        lblMessageTitle = new Label();
        lblMessageIcon = new Label();
        layoutMessage = new TableLayoutPanel();
        panelRecipients = new Panel();
        panelRecipientsHeader = new Panel();
        lblRecipients = new Label();
        panelWhatsAppImport = new Panel();
        panelWhatsAppToolbar = new FlowLayoutPanel();
        btnImportWhatsApp = new Button();
        chkWhatsAppRemoveDuplicates = new CheckBox();
        chkWhatsAppAppendRecipients = new CheckBox();
        panelWhatsAppStatus = new Panel();
        lblWhatsAppFileName = new Label();
        lblWhatsAppEmailCount = new Label();
        txtRecipients = new TextBox();
        lblErrRecipients = new Label();
        panelSubject = new Panel();
        lblSubject = new Label();
        txtSubject = new TextBox();
        lblErrSubject = new Label();
        panelBody = new Panel();
        lblBody = new Label();
        txtBody = new TextBox();
        lblErrBody = new Label();
        panelFooter = new Panel();
        statusBanner = new StatusBanner();
        panelActions = new Panel();
        btnSend = new ModernButton();
        panelHeader = new Panel();
        lblSubtitle = new Label();
        lblTitle = new Label();
        panelRoot.SuspendLayout();
        panelMain.SuspendLayout();
        layoutContent.SuspendLayout();
        cardSmtp.SuspendLayout();
        headerSmtp.SuspendLayout();
        layoutSmtp.SuspendLayout();
        panelSmtpServer.SuspendLayout();
        panelPort.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
        panelSenderEmail.SuspendLayout();
        panelPassword.SuspendLayout();
        panelAttachments.SuspendLayout();
        panelAttachmentsHeader.SuspendLayout();
        panelAttachmentButtons.SuspendLayout();
        cardMessage.SuspendLayout();
        headerMessage.SuspendLayout();
        layoutMessage.SuspendLayout();
        panelRecipients.SuspendLayout();
        panelRecipientsHeader.SuspendLayout();
        panelWhatsAppImport.SuspendLayout();
        panelWhatsAppToolbar.SuspendLayout();
        panelWhatsAppStatus.SuspendLayout();
        panelSubject.SuspendLayout();
        panelBody.SuspendLayout();
        panelFooter.SuspendLayout();
        panelActions.SuspendLayout();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // panelRoot
        // 
        panelRoot.BackColor = UiTheme.PageBackground;
        panelRoot.Controls.Add(panelMain);
        panelRoot.Controls.Add(panelFooter);
        panelRoot.Controls.Add(panelHeader);
        panelRoot.Dock = DockStyle.Fill;
        panelRoot.Location = new Point(0, 0);
        panelRoot.Name = "panelRoot";
        panelRoot.Padding = new Padding(20, 14, 20, 10);
        panelRoot.Size = new Size(1200, 750);
        panelRoot.TabIndex = 0;
        // 
        // panelHeader
        // 
        panelHeader.Controls.Add(lblSubtitle);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(20, 14);
        panelHeader.Name = "panelHeader";
        panelHeader.Padding = new Padding(0, 0, 0, 6);
        panelHeader.Size = new Size(1160, 48);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = UiTheme.TitleFont;
        lblTitle.ForeColor = UiTheme.TextPrimary;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(236, 37);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Bulk Email Sender";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = UiTheme.SubtitleFont;
        lblSubtitle.ForeColor = UiTheme.TextSecondary;
        lblSubtitle.Location = new Point(2, 30);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(314, 17);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Send one message to multiple recipients via SMTP.";
        // 
        // panelMain
        // 
        panelMain.Controls.Add(layoutContent);
        panelMain.Dock = DockStyle.Fill;
        panelMain.Location = new Point(20, 62);
        panelMain.Name = "panelMain";
        panelMain.Padding = new Padding(0, 4, 0, 4);
        panelMain.Size = new Size(1160, 622);
        panelMain.TabIndex = 1;
        // 
        // layoutContent
        // 
        layoutContent.ColumnCount = 2;
        layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        layoutContent.Controls.Add(cardSmtp, 0, 0);
        layoutContent.Controls.Add(cardMessage, 1, 0);
        layoutContent.Dock = DockStyle.Fill;
        layoutContent.Location = new Point(0, 4);
        layoutContent.Name = "layoutContent";
        layoutContent.RowCount = 1;
        layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutContent.Size = new Size(1160, 614);
        layoutContent.TabIndex = 0;
        // 
        // cardSmtp
        // 
        cardSmtp.Controls.Add(panelAttachments);
        cardSmtp.Controls.Add(layoutSmtp);
        cardSmtp.Controls.Add(headerSmtp);
        cardSmtp.Dock = DockStyle.Fill;
        cardSmtp.Location = new Point(0, 0);
        cardSmtp.Margin = new Padding(0, 0, 6, 0);
        cardSmtp.Name = "cardSmtp";
        cardSmtp.Size = new Size(458, 614);
        cardSmtp.TabIndex = 0;
        // 
        // headerSmtp
        // 
        headerSmtp.Controls.Add(lblSmtpTitle);
        headerSmtp.Controls.Add(lblSmtpIcon);
        headerSmtp.Dock = DockStyle.Top;
        headerSmtp.Location = new Point(14, 12);
        headerSmtp.Name = "headerSmtp";
        headerSmtp.Size = new Size(430, 26);
        headerSmtp.TabIndex = 0;
        // 
        // lblSmtpIcon
        // 
        lblSmtpIcon.Font = UiTheme.IconFont;
        lblSmtpIcon.ForeColor = UiTheme.Primary;
        lblSmtpIcon.Location = new Point(0, 0);
        lblSmtpIcon.Name = "lblSmtpIcon";
        lblSmtpIcon.Size = new Size(24, 24);
        lblSmtpIcon.TabIndex = 0;
        lblSmtpIcon.Text = "";
        lblSmtpIcon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSmtpTitle
        // 
        lblSmtpTitle.AutoSize = true;
        lblSmtpTitle.Font = UiTheme.SectionFont;
        lblSmtpTitle.ForeColor = UiTheme.TextPrimary;
        lblSmtpTitle.Location = new Point(28, 2);
        lblSmtpTitle.Name = "lblSmtpTitle";
        lblSmtpTitle.Size = new Size(142, 20);
        lblSmtpTitle.TabIndex = 1;
        lblSmtpTitle.Text = "SMTP Configuration";
        // 
        // layoutSmtp
        // 
        layoutSmtp.AutoSize = true;
        layoutSmtp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        layoutSmtp.ColumnCount = 2;
        layoutSmtp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
        layoutSmtp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        layoutSmtp.Controls.Add(panelSmtpServer, 0, 0);
        layoutSmtp.Controls.Add(panelPort, 1, 0);
        layoutSmtp.Controls.Add(panelSenderEmail, 0, 1);
        layoutSmtp.Controls.Add(panelPassword, 0, 2);
        layoutSmtp.Controls.Add(chkUseSslTls, 0, 3);
        layoutSmtp.Dock = DockStyle.Top;
        layoutSmtp.Location = new Point(14, 38);
        layoutSmtp.Name = "layoutSmtp";
        layoutSmtp.RowCount = 4;
        layoutSmtp.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        layoutSmtp.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        layoutSmtp.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        layoutSmtp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        layoutSmtp.SetColumnSpan(panelSenderEmail, 2);
        layoutSmtp.SetColumnSpan(panelPassword, 2);
        layoutSmtp.SetColumnSpan(chkUseSslTls, 2);
        layoutSmtp.Size = new Size(430, 564);
        layoutSmtp.TabIndex = 1;
        // 
        // panelSmtpServer
        // 
        panelSmtpServer.Controls.Add(lblErrSmtpServer);
        panelSmtpServer.Controls.Add(txtSmtpServer);
        panelSmtpServer.Controls.Add(lblSmtpServer);
        panelSmtpServer.Dock = DockStyle.Fill;
        panelSmtpServer.Location = new Point(0, 0);
        panelSmtpServer.Margin = new Padding(0, 0, 8, 0);
        panelSmtpServer.Name = "panelSmtpServer";
        panelSmtpServer.Size = new Size(284, 58);
        panelSmtpServer.TabIndex = 0;
        // 
        // lblSmtpServer
        // 
        UiTheme.StyleFieldLabel(lblSmtpServer);
        lblSmtpServer.Location = new Point(0, 0);
        lblSmtpServer.Name = "lblSmtpServer";
        lblSmtpServer.Size = new Size(79, 16);
        lblSmtpServer.TabIndex = 0;
        lblSmtpServer.Text = "SMTP Server";
        // 
        // txtSmtpServer
        // 
        txtSmtpServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSmtpServer.Location = new Point(0, 18);
        txtSmtpServer.Name = "txtSmtpServer";
        txtSmtpServer.PlaceholderText = "smtp.gmail.com";
        txtSmtpServer.Size = new Size(284, 23);
        txtSmtpServer.TabIndex = 1;
        UiTheme.StyleInput(txtSmtpServer);
        // 
        // lblErrSmtpServer
        // 
        lblErrSmtpServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrSmtpServer);
        lblErrSmtpServer.Location = new Point(0, 48);
        lblErrSmtpServer.Name = "lblErrSmtpServer";
        lblErrSmtpServer.Size = new Size(284, 15);
        lblErrSmtpServer.TabIndex = 2;
        // 
        // panelPort
        // 
        panelPort.Controls.Add(lblErrPort);
        panelPort.Controls.Add(numPort);
        panelPort.Controls.Add(lblPort);
        panelPort.Dock = DockStyle.Fill;
        panelPort.Location = new Point(292, 0);
        panelPort.Margin = new Padding(0);
        panelPort.Name = "panelPort";
        panelPort.Size = new Size(138, 58);
        panelPort.TabIndex = 1;
        // 
        // lblPort
        // 
        UiTheme.StyleFieldLabel(lblPort);
        lblPort.Location = new Point(0, 0);
        lblPort.Name = "lblPort";
        lblPort.Size = new Size(29, 16);
        lblPort.TabIndex = 0;
        lblPort.Text = "Port";
        // 
        // numPort
        // 
        numPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        numPort.Font = UiTheme.BodyFont;
        numPort.Location = new Point(0, 18);
        numPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        numPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPort.Name = "numPort";
        numPort.Size = new Size(138, 25);
        numPort.TabIndex = 1;
        numPort.Value = new decimal(new int[] { 587, 0, 0, 0 });
        // 
        // lblErrPort
        // 
        lblErrPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrPort);
        lblErrPort.Location = new Point(0, 48);
        lblErrPort.Name = "lblErrPort";
        lblErrPort.Size = new Size(138, 15);
        lblErrPort.TabIndex = 2;
        // 
        // panelSenderEmail
        // 
        panelSenderEmail.Controls.Add(lblErrSenderEmail);
        panelSenderEmail.Controls.Add(txtSenderEmail);
        panelSenderEmail.Controls.Add(lblSenderEmail);
        panelSenderEmail.Dock = DockStyle.Fill;
        panelSenderEmail.Location = new Point(0, 58);
        panelSenderEmail.Margin = new Padding(0);
        panelSenderEmail.Name = "panelSenderEmail";
        panelSenderEmail.Size = new Size(430, 58);
        panelSenderEmail.TabIndex = 2;
        // 
        // lblSenderEmail
        // 
        UiTheme.StyleFieldLabel(lblSenderEmail);
        lblSenderEmail.Location = new Point(0, 0);
        lblSenderEmail.Name = "lblSenderEmail";
        lblSenderEmail.Size = new Size(81, 16);
        lblSenderEmail.TabIndex = 0;
        lblSenderEmail.Text = "Sender Email";
        // 
        // txtSenderEmail
        // 
        txtSenderEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSenderEmail.Location = new Point(0, 18);
        txtSenderEmail.Name = "txtSenderEmail";
        txtSenderEmail.PlaceholderText = "you@example.com";
        txtSenderEmail.Size = new Size(430, 23);
        txtSenderEmail.TabIndex = 1;
        UiTheme.StyleInput(txtSenderEmail);
        // 
        // lblErrSenderEmail
        // 
        lblErrSenderEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrSenderEmail);
        lblErrSenderEmail.Location = new Point(0, 48);
        lblErrSenderEmail.Name = "lblErrSenderEmail";
        lblErrSenderEmail.Size = new Size(430, 15);
        lblErrSenderEmail.TabIndex = 2;
        // 
        // panelPassword
        // 
        panelPassword.Controls.Add(lblErrPassword);
        panelPassword.Controls.Add(txtPassword);
        panelPassword.Controls.Add(lblPassword);
        panelPassword.Dock = DockStyle.Fill;
        panelPassword.Location = new Point(0, 116);
        panelPassword.Margin = new Padding(0);
        panelPassword.Name = "panelPassword";
        panelPassword.Size = new Size(430, 58);
        panelPassword.TabIndex = 3;
        // 
        // lblPassword
        // 
        UiTheme.StyleFieldLabel(lblPassword);
        lblPassword.Location = new Point(0, 0);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(126, 16);
        lblPassword.TabIndex = 0;
        lblPassword.Text = "Password / App Password";
        // 
        // txtPassword
        // 
        txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtPassword.Location = new Point(0, 18);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "App password";
        txtPassword.Size = new Size(430, 23);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        UiTheme.StyleInput(txtPassword);
        // 
        // lblErrPassword
        // 
        lblErrPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrPassword);
        lblErrPassword.Location = new Point(0, 48);
        lblErrPassword.Name = "lblErrPassword";
        lblErrPassword.Size = new Size(430, 15);
        lblErrPassword.TabIndex = 2;
        // 
        // chkUseSslTls
        // 
        chkUseSslTls.Anchor = AnchorStyles.Left;
        chkUseSslTls.AutoSize = true;
        chkUseSslTls.Checked = true;
        chkUseSslTls.CheckState = CheckState.Checked;
        chkUseSslTls.Font = UiTheme.BodyFont;
        chkUseSslTls.ForeColor = UiTheme.TextSecondary;
        chkUseSslTls.Location = new Point(0, 178);
        chkUseSslTls.Margin = new Padding(0);
        chkUseSslTls.Name = "chkUseSslTls";
        chkUseSslTls.Size = new Size(112, 21);
        chkUseSslTls.TabIndex = 4;
        chkUseSslTls.Text = "Enable SSL/TLS";
        chkUseSslTls.UseVisualStyleBackColor = true;
        //
        // panelAttachments
        //
        panelAttachments.Controls.Add(listViewAttachments);
        panelAttachments.Controls.Add(lblErrAttachments);
        panelAttachments.Controls.Add(panelAttachmentButtons);
        panelAttachments.Controls.Add(panelAttachmentsHeader);
        panelAttachments.Dock = DockStyle.Fill;
        panelAttachments.Location = new Point(14, 240);
        panelAttachments.Name = "panelAttachments";
        panelAttachments.Padding = new Padding(0, 8, 0, 0);
        panelAttachments.Size = new Size(430, 362);
        panelAttachments.TabIndex = 2;
        //
        // panelAttachmentsHeader
        //
        panelAttachmentsHeader.Controls.Add(lblAttachmentCount);
        panelAttachmentsHeader.Controls.Add(lblAttachmentsTitle);
        panelAttachmentsHeader.Dock = DockStyle.Top;
        panelAttachmentsHeader.Location = new Point(0, 8);
        panelAttachmentsHeader.Name = "panelAttachmentsHeader";
        panelAttachmentsHeader.Size = new Size(430, 22);
        panelAttachmentsHeader.TabIndex = 0;
        //
        // lblAttachmentsTitle
        //
        lblAttachmentsTitle.AutoSize = true;
        lblAttachmentsTitle.Font = UiTheme.LabelFont;
        lblAttachmentsTitle.ForeColor = UiTheme.TextSecondary;
        lblAttachmentsTitle.Location = new Point(0, 2);
        lblAttachmentsTitle.Name = "lblAttachmentsTitle";
        lblAttachmentsTitle.Size = new Size(78, 16);
        lblAttachmentsTitle.TabIndex = 0;
        lblAttachmentsTitle.Text = "Attachments";
        //
        // lblAttachmentCount
        //
        lblAttachmentCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblAttachmentCount.Font = UiTheme.HintFont;
        lblAttachmentCount.ForeColor = UiTheme.TextMuted;
        lblAttachmentCount.Location = new Point(230, 3);
        lblAttachmentCount.Name = "lblAttachmentCount";
        lblAttachmentCount.Size = new Size(200, 15);
        lblAttachmentCount.TabIndex = 1;
        lblAttachmentCount.Text = "No files attached";
        lblAttachmentCount.TextAlign = ContentAlignment.TopRight;
        //
        // panelAttachmentButtons
        //
        panelAttachmentButtons.Controls.Add(btnAddFiles);
        panelAttachmentButtons.Controls.Add(btnRemoveSelected);
        panelAttachmentButtons.Controls.Add(btnClearAttachments);
        panelAttachmentButtons.Dock = DockStyle.Top;
        panelAttachmentButtons.Location = new Point(0, 30);
        panelAttachmentButtons.Name = "panelAttachmentButtons";
        panelAttachmentButtons.Padding = new Padding(0, 0, 0, 6);
        panelAttachmentButtons.Size = new Size(430, 34);
        panelAttachmentButtons.TabIndex = 2;
        panelAttachmentButtons.WrapContents = false;
        //
        // btnAddFiles
        //
        btnAddFiles.AutoSize = true;
        btnAddFiles.Margin = new Padding(0, 0, 6, 0);
        btnAddFiles.Name = "btnAddFiles";
        btnAddFiles.Size = new Size(68, 28);
        btnAddFiles.TabIndex = 0;
        btnAddFiles.Text = "Add Files";
        btnAddFiles.UseVisualStyleBackColor = true;
        UiTheme.StyleSecondaryButton(btnAddFiles);
        //
        // btnRemoveSelected
        //
        btnRemoveSelected.AutoSize = true;
        btnRemoveSelected.Enabled = false;
        btnRemoveSelected.Margin = new Padding(0, 0, 6, 0);
        btnRemoveSelected.Name = "btnRemoveSelected";
        btnRemoveSelected.Size = new Size(104, 28);
        btnRemoveSelected.TabIndex = 1;
        btnRemoveSelected.Text = "Remove Selected";
        btnRemoveSelected.UseVisualStyleBackColor = true;
        UiTheme.StyleSecondaryButton(btnRemoveSelected);
        //
        // btnClearAttachments
        //
        btnClearAttachments.AutoSize = true;
        btnClearAttachments.Enabled = false;
        btnClearAttachments.Margin = new Padding(0);
        btnClearAttachments.Name = "btnClearAttachments";
        btnClearAttachments.Size = new Size(62, 28);
        btnClearAttachments.TabIndex = 2;
        btnClearAttachments.Text = "Clear All";
        btnClearAttachments.UseVisualStyleBackColor = true;
        UiTheme.StyleSecondaryButton(btnClearAttachments);
        //
        // listViewAttachments
        //
        listViewAttachments.Dock = DockStyle.Fill;
        listViewAttachments.Location = new Point(0, 64);
        listViewAttachments.Name = "listViewAttachments";
        listViewAttachments.Size = new Size(430, 283);
        listViewAttachments.TabIndex = 3;
        //
        // lblErrAttachments
        //
        lblErrAttachments.Dock = DockStyle.Bottom;
        UiTheme.StyleErrorLabel(lblErrAttachments);
        lblErrAttachments.Location = new Point(0, 347);
        lblErrAttachments.Name = "lblErrAttachments";
        lblErrAttachments.Padding = new Padding(0, 4, 0, 0);
        lblErrAttachments.Size = new Size(430, 15);
        lblErrAttachments.TabIndex = 4;
        //
        // cardMessage
        //
        cardMessage.Controls.Add(layoutMessage);
        cardMessage.Controls.Add(headerMessage);
        cardMessage.Dock = DockStyle.Fill;
        cardMessage.Location = new Point(464, 0);
        cardMessage.Margin = new Padding(6, 0, 0, 0);
        cardMessage.Name = "cardMessage";
        cardMessage.Size = new Size(696, 614);
        cardMessage.TabIndex = 1;
        // 
        // headerMessage
        // 
        headerMessage.Controls.Add(lblMessageTitle);
        headerMessage.Controls.Add(lblMessageIcon);
        headerMessage.Dock = DockStyle.Top;
        headerMessage.Location = new Point(14, 12);
        headerMessage.Name = "headerMessage";
        headerMessage.Size = new Size(668, 26);
        headerMessage.TabIndex = 0;
        // 
        // lblMessageIcon
        // 
        lblMessageIcon.Font = UiTheme.IconFont;
        lblMessageIcon.ForeColor = UiTheme.Primary;
        lblMessageIcon.Location = new Point(0, 0);
        lblMessageIcon.Name = "lblMessageIcon";
        lblMessageIcon.Size = new Size(24, 24);
        lblMessageIcon.TabIndex = 0;
        lblMessageIcon.Text = "";
        lblMessageIcon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblMessageTitle
        // 
        lblMessageTitle.AutoSize = true;
        lblMessageTitle.Font = UiTheme.SectionFont;
        lblMessageTitle.ForeColor = UiTheme.TextPrimary;
        lblMessageTitle.Location = new Point(28, 2);
        lblMessageTitle.Name = "lblMessageTitle";
        lblMessageTitle.Size = new Size(99, 20);
        lblMessageTitle.TabIndex = 1;
        lblMessageTitle.Text = "Message Data";
        // 
        // layoutMessage
        // 
        layoutMessage.ColumnCount = 1;
        layoutMessage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layoutMessage.Controls.Add(panelRecipients, 0, 0);
        layoutMessage.Controls.Add(panelSubject, 0, 1);
        layoutMessage.Controls.Add(panelBody, 0, 2);
        layoutMessage.Dock = DockStyle.Fill;
        layoutMessage.Location = new Point(14, 38);
        layoutMessage.Name = "layoutMessage";
        layoutMessage.RowCount = 3;
        layoutMessage.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
        layoutMessage.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        layoutMessage.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
        layoutMessage.Size = new Size(668, 564);
        layoutMessage.TabIndex = 1;
        // 
        // panelRecipients
        // 
        panelRecipients.Controls.Add(txtRecipients);
        panelRecipients.Controls.Add(lblErrRecipients);
        panelRecipients.Controls.Add(panelWhatsAppImport);
        panelRecipients.Controls.Add(panelRecipientsHeader);
        panelRecipients.Dock = DockStyle.Fill;
        panelRecipients.Location = new Point(0, 0);
        panelRecipients.Margin = new Padding(0, 0, 0, 6);
        panelRecipients.Name = "panelRecipients";
        panelRecipients.Size = new Size(668, 162);
        panelRecipients.TabIndex = 0;
        // 
        // panelRecipientsHeader
        // 
        panelRecipientsHeader.Controls.Add(lblRecipients);
        panelRecipientsHeader.Dock = DockStyle.Top;
        panelRecipientsHeader.Location = new Point(0, 0);
        panelRecipientsHeader.Name = "panelRecipientsHeader";
        panelRecipientsHeader.Size = new Size(668, 18);
        panelRecipientsHeader.TabIndex = 0;
        // 
        // lblRecipients
        // 
        UiTheme.StyleFieldLabel(lblRecipients);
        lblRecipients.Location = new Point(0, 0);
        lblRecipients.Name = "lblRecipients";
        lblRecipients.Size = new Size(64, 16);
        lblRecipients.TabIndex = 0;
        lblRecipients.Text = "Recipients";
        // 
        // panelWhatsAppImport
        // 
        panelWhatsAppImport.Controls.Add(panelWhatsAppStatus);
        panelWhatsAppImport.Controls.Add(panelWhatsAppToolbar);
        panelWhatsAppImport.Dock = DockStyle.Top;
        panelWhatsAppImport.Location = new Point(0, 18);
        panelWhatsAppImport.Name = "panelWhatsAppImport";
        panelWhatsAppImport.Padding = new Padding(0, 2, 0, 6);
        panelWhatsAppImport.Size = new Size(668, 58);
        panelWhatsAppImport.TabIndex = 1;
        // 
        // panelWhatsAppToolbar
        // 
        panelWhatsAppToolbar.Controls.Add(btnImportWhatsApp);
        panelWhatsAppToolbar.Controls.Add(chkWhatsAppRemoveDuplicates);
        panelWhatsAppToolbar.Controls.Add(chkWhatsAppAppendRecipients);
        panelWhatsAppToolbar.Dock = DockStyle.Top;
        panelWhatsAppToolbar.Location = new Point(0, 2);
        panelWhatsAppToolbar.Name = "panelWhatsAppToolbar";
        panelWhatsAppToolbar.Size = new Size(668, 32);
        panelWhatsAppToolbar.TabIndex = 0;
        panelWhatsAppToolbar.WrapContents = false;
        // 
        // btnImportWhatsApp
        // 
        btnImportWhatsApp.AutoSize = true;
        btnImportWhatsApp.Margin = new Padding(0, 0, 8, 0);
        btnImportWhatsApp.Name = "btnImportWhatsApp";
        btnImportWhatsApp.Size = new Size(136, 28);
        btnImportWhatsApp.TabIndex = 0;
        btnImportWhatsApp.Text = "Import WhatsApp Chat";
        btnImportWhatsApp.UseVisualStyleBackColor = true;
        UiTheme.StyleSecondaryButton(btnImportWhatsApp);
        // 
        // chkWhatsAppRemoveDuplicates
        // 
        chkWhatsAppRemoveDuplicates.AutoSize = true;
        chkWhatsAppRemoveDuplicates.Checked = true;
        chkWhatsAppRemoveDuplicates.CheckState = CheckState.Checked;
        chkWhatsAppRemoveDuplicates.Font = UiTheme.HintFont;
        chkWhatsAppRemoveDuplicates.ForeColor = UiTheme.TextSecondary;
        chkWhatsAppRemoveDuplicates.Margin = new Padding(0, 6, 12, 0);
        chkWhatsAppRemoveDuplicates.Name = "chkWhatsAppRemoveDuplicates";
        chkWhatsAppRemoveDuplicates.Size = new Size(141, 20);
        chkWhatsAppRemoveDuplicates.TabIndex = 1;
        chkWhatsAppRemoveDuplicates.Text = "Remove duplicate emails";
        chkWhatsAppRemoveDuplicates.UseVisualStyleBackColor = true;
        // 
        // chkWhatsAppAppendRecipients
        // 
        chkWhatsAppAppendRecipients.AutoSize = true;
        chkWhatsAppAppendRecipients.Font = UiTheme.HintFont;
        chkWhatsAppAppendRecipients.ForeColor = UiTheme.TextSecondary;
        chkWhatsAppAppendRecipients.Margin = new Padding(0, 6, 0, 0);
        chkWhatsAppAppendRecipients.Name = "chkWhatsAppAppendRecipients";
        chkWhatsAppAppendRecipients.Size = new Size(168, 20);
        chkWhatsAppAppendRecipients.TabIndex = 2;
        chkWhatsAppAppendRecipients.Text = "Append to current recipients";
        chkWhatsAppAppendRecipients.UseVisualStyleBackColor = true;
        // 
        // panelWhatsAppStatus
        // 
        panelWhatsAppStatus.Controls.Add(lblWhatsAppEmailCount);
        panelWhatsAppStatus.Controls.Add(lblWhatsAppFileName);
        panelWhatsAppStatus.Dock = DockStyle.Top;
        panelWhatsAppStatus.Location = new Point(0, 34);
        panelWhatsAppStatus.Name = "panelWhatsAppStatus";
        panelWhatsAppStatus.Size = new Size(668, 18);
        panelWhatsAppStatus.TabIndex = 1;
        // 
        // lblWhatsAppFileName
        // 
        lblWhatsAppFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblWhatsAppFileName.AutoEllipsis = true;
        lblWhatsAppFileName.Font = UiTheme.HintFont;
        lblWhatsAppFileName.ForeColor = UiTheme.TextMuted;
        lblWhatsAppFileName.Location = new Point(0, 1);
        lblWhatsAppFileName.Name = "lblWhatsAppFileName";
        lblWhatsAppFileName.Size = new Size(430, 15);
        lblWhatsAppFileName.TabIndex = 0;
        lblWhatsAppFileName.Text = "No file selected";
        // 
        // lblWhatsAppEmailCount
        // 
        lblWhatsAppEmailCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblWhatsAppEmailCount.Font = UiTheme.HintFont;
        lblWhatsAppEmailCount.ForeColor = UiTheme.TextMuted;
        lblWhatsAppEmailCount.Location = new Point(438, 1);
        lblWhatsAppEmailCount.Name = "lblWhatsAppEmailCount";
        lblWhatsAppEmailCount.Size = new Size(230, 15);
        lblWhatsAppEmailCount.TabIndex = 1;
        lblWhatsAppEmailCount.Text = "0 emails extracted";
        lblWhatsAppEmailCount.TextAlign = ContentAlignment.TopRight;
        // 
        // txtRecipients
        // 
        txtRecipients.AcceptsReturn = true;
        txtRecipients.Dock = DockStyle.Fill;
        txtRecipients.Location = new Point(0, 76);
        txtRecipients.Multiline = true;
        txtRecipients.Name = "txtRecipients";
        txtRecipients.PlaceholderText = "user1@example.com, user2@example.com  — comma, semicolon, or new line";
        txtRecipients.Size = new Size(668, 71);
        txtRecipients.TabIndex = 2;
        UiTheme.StyleInput(txtRecipients, true);
        // 
        // lblErrRecipients
        // 
        lblErrRecipients.Dock = DockStyle.Bottom;
        UiTheme.StyleErrorLabel(lblErrRecipients);
        lblErrRecipients.Location = new Point(0, 147);
        lblErrRecipients.Name = "lblErrRecipients";
        lblErrRecipients.Padding = new Padding(0, 4, 0, 0);
        lblErrRecipients.Size = new Size(668, 15);
        lblErrRecipients.TabIndex = 3;
        // 
        // panelSubject
        // 
        panelSubject.Controls.Add(lblErrSubject);
        panelSubject.Controls.Add(txtSubject);
        panelSubject.Controls.Add(lblSubject);
        panelSubject.Dock = DockStyle.Fill;
        panelSubject.Location = new Point(0, 168);
        panelSubject.Margin = new Padding(0, 0, 0, 6);
        panelSubject.Name = "panelSubject";
        panelSubject.Size = new Size(668, 58);
        panelSubject.TabIndex = 1;
        // 
        // lblSubject
        // 
        UiTheme.StyleFieldLabel(lblSubject);
        lblSubject.Location = new Point(0, 0);
        lblSubject.Name = "lblSubject";
        lblSubject.Size = new Size(47, 16);
        lblSubject.TabIndex = 0;
        lblSubject.Text = "Subject";
        // 
        // txtSubject
        // 
        txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSubject.Location = new Point(0, 18);
        txtSubject.Name = "txtSubject";
        txtSubject.Size = new Size(668, 23);
        txtSubject.TabIndex = 1;
        UiTheme.StyleInput(txtSubject);
        // 
        // lblErrSubject
        // 
        lblErrSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrSubject);
        lblErrSubject.Location = new Point(0, 48);
        lblErrSubject.Name = "lblErrSubject";
        lblErrSubject.Size = new Size(668, 15);
        lblErrSubject.TabIndex = 2;
        // 
        // panelBody
        // 
        panelBody.Controls.Add(lblErrBody);
        panelBody.Controls.Add(txtBody);
        panelBody.Controls.Add(lblBody);
        panelBody.Dock = DockStyle.Fill;
        panelBody.Location = new Point(0, 232);
        panelBody.Name = "panelBody";
        panelBody.Size = new Size(668, 332);
        panelBody.TabIndex = 2;
        // 
        // lblBody
        // 
        UiTheme.StyleFieldLabel(lblBody);
        lblBody.Location = new Point(0, 0);
        lblBody.Name = "lblBody";
        lblBody.Size = new Size(34, 16);
        lblBody.TabIndex = 0;
        lblBody.Text = "Body";
        // 
        // txtBody
        // 
        txtBody.AcceptsReturn = true;
        txtBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtBody.Location = new Point(0, 18);
        txtBody.Multiline = true;
        txtBody.Name = "txtBody";
        txtBody.Size = new Size(668, 298);
        txtBody.TabIndex = 1;
        UiTheme.StyleInput(txtBody, true);
        // 
        // lblErrBody
        // 
        lblErrBody.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        UiTheme.StyleErrorLabel(lblErrBody);
        lblErrBody.Location = new Point(0, 317);
        lblErrBody.Name = "lblErrBody";
        lblErrBody.Size = new Size(668, 15);
        lblErrBody.TabIndex = 2;
        // 
        // panelFooter
        // 
        panelFooter.Controls.Add(statusBanner);
        panelFooter.Controls.Add(panelActions);
        panelFooter.Dock = DockStyle.Bottom;
        panelFooter.Location = new Point(20, 684);
        panelFooter.Name = "panelFooter";
        panelFooter.Padding = new Padding(0, 8, 0, 0);
        panelFooter.Size = new Size(1160, 56);
        panelFooter.TabIndex = 2;
        // 
        // statusBanner
        // 
        statusBanner.Dock = DockStyle.Fill;
        statusBanner.Location = new Point(0, 8);
        statusBanner.Margin = new Padding(0, 0, 10, 0);
        statusBanner.Name = "statusBanner";
        statusBanner.Size = new Size(990, 44);
        statusBanner.TabIndex = 0;
        // 
        // panelActions
        // 
        panelActions.Controls.Add(btnSend);
        panelActions.Dock = DockStyle.Right;
        panelActions.Location = new Point(1000, 8);
        panelActions.Name = "panelActions";
        panelActions.Padding = new Padding(10, 0, 0, 0);
        panelActions.Size = new Size(160, 48);
        panelActions.TabIndex = 1;
        // 
        // btnSend
        // 
        btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSend.Location = new Point(10, 0);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(150, 40);
        btnSend.TabIndex = 0;
        btnSend.Text = "Send Email";
        btnSend.Click += btnSend_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiTheme.PageBackground;
        ClientSize = new Size(1200, 750);
        Controls.Add(panelRoot);
        Font = UiTheme.BodyFont;
        MinimumSize = new Size(900, 640);
        Name = "Sender App";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bulk Email Sender";
        panelRoot.ResumeLayout(false);
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        panelMain.ResumeLayout(false);
        layoutContent.ResumeLayout(false);
        cardSmtp.ResumeLayout(false);
        headerSmtp.ResumeLayout(false);
        headerSmtp.PerformLayout();
        layoutSmtp.ResumeLayout(false);
        panelSmtpServer.ResumeLayout(false);
        panelSmtpServer.PerformLayout();
        panelPort.ResumeLayout(false);
        panelPort.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
        panelSenderEmail.ResumeLayout(false);
        panelSenderEmail.PerformLayout();
        panelPassword.ResumeLayout(false);
        panelPassword.PerformLayout();
        panelAttachments.ResumeLayout(false);
        panelAttachments.PerformLayout();
        panelAttachmentsHeader.ResumeLayout(false);
        panelAttachmentsHeader.PerformLayout();
        panelAttachmentButtons.ResumeLayout(false);
        panelAttachmentButtons.PerformLayout();
        cardMessage.ResumeLayout(false);
        headerMessage.ResumeLayout(false);
        headerMessage.PerformLayout();
        layoutMessage.ResumeLayout(false);
        panelRecipients.ResumeLayout(false);
        panelRecipients.PerformLayout();
        panelRecipientsHeader.ResumeLayout(false);
        panelRecipientsHeader.PerformLayout();
        panelWhatsAppImport.ResumeLayout(false);
        panelWhatsAppToolbar.ResumeLayout(false);
        panelWhatsAppToolbar.PerformLayout();
        panelWhatsAppStatus.ResumeLayout(false);
        panelSubject.ResumeLayout(false);
        panelSubject.PerformLayout();
        panelBody.ResumeLayout(false);
        panelBody.PerformLayout();
        panelFooter.ResumeLayout(false);
        panelActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelRoot;
    private Panel panelHeader;
    private Label lblTitle;
    private Label lblSubtitle;
    private Panel panelMain;
    private TableLayoutPanel layoutContent;
    private CardPanel cardSmtp;
    private Panel headerSmtp;
    private Label lblSmtpIcon;
    private Label lblSmtpTitle;
    private TableLayoutPanel layoutSmtp;
    private Panel panelSmtpServer;
    private Label lblSmtpServer;
    private TextBox txtSmtpServer;
    private Label lblErrSmtpServer;
    private Panel panelPort;
    private Label lblPort;
    private NumericUpDown numPort;
    private Label lblErrPort;
    private Panel panelSenderEmail;
    private Label lblSenderEmail;
    private TextBox txtSenderEmail;
    private Label lblErrSenderEmail;
    private Panel panelPassword;
    private Label lblPassword;
    private TextBox txtPassword;
    private Label lblErrPassword;
    private CheckBox chkUseSslTls;
    private Panel panelAttachments;
    private Panel panelAttachmentsHeader;
    private Label lblAttachmentsTitle;
    private Label lblAttachmentCount;
    private FlowLayoutPanel panelAttachmentButtons;
    private Button btnAddFiles;
    private Button btnRemoveSelected;
    private Button btnClearAttachments;
    private ListView listViewAttachments;
    private Label lblErrAttachments;
    private CardPanel cardMessage;
    private Panel headerMessage;
    private Label lblMessageIcon;
    private Label lblMessageTitle;
    private TableLayoutPanel layoutMessage;
    private Panel panelRecipients;
    private Panel panelRecipientsHeader;
    private Label lblRecipients;
    private Panel panelWhatsAppImport;
    private FlowLayoutPanel panelWhatsAppToolbar;
    private Button btnImportWhatsApp;
    private CheckBox chkWhatsAppRemoveDuplicates;
    private CheckBox chkWhatsAppAppendRecipients;
    private Panel panelWhatsAppStatus;
    private Label lblWhatsAppFileName;
    private Label lblWhatsAppEmailCount;
    private TextBox txtRecipients;
    private Label lblErrRecipients;
    private Panel panelSubject;
    private Label lblSubject;
    private TextBox txtSubject;
    private Label lblErrSubject;
    private Panel panelBody;
    private Label lblBody;
    private TextBox txtBody;
    private Label lblErrBody;
    private Panel panelFooter;
    private StatusBanner statusBanner;
    private Panel panelActions;
    private ModernButton btnSend;
}
