
namespace Biblia_Reina_valera_Vs._1960
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxVersiculo = new System.Windows.Forms.ComboBox();
            this.CBoxCapitulo = new System.Windows.Forms.ComboBox();
            this.CBoxLibro = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RichTxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBoxVersiculo);
            this.panel1.Controls.Add(this.CBoxCapitulo);
            this.panel1.Controls.Add(this.CBoxLibro);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 81);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.Location = new System.Drawing.Point(456, 2);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Buscar rango de versiculos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(633, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Versiculos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(337, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capitulos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libros";
            // 
            // CBoxVersiculo
            // 
            this.CBoxVersiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBoxVersiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxVersiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVersiculo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBoxVersiculo.FormattingEnabled = true;
            this.CBoxVersiculo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBoxVersiculo.Location = new System.Drawing.Point(574, 41);
            this.CBoxVersiculo.Margin = new System.Windows.Forms.Padding(2);
            this.CBoxVersiculo.Name = "CBoxVersiculo";
            this.CBoxVersiculo.Size = new System.Drawing.Size(194, 25);
            this.CBoxVersiculo.TabIndex = 2;
            this.CBoxVersiculo.DropDown += new System.EventHandler(this.CBoxVersiculo_DropDown);
            this.CBoxVersiculo.SelectedIndexChanged += new System.EventHandler(this.CBoxVersiculo_SelectedIndexChanged);
            // 
            // CBoxCapitulo
            // 
            this.CBoxCapitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBoxCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCapitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCapitulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBoxCapitulo.FormattingEnabled = true;
            this.CBoxCapitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBoxCapitulo.Location = new System.Drawing.Point(271, 41);
            this.CBoxCapitulo.Margin = new System.Windows.Forms.Padding(2);
            this.CBoxCapitulo.Name = "CBoxCapitulo";
            this.CBoxCapitulo.Size = new System.Drawing.Size(207, 25);
            this.CBoxCapitulo.TabIndex = 1;
            this.CBoxCapitulo.SelectedIndexChanged += new System.EventHandler(this.CBoxCapitulo_SelectedIndexChanged_1);
            // 
            // CBoxLibro
            // 
            this.CBoxLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBoxLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxLibro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBoxLibro.FormattingEnabled = true;
            this.CBoxLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBoxLibro.Location = new System.Drawing.Point(20, 40);
            this.CBoxLibro.Margin = new System.Windows.Forms.Padding(2);
            this.CBoxLibro.Name = "CBoxLibro";
            this.CBoxLibro.Size = new System.Drawing.Size(179, 25);
            this.CBoxLibro.TabIndex = 0;
            this.CBoxLibro.SelectedIndexChanged += new System.EventHandler(this.CBoxLibro_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.RichTxt);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 551);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(574, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(194, 497);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RichTxt
            // 
            this.RichTxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.RichTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.RichTxt.Location = new System.Drawing.Point(0, 0);
            this.RichTxt.Margin = new System.Windows.Forms.Padding(4);
            this.RichTxt.Name = "RichTxt";
            this.RichTxt.Size = new System.Drawing.Size(1042, 551);
            this.RichTxt.TabIndex = 0;
            this.RichTxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1043, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1059, 678);
            this.Name = "Form1";
            this.Text = "Santa_Biblia_Reina_Valera 1960 vs. -1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxVersiculo;
        private System.Windows.Forms.ComboBox CBoxCapitulo;
        private System.Windows.Forms.ComboBox CBoxLibro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

