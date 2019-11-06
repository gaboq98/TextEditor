namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox.Location = new System.Drawing.Point(0, 51);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(979, 486);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.textChangeEvent);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCopy.Location = new System.Drawing.Point(336, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 41);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCut.Location = new System.Drawing.Point(417, 4);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(75, 41);
            this.buttonCut.TabIndex = 2;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPaste.Location = new System.Drawing.Point(498, 4);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(75, 41);
            this.buttonPaste.TabIndex = 3;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonUndo.Location = new System.Drawing.Point(579, 4);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 41);
            this.buttonUndo.TabIndex = 4;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRedo.Location = new System.Drawing.Point(660, 4);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(75, 41);
            this.buttonRedo.TabIndex = 5;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = false;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNew.Location = new System.Drawing.Point(12, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 41);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpen.Location = new System.Drawing.Point(93, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 41);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave.Location = new System.Drawing.Point(174, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSaveAs.Location = new System.Drawing.Point(255, 4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 41);
            this.buttonSaveAs.TabIndex = 9;
            this.buttonSaveAs.Text = "SaveAs";
            this.buttonSaveAs.UseVisualStyleBackColor = false;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo TXT|*.txt|Archivo Tabulado|*.txt|Archivo CSV|*.csv|Archivo XML|*.xml|Arch" +
    "ivo JSON|*.json|Archivo RichTextFont|*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo TXT|*.txt|Archivo Tabulado|*.txt|Archivo CSV|*.csv|Archivo PDF|*.pdf|Arch" +
    "ivo XML|*.xml|Archivo JSON|*.json|Archivo RichTextFont|*.rtf";
            // 
            // buttonFont
            // 
            this.buttonFont.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFont.Location = new System.Drawing.Point(811, 4);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 41);
            this.buttonFont.TabIndex = 10;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = false;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.DarkGray;
            this.buttonColor.Location = new System.Drawing.Point(892, 4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 41);
            this.buttonColor.TabIndex = 11;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 537);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.richTextBox);
            this.Name = "MainForm";
            this.Text = "TextEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

