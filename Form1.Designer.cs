
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxVersiculo = new System.Windows.Forms.ComboBox();
            this.CBoxCapitulo = new System.Windows.Forms.ComboBox();
            this.CBoxLibro = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RichTxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBoxVersiculo);
            this.panel1.Controls.Add(this.CBoxCapitulo);
            this.panel1.Controls.Add(this.CBoxLibro);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(844, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Versiculos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capitulos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
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
            this.CBoxVersiculo.Location = new System.Drawing.Point(765, 50);
            this.CBoxVersiculo.Name = "CBoxVersiculo";
            this.CBoxVersiculo.Size = new System.Drawing.Size(258, 28);
            this.CBoxVersiculo.TabIndex = 2;
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
            this.CBoxCapitulo.Location = new System.Drawing.Point(361, 50);
            this.CBoxCapitulo.Name = "CBoxCapitulo";
            this.CBoxCapitulo.Size = new System.Drawing.Size(275, 28);
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
            this.CBoxLibro.Location = new System.Drawing.Point(27, 49);
            this.CBoxLibro.Name = "CBoxLibro";
            this.CBoxLibro.Size = new System.Drawing.Size(237, 28);
            this.CBoxLibro.TabIndex = 0;
            this.CBoxLibro.SelectedIndexChanged += new System.EventHandler(this.CBoxLibro_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.RichTxt);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 678);
            this.panel2.TabIndex = 1;
            // 
            // RichTxt
            // 
            this.RichTxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.RichTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.RichTxt.Location = new System.Drawing.Point(0, 0);
            this.RichTxt.Margin = new System.Windows.Forms.Padding(5);
            this.RichTxt.Name = "RichTxt";
            this.RichTxt.Size = new System.Drawing.Size(1389, 678);
            this.RichTxt.TabIndex = 0;
            this.RichTxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 778);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1407, 825);
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
    }
}

