using SentEmailApp.Controls;
using SentEmailApp.Helpers;
using SentEmailApp.Models;

namespace SentEmailApp;

public partial class Form1
{
    private readonly AttachmentCollection _attachments = new();
    private readonly ToolTip _attachmentToolTip = new();

    private void InitializeAttachments()
    {
        ConfigureAttachmentListView();
        RefreshAttachmentListView();
        UpdateAttachmentButtons();

        listViewAttachments.Resize += (_, _) => AdjustAttachmentColumnWidths();
        listViewAttachments.SelectedIndexChanged += (_, _) => UpdateAttachmentButtons();
        listViewAttachments.MouseMove += ListViewAttachments_MouseMove;
        panelAttachmentsHeader.Resize += (_, _) =>
            lblAttachmentCount.Width = Math.Max(120, panelAttachmentsHeader.Width);

        btnAddFiles.Click += BtnAddFiles_Click;
        btnRemoveSelected.Click += BtnRemoveSelected_Click;
        btnClearAttachments.Click += BtnClearAttachments_Click;
    }

    private void ConfigureAttachmentListView()
    {
        listViewAttachments.View = View.Details;
        listViewAttachments.FullRowSelect = true;
        listViewAttachments.GridLines = true;
        listViewAttachments.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        listViewAttachments.MultiSelect = true;
        listViewAttachments.Font = UiTheme.BodyFont;
        listViewAttachments.BorderStyle = BorderStyle.FixedSingle;
        listViewAttachments.Columns.Add("File Name", 220);
        listViewAttachments.Columns.Add("Size", 90);
        AdjustAttachmentColumnWidths();
    }

    private void AdjustAttachmentColumnWidths()
    {
        if (listViewAttachments.Columns.Count < 2)
            return;

        var width = Math.Max(120, listViewAttachments.ClientSize.Width - 4);
        listViewAttachments.Columns[0].Width = (int)(width * 0.72);
        listViewAttachments.Columns[1].Width = width - listViewAttachments.Columns[0].Width;
    }

    private void BtnAddFiles_Click(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Multiselect = true,
            Title = "Select files to attach",
            Filter =
                "All files (*.*)|*.*|" +
                "Documents (*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.txt)|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.txt|" +
                "Images (*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.webp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.webp|" +
                "Archives (*.zip;*.rar;*.7z)|*.zip;*.rar;*.7z"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        var added = _attachments.AddFiles(dialog.FileNames);
        if (added == 0 && dialog.FileNames.Length > 0)
        {
            SetFieldError(lblErrAttachments, "Selected file(s) are already attached or unavailable.");
            return;
        }

        ClearFieldError(lblErrAttachments);
        RefreshAttachmentListView();
        UpdateAttachmentButtons();
    }

    private void BtnRemoveSelected_Click(object? sender, EventArgs e)
    {
        if (listViewAttachments.SelectedIndices.Count == 0)
            return;

        foreach (var index in listViewAttachments.SelectedIndices.Cast<int>().OrderByDescending(i => i))
            _attachments.RemoveAt(index);

        ClearFieldError(lblErrAttachments);
        RefreshAttachmentListView();
        UpdateAttachmentButtons();
    }

    private void BtnClearAttachments_Click(object? sender, EventArgs e)
    {
        if (_attachments.Items.Count == 0)
            return;

        _attachments.Clear();
        ClearFieldError(lblErrAttachments);
        RefreshAttachmentListView();
        UpdateAttachmentButtons();
    }

    private void ListViewAttachments_MouseMove(object? sender, MouseEventArgs e)
    {
        var item = listViewAttachments.GetItemAt(e.X, e.Y);
        if (item?.Tag is string path)
            _attachmentToolTip.SetToolTip(listViewAttachments, path);
        else
            _attachmentToolTip.SetToolTip(listViewAttachments, string.Empty);
    }

    private void RefreshAttachmentListView()
    {
        listViewAttachments.BeginUpdate();
        listViewAttachments.Items.Clear();

        foreach (var attachment in _attachments.Items)
        {
            var item = new ListViewItem(attachment.FileName)
            {
                Tag = attachment.FilePath
            };
            item.SubItems.Add(attachment.FormattedSize);
            listViewAttachments.Items.Add(item);
        }

        listViewAttachments.EndUpdate();
        lblAttachmentCount.Text = _attachments.Items.Count == 0
            ? "No files attached"
            : $"{_attachments.Items.Count} file(s) attached";
    }

    private void UpdateAttachmentButtons()
    {
        var hasItems = _attachments.Items.Count > 0;
        btnRemoveSelected.Enabled = hasItems && listViewAttachments.SelectedIndices.Count > 0;
        btnClearAttachments.Enabled = hasItems;
    }

    private bool TryValidateAttachments(out string error)
    {
        error = string.Empty;
        var missing = _attachments.GetMissingFiles();

        if (missing.Count == 0)
        {
            ClearFieldError(lblErrAttachments);
            return true;
        }

        var names = string.Join(", ", missing.Select(file => file.FileName));
        error = missing.Count == 1
            ? $"Attachment not found: {names}"
            : $"Attachments not found: {names}";

        SetFieldError(lblErrAttachments, error);
        return false;
    }

    private IReadOnlyList<string> GetAttachmentPaths() =>
        _attachments.Items.Select(item => item.FilePath).ToList();
}
