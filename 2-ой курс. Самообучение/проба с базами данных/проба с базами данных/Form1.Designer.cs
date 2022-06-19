namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label indexLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label компанияLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label клиентLabel;
            System.Windows.Forms.Label последний_звонокLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.карточкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.карточкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.компанияTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.клиентCheckBox = new System.Windows.Forms.CheckBox();
            this.последний_звонокDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.карточкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApplication1.Database1DataSet1();
            this.карточкаTableAdapter = new WindowsFormsApplication1.Database1DataSet1TableAdapters.КарточкаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Database1DataSet1TableAdapters.TableAdapterManager();
            indexLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            компанияLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            клиентLabel = new System.Windows.Forms.Label();
            последний_звонокLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.карточкаBindingNavigator)).BeginInit();
            this.карточкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Location = new System.Drawing.Point(67, 103);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new System.Drawing.Size(35, 13);
            indexLabel.TabIndex = 1;
            indexLabel.Text = "index:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(70, 130);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // компанияLabel
            // 
            компанияLabel.AutoSize = true;
            компанияLabel.Location = new System.Drawing.Point(41, 161);
            компанияLabel.Name = "компанияLabel";
            компанияLabel.Size = new System.Drawing.Size(61, 13);
            компанияLabel.TabIndex = 5;
            компанияLabel.Text = "Компания:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(47, 196);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(64, 238);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 9;
            e_mailLabel.Text = "E-mail:";
            // 
            // клиентLabel
            // 
            клиентLabel.AutoSize = true;
            клиентLabel.Location = new System.Drawing.Point(56, 279);
            клиентLabel.Name = "клиентLabel";
            клиентLabel.Size = new System.Drawing.Size(46, 13);
            клиентLabel.TabIndex = 11;
            клиентLabel.Text = "Клиент:";
            // 
            // последний_звонокLabel
            // 
            последний_звонокLabel.AutoSize = true;
            последний_звонокLabel.Location = new System.Drawing.Point(-3, 321);
            последний_звонокLabel.Name = "последний_звонокLabel";
            последний_звонокLabel.Size = new System.Drawing.Size(105, 13);
            последний_звонокLabel.TabIndex = 13;
            последний_звонокLabel.Text = "Последний звонок:";
            // 
            // карточкаBindingNavigator
            // 
            this.карточкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.карточкаBindingNavigator.BindingSource = this.карточкаBindingSource;
            this.карточкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.карточкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.карточкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.карточкаBindingNavigatorSaveItem});
            this.карточкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.карточкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.карточкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.карточкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.карточкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.карточкаBindingNavigator.Name = "карточкаBindingNavigator";
            this.карточкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.карточкаBindingNavigator.Size = new System.Drawing.Size(668, 25);
            this.карточкаBindingNavigator.TabIndex = 0;
            this.карточкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // карточкаBindingNavigatorSaveItem
            // 
            this.карточкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.карточкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("карточкаBindingNavigatorSaveItem.Image")));
            this.карточкаBindingNavigatorSaveItem.Name = "карточкаBindingNavigatorSaveItem";
            this.карточкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.карточкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.карточкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.карточкаBindingNavigatorSaveItem_Click);
            // 
            // indexTextBox
            // 
            this.indexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.карточкаBindingSource, "index", true));
            this.indexTextBox.Location = new System.Drawing.Point(106, 96);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 20);
            this.indexTextBox.TabIndex = 2;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.карточкаBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(108, 127);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 4;
            // 
            // компанияTextBox
            // 
            this.компанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.карточкаBindingSource, "Компания", true));
            this.компанияTextBox.Location = new System.Drawing.Point(108, 158);
            this.компанияTextBox.Name = "компанияTextBox";
            this.компанияTextBox.Size = new System.Drawing.Size(100, 20);
            this.компанияTextBox.TabIndex = 6;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.карточкаBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(108, 193);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 8;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.карточкаBindingSource, "E-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(108, 235);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mailTextBox.TabIndex = 10;
            // 
            // клиентCheckBox
            // 
            this.клиентCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.карточкаBindingSource, "Клиент", true));
            this.клиентCheckBox.Location = new System.Drawing.Point(108, 274);
            this.клиентCheckBox.Name = "клиентCheckBox";
            this.клиентCheckBox.Size = new System.Drawing.Size(104, 24);
            this.клиентCheckBox.TabIndex = 12;
            this.клиентCheckBox.UseVisualStyleBackColor = true;
            // 
            // последний_звонокDateTimePicker
            // 
            this.последний_звонокDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.карточкаBindingSource, "Последний звонок", true));
            this.последний_звонокDateTimePicker.Location = new System.Drawing.Point(108, 317);
            this.последний_звонокDateTimePicker.Name = "последний_звонокDateTimePicker";
            this.последний_звонокDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.последний_звонокDateTimePicker.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(465, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "начать работу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // карточкаBindingSource
            // 
            this.карточкаBindingSource.DataMember = "Карточка";
            this.карточкаBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // карточкаTableAdapter
            // 
            this.карточкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КарточкаTableAdapter = this.карточкаTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(последний_звонокLabel);
            this.Controls.Add(this.последний_звонокDateTimePicker);
            this.Controls.Add(клиентLabel);
            this.Controls.Add(this.клиентCheckBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(компанияLabel);
            this.Controls.Add(this.компанияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(indexLabel);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.карточкаBindingNavigator);
            this.Name = "Form1";
            this.Text = "программа 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.карточкаBindingNavigator)).EndInit();
            this.карточкаBindingNavigator.ResumeLayout(false);
            this.карточкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource карточкаBindingSource;
        private Database1DataSet1TableAdapters.КарточкаTableAdapter карточкаTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator карточкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton карточкаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox компанияTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.CheckBox клиентCheckBox;
        private System.Windows.Forms.DateTimePicker последний_звонокDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}

