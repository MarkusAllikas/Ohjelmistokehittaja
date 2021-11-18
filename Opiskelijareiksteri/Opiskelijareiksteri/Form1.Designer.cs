
namespace Opiskelijareiksteri
{
    partial class Form1
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
            this.OidLB = new System.Windows.Forms.Label();
            this.opiskelijaid = new System.Windows.Forms.TextBox();
            this.enimiLB = new System.Windows.Forms.Label();
            this.etunimi = new System.Windows.Forms.TextBox();
            this.snimiLB = new System.Windows.Forms.Label();
            this.sukunimi = new System.Windows.Forms.TextBox();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.spostiLB = new System.Windows.Forms.Label();
            this.OnroLB = new System.Windows.Forms.Label();
            this.puhelin = new System.Windows.Forms.TextBox();
            this.sahkoposti = new System.Windows.Forms.TextBox();
            this.opiskelijanro = new System.Windows.Forms.TextBox();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OidLB
            // 
            this.OidLB.AutoSize = true;
            this.OidLB.Location = new System.Drawing.Point(12, 49);
            this.OidLB.Name = "OidLB";
            this.OidLB.Size = new System.Drawing.Size(21, 13);
            this.OidLB.TabIndex = 0;
            this.OidLB.Text = "ID:";
            this.OidLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // opiskelijaid
            // 
            this.opiskelijaid.Location = new System.Drawing.Point(69, 42);
            this.opiskelijaid.Name = "opiskelijaid";
            this.opiskelijaid.Size = new System.Drawing.Size(136, 20);
            this.opiskelijaid.TabIndex = 1;
            // 
            // enimiLB
            // 
            this.enimiLB.AutoSize = true;
            this.enimiLB.Location = new System.Drawing.Point(12, 77);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(44, 13);
            this.enimiLB.TabIndex = 2;
            this.enimiLB.Text = "Etunimi:";
            // 
            // etunimi
            // 
            this.etunimi.Location = new System.Drawing.Point(69, 70);
            this.etunimi.Name = "etunimi";
            this.etunimi.Size = new System.Drawing.Size(136, 20);
            this.etunimi.TabIndex = 3;
            // 
            // snimiLB
            // 
            this.snimiLB.AutoSize = true;
            this.snimiLB.Location = new System.Drawing.Point(13, 107);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(53, 13);
            this.snimiLB.TabIndex = 4;
            this.snimiLB.Text = "Sukunimi:";
            // 
            // sukunimi
            // 
            this.sukunimi.Location = new System.Drawing.Point(69, 100);
            this.sukunimi.Name = "sukunimi";
            this.sukunimi.Size = new System.Drawing.Size(136, 20);
            this.sukunimi.TabIndex = 5;
            this.sukunimi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(235, 48);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(45, 13);
            this.puhelinLB.TabIndex = 6;
            this.puhelinLB.Text = "Puhelin:";
            // 
            // spostiLB
            // 
            this.spostiLB.AutoSize = true;
            this.spostiLB.Location = new System.Drawing.Point(235, 77);
            this.spostiLB.Name = "spostiLB";
            this.spostiLB.Size = new System.Drawing.Size(63, 13);
            this.spostiLB.TabIndex = 7;
            this.spostiLB.Text = "Sähköposti:";
            // 
            // OnroLB
            // 
            this.OnroLB.AutoSize = true;
            this.OnroLB.Location = new System.Drawing.Point(238, 106);
            this.OnroLB.Name = "OnroLB";
            this.OnroLB.Size = new System.Drawing.Size(70, 13);
            this.OnroLB.TabIndex = 8;
            this.OnroLB.Text = "Opiskelijanro:";
            // 
            // puhelin
            // 
            this.puhelin.Location = new System.Drawing.Point(331, 41);
            this.puhelin.Name = "puhelin";
            this.puhelin.Size = new System.Drawing.Size(136, 20);
            this.puhelin.TabIndex = 9;
            // 
            // sahkoposti
            // 
            this.sahkoposti.Location = new System.Drawing.Point(331, 69);
            this.sahkoposti.Name = "sahkoposti";
            this.sahkoposti.Size = new System.Drawing.Size(136, 20);
            this.sahkoposti.TabIndex = 10;
            // 
            // opiskelijanro
            // 
            this.opiskelijanro.Location = new System.Drawing.Point(331, 99);
            this.opiskelijanro.Name = "opiskelijanro";
            this.opiskelijanro.Size = new System.Drawing.Size(136, 20);
            this.opiskelijanro.TabIndex = 11;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(12, 154);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(113, 29);
            this.TyhjennaBT.TabIndex = 12;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(131, 154);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(113, 29);
            this.TallennaBT.TabIndex = 13;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = true;
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(250, 154);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(114, 29);
            this.PaivitaBT.TabIndex = 14;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(370, 154);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(113, 29);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1193, 429);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.opiskelijanro);
            this.Controls.Add(this.sahkoposti);
            this.Controls.Add(this.puhelin);
            this.Controls.Add(this.OnroLB);
            this.Controls.Add(this.spostiLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.sukunimi);
            this.Controls.Add(this.snimiLB);
            this.Controls.Add(this.etunimi);
            this.Controls.Add(this.enimiLB);
            this.Controls.Add(this.opiskelijaid);
            this.Controls.Add(this.OidLB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OidLB;
        private System.Windows.Forms.TextBox opiskelijaid;
        private System.Windows.Forms.Label enimiLB;
        private System.Windows.Forms.TextBox etunimi;
        private System.Windows.Forms.Label snimiLB;
        private System.Windows.Forms.TextBox sukunimi;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label spostiLB;
        private System.Windows.Forms.Label OnroLB;
        private System.Windows.Forms.TextBox puhelin;
        private System.Windows.Forms.TextBox sahkoposti;
        private System.Windows.Forms.TextBox opiskelijanro;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

