namespace _19_EntityFramework
{
    partial class Detalle
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
            label1 = new Label();
            Codigo = new TextBox();
            Nombre = new TextBox();
            label2 = new Label();
            Costo = new TextBox();
            label3 = new Label();
            PrecioVenta = new TextBox();
            label4 = new Label();
            Existencias = new TextBox();
            label5 = new Label();
            Observaciones = new TextBox();
            label6 = new Label();
            botonCancelar = new Button();
            botonAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // Codigo
            // 
            Codigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo.Location = new Point(204, 12);
            Codigo.MaxLength = 20;
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(281, 39);
            Codigo.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(204, 57);
            Nombre.MaxLength = 255;
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(519, 39);
            Nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 60);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // Costo
            // 
            Costo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Costo.Location = new Point(204, 102);
            Costo.Name = "Costo";
            Costo.Size = new Size(189, 39);
            Costo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 105);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 4;
            label3.Text = "Costo:";
            // 
            // PrecioVenta
            // 
            PrecioVenta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioVenta.Location = new Point(204, 147);
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Size = new Size(281, 39);
            PrecioVenta.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 150);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 6;
            label4.Text = "Precio de Venta:";
            // 
            // Existencias
            // 
            Existencias.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Existencias.Location = new Point(204, 192);
            Existencias.Name = "Existencias";
            Existencias.Size = new Size(281, 39);
            Existencias.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 195);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 8;
            label5.Text = "Existencias:";
            // 
            // Observaciones
            // 
            Observaciones.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Observaciones.Location = new Point(204, 237);
            Observaciones.Multiline = true;
            Observaciones.Name = "Observaciones";
            Observaciones.Size = new Size(519, 187);
            Observaciones.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 240);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 10;
            label6.Text = "Observaciones:";
            // 
            // botonCancelar
            // 
            botonCancelar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonCancelar.Location = new Point(580, 441);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(143, 60);
            botonCancelar.TabIndex = 12;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonAceptar
            // 
            botonAceptar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAceptar.Location = new Point(431, 441);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(143, 60);
            botonAceptar.TabIndex = 13;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            botonAceptar.Click += botonAceptar_Click;
            // 
            // Detalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 513);
            Controls.Add(botonAceptar);
            Controls.Add(botonCancelar);
            Controls.Add(Observaciones);
            Controls.Add(label6);
            Controls.Add(Existencias);
            Controls.Add(label5);
            Controls.Add(PrecioVenta);
            Controls.Add(label4);
            Controls.Add(Costo);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(Codigo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Detalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button botonCancelar;
        private Button botonAceptar;
        public TextBox Codigo;
        public TextBox Nombre;
        public TextBox Costo;
        public TextBox PrecioVenta;
        public TextBox Existencias;
        public TextBox Observaciones;
    }
}