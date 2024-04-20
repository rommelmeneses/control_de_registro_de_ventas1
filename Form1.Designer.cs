namespace control_de_registro_de_ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            lblfecha=new Label();
            groupBox1=new GroupBox();
            lblprecio=new Label();
            label7=new Label();
            label6=new Label();
            label5=new Label();
            label4=new Label();
            txtcantidad=new TextBox();
            cbotipo=new ComboBox();
            cboproductos=new ComboBox();
            btnsalir=new Button();
            btncancelar=new Button();
            btnregistrar=new Button();
            lvventa=new ListView();
            columnHeader1=new ColumnHeader();
            columnHeader2=new ColumnHeader();
            columnHeader3=new ColumnHeader();
            columnHeader4=new ColumnHeader();
            columnHeader5=new ColumnHeader();
            columnHeader6=new ColumnHeader();
            columnHeader7=new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign=ContentAlignment.MiddleRight;
            label1.Location=new Point(177, 9);
            label1.Name="label1";
            label1.Size=new Size(264, 23);
            label1.TabIndex=0;
            label1.Text="control de registro de ventas";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(461, 47);
            label2.Name="label2";
            label2.Size=new Size(99, 18);
            label2.TabIndex=1;
            label2.Text="Fecha actual:";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize=true;
            lblfecha.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.Location=new Point(557, 47);
            lblfecha.Name="lblfecha";
            lblfecha.Size=new Size(65, 18);
            lblfecha.TabIndex=1;
            lblfecha.Text="lblfecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblprecio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(cbotipo);
            groupBox1.Controls.Add(cboproductos);
            groupBox1.Location=new Point(34, 90);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(635, 125);
            groupBox1.TabIndex=2;
            groupBox1.TabStop=false;
            groupBox1.Text="Area de ventas";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize=true;
            lblprecio.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblprecio.Location=new Point(391, 63);
            lblprecio.Name="lblprecio";
            lblprecio.Size=new Size(72, 18);
            lblprecio.TabIndex=11;
            lblprecio.Text="lblprecio";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location=new Point(254, 19);
            label7.Name="label7";
            label7.Size=new Size(73, 18);
            label7.TabIndex=10;
            label7.Text="Cantidad";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location=new Point(391, 37);
            label6.Name="label6";
            label6.Size=new Size(149, 18);
            label6.TabIndex=9;
            label6.Text="Precio del producto";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(33, 16);
            label5.Name="label5";
            label5.Size=new Size(151, 18);
            label5.TabIndex=8;
            label5.Text="seleccione producto";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(33, 63);
            label4.Name="label4";
            label4.Size=new Size(174, 18);
            label4.TabIndex=7;
            label4.Text="seleccione tipo de pago";
            // 
            // txtcantidad
            // 
            txtcantidad.Location=new Point(243, 37);
            txtcantidad.Name="txtcantidad";
            txtcantidad.Size=new Size(100, 23);
            txtcantidad.TabIndex=2;
            // 
            // cbotipo
            // 
            cbotipo.FormattingEnabled=true;
            cbotipo.Items.AddRange(new object[] { "contado", "tarjeta" });
            cbotipo.Location=new Point(33, 84);
            cbotipo.Name="cbotipo";
            cbotipo.Size=new Size(174, 23);
            cbotipo.TabIndex=1;
            // 
            // cboproductos
            // 
            cboproductos.FormattingEnabled=true;
            cboproductos.Items.AddRange(new object[] { "coleccion escolar", "coleccion preuniversitario", "coleccion profecional" });
            cboproductos.Location=new Point(33, 37);
            cboproductos.Name="cboproductos";
            cboproductos.Size=new Size(174, 23);
            cboproductos.TabIndex=0;
            cboproductos.SelectedIndexChanged+=cboproductos_SelectedIndexChanged;
            // 
            // btnsalir
            // 
            btnsalir.BackColor=Color.Yellow;
            btnsalir.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor=Color.DimGray;
            btnsalir.Location=new Point(599, 371);
            btnsalir.Name="btnsalir";
            btnsalir.Size=new Size(75, 23);
            btnsalir.TabIndex=4;
            btnsalir.Text="salir";
            btnsalir.UseVisualStyleBackColor=false;
            btnsalir.Click+=button1_Click;
            // 
            // btncancelar
            // 
            btncancelar.BackColor=Color.Yellow;
            btncancelar.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncancelar.ForeColor=Color.DimGray;
            btncancelar.Location=new Point(214, 221);
            btncancelar.Name="btncancelar";
            btncancelar.Size=new Size(103, 23);
            btncancelar.TabIndex=5;
            btncancelar.Text="Cancelar";
            btncancelar.UseVisualStyleBackColor=false;
            btncancelar.Click+=btncancelar_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor=Color.Yellow;
            btnregistrar.Font=new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnregistrar.ForeColor=Color.DimGray;
            btnregistrar.Location=new Point(323, 221);
            btnregistrar.Name="btnregistrar";
            btnregistrar.Size=new Size(101, 23);
            btnregistrar.TabIndex=6;
            btnregistrar.Text="Registrar";
            btnregistrar.UseVisualStyleBackColor=false;
            btnregistrar.Click+=btnregistrar_Click;
            // 
            // lvventa
            // 
            lvventa.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvventa.GridLines=true;
            lvventa.Location=new Point(25, 262);
            lvventa.Name="lvventa";
            lvventa.Size=new Size(644, 103);
            lvventa.TabIndex=7;
            lvventa.UseCompatibleStateImageBehavior=false;
            lvventa.View=View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text="Productos";
            // 
            // columnHeader2
            // 
            columnHeader2.Text="CANT";
            // 
            // columnHeader3
            // 
            columnHeader3.Text="PRECIO";
            // 
            // columnHeader4
            // 
            columnHeader4.Text="TIPO DE PAGO";
            // 
            // columnHeader5
            // 
            columnHeader5.Text="DESCUENTO";
            // 
            // columnHeader6
            // 
            columnHeader6.Text="RECARGO";
            // 
            // columnHeader7
            // 
            columnHeader7.Text="PRECIO FINAL";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(681, 406);
            Controls.Add(lvventa);
            Controls.Add(btnregistrar);
            Controls.Add(btncancelar);
            Controls.Add(btnsalir);
            Controls.Add(groupBox1);
            Controls.Add(lblfecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="control de registro de ventas";
            Load+=Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblfecha;
        private GroupBox groupBox1;
        private ComboBox cbotipo;
        private ComboBox cboproductos;
        private TextBox txtcantidad;
        private Button btnsalir;
        private Button btncancelar;
        private Button btnregistrar;
        private Label lblprecio;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListView lvventa;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}