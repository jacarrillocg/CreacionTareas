﻿namespace CreaciónTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblComponentes = new System.Windows.Forms.DataGridView();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblResultado = new System.Windows.Forms.DataGridView();
            this.Título1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tblCategoryTask = new System.Windows.Forms.DataGridView();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TipoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcantidadFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnumerofilas = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryTask)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de item principal";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(189, 23);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(369, 22);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.Text = "RQM";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(189, 70);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(369, 22);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(189, 111);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(369, 22);
            this.txtTitulo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Título";
            // 
            // tblComponentes
            // 
            this.tblComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarea,
            this.TaskSize});
            this.tblComponentes.Location = new System.Drawing.Point(653, 34);
            this.tblComponentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblComponentes.Name = "tblComponentes";
            this.tblComponentes.RowHeadersWidth = 51;
            this.tblComponentes.RowTemplate.Height = 24;
            this.tblComponentes.Size = new System.Drawing.Size(928, 261);
            this.tblComponentes.TabIndex = 8;

            // 
            // Tarea
            // 
            this.Tarea.FillWeight = 70F;
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.MinimumWidth = 6;
            this.Tarea.Name = "Tarea";
            this.Tarea.Width = 300;
            // 
            // TaskSize
            // 
            this.TaskSize.HeaderText = "Size";
            this.TaskSize.MinimumWidth = 6;
            this.TaskSize.Name = "TaskSize";
            this.TaskSize.Width = 125;
            // 
            // tblResultado
            // 
            this.tblResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título1,
            this.Título2,
            this.OriginalEstimate});
            this.tblResultado.Location = new System.Drawing.Point(633, 354);
            this.tblResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblResultado.Name = "tblResultado";
            this.tblResultado.RowHeadersWidth = 51;
            this.tblResultado.RowTemplate.Height = 24;
            this.tblResultado.Size = new System.Drawing.Size(989, 465);
            this.tblResultado.TabIndex = 9;
            // 
            // Título1
            // 
            this.Título1.HeaderText = "Título1";
            this.Título1.MinimumWidth = 6;
            this.Título1.Name = "Título1";
            this.Título1.Width = 325;
            // 
            // Título2
            // 
            this.Título2.HeaderText = "Título2";
            this.Título2.MinimumWidth = 6;
            this.Título2.Name = "Título2";
            this.Título2.Width = 425;
            // 
            // OriginalEstimate
            // 
            this.OriginalEstimate.HeaderText = "OriginalEstimate";
            this.OriginalEstimate.MinimumWidth = 6;
            this.OriginalEstimate.Name = "OriginalEstimate";
            this.OriginalEstimate.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Componentes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1588, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pegar desde excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblCategoryTask
            // 
            this.tblCategoryTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCategoryTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.TipoTarea,
            this.Porcentaje});
            this.tblCategoryTask.Location = new System.Drawing.Point(12, 354);
            this.tblCategoryTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblCategoryTask.Name = "tblCategoryTask";
            this.tblCategoryTask.RowHeadersWidth = 51;
            this.tblCategoryTask.RowTemplate.Height = 24;
            this.tblCategoryTask.Size = new System.Drawing.Size(600, 465);
            this.tblCategoryTask.TabIndex = 15;
            // 
            // colSelected
            // 
            this.colSelected.HeaderText = "";
            this.colSelected.MinimumWidth = 6;
            this.colSelected.Name = "colSelected";
            this.colSelected.Width = 125;
            // 
            // TipoTarea
            // 
            this.TipoTarea.HeaderText = "Categoría Tarea";
            this.TipoTarea.MinimumWidth = 6;
            this.TipoTarea.Name = "TipoTarea";
            this.TipoTarea.Width = 125;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.MinimumWidth = 6;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 125;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1588, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 53);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categoría de tareas";

            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblcantidadFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 822);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1652, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";

            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabel2.Text = "Cantidad de filas";
            // 
            // lblcantidadFilas
            // 
            this.lblcantidadFilas.Name = "lblcantidadFilas";
            this.lblcantidadFilas.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel1.Text = "Total del filas:";
            // 
            // lblnumerofilas
            // 
            this.lblnumerofilas.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lblnumerofilas.Name = "lblnumerofilas";
            this.lblnumerofilas.Size = new System.Drawing.Size(0, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 848);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tblCategoryTask);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tblResultado);
            this.Controls.Add(this.tblComponentes);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryTask)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblComponentes;
        private System.Windows.Forms.DataGridView tblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalEstimate;
        private System.Windows.Forms.DataGridView tblCategoryTask;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblnumerofilas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblcantidadFilas;
    }
}

