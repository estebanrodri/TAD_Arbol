
namespace TAD_Arbol
{
    partial class Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.LabelPreOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostOrden = new System.Windows.Forms.Label();
            this.LabelEnOrden = new System.Windows.Forms.Label();
            this.txtEnOrden = new System.Windows.Forms.Label();
            this.txtPreOrden = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce una letra:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.Silver;
            this.btnGraficar.Location = new System.Drawing.Point(42, 100);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(144, 35);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar Árbol";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(246, 29);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(144, 26);
            this.txtExpresion.TabIndex = 2;
            // 
            // LabelPreOrden
            // 
            this.LabelPreOrden.AutoSize = true;
            this.LabelPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreOrden.ForeColor = System.Drawing.Color.SteelBlue;
            this.LabelPreOrden.Location = new System.Drawing.Point(432, 35);
            this.LabelPreOrden.Name = "LabelPreOrden";
            this.LabelPreOrden.Size = new System.Drawing.Size(90, 20);
            this.LabelPreOrden.TabIndex = 3;
            this.LabelPreOrden.Text = "PreOrden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(432, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postorden:";
            // 
            // txtPostOrden
            // 
            this.txtPostOrden.AutoSize = true;
            this.txtPostOrden.Location = new System.Drawing.Point(546, 115);
            this.txtPostOrden.Name = "txtPostOrden";
            this.txtPostOrden.Size = new System.Drawing.Size(0, 20);
            this.txtPostOrden.TabIndex = 5;
            // 
            // LabelEnOrden
            // 
            this.LabelEnOrden.AutoSize = true;
            this.LabelEnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnOrden.ForeColor = System.Drawing.Color.SteelBlue;
            this.LabelEnOrden.Location = new System.Drawing.Point(432, 72);
            this.LabelEnOrden.Name = "LabelEnOrden";
            this.LabelEnOrden.Size = new System.Drawing.Size(90, 20);
            this.LabelEnOrden.TabIndex = 6;
            this.LabelEnOrden.Text = "En Orden:";
            // 
            // txtEnOrden
            // 
            this.txtEnOrden.AutoSize = true;
            this.txtEnOrden.Location = new System.Drawing.Point(546, 72);
            this.txtEnOrden.Name = "txtEnOrden";
            this.txtEnOrden.Size = new System.Drawing.Size(0, 20);
            this.txtEnOrden.TabIndex = 7;
            // 
            // txtPreOrden
            // 
            this.txtPreOrden.AutoSize = true;
            this.txtPreOrden.Location = new System.Drawing.Point(546, 35);
            this.txtPreOrden.Name = "txtPreOrden";
            this.txtPreOrden.Size = new System.Drawing.Size(0, 20);
            this.txtPreOrden.TabIndex = 8;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(42, 162);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(992, 484);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarNodo.Location = new System.Drawing.Point(246, 100);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(144, 35);
            this.btnAgregarNodo.TabIndex = 10;
            this.btnAgregarNodo.Text = "Agregar Nodo";
            this.btnAgregarNodo.UseVisualStyleBackColor = false;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(418, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 658);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtPreOrden);
            this.Controls.Add(this.txtEnOrden);
            this.Controls.Add(this.LabelEnOrden);
            this.Controls.Add(this.txtPostOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelPreOrden);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario";
            this.Text = "Árbol de Letras";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label LabelPreOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPostOrden;
        private System.Windows.Forms.Label LabelEnOrden;
        private System.Windows.Forms.Label txtEnOrden;
        private System.Windows.Forms.Label txtPreOrden;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

