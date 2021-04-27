
namespace MFCoach
{
    partial class FrmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.bttnSearch = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCellphinenumber = new MetroFramework.Controls.MetroTextBox();
            this.txtPhonenumber = new MetroFramework.Controls.MetroTextBox();
            this.txtBirthdate = new MetroFramework.Controls.MetroTextBox();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.txtFirtsName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblCellphonenumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblPhonenumber = new MetroFramework.Controls.MetroLabel();
            this.lblBirthdate = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.bttnAdd = new MetroFramework.Controls.MetroButton();
            this.bttnEdit = new MetroFramework.Controls.MetroButton();
            this.bttnDelete = new MetroFramework.Controls.MetroButton();
            this.bttnCancel = new MetroFramework.Controls.MetroButton();
            this.bttnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.cellphonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.studentBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(23, 54);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.RowHeadersWidth = 51;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.RowTemplate.Height = 24;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1178, 178);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDatos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Visible = false;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Visible = false;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cellphonenumberDataGridViewTextBoxColumn
            // 
            this.cellphonenumberDataGridViewTextBoxColumn.DataPropertyName = "cellphonenumber";
            this.cellphonenumberDataGridViewTextBoxColumn.HeaderText = "cellphonenumber";
            this.cellphonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cellphonenumberDataGridViewTextBoxColumn.Name = "cellphonenumberDataGridViewTextBoxColumn";
            this.cellphonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(MFCoach.Entities.Student);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.bttnSearch);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.txtCellphinenumber);
            this.pnlDatos.Controls.Add(this.txtPhonenumber);
            this.pnlDatos.Controls.Add(this.txtBirthdate);
            this.pnlDatos.Controls.Add(this.txtLastname);
            this.pnlDatos.Controls.Add(this.txtFirtsName);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.lblCellphonenumber);
            this.pnlDatos.Controls.Add(this.metroLabel5);
            this.pnlDatos.Controls.Add(this.lblPhonenumber);
            this.pnlDatos.Controls.Add(this.lblBirthdate);
            this.pnlDatos.Controls.Add(this.lblLastName);
            this.pnlDatos.Controls.Add(this.lblFirstName);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.pctPhoto);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(23, 253);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(566, 255);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(38, 214);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 23);
            this.bttnSearch.TabIndex = 18;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseSelectable = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(306, 211);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(206, 23);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCellphinenumber
            // 
            // 
            // 
            // 
            this.txtCellphinenumber.CustomButton.Image = null;
            this.txtCellphinenumber.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtCellphinenumber.CustomButton.Name = "";
            this.txtCellphinenumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellphinenumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellphinenumber.CustomButton.TabIndex = 1;
            this.txtCellphinenumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellphinenumber.CustomButton.UseSelectable = true;
            this.txtCellphinenumber.CustomButton.Visible = false;
            this.txtCellphinenumber.Lines = new string[0];
            this.txtCellphinenumber.Location = new System.Drawing.Point(306, 180);
            this.txtCellphinenumber.MaxLength = 32767;
            this.txtCellphinenumber.Name = "txtCellphinenumber";
            this.txtCellphinenumber.PasswordChar = '\0';
            this.txtCellphinenumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellphinenumber.SelectedText = "";
            this.txtCellphinenumber.SelectionLength = 0;
            this.txtCellphinenumber.SelectionStart = 0;
            this.txtCellphinenumber.ShortcutsEnabled = true;
            this.txtCellphinenumber.Size = new System.Drawing.Size(206, 23);
            this.txtCellphinenumber.TabIndex = 16;
            this.txtCellphinenumber.UseSelectable = true;
            this.txtCellphinenumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellphinenumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhonenumber
            // 
            // 
            // 
            // 
            this.txtPhonenumber.CustomButton.Image = null;
            this.txtPhonenumber.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtPhonenumber.CustomButton.Name = "";
            this.txtPhonenumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhonenumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhonenumber.CustomButton.TabIndex = 1;
            this.txtPhonenumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhonenumber.CustomButton.UseSelectable = true;
            this.txtPhonenumber.CustomButton.Visible = false;
            this.txtPhonenumber.Lines = new string[0];
            this.txtPhonenumber.Location = new System.Drawing.Point(306, 142);
            this.txtPhonenumber.MaxLength = 32767;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.PasswordChar = '\0';
            this.txtPhonenumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhonenumber.SelectedText = "";
            this.txtPhonenumber.SelectionLength = 0;
            this.txtPhonenumber.SelectionStart = 0;
            this.txtPhonenumber.ShortcutsEnabled = true;
            this.txtPhonenumber.Size = new System.Drawing.Size(206, 23);
            this.txtPhonenumber.TabIndex = 15;
            this.txtPhonenumber.UseSelectable = true;
            this.txtPhonenumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhonenumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBirthdate
            // 
            // 
            // 
            // 
            this.txtBirthdate.CustomButton.Image = null;
            this.txtBirthdate.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtBirthdate.CustomButton.Name = "";
            this.txtBirthdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirthdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirthdate.CustomButton.TabIndex = 1;
            this.txtBirthdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirthdate.CustomButton.UseSelectable = true;
            this.txtBirthdate.CustomButton.Visible = false;
            this.txtBirthdate.Lines = new string[0];
            this.txtBirthdate.Location = new System.Drawing.Point(306, 104);
            this.txtBirthdate.MaxLength = 32767;
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.PasswordChar = '\0';
            this.txtBirthdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirthdate.SelectedText = "";
            this.txtBirthdate.SelectionLength = 0;
            this.txtBirthdate.SelectionStart = 0;
            this.txtBirthdate.ShortcutsEnabled = true;
            this.txtBirthdate.Size = new System.Drawing.Size(206, 23);
            this.txtBirthdate.TabIndex = 14;
            this.txtBirthdate.UseSelectable = true;
            this.txtBirthdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirthdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(306, 72);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Size = new System.Drawing.Size(206, 23);
            this.txtLastname.TabIndex = 13;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirtsName
            // 
            // 
            // 
            // 
            this.txtFirtsName.CustomButton.Image = null;
            this.txtFirtsName.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtFirtsName.CustomButton.Name = "";
            this.txtFirtsName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirtsName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirtsName.CustomButton.TabIndex = 1;
            this.txtFirtsName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirtsName.CustomButton.UseSelectable = true;
            this.txtFirtsName.CustomButton.Visible = false;
            this.txtFirtsName.Lines = new string[0];
            this.txtFirtsName.Location = new System.Drawing.Point(306, 43);
            this.txtFirtsName.MaxLength = 32767;
            this.txtFirtsName.Name = "txtFirtsName";
            this.txtFirtsName.PasswordChar = '\0';
            this.txtFirtsName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirtsName.SelectedText = "";
            this.txtFirtsName.SelectionLength = 0;
            this.txtFirtsName.SelectionStart = 0;
            this.txtFirtsName.ShortcutsEnabled = true;
            this.txtFirtsName.Size = new System.Drawing.Size(206, 23);
            this.txtFirtsName.TabIndex = 12;
            this.txtFirtsName.UseSelectable = true;
            this.txtFirtsName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirtsName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(306, 11);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(206, 23);
            this.txtId.TabIndex = 11;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(144, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblCellphonenumber
            // 
            this.lblCellphonenumber.AutoSize = true;
            this.lblCellphonenumber.Location = new System.Drawing.Point(144, 183);
            this.lblCellphonenumber.Name = "lblCellphonenumber";
            this.lblCellphonenumber.Size = new System.Drawing.Size(125, 20);
            this.lblCellphonenumber.TabIndex = 9;
            this.lblCellphonenumber.Text = "Cellphone number";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(144, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 8;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(144, 142);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(102, 20);
            this.lblPhonenumber.TabIndex = 7;
            this.lblPhonenumber.Text = "Phone number";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(144, 107);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(65, 20);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(144, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(144, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 20);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(144, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(15, 42);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(123, 161);
            this.pctPhoto.TabIndex = 2;
            this.pctPhoto.TabStop = false;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(31, 529);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 19;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseSelectable = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(157, 529);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(75, 23);
            this.bttnEdit.TabIndex = 20;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseSelectable = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(281, 529);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 21;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseSelectable = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(409, 529);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 22;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseSelectable = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(568, 529);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 23;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseSelectable = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 587);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblCellphonenumber;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblPhonenumber;
        private MetroFramework.Controls.MetroLabel lblBirthdate;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroButton bttnSearch;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCellphinenumber;
        private MetroFramework.Controls.MetroTextBox txtPhonenumber;
        private MetroFramework.Controls.MetroTextBox txtBirthdate;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtFirtsName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroButton bttnAdd;
        private MetroFramework.Controls.MetroButton bttnEdit;
        private MetroFramework.Controls.MetroButton bttnDelete;
        private MetroFramework.Controls.MetroButton bttnCancel;
        private MetroFramework.Controls.MetroButton bttnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
    }
}