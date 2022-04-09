
namespace CapaPresentacion
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmensaje = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensaje:";
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(69, 410);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(758, 126);
            this.txtmensaje.TabIndex = 8;
            this.txtmensaje.Text = "";
            this.txtmensaje.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 233);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar Correo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(78, 106);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(292, 20);
            this.txtDe.TabIndex = 10;
            this.txtDe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPara
            // 
            this.txtPara.AcceptsReturn = true;
            this.txtPara.Location = new System.Drawing.Point(81, 193);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(292, 20);
            this.txtPara.TabIndex = 11;
            this.txtPara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(81, 295);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(292, 20);
            this.txtAsunto.TabIndex = 12;
            this.txtAsunto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 539);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtmensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
    }
}