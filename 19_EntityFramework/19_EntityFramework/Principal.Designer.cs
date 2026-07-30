namespace _19_EntityFramework
{
    partial class Principal
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
            Grid1 = new DataGridView();
            botonAgregar = new Button();
            botonEditar = new Button();
            botonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid1).BeginInit();
            SuspendLayout();
            // 
            // Grid1
            // 
            Grid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid1.Location = new Point(12, 12);
            Grid1.Name = "Grid1";
            Grid1.Size = new Size(776, 412);
            Grid1.TabIndex = 0;
            Grid1.CellContentClick += Grid1_CellContentClick;
            // 
            // botonAgregar
            // 
            botonAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            botonAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAgregar.Location = new Point(12, 433);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(120, 41);
            botonAgregar.TabIndex = 1;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // botonEditar
            // 
            botonEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            botonEditar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonEditar.Location = new Point(138, 433);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(120, 41);
            botonEditar.TabIndex = 2;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            botonEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonEliminar.Location = new Point(483, 433);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(120, 41);
            botonEliminar.TabIndex = 3;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(botonEliminar);
            Controls.Add(botonEditar);
            Controls.Add(botonAgregar);
            Controls.Add(Grid1);
            Name = "Principal";
            Text = "Gerardo Portillo 20012002049";
            Load += Principal_Load;
            SizeChanged += Principal_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)Grid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid1;
        private Button botonAgregar;
        private Button botonEditar;
        private Button botonEliminar;
    }
}
