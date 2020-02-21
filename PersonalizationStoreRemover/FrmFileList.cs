using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res = PersonalizationStoreRemover.Resources.Resources;

namespace PersonalizationStoreRemover
{
    public partial class FrmFileList : Form
    {
        private const string LOCAL_USER_FOLDER_PATH = @"C:\Users";
        private const string REMOTE_USER_FOLDER_PATH = @"\\{0}\C$\Users";
        private const string PERSO_STORE_PATH = @"AppData\Roaming\Microsoft\Microsoft Dynamics NAV\PersonalizationStore.xml";

        private List<string> userWithFileList = new List<string>();
        private ComputerChoice choice = new ComputerChoice();

        public FrmFileList()
        {
            InitializeComponent();
            Localize();

            dgvFileList.AutoGenerateColumns = false;

            dgvFileList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = Res.Column_User,
                Width = 200,
                MinimumWidth = 200
            });

            dgvFileList.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = Res.Column_Archive,
                UseColumnTextForButtonValue = true,
                MinimumWidth = 100
            });

            dgvFileList.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = Res.Column_Delete,
                UseColumnTextForButtonValue = true,
                MinimumWidth = 100
            });

            dgvFileList.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = Res.Column_OpenFolder,
                UseColumnTextForButtonValue = true,
                MinimumWidth = 100
            });
        }

        private void Localize()
        {
            Text = Res.Title_FrmFileList;
            btnReload.Text = Res.Button_Reload;
            btnComputerChoice.Text = Res.Button_LocalRemote;
            btnArchiveAll.Text = Res.Button_ArchiveAll;
            btnDeleteAll.Text = Res.Button_DeleteAll;
            label1.Text = Res.Text_CreationTime;
            label2.Text = Res.Text_LastModificationTime;
            label4.Text = Res.Text_LastAccessTime;
            toolStripStatusLabel1.Text = Res.StatusLabel_LastReload;
            toolStripStatusLabel2.Text = Res.StatusLabel_Computer;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UpdateComputerName();
            LoadData();
            if (dgvFileList.SelectedCells.Count > 0)
            {
                var selection = dgvFileList.SelectedCells[0];
                string user = selection.ColumnIndex == 0 ? (string)selection.Value : (string)selection.OwningRow.Cells[0].Value;
                DisplayFileInfos(user);
            }
        }

        private void LoadData()
        {
            try
            {
                SearchPersoStoreFiles();
            }
            catch (Exception ex)
            {
                AddErrorLog(Res.Message_ErrorDuringFileListing);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}");
                AddWarningLog("Listing local files");
                choice.UseLocalComputer = true;
                UpdateComputerName();
                SearchPersoStoreFiles();
            }

            DisplayDataInGridView();
        }

        private void SearchPersoStoreFiles()
        {
            AddInfoLog(Res.Message_SearchingPersoStoreFiles);
            userWithFileList.Clear();
            IEnumerable<string> userList = Directory.EnumerateDirectories(GetUsersFolderPath());

            string persoFileFullPath = string.Empty;
            string user = string.Empty;

            foreach (string path in userList)
            {
                user = Path.GetFileName(path);
                persoFileFullPath = GetFileFullPath(user);
                if (File.Exists(persoFileFullPath))
                {
                    userWithFileList.Add(user);
                }
            }

            AddInfoLog(string.Format(Res.Message_FoundXFiles,userWithFileList.Count));

            btnArchiveAll.Enabled = userWithFileList.Count > 0;
            btnDeleteAll.Enabled = userWithFileList.Count > 0;

            tsLblLastUpdate.Text = DateTime.Now.ToLongTimeString();
        }

        private void DisplayDataInGridView()
        {
            dgvFileList.Rows.Clear();
            foreach (string user in userWithFileList)
            {
                dgvFileList.Rows.Add(new[] { user});
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvFileList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlFileInfo.Visible = (e.RowIndex >= 0);

            //en ne prend pas en compte la ligne de header
            if (e.RowIndex < 0)
            {
                return;
            }

            string user = (string)dgvFileList.Rows[e.RowIndex].Cells[0].Value;

            DisplayFileInfos(user);

            if (e.ColumnIndex == 0) return;

            //Archive button
            if (e.ColumnIndex == 1)
            {
                ArchiveFile(user);
            }

            //Delete button
            if (e.ColumnIndex == 2)
            {
                DeleteFile(user);
            }

            //Open folder button
            if(e.ColumnIndex == 3)
            {
                OpenFolder(user);
                return;
            }

            LoadData();
        }

        private void OpenFolder(string user)
        {
            string folderPath = GetFolderFullPath(user);
            AddInfoLog($"{Res.Message_FolderToOpen} : '{folderPath}'");
            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                AddErrorLog(Res.Message_ErrorDuringProcessStart);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}");
            }
        }

        private void ArchiveFile(string user)
        {
            string fullPath = GetFileFullPath(user);

            AddInfoLog($"{Res.Message_TryingToArchive} '{fullPath}'");

            string newFileName = Path.GetFileNameWithoutExtension(fullPath) + "_" +
                DateTime.Now.ToString("yyyyMMdd") + Path.GetExtension(fullPath);
            string newFilePath = Path.Combine(GetFolderFullPath(user), newFileName);

            try
            {
                File.Copy(fullPath, newFilePath, true);
                File.Delete(fullPath);

                AddSuccessLog(Res.Message_FileSuccessfullyArchived);
            }
            catch (UnauthorizedAccessException ex)
            {
                AddErrorLog(Res.Message_NoAccessToFile);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}");
            }
            catch (Exception ex)
            {
                AddErrorLog(Res.Message_ErrorDuringArchiving);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}.");
            }
        }

        private void DeleteFile(string user)
        {
            string fullPath = GetFileFullPath(user);

            AddInfoLog($"{Res.Message_TryingToDelete} '{fullPath}'");

            try
            {
                File.Delete(fullPath);
                AddSuccessLog(Res.Message_FileSuccessfullyDeleted);
            }
            catch (UnauthorizedAccessException ex)
            {
                AddErrorLog(Res.Message_NoAccessToFile);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}");
            }
            catch (Exception ex)
            {
                AddErrorLog(Res.Message_ErrorDuringDeleting);
                AddErrorLog($"{Res.Message_Message} : {ex.Message}");
            }
        }

        private void DisplayFileInfos(string user)
        {
            string fullPath = GetFileFullPath(user);
            DateTime creationTime = File.GetCreationTime(fullPath);
            DateTime modificationTime = File.GetLastWriteTime(fullPath);
            DateTime accessTime = File.GetLastAccessTime(fullPath);

            lblCreationTime.Text = $"{creationTime.ToShortDateString()} {creationTime.ToShortTimeString()}";
            lblLastModifTime.Text = $"{modificationTime.ToShortDateString()} {modificationTime.ToShortTimeString()}";
            lblAccessTime.Text = $"{accessTime.ToShortDateString()} {accessTime.ToShortTimeString()}";
        }

        private string GetUsersFolderPath()
        {
            if (choice.UseLocalComputer) return LOCAL_USER_FOLDER_PATH;

            if(string.IsNullOrWhiteSpace(choice.RemoteComputerName))
            {
                AddWarningLog(Res.Message_EmptyRemoteName);
                UpdateComputerName(true);
                return LOCAL_USER_FOLDER_PATH;
            }

            return string.Format(REMOTE_USER_FOLDER_PATH, choice.RemoteComputerName);

        }

        private void UpdateComputerName(bool forceLocal = false)
        {
            if (choice.UseLocalComputer || forceLocal)
            {
                tsLblComputerName.Text = Res.StatusLabel_Computer_Local;
            }
            else
            {
                tsLblComputerName.Text = choice.RemoteComputerName;
            }
        }

        private string GetFileFullPath(string user)
        {
            return Path.Combine(GetUsersFolderPath(), user, PERSO_STORE_PATH);
        }

        private string GetFolderFullPath(string user)
        {
            return Path.GetDirectoryName(GetFileFullPath(user));
        }

        private void AppendText(string text, Color color, bool addNewLine = false)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }

            rtbLog.SuspendLayout();
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.SelectionLength = 0;

            rtbLog.SelectionColor = color;
            rtbLog.AppendText(text);
            rtbLog.SelectionColor = rtbLog.ForeColor;
            rtbLog.ScrollToCaret();
            rtbLog.ResumeLayout();
        }

        private void AddInfoLog(string message)
        {
            AppendText(message, Color.Black,true);
        }

        private void AddSuccessLog(string message)
        {
            AppendText(message, Color.Green, true);
        }

        private void AddWarningLog(string message)
        {
            AppendText(message, Color.Orange, true);
        }

        private void AddErrorLog(string message)
        {
            AppendText(message, Color.Red, true);
        }

        private void btnArchiveAll_Click(object sender, EventArgs e)
        {
            foreach (string user in userWithFileList)
            {
                ArchiveFile(user);
            }
            LoadData();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (string user in userWithFileList)
            {
                DeleteFile(user);
            }
            LoadData();
        }

        private void btnComputerChoice_Click(object sender, EventArgs e)
        {
            FrmComputerChoice frm = new FrmComputerChoice(choice);
            DialogResult result = frm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                UpdateComputerName();
                LoadData();
            }
        }
    }
}
