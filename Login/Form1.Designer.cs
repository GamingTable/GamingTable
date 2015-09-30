namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.servtab = new System.Windows.Forms.TabPage();
            this.servTerminal = new System.Windows.Forms.TextBox();
            this.servButton = new System.Windows.Forms.Button();
            this.servLabel = new System.Windows.Forms.Label();
            this.logtab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.regtab = new System.Windows.Forms.TabPage();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.registerConfirm = new System.Windows.Forms.TextBox();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbtab = new System.Windows.Forms.TabPage();
            this.loginsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamingTableDataSet = new Login.GamingTableDataSet();
            this.loginsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loginsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.conftab = new System.Windows.Forms.TabPage();
            this.smtpPortNumericUD = new System.Windows.Forms.NumericUpDown();
            this.smtpUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.smtpUserNameTextBox = new System.Windows.Forms.TextBox();
            this.smtpAddressTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginsTableAdapter = new Login.GamingTableDataSetTableAdapters.LoginsTableAdapter();
            this.tableAdapterManager = new Login.GamingTableDataSetTableAdapters.TableAdapterManager();
            this.servIP = new System.Windows.Forms.TextBox();
            this.servPort = new System.Windows.Forms.NumericUpDown();
            this.clientIP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clientPort = new System.Windows.Forms.NumericUpDown();
            this.tabs.SuspendLayout();
            this.servtab.SuspendLayout();
            this.logtab.SuspendLayout();
            this.regtab.SuspendLayout();
            this.dbtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamingTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingNavigator)).BeginInit();
            this.loginsBindingNavigator.SuspendLayout();
            this.conftab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabs.Controls.Add(this.servtab);
            this.tabs.Controls.Add(this.logtab);
            this.tabs.Controls.Add(this.regtab);
            this.tabs.Controls.Add(this.dbtab);
            this.tabs.Controls.Add(this.conftab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabs.Location = new System.Drawing.Point(0, 2);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(284, 255);
            this.tabs.TabIndex = 0;
            // 
            // servtab
            // 
            this.servtab.Controls.Add(this.servPort);
            this.servtab.Controls.Add(this.servIP);
            this.servtab.Controls.Add(this.servTerminal);
            this.servtab.Controls.Add(this.servButton);
            this.servtab.Controls.Add(this.servLabel);
            this.servtab.Location = new System.Drawing.Point(4, 4);
            this.servtab.Name = "servtab";
            this.servtab.Padding = new System.Windows.Forms.Padding(3);
            this.servtab.Size = new System.Drawing.Size(276, 229);
            this.servtab.TabIndex = 4;
            this.servtab.Text = "Server";
            this.servtab.UseVisualStyleBackColor = true;
            // 
            // servTerminal
            // 
            this.servTerminal.AcceptsReturn = true;
            this.servTerminal.BackColor = System.Drawing.SystemColors.WindowText;
            this.servTerminal.ForeColor = System.Drawing.SystemColors.Window;
            this.servTerminal.Location = new System.Drawing.Point(3, 6);
            this.servTerminal.Multiline = true;
            this.servTerminal.Name = "servTerminal";
            this.servTerminal.ReadOnly = true;
            this.servTerminal.Size = new System.Drawing.Size(267, 180);
            this.servTerminal.TabIndex = 2;
            // 
            // servButton
            // 
            this.servButton.Location = new System.Drawing.Point(193, 192);
            this.servButton.Name = "servButton";
            this.servButton.Size = new System.Drawing.Size(77, 23);
            this.servButton.TabIndex = 1;
            this.servButton.Text = "Start Server";
            this.servButton.UseVisualStyleBackColor = true;
            this.servButton.Click += new System.EventHandler(this.servButton_Click);
            // 
            // servLabel
            // 
            this.servLabel.AutoSize = true;
            this.servLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.servLabel.Location = new System.Drawing.Point(170, 195);
            this.servLabel.Name = "servLabel";
            this.servLabel.Size = new System.Drawing.Size(26, 20);
            this.servLabel.TabIndex = 0;
            this.servLabel.Text = "■";
            // 
            // logtab
            // 
            this.logtab.Controls.Add(this.clientPort);
            this.logtab.Controls.Add(this.label12);
            this.logtab.Controls.Add(this.label11);
            this.logtab.Controls.Add(this.clientIP);
            this.logtab.Controls.Add(this.label2);
            this.logtab.Controls.Add(this.label1);
            this.logtab.Controls.Add(this.loginButton);
            this.logtab.Controls.Add(this.loginPassword);
            this.logtab.Controls.Add(this.loginUsername);
            this.logtab.Location = new System.Drawing.Point(4, 4);
            this.logtab.Name = "logtab";
            this.logtab.Padding = new System.Windows.Forms.Padding(3);
            this.logtab.Size = new System.Drawing.Size(276, 229);
            this.logtab.TabIndex = 0;
            this.logtab.Text = "Login";
            this.logtab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(92, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(132, 69);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(100, 20);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginUsername
            // 
            this.loginUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.loginUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.loginUsername.Location = new System.Drawing.Point(132, 43);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(100, 20);
            this.loginUsername.TabIndex = 0;
            // 
            // regtab
            // 
            this.regtab.Controls.Add(this.registerButton);
            this.regtab.Controls.Add(this.registerEmail);
            this.regtab.Controls.Add(this.registerConfirm);
            this.regtab.Controls.Add(this.registerPassword);
            this.regtab.Controls.Add(this.registerUsername);
            this.regtab.Controls.Add(this.label6);
            this.regtab.Controls.Add(this.label5);
            this.regtab.Controls.Add(this.label4);
            this.regtab.Controls.Add(this.label3);
            this.regtab.Location = new System.Drawing.Point(4, 4);
            this.regtab.Name = "regtab";
            this.regtab.Padding = new System.Windows.Forms.Padding(3);
            this.regtab.Size = new System.Drawing.Size(276, 229);
            this.regtab.TabIndex = 1;
            this.regtab.Text = "Register";
            this.regtab.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(84, 162);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(134, 115);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(100, 20);
            this.registerEmail.TabIndex = 7;
            // 
            // registerConfirm
            // 
            this.registerConfirm.Location = new System.Drawing.Point(134, 87);
            this.registerConfirm.Name = "registerConfirm";
            this.registerConfirm.PasswordChar = '*';
            this.registerConfirm.Size = new System.Drawing.Size(100, 20);
            this.registerConfirm.TabIndex = 6;
            this.registerConfirm.UseSystemPasswordChar = true;
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(134, 60);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(100, 20);
            this.registerPassword.TabIndex = 5;
            this.registerPassword.UseSystemPasswordChar = true;
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(134, 30);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(100, 20);
            this.registerUsername.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // dbtab
            // 
            this.dbtab.AutoScroll = true;
            this.dbtab.Controls.Add(this.loginsDataGridView);
            this.dbtab.Controls.Add(this.loginsBindingNavigator);
            this.dbtab.Location = new System.Drawing.Point(4, 4);
            this.dbtab.Name = "dbtab";
            this.dbtab.Padding = new System.Windows.Forms.Padding(3);
            this.dbtab.Size = new System.Drawing.Size(276, 229);
            this.dbtab.TabIndex = 2;
            this.dbtab.Text = "Logins Table";
            this.dbtab.UseVisualStyleBackColor = true;
            // 
            // loginsDataGridView
            // 
            this.loginsDataGridView.AutoGenerateColumns = false;
            this.loginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.loginsDataGridView.DataSource = this.loginsBindingSource;
            this.loginsDataGridView.Location = new System.Drawing.Point(3, 31);
            this.loginsDataGridView.Name = "loginsDataGridView";
            this.loginsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.loginsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.gamingTableDataSet;
            // 
            // gamingTableDataSet
            // 
            this.gamingTableDataSet.DataSetName = "GamingTableDataSet";
            this.gamingTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingNavigator
            // 
            this.loginsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginsBindingNavigator.BindingSource = this.loginsBindingSource;
            this.loginsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loginsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.loginsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.loginsBindingNavigatorSaveItem});
            this.loginsBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.loginsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loginsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loginsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loginsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loginsBindingNavigator.Name = "loginsBindingNavigator";
            this.loginsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loginsBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.loginsBindingNavigator.TabIndex = 1;
            this.loginsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // loginsBindingNavigatorSaveItem
            // 
            this.loginsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginsBindingNavigatorSaveItem.Image")));
            this.loginsBindingNavigatorSaveItem.Name = "loginsBindingNavigatorSaveItem";
            this.loginsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loginsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // conftab
            // 
            this.conftab.Controls.Add(this.smtpPortNumericUD);
            this.conftab.Controls.Add(this.smtpUserPasswordTextBox);
            this.conftab.Controls.Add(this.smtpUserNameTextBox);
            this.conftab.Controls.Add(this.smtpAddressTextBox);
            this.conftab.Controls.Add(this.label10);
            this.conftab.Controls.Add(this.label9);
            this.conftab.Controls.Add(this.label8);
            this.conftab.Controls.Add(this.label7);
            this.conftab.Location = new System.Drawing.Point(4, 4);
            this.conftab.Name = "conftab";
            this.conftab.Padding = new System.Windows.Forms.Padding(3);
            this.conftab.Size = new System.Drawing.Size(276, 229);
            this.conftab.TabIndex = 3;
            this.conftab.Text = "Configuration";
            this.conftab.UseVisualStyleBackColor = true;
            // 
            // smtpPortNumericUD
            // 
            this.smtpPortNumericUD.Location = new System.Drawing.Point(139, 66);
            this.smtpPortNumericUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.smtpPortNumericUD.Name = "smtpPortNumericUD";
            this.smtpPortNumericUD.Size = new System.Drawing.Size(100, 20);
            this.smtpPortNumericUD.TabIndex = 5;
            this.smtpPortNumericUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // smtpUserPasswordTextBox
            // 
            this.smtpUserPasswordTextBox.Location = new System.Drawing.Point(139, 121);
            this.smtpUserPasswordTextBox.Name = "smtpUserPasswordTextBox";
            this.smtpUserPasswordTextBox.PasswordChar = '*';
            this.smtpUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpUserPasswordTextBox.TabIndex = 7;
            this.smtpUserPasswordTextBox.Text = "adozamujprksxjza";
            this.smtpUserPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // smtpUserNameTextBox
            // 
            this.smtpUserNameTextBox.Location = new System.Drawing.Point(139, 94);
            this.smtpUserNameTextBox.Name = "smtpUserNameTextBox";
            this.smtpUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpUserNameTextBox.TabIndex = 6;
            this.smtpUserNameTextBox.Text = "chapeau.plume@gmail.com";
            // 
            // smtpAddressTextBox
            // 
            this.smtpAddressTextBox.Location = new System.Drawing.Point(139, 36);
            this.smtpAddressTextBox.Name = "smtpAddressTextBox";
            this.smtpAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.smtpAddressTextBox.TabIndex = 4;
            this.smtpAddressTextBox.Text = "smtp.gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Email Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SMTP Address";
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginsTableAdapter = this.loginsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.GamingTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servIP
            // 
            this.servIP.Location = new System.Drawing.Point(3, 194);
            this.servIP.Name = "servIP";
            this.servIP.Size = new System.Drawing.Size(86, 20);
            this.servIP.TabIndex = 3;
            this.servIP.Text = "127.0.0.1";
            // 
            // servPort
            // 
            this.servPort.Location = new System.Drawing.Point(95, 195);
            this.servPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.servPort.Name = "servPort";
            this.servPort.Size = new System.Drawing.Size(55, 20);
            this.servPort.TabIndex = 4;
            this.servPort.Value = new decimal(new int[] {
            357,
            0,
            0,
            0});
            // 
            // clientIP
            // 
            this.clientIP.Location = new System.Drawing.Point(132, 111);
            this.clientIP.Name = "clientIP";
            this.clientIP.Size = new System.Drawing.Size(100, 20);
            this.clientIP.TabIndex = 5;
            this.clientIP.Text = "127.0.0.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Server IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Server Port";
            // 
            // clientPort
            // 
            this.clientPort.Location = new System.Drawing.Point(132, 137);
            this.clientPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(100, 20);
            this.clientPort.TabIndex = 9;
            this.clientPort.Value = new decimal(new int[] {
            357,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Gaming Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.servtab.ResumeLayout(false);
            this.servtab.PerformLayout();
            this.logtab.ResumeLayout(false);
            this.logtab.PerformLayout();
            this.regtab.ResumeLayout(false);
            this.regtab.PerformLayout();
            this.dbtab.ResumeLayout(false);
            this.dbtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamingTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingNavigator)).EndInit();
            this.loginsBindingNavigator.ResumeLayout(false);
            this.loginsBindingNavigator.PerformLayout();
            this.conftab.ResumeLayout(false);
            this.conftab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage logtab;
        private System.Windows.Forms.TabPage regtab;
        private System.Windows.Forms.TabPage dbtab;
        private System.Windows.Forms.TabPage conftab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.TextBox registerConfirm;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown smtpPortNumericUD;
        private System.Windows.Forms.TextBox smtpUserPasswordTextBox;
        private System.Windows.Forms.TextBox smtpUserNameTextBox;
        private System.Windows.Forms.TextBox smtpAddressTextBox;
        private System.Windows.Forms.Label label10;
        private GamingTableDataSet gamingTableDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private GamingTableDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private GamingTableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton loginsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView loginsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage servtab;
        private System.Windows.Forms.Button servButton;
        private System.Windows.Forms.Label servLabel;
        private System.Windows.Forms.TextBox servTerminal;
        private System.Windows.Forms.NumericUpDown servPort;
        private System.Windows.Forms.TextBox servIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clientIP;
        private System.Windows.Forms.NumericUpDown clientPort;
    }
}

