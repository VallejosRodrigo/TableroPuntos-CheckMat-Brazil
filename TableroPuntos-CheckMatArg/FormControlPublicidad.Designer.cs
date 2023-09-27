namespace TableroPuntos_CheckMatArg
{
    partial class FormControlPublicidad
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlPublicidad));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAgregarImagen = new Button();
            buttonEliminarImagen = new Button();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Imagenes = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            toolTipControladorPublicidad = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Gold;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.12808F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.87192F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.888889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.Size = new Size(806, 444);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 26);
            label1.TabIndex = 0;
            label1.Text = "Lista de imagens para Painel de Anúncios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            toolTipControladorPublicidad.SetToolTip(label1, "Esta é a lista de imagens que serão executadas no painel de anúncios");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 0);
            label2.Name = "label2";
            label2.Size = new Size(533, 29);
            label2.TabIndex = 1;
            label2.Text = "CHECKMAT Equipe 1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            toolTipControladorPublicidad.SetToolTip(label2, "CheckMat International");
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonAgregarImagen, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonEliminarImagen, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 1);
            tableLayoutPanel2.Controls.Add(button2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 329);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(261, 112);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonAgregarImagen
            // 
            buttonAgregarImagen.BackColor = Color.Silver;
            buttonAgregarImagen.Dock = DockStyle.Fill;
            buttonAgregarImagen.FlatStyle = FlatStyle.Flat;
            buttonAgregarImagen.Font = new Font("Cambria", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarImagen.Location = new Point(3, 3);
            buttonAgregarImagen.Name = "buttonAgregarImagen";
            buttonAgregarImagen.Size = new Size(124, 50);
            buttonAgregarImagen.TabIndex = 0;
            buttonAgregarImagen.Text = "Examinar...";
            toolTipControladorPublicidad.SetToolTip(buttonAgregarImagen, "Procure aqui sua imagem para anúncios. Recomendação: resolução de 1386x788 pixels");
            buttonAgregarImagen.UseVisualStyleBackColor = false;
            buttonAgregarImagen.Click += buttonAgregarImagen_Click;
            // 
            // buttonEliminarImagen
            // 
            buttonEliminarImagen.BackColor = Color.Silver;
            buttonEliminarImagen.Dock = DockStyle.Fill;
            buttonEliminarImagen.FlatStyle = FlatStyle.Flat;
            buttonEliminarImagen.Font = new Font("Cambria", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminarImagen.Location = new Point(133, 3);
            buttonEliminarImagen.Name = "buttonEliminarImagen";
            buttonEliminarImagen.Size = new Size(125, 50);
            buttonEliminarImagen.TabIndex = 1;
            buttonEliminarImagen.Text = "Remover";
            toolTipControladorPublicidad.SetToolTip(buttonEliminarImagen, "Remover uma imagem da lista");
            buttonEliminarImagen.UseVisualStyleBackColor = false;
            buttonEliminarImagen.Click += buttonEliminarImagen_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Silver;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 59);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 2;
            button1.Text = "Sair";
            toolTipControladorPublicidad.SetToolTip(button1, "Sair do Gerenciador de anúncios");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Silver;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(133, 59);
            button2.Name = "button2";
            button2.Size = new Size(125, 50);
            button2.TabIndex = 3;
            button2.Text = "Informação";
            toolTipControladorPublicidad.SetToolTip(button2, "Como usar este Gerenciador de Anúncios?");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.BackColor = Color.OrangeRed;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.19553F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.80447F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(270, 329);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(533, 112);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.BackColor = Color.OrangeRed;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(button3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(181, 106);
            tableLayoutPanel4.TabIndex = 0;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.WhiteSmoke;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(175, 100);
            button3.TabIndex = 0;
            button3.Text = "Altere a imagem do marcador de Pontos -Resolução sugerida:        836 ; 219";
            toolTipControladorPublicidad.SetToolTip(button3, "\"Você pode carregar sua imagem aqui, aquela que aparece no marcador de pontos.\"");
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OrangeRed;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(190, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            toolTipControladorPublicidad.SetToolTip(pictureBox2, "Este é o banner encontrado no placar.");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(270, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(533, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            toolTipControladorPublicidad.SetToolTip(pictureBox1, "ilustração de anúncios.");
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Imagenes });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Margin = new Padding(3, 0, 3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(261, 294);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Imagenes
            // 
            Imagenes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            Imagenes.DefaultCellStyle = dataGridViewCellStyle1;
            Imagenes.HeaderText = "(Resolução sugerida: 1386; 788)";
            Imagenes.Name = "Imagenes";
            Imagenes.ReadOnly = true;
            Imagenes.Resizable = DataGridViewTriState.False;
            Imagenes.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTipControladorPublicidad
            // 
            toolTipControladorPublicidad.AutoPopDelay = 10000;
            toolTipControladorPublicidad.InitialDelay = 500;
            toolTipControladorPublicidad.ReshowDelay = 100;
            // 
            // FormControlPublicidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(812, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormControlPublicidad";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controlador de Imagens para Anúncios";
            FormClosed += FormControlPublicidad_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel4;
        internal DataGridView dataGridView1;
        internal Button buttonAgregarImagen;
        internal Button buttonEliminarImagen;
        internal PictureBox pictureBox1;
        internal Button button1;
        internal PictureBox pictureBox2;
        internal Button button2;
        private ToolTip toolTipControladorPublicidad;
        internal Button button3;
        private DataGridViewTextBoxColumn Imagenes;
    }
}