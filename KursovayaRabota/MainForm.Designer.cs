namespace KursovayaRabota
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseScladDataSet = new KursovayaRabota.DataBaseScladDataSet();
            this.scladTableAdapter = new KursovayaRabota.DataBaseScladDataSetTableAdapters.ScladTableAdapter();
            this.Search = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.Add_Dan = new System.Windows.Forms.GroupBox();
            this.OK = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.Pr_ = new System.Windows.Forms.Label();
            this.Sg = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.Col = new System.Windows.Forms.TextBox();
            this.Pr = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Prod = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.TextBox();
            this.SG_ = new System.Windows.Forms.Label();
            this.D_ = new System.Windows.Forms.Label();
            this.PRI_ = new System.Windows.Forms.Label();
            this.C_ = new System.Windows.Forms.Label();
            this.P_ = new System.Windows.Forms.Label();
            this.Baza_Sclada_2 = new System.Windows.Forms.DataGridView();
            this.dataBaseScladDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Baza_Sclada = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshik_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokgod_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseScladDataSet)).BeginInit();
            this.Add_Dan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_Sclada_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseScladDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_Sclada)).BeginInit();
            this.SuspendLayout();
            // 
            // scladBindingSource
            // 
            this.scladBindingSource.DataMember = "Sclad";
            this.scladBindingSource.DataSource = this.dataBaseScladDataSet;
            // 
            // dataBaseScladDataSet
            // 
            this.dataBaseScladDataSet.DataSetName = "DataBaseScladDataSet";
            this.dataBaseScladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scladTableAdapter
            // 
            this.scladTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(13, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 13);
            this.Search.TabIndex = 1;
            this.Search.Text = "Поиск по товару";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(225, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(144, 36);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Сброс";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(726, 461);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(110, 10);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(190, 20);
            this.textBoxS.TabIndex = 8;
            // 
            // Add_Dan
            // 
            this.Add_Dan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Dan.Controls.Add(this.OK);
            this.Add_Dan.Controls.Add(this.buttonDel);
            this.Add_Dan.Controls.Add(this.Pr_);
            this.Add_Dan.Controls.Add(this.Sg);
            this.Add_Dan.Controls.Add(this.D);
            this.Add_Dan.Controls.Add(this.Col);
            this.Add_Dan.Controls.Add(this.Pr);
            this.Add_Dan.Controls.Add(this.buttonAdd);
            this.Add_Dan.Controls.Add(this.Prod);
            this.Add_Dan.Controls.Add(this.Post);
            this.Add_Dan.Controls.Add(this.SG_);
            this.Add_Dan.Controls.Add(this.D_);
            this.Add_Dan.Controls.Add(this.PRI_);
            this.Add_Dan.Controls.Add(this.C_);
            this.Add_Dan.Controls.Add(this.P_);
            this.Add_Dan.Location = new System.Drawing.Point(510, 13);
            this.Add_Dan.Name = "Add_Dan";
            this.Add_Dan.Size = new System.Drawing.Size(302, 179);
            this.Add_Dan.TabIndex = 9;
            this.Add_Dan.TabStop = false;
            this.Add_Dan.Text = "Добавить данные";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(228, 140);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(68, 20);
            this.OK.TabIndex = 15;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(210, 47);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(86, 25);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Pr_
            // 
            this.Pr_.AutoSize = true;
            this.Pr_.Location = new System.Drawing.Point(6, 22);
            this.Pr_.Name = "Pr_";
            this.Pr_.Size = new System.Drawing.Size(65, 13);
            this.Pr_.TabIndex = 12;
            this.Pr_.Text = "Поставщик";
            // 
            // Sg
            // 
            this.Sg.Location = new System.Drawing.Point(93, 136);
            this.Sg.Name = "Sg";
            this.Sg.Size = new System.Drawing.Size(100, 20);
            this.Sg.TabIndex = 11;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(61, 115);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(100, 20);
            this.D.TabIndex = 10;
            // 
            // Col
            // 
            this.Col.Location = new System.Drawing.Point(61, 93);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(100, 20);
            this.Col.TabIndex = 9;
            // 
            // Pr
            // 
            this.Pr.Location = new System.Drawing.Point(61, 68);
            this.Pr.Name = "Pr";
            this.Pr.Size = new System.Drawing.Size(100, 20);
            this.Pr.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(210, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 20);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // Prod
            // 
            this.Prod.Location = new System.Drawing.Point(61, 47);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(100, 20);
            this.Prod.TabIndex = 7;
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(77, 19);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(100, 20);
            this.Post.TabIndex = 6;
            // 
            // SG_
            // 
            this.SG_.AutoSize = true;
            this.SG_.Location = new System.Drawing.Point(6, 139);
            this.SG_.Name = "SG_";
            this.SG_.Size = new System.Drawing.Size(81, 13);
            this.SG_.TabIndex = 4;
            this.SG_.Text = "Срок годности";
            // 
            // D_
            // 
            this.D_.AutoSize = true;
            this.D_.Location = new System.Drawing.Point(6, 118);
            this.D_.Name = "D_";
            this.D_.Size = new System.Drawing.Size(33, 13);
            this.D_.TabIndex = 3;
            this.D_.Text = "Дата";
            // 
            // PRI_
            // 
            this.PRI_.AutoSize = true;
            this.PRI_.Location = new System.Drawing.Point(6, 96);
            this.PRI_.Name = "PRI_";
            this.PRI_.Size = new System.Drawing.Size(33, 13);
            this.PRI_.TabIndex = 2;
            this.PRI_.Text = "Цена";
            // 
            // C_
            // 
            this.C_.AutoSize = true;
            this.C_.Location = new System.Drawing.Point(6, 71);
            this.C_.Name = "C_";
            this.C_.Size = new System.Drawing.Size(41, 13);
            this.C_.TabIndex = 1;
            this.C_.Text = "Кол-во";
            // 
            // P_
            // 
            this.P_.AutoSize = true;
            this.P_.Location = new System.Drawing.Point(6, 50);
            this.P_.Name = "P_";
            this.P_.Size = new System.Drawing.Size(49, 13);
            this.P_.TabIndex = 0;
            this.P_.Text = "Продукт";
            // 
            // Baza_Sclada_2
            // 
            this.Baza_Sclada_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Baza_Sclada_2.Location = new System.Drawing.Point(71, 209);
            this.Baza_Sclada_2.Name = "Baza_Sclada_2";
            this.Baza_Sclada_2.Size = new System.Drawing.Size(741, 242);
            this.Baza_Sclada_2.TabIndex = 10;
            this.Baza_Sclada_2.SelectionChanged += new System.EventHandler(this.Baza_Sclada2_SelectionChanged);
            // 
            // dataBaseScladDataSetBindingSource
            // 
            this.dataBaseScladDataSetBindingSource.DataSource = this.dataBaseScladDataSet;
            this.dataBaseScladDataSetBindingSource.Position = 0;
            // 
            // Baza_Sclada
            // 
            this.Baza_Sclada.AllowUserToAddRows = false;
            this.Baza_Sclada.AutoGenerateColumns = false;
            this.Baza_Sclada.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Baza_Sclada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Baza_Sclada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.postavshik_,
            this.product_,
            this.colvo_,
            this.price_,
            this.data_,
            this.srokgod_});
            this.Baza_Sclada.DataSource = this.scladBindingSource;
            this.Baza_Sclada.Location = new System.Drawing.Point(71, 209);
            this.Baza_Sclada.Name = "Baza_Sclada";
            this.Baza_Sclada.Size = new System.Drawing.Size(741, 242);
            this.Baza_Sclada.TabIndex = 11;
            this.Baza_Sclada.SelectionChanged += new System.EventHandler(this.Baza_Sclada_SelectionChanged_1);
            // 
            // id_
            // 
            this.id_.DataPropertyName = "id";
            this.id_.HeaderText = "Номер";
            this.id_.Name = "id_";
            // 
            // postavshik_
            // 
            this.postavshik_.DataPropertyName = "postavshik";
            this.postavshik_.HeaderText = "Поставщик";
            this.postavshik_.Name = "postavshik_";
            // 
            // product_
            // 
            this.product_.DataPropertyName = "product";
            this.product_.HeaderText = "Продукт";
            this.product_.Name = "product_";
            // 
            // colvo_
            // 
            this.colvo_.DataPropertyName = "colvo";
            this.colvo_.HeaderText = "Количество";
            this.colvo_.Name = "colvo_";
            // 
            // price_
            // 
            this.price_.DataPropertyName = "price";
            this.price_.HeaderText = "Цена";
            this.price_.Name = "price_";
            // 
            // data_
            // 
            this.data_.DataPropertyName = "data";
            this.data_.HeaderText = "Дата";
            this.data_.Name = "data_";
            // 
            // srokgod_
            // 
            this.srokgod_.DataPropertyName = "srokgod";
            this.srokgod_.HeaderText = "Срок годности";
            this.srokgod_.Name = "srokgod_";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KursovayaRabota.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.Add_Dan);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Baza_Sclada);
            this.Controls.Add(this.Baza_Sclada_2);
            this.Name = "MainForm";
            this.Text = "Склад продуктов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseScladDataSet)).EndInit();
            this.Add_Dan.ResumeLayout(false);
            this.Add_Dan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_Sclada_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseScladDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_Sclada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataBaseScladDataSet dataBaseScladDataSet;
        private System.Windows.Forms.BindingSource scladBindingSource;
        private DataBaseScladDataSetTableAdapters.ScladTableAdapter scladTableAdapter;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.GroupBox Add_Dan;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label Pr_;
        private System.Windows.Forms.TextBox Sg;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox Col;
        private System.Windows.Forms.TextBox Pr;
        private System.Windows.Forms.TextBox Prod;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.Label SG_;
        private System.Windows.Forms.Label D_;
        private System.Windows.Forms.Label PRI_;
        private System.Windows.Forms.Label P_;
        private System.Windows.Forms.Label C_;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshik;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokgod;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridView Baza_Sclada_2;
        private System.Windows.Forms.BindingSource dataBaseScladDataSetBindingSource;
        private System.Windows.Forms.DataGridView Baza_Sclada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshik_;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokgod_;
    }
}

