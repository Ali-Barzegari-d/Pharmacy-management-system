namespace DarooKhaneh
{
    partial class frmCheckP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckP));
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.cmbVaziyat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnS = new DevComponents.DotNetBar.ButtonX();
            this.mskSarResid = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.mskTarikh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnList = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTozih = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMablagh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNameH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtShH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "برگشت خورده";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "عدم وصول";
            // 
            // cmbVaziyat
            // 
            this.cmbVaziyat.DisplayMember = "Text";
            this.cmbVaziyat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVaziyat.FormattingEnabled = true;
            this.cmbVaziyat.ItemHeight = 25;
            this.cmbVaziyat.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbVaziyat.Location = new System.Drawing.Point(190, 227);
            this.cmbVaziyat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVaziyat.Name = "cmbVaziyat";
            this.cmbVaziyat.Size = new System.Drawing.Size(170, 31);
            this.cmbVaziyat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbVaziyat.TabIndex = 10;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "وصول شده";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "وضعیت";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(120, 33);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(34, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "+";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnS
            // 
            this.btnS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnS.Location = new System.Drawing.Point(120, 3);
            this.btnS.Margin = new System.Windows.Forms.Padding(4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(34, 31);
            this.btnS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnS.TabIndex = 1;
            this.btnS.Text = "+";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // mskSarResid
            // 
            // 
            // 
            // 
            this.mskSarResid.BackgroundStyle.Class = "TextBoxBorder";
            this.mskSarResid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskSarResid.ButtonClear.Visible = true;
            this.mskSarResid.Location = new System.Drawing.Point(190, 195);
            this.mskSarResid.Margin = new System.Windows.Forms.Padding(4);
            this.mskSarResid.Mask = "####/##/##";
            this.mskSarResid.Name = "mskSarResid";
            this.mskSarResid.Size = new System.Drawing.Size(174, 28);
            this.mskSarResid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskSarResid.TabIndex = 8;
            this.mskSarResid.Text = "";
            // 
            // mskTarikh
            // 
            // 
            // 
            // 
            this.mskTarikh.BackgroundStyle.Class = "TextBoxBorder";
            this.mskTarikh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskTarikh.ButtonClear.Visible = true;
            this.mskTarikh.Location = new System.Drawing.Point(190, 163);
            this.mskTarikh.Margin = new System.Windows.Forms.Padding(4);
            this.mskTarikh.Mask = "####/##/##";
            this.mskTarikh.Name = "mskTarikh";
            this.mskTarikh.Size = new System.Drawing.Size(174, 28);
            this.mskTarikh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskTarikh.TabIndex = 7;
            this.mskTarikh.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "توضیحات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "سررسید";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "تاریخ صدور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "مبلغ چک";
            // 
            // btnList
            // 
            this.btnList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(0, 1);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 8, 8, 2);
            this.btnList.Size = new System.Drawing.Size(119, 47);
            this.btnList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnList.TabIndex = 3;
            this.btnList.Text = "لیست";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(505, 416);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.btnEdit);
            this.groupPanel4.Controls.Add(this.btnList);
            this.groupPanel4.Controls.Add(this.btnDelete);
            this.groupPanel4.Controls.Add(this.btnSave);
            this.groupPanel4.Location = new System.Drawing.Point(1, 351);
            this.groupPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(492, 57);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.Class = "";
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.Class = "";
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.Class = "";
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(122, 1);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 8, 8, 2);
            this.btnEdit.Size = new System.Drawing.Size(119, 47);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(245, 1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 8, 8, 2);
            this.btnDelete.Size = new System.Drawing.Size(119, 47);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(366, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 8, 8, 2);
            this.btnSave.Size = new System.Drawing.Size(119, 47);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.cmbVaziyat);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.btnS);
            this.groupPanel2.Controls.Add(this.mskSarResid);
            this.groupPanel2.Controls.Add(this.mskTarikh);
            this.groupPanel2.Controls.Add(this.label8);
            this.groupPanel2.Controls.Add(this.label9);
            this.groupPanel2.Controls.Add(this.label7);
            this.groupPanel2.Controls.Add(this.label6);
            this.groupPanel2.Controls.Add(this.label5);
            this.groupPanel2.Controls.Add(this.label4);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.txtTozih);
            this.groupPanel2.Controls.Add(this.txtMablagh);
            this.groupPanel2.Controls.Add(this.txtNameM);
            this.groupPanel2.Controls.Add(this.txtNameH);
            this.groupPanel2.Controls.Add(this.txtShH);
            this.groupPanel2.Controls.Add(this.txtCode);
            this.groupPanel2.Location = new System.Drawing.Point(4, 1);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(491, 347);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام شخص";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "شماره حساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "سریال چک";
            // 
            // txtTozih
            // 
            // 
            // 
            // 
            this.txtTozih.Border.Class = "TextBoxBorder";
            this.txtTozih.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTozih.Location = new System.Drawing.Point(-1, 260);
            this.txtTozih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTozih.Multiline = true;
            this.txtTozih.Name = "txtTozih";
            this.txtTozih.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTozih.Size = new System.Drawing.Size(365, 73);
            this.txtTozih.TabIndex = 9;
            // 
            // txtMablagh
            // 
            // 
            // 
            // 
            this.txtMablagh.Border.Class = "TextBoxBorder";
            this.txtMablagh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMablagh.Location = new System.Drawing.Point(190, 131);
            this.txtMablagh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMablagh.Name = "txtMablagh";
            this.txtMablagh.Size = new System.Drawing.Size(174, 37);
            this.txtMablagh.TabIndex = 6;
            // 
            // txtNameM
            // 
            // 
            // 
            // 
            this.txtNameM.Border.Class = "TextBoxBorder";
            this.txtNameM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameM.Location = new System.Drawing.Point(116, 99);
            this.txtNameM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameM.Name = "txtNameM";
            this.txtNameM.Size = new System.Drawing.Size(248, 37);
            this.txtNameM.TabIndex = 5;
            // 
            // txtNameH
            // 
            // 
            // 
            // 
            this.txtNameH.Border.Class = "TextBoxBorder";
            this.txtNameH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNameH.Location = new System.Drawing.Point(116, 67);
            this.txtNameH.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameH.Name = "txtNameH";
            this.txtNameH.Size = new System.Drawing.Size(248, 37);
            this.txtNameH.TabIndex = 4;
            // 
            // txtShH
            // 
            // 
            // 
            // 
            this.txtShH.Border.Class = "TextBoxBorder";
            this.txtShH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShH.Location = new System.Drawing.Point(156, 35);
            this.txtShH.Margin = new System.Windows.Forms.Padding(4);
            this.txtShH.Name = "txtShH";
            this.txtShH.Size = new System.Drawing.Size(208, 37);
            this.txtShH.TabIndex = 2;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.Location = new System.Drawing.Point(156, 3);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 37);
            this.txtCode.TabIndex = 0;
            // 
            // frmCheckP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 416);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCheckP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف چک های پرداختی";
            this.Load += new System.EventHandler(this.frmCheckP_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbVaziyat;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnS;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskSarResid;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskTarikh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnList;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtShH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        public DevComponents.DotNetBar.Controls.TextBoxX txtTozih;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMablagh;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNameM;
    }
}