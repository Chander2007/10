namespace WindowsFormsApp1
{
   partial class Form1
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
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.tbFullName = new System.Windows.Forms.TextBox();
         this.tbGender = new System.Windows.Forms.TextBox();
         this.tbNotes = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnAdd = new System.Windows.Forms.Button();
         this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
         this.dgvRegister = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(24, 39);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Ingrese la edad:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(27, 64);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(80, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Ingrese la nota:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(15, 90);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(92, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Ingrese el género:";
         // 
         // tbFullName
         // 
         this.tbFullName.Location = new System.Drawing.Point(109, 10);
         this.tbFullName.Name = "tbFullName";
         this.tbFullName.Size = new System.Drawing.Size(200, 20);
         this.tbFullName.TabIndex = 4;
         
         // 
         // tbGender
         // 
         this.tbGender.Location = new System.Drawing.Point(109, 87);
         this.tbGender.Name = "tbGender";
         this.tbGender.Size = new System.Drawing.Size(100, 20);
         this.tbGender.TabIndex = 5;
         
         // 
         // tbNotes
         // 
         this.tbNotes.Location = new System.Drawing.Point(109, 61);
         this.tbNotes.Name = "tbNotes";
         this.tbNotes.Size = new System.Drawing.Size(52, 20);
         this.tbNotes.TabIndex = 6;
         
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ingrese el nombre:";
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(234, 87);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 8;
         this.btnAdd.Text = "Agregar";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // dateTimePickerBirthdate
         // 
         this.dateTimePickerBirthdate.Location = new System.Drawing.Point(109, 36);
         this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
         this.dateTimePickerBirthdate.Size = new System.Drawing.Size(200, 20);
         this.dateTimePickerBirthdate.TabIndex = 9;
         
         // 
         // dgvRegister
         // 
         this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvRegister.Location = new System.Drawing.Point(18, 136);
         this.dgvRegister.Name = "dgvRegister";
         this.dgvRegister.Size = new System.Drawing.Size(291, 192);
         this.dgvRegister.TabIndex = 10;
         
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dgvRegister);
         this.Controls.Add(this.dateTimePickerBirthdate);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.tbNotes);
         this.Controls.Add(this.tbGender);
         this.Controls.Add(this.tbFullName);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox tbFullName;
      private System.Windows.Forms.TextBox tbGender;
      private System.Windows.Forms.TextBox tbNotes;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
      private System.Windows.Forms.DataGridView dgvRegister;
   }
}

