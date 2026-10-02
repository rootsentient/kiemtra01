using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private TableLayoutPanel tableMain;
        private TableLayoutPanel tableInput;
        private TableLayoutPanel tableRight;

        private Label lblProductId;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblAvatar;
        private Label lblSearch;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;

        private ComboBox cboCategory;

        private PictureBox picAvatar;

        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private DataGridView dgvProducts;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalProducts;

        private ErrorProvider errorProvider;

        private BindingSource bindingSourceProducts;

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableMain = new TableLayoutPanel();
            tableInput = new TableLayoutPanel();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblAvatar = new Label();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            panelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tableRight = new TableLayoutPanel();
            searchPanel = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblTotalProducts = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            bindingSourceProducts = new BindingSource(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            tableMain.SuspendLayout();
            tableInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panelButtons.SuspendLayout();
            tableRight.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducts).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCSVToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportCSVToolStripMenuItem.Size = new Size(32, 19);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(32, 19);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 2;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableMain.Controls.Add(tableInput, 0, 0);
            tableMain.Controls.Add(tableRight, 1, 0);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 28);
            tableMain.Name = "tableMain";
            tableMain.Padding = new Padding(10);
            tableMain.RowCount = 1;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableMain.Size = new Size(1182, 599);
            tableMain.TabIndex = 0;
            // 
            // tableInput
            // 
            tableInput.ColumnCount = 2;
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableInput.Controls.Add(lblProductId, 0, 0);
            tableInput.Controls.Add(txtProductId, 1, 0);
            tableInput.Controls.Add(lblProductName, 0, 1);
            tableInput.Controls.Add(txtProductName, 1, 1);
            tableInput.Controls.Add(lblCategory, 0, 2);
            tableInput.Controls.Add(cboCategory, 1, 2);
            tableInput.Controls.Add(lblUnitPrice, 0, 3);
            tableInput.Controls.Add(txtUnitPrice, 1, 3);
            tableInput.Controls.Add(lblQuantity, 0, 4);
            tableInput.Controls.Add(txtQuantity, 1, 4);
            tableInput.Controls.Add(lblAvatar, 0, 5);
            tableInput.Controls.Add(picAvatar, 1, 5);
            tableInput.Controls.Add(btnChooseImage, 1, 6);
            tableInput.Controls.Add(panelButtons, 0, 7);
            tableInput.Dock = DockStyle.Fill;
            tableInput.Location = new Point(13, 13);
            tableInput.Name = "tableInput";
            tableInput.RowCount = 8;
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableInput.Size = new Size(400, 573);
            tableInput.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.Location = new Point(3, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(100, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // txtProductId
            // 
            txtProductId.Dock = DockStyle.Fill;
            txtProductId.Location = new Point(143, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(254, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(3, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(143, 23);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(254, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(3, 40);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Danh mục:";
            // 
            // cboCategory
            // 
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(143, 43);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(254, 28);
            cboCategory.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Location = new Point(3, 60);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(100, 20);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(143, 63);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(254, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(3, 80);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 20);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(143, 83);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(254, 27);
            txtQuantity.TabIndex = 9;
            // 
            // lblAvatar
            // 
            lblAvatar.Location = new Point(3, 100);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(100, 20);
            lblAvatar.TabIndex = 10;
            lblAvatar.Text = "Ảnh:";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Dock = DockStyle.Fill;
            picAvatar.Location = new Point(143, 103);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(254, 14);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 11;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Dock = DockStyle.Fill;
            btnChooseImage.Location = new Point(143, 123);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(254, 14);
            btnChooseImage.TabIndex = 12;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // panelButtons
            // 
            panelButtons.AutoSize = true;
            tableInput.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 143);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(394, 427);
            panelButtons.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // tableRight
            // 
            tableRight.ColumnCount = 1;
            tableRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableRight.Controls.Add(searchPanel, 0, 0);
            tableRight.Controls.Add(dgvProducts, 0, 1);
            tableRight.Dock = DockStyle.Fill;
            tableRight.Location = new Point(419, 13);
            tableRight.Name = "tableRight";
            tableRight.RowCount = 2;
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableRight.Size = new Size(750, 573);
            tableRight.TabIndex = 1;
            // 
            // searchPanel
            // 
            searchPanel.AutoSize = true;
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(3, 3);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(744, 33);
            searchPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(3, 42);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(744, 528);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalProducts });
            statusStrip1.Location = new Point(0, 627);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 26);
            statusStrip1.TabIndex = 1;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(145, 20);
            lblTotalProducts.Text = "Tổng số sản phẩm: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(1182, 653);
            Controls.Add(tableMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableMain.ResumeLayout(false);
            tableInput.ResumeLayout(false);
            tableInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panelButtons.ResumeLayout(false);
            tableRight.ResumeLayout(false);
            tableRight.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private FlowLayoutPanel panelButtons;
        private FlowLayoutPanel searchPanel;
    }
}