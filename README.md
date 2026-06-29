# Bulk Email Sender

A modern .NET Desktop application for sending emails to one or many recipients using SMTP and MailKit.

---

## Features

* Send emails to multiple recipients
* Support for **To**, **CC**, and **BCC**
* HTML or plain text email body
* Multiple recipients separated by:

  * Comma (,)
  * Semicolon (;)
  * New line
* Uses **MailKit** (recommended instead of System.Net.Mail)
* SMTP configuration loaded automatically from **appsettings.json**
* Modern desktop UI
* Input validation
* Status messages while sending
* SSL/TLS support
* Default SMTP configuration
* No need to enter SMTP information every time

---

## Technologies

* .NET 8
* C#
* Windows Forms / WPF
* MailKit
* MimeKit
* Microsoft.Extensions.Configuration

---

## Project Structure

```
BulkEmailSender
│
├── Services
│   └── EmailService.cs
│
├── Models
│   └── SmtpSettings.cs
│
├── Configuration
│   └── appsettings.json
│
├── Forms
│   └── MainForm.cs
│
├── Program.cs
└── README.md
```

---

## SMTP Configuration

SMTP settings are stored inside:

```
appsettings.json
```

Example:

```json
{
  "SmtpSettings": {
    "Host": "smtp.gmail.com",
    "Port": 587,
    "EnableSsl": true,
    "SenderEmail": "your-email@gmail.com",
    "SenderName": "Bulk Email Sender",
    "AppPassword": "YOUR_APP_PASSWORD"
  }
}
```

The application automatically loads these settings when sending emails.

---

## User Interface

The application provides a simple interface:

* Recipients (To)
* CC
* BCC
* Subject
* Message Body
* Send Button
* Sending Status

SMTP settings are hidden from normal users and can optionally be opened by administrators.

---

## Sending Email

1. Open the application.
2. Enter one or more recipients.
3. (Optional) Enter CC and BCC.
4. Enter the subject.
5. Write the email body.
6. Click **Send Email**.

---

## Gmail Configuration

If using Gmail:

1. Enable Two-Factor Authentication.
2. Generate an **App Password**.
3. Use the App Password instead of your Gmail password.

SMTP Settings:

| Setting | Value          |
| ------- | -------------- |
| Host    | smtp.gmail.com |
| Port    | 587            |
| SSL     | Enabled        |

---

## Supported Recipient Formats

The following formats are accepted:

```
user1@example.com,user2@example.com
```

```
user1@example.com;
user2@example.com
```

```
user1@example.com
user2@example.com
```

---

## Validation

The application validates:

* SMTP configuration
* Email format
* Empty recipients
* Empty subject
* Empty message body

---

## Error Handling

Displays clear messages for:

* Invalid email address
* SMTP authentication failure
* Network errors
* SSL errors
* SMTP server unavailable

---

## Security

* SMTP credentials are stored in configuration.
* Password field is masked.
* Uses secure TLS connections.
* No credentials are hardcoded in source code.

---

## Future Improvements

* Import recipients from Excel (.xlsx)
* Import recipients from CSV
* Email templates
* Attachments
* Drag & Drop attachments
* Send progress bar
* Scheduled email sending
* Email history
* Logging
* Dark Mode
* Multiple SMTP profiles
* Save drafts
* Retry failed emails

---

## NuGet Packages

```
MailKit
MimeKit
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.Json
Microsoft.Extensions.Configuration.Binder
```

---

## License

This project is intended for educational and business use.

---

## Author

Developed using **.NET 8** and **MailKit**.
