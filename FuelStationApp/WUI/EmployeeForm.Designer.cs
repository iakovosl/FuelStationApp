
namespace FuelStationApp.WUI {
    partial class EmployeeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSurname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateEnd = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateStart = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSalary = new DevExpress.XtraEditors.LabelControl();
            this.gridEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSalary = new DevExpress.XtraEditors.TextEdit();
            this.ctrlDateStart = new DevExpress.XtraEditors.TextEdit();
            this.ctrlDateEnd = new DevExpress.XtraEditors.TextEdit();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctrlDateStart11 = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart11.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart11.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(723, 78);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(41, 16);
            this.labelControlName.TabIndex = 3;
            this.labelControlName.Text = "Name:";
            // 
            // labelControlSurname
            // 
            this.labelControlSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSurname.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSurname.Appearance.Options.UseFont = true;
            this.labelControlSurname.Appearance.Options.UseForeColor = true;
            this.labelControlSurname.Location = new System.Drawing.Point(723, 136);
            this.labelControlSurname.Name = "labelControlSurname";
            this.labelControlSurname.Size = new System.Drawing.Size(63, 16);
            this.labelControlSurname.TabIndex = 4;
            this.labelControlSurname.Text = "Surname:";
            // 
            // labelControlDateEnd
            // 
            this.labelControlDateEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlDateEnd.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlDateEnd.Appearance.Options.UseFont = true;
            this.labelControlDateEnd.Appearance.Options.UseForeColor = true;
            this.labelControlDateEnd.Location = new System.Drawing.Point(723, 236);
            this.labelControlDateEnd.Name = "labelControlDateEnd";
            this.labelControlDateEnd.Size = new System.Drawing.Size(64, 16);
            this.labelControlDateEnd.TabIndex = 5;
            this.labelControlDateEnd.Text = "Date End:";
            // 
            // labelControlDateStart
            // 
            this.labelControlDateStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlDateStart.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlDateStart.Appearance.Options.UseFont = true;
            this.labelControlDateStart.Appearance.Options.UseForeColor = true;
            this.labelControlDateStart.Location = new System.Drawing.Point(723, 185);
            this.labelControlDateStart.Name = "labelControlDateStart";
            this.labelControlDateStart.Size = new System.Drawing.Size(75, 16);
            this.labelControlDateStart.TabIndex = 6;
            this.labelControlDateStart.Text = "Date Start:";
            // 
            // labelControlSalary
            // 
            this.labelControlSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSalary.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSalary.Appearance.Options.UseFont = true;
            this.labelControlSalary.Appearance.Options.UseForeColor = true;
            this.labelControlSalary.Location = new System.Drawing.Point(723, 285);
            this.labelControlSalary.Name = "labelControlSalary";
            this.labelControlSalary.Size = new System.Drawing.Size(96, 16);
            this.labelControlSalary.TabIndex = 7;
            this.labelControlSalary.Text = "Salary/Month:";
            // 
            // gridEmployees
            // 
            this.gridEmployees.Location = new System.Drawing.Point(12, 78);
            this.gridEmployees.MainView = this.gridView1;
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(576, 357);
            this.gridEmployees.TabIndex = 8;
            this.gridEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colDateStart,
            this.colDateEnd,
            this.colSalary});
            this.gridView1.GridControl = this.gridEmployees;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // colDateStart
            // 
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 3;
            // 
            // colDateEnd
            // 
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 4;
            // 
            // colSalary
            // 
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(305, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(310, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Employees Management System";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(825, 74);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(152, 20);
            this.ctrlName.TabIndex = 10;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(825, 135);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(152, 20);
            this.ctrlSurname.TabIndex = 11;
            // 
            // ctrlSalary
            // 
            this.ctrlSalary.Location = new System.Drawing.Point(825, 284);
            this.ctrlSalary.Name = "ctrlSalary";
            this.ctrlSalary.Size = new System.Drawing.Size(152, 20);
            this.ctrlSalary.TabIndex = 12;
            // 
            // ctrlDateStart
            // 
            this.ctrlDateStart.Location = new System.Drawing.Point(358, 479);
            this.ctrlDateStart.Name = "ctrlDateStart";
            this.ctrlDateStart.Size = new System.Drawing.Size(152, 20);
            this.ctrlDateStart.TabIndex = 13;
            // 
            // ctrlDateEnd
            // 
            this.ctrlDateEnd.Location = new System.Drawing.Point(825, 232);
            this.ctrlDateEnd.Name = "ctrlDateEnd";
            this.ctrlDateEnd.Size = new System.Drawing.Size(152, 20);
            this.ctrlDateEnd.TabIndex = 14;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Location = new System.Drawing.Point(626, 346);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(78, 42);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View Record";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(723, 346);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 42);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(825, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 42);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(918, 346);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 42);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete  Record";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(949, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 42);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlDateStart11
            // 
            this.ctrlDateStart11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDateStart11.EditValue = new System.DateTime(2021, 7, 15, 0, 0, 0, 0);
            this.ctrlDateStart11.Location = new System.Drawing.Point(825, 181);
            this.ctrlDateStart11.Name = "ctrlDateStart11";
            this.ctrlDateStart11.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateStart11.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateStart11.Properties.NullDate = new System.DateTime(2021, 7, 5, 1, 17, 37, 675);
            this.ctrlDateStart11.Size = new System.Drawing.Size(152, 20);
            this.ctrlDateStart11.TabIndex = 46;
            this.ctrlDateStart11.EditValueChanged += new System.EventHandler(this.ctrlDateStart_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(846, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 42);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 542);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlDateStart11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.ctrlDateEnd);
            this.Controls.Add(this.ctrlDateStart);
            this.Controls.Add(this.ctrlSalary);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.labelControlSalary);
            this.Controls.Add(this.labelControlDateStart);
            this.Controls.Add(this.labelControlDateEnd);
            this.Controls.Add(this.labelControlSurname);
            this.Controls.Add(this.labelControlName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart11.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart11.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlSurname;
        private DevExpress.XtraEditors.LabelControl labelControlDateEnd;
        private DevExpress.XtraEditors.LabelControl labelControlDateStart;
        private DevExpress.XtraEditors.LabelControl labelControlSalary;
        private DevExpress.XtraGrid.GridControl gridEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlSalary;
        private DevExpress.XtraEditors.TextEdit ctrlDateStart;
        private DevExpress.XtraEditors.TextEdit ctrlDateEnd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraEditors.DateEdit ctrlDateStart11;
        private System.Windows.Forms.Button btnSave;
    }
}