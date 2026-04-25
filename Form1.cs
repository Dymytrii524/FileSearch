using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileSearch
{
    public partial class Form1 : Form
    {
        private Thread _searchThread;
        private CancellationTokenSource _cts;

        public Form1()
        {
            InitializeComponent();
            LoadDisks();
        }

        // Заповнити ComboBox дисками
        private void LoadDisks()
        {
            cboDisk.Items.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    cboDisk.Items.Add(drive.Name);
            }
            if (cboDisk.Items.Count > 0)
                cboDisk.SelectedIndex = 0;
        }

        // Кнопка "Знайти"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_searchThread != null && _searchThread.IsAlive)
                return;

            listView1.Items.Clear();
            lblCount.Text = "Результати пошуку: пошук...";

            string mask = txtMask.Text.Trim();
            string root = cboDisk.SelectedItem?.ToString() ?? "C:\\";
            bool subdirs = chkSubdirs.Checked;

            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            _searchThread = new Thread(() => Search(mask, root, subdirs, token))
            {
                IsBackground = true
            };
            _searchThread.Start();
        }

        // Кнопка "Зупинити"
        private void btnStop_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        // Основна логіка пошуку (виконується у вторинному потоці)
        private void Search(string mask, string root,
                            bool subdirs, CancellationToken token)
        {
            int count = 0;

            try
            {
                SearchDirectory(root, mask, subdirs, token, ref count);
            }
            catch (OperationCanceledException) { }

            // Оновити лічильник після завершення
            this.Invoke((Action)(() =>
                lblCount.Text = $"Результати пошуку: кількість знайдених файлів — {count}"));
        }

        private void SearchDirectory(string path, string mask,
                                     bool subdirs, CancellationToken token,
                                     ref int count)
        {
            if (token.IsCancellationRequested)
                throw new OperationCanceledException();

            // Шукаємо файли у поточній папці
            try
            {
                foreach (var file in Directory.GetFiles(path, mask))
                {
                    if (token.IsCancellationRequested)
                        throw new OperationCanceledException();

                    var info = new FileInfo(file);
                    count++;

                    int currentCount = count;
                    this.Invoke((Action)(() =>
                    {
                        var item = new ListViewItem(info.Name);
                        item.SubItems.Add(info.DirectoryName);
                        item.SubItems.Add(info.Length + " байт");
                        item.SubItems.Add(info.LastWriteTime.ToString("dd.MM.yyyy HH:mm"));
                        listView1.Items.Add(item);

                        lblCount.Text = "Результати пошуку: знайдено " + currentCount + " файлів...";
                    }));
                }
            }
            catch (UnauthorizedAccessException) { } // пропускаємо закриті папки

            // Рекурсивно обходимо підпапки
            if (subdirs)
            {
                try
                {
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        SearchDirectory(dir, mask, true, token, ref count);
                    }
                }
                catch (UnauthorizedAccessException) { }
            }
        }

        // Безпечне закриття
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _cts?.Cancel();
            base.OnFormClosing(e);
        }
    }
}
