namespace CapaPresentacion.Formularios
{
    partial class frmCrearCuenta
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCuenta));
            this.RoundedCorners = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCrear = new RJCodeAdvance.RJControls.RJButton();
            this.btnInicar_Sesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboContraseña = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.gboConfimación = new System.Windows.Forms.GroupBox();
            this.txtConfirmar_Pass = new System.Windows.Forms.TextBox();
            this.gboUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gboCorreo = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.gboNombre = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MoveForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.txtidusuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboContraseña.SuspendLayout();
            this.gboConfimación.SuspendLayout();
            this.gboUsuario.SuspendLayout();
            this.gboCorreo.SuspendLayout();
            this.gboNombre.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundedCorners
            // 
            this.RoundedCorners.ElipseRadius = 20;
            this.RoundedCorners.TargetControl = this;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.btnCrear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.btnCrear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrear.BorderRadius = 5;
            this.btnCrear.BorderSize = 0;
            this.bunifuTransition1.SetDecoration(this.btnCrear, BunifuAnimatorNS.DecorationType.None);
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(287, 369);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(156, 24);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnInicar_Sesion
            // 
            this.btnInicar_Sesion.Activecolor = System.Drawing.SystemColors.Control;
            this.btnInicar_Sesion.BackColor = System.Drawing.Color.White;
            this.btnInicar_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicar_Sesion.BorderRadius = 0;
            this.btnInicar_Sesion.ButtonText = "Prefiero iniciar sesión";
            this.btnInicar_Sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnInicar_Sesion, BunifuAnimatorNS.DecorationType.None);
            this.btnInicar_Sesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicar_Sesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicar_Sesion.Iconimage = null;
            this.btnInicar_Sesion.Iconimage_right = null;
            this.btnInicar_Sesion.Iconimage_right_Selected = null;
            this.btnInicar_Sesion.Iconimage_Selected = null;
            this.btnInicar_Sesion.IconMarginLeft = 0;
            this.btnInicar_Sesion.IconMarginRight = 0;
            this.btnInicar_Sesion.IconRightVisible = true;
            this.btnInicar_Sesion.IconRightZoom = 0D;
            this.btnInicar_Sesion.IconVisible = true;
            this.btnInicar_Sesion.IconZoom = 90D;
            this.btnInicar_Sesion.IsTab = false;
            this.btnInicar_Sesion.Location = new System.Drawing.Point(70, 369);
            this.btnInicar_Sesion.Name = "btnInicar_Sesion";
            this.btnInicar_Sesion.Normalcolor = System.Drawing.Color.White;
            this.btnInicar_Sesion.OnHovercolor = System.Drawing.Color.White;
            this.btnInicar_Sesion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.btnInicar_Sesion.selected = false;
            this.btnInicar_Sesion.Size = new System.Drawing.Size(148, 25);
            this.btnInicar_Sesion.TabIndex = 39;
            this.btnInicar_Sesion.Text = "Prefiero iniciar sesión";
            this.btnInicar_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicar_Sesion.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.btnInicar_Sesion.TextFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicar_Sesion.Click += new System.EventHandler(this.btnInicar_Sesion_Click);
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.chkMostrar, BunifuAnimatorNS.DecorationType.None);
            this.chkMostrar.Location = new System.Drawing.Point(70, 306);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(118, 17);
            this.chkMostrar.TabIndex = 38;
            this.chkMostrar.Text = "Mostrar Contraseña";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.IMG_20220514_183745;
            this.pictureBox1.Location = new System.Drawing.Point(371, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(184, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Crear Cuenta";
            // 
            // gboContraseña
            // 
            this.gboContraseña.Controls.Add(this.txtContraseña);
            this.bunifuTransition1.SetDecoration(this.gboContraseña, BunifuAnimatorNS.DecorationType.None);
            this.gboContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.gboContraseña.Location = new System.Drawing.Point(70, 249);
            this.gboContraseña.Name = "gboContraseña";
            this.gboContraseña.Size = new System.Drawing.Size(177, 40);
            this.gboContraseña.TabIndex = 32;
            this.gboContraseña.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtContraseña, BunifuAnimatorNS.DecorationType.None);
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(6, 14);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(165, 19);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // gboConfimación
            // 
            this.gboConfimación.Controls.Add(this.txtConfirmar_Pass);
            this.bunifuTransition1.SetDecoration(this.gboConfimación, BunifuAnimatorNS.DecorationType.None);
            this.gboConfimación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboConfimación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.gboConfimación.Location = new System.Drawing.Point(272, 249);
            this.gboConfimación.Name = "gboConfimación";
            this.gboConfimación.Size = new System.Drawing.Size(177, 40);
            this.gboConfimación.TabIndex = 35;
            this.gboConfimación.TabStop = false;
            // 
            // txtConfirmar_Pass
            // 
            this.txtConfirmar_Pass.BackColor = System.Drawing.Color.White;
            this.txtConfirmar_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtConfirmar_Pass, BunifuAnimatorNS.DecorationType.None);
            this.txtConfirmar_Pass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar_Pass.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmar_Pass.Location = new System.Drawing.Point(6, 14);
            this.txtConfirmar_Pass.Name = "txtConfirmar_Pass";
            this.txtConfirmar_Pass.Size = new System.Drawing.Size(165, 19);
            this.txtConfirmar_Pass.TabIndex = 4;
            this.txtConfirmar_Pass.Text = "Confirmación";
            this.txtConfirmar_Pass.Enter += new System.EventHandler(this.txtConfirmar_Pass_Enter);
            this.txtConfirmar_Pass.Leave += new System.EventHandler(this.txtConfirmar_Pass_Leave);
            // 
            // gboUsuario
            // 
            this.gboUsuario.Controls.Add(this.txtUsuario);
            this.bunifuTransition1.SetDecoration(this.gboUsuario, BunifuAnimatorNS.DecorationType.None);
            this.gboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.gboUsuario.Location = new System.Drawing.Point(272, 105);
            this.gboUsuario.Name = "gboUsuario";
            this.gboUsuario.Size = new System.Drawing.Size(177, 42);
            this.gboUsuario.TabIndex = 33;
            this.gboUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(6, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(165, 19);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // gboCorreo
            // 
            this.gboCorreo.Controls.Add(this.txtCorreo);
            this.bunifuTransition1.SetDecoration(this.gboCorreo, BunifuAnimatorNS.DecorationType.None);
            this.gboCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.gboCorreo.Location = new System.Drawing.Point(70, 177);
            this.gboCorreo.Name = "gboCorreo";
            this.gboCorreo.Size = new System.Drawing.Size(379, 41);
            this.gboCorreo.TabIndex = 34;
            this.gboCorreo.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtCorreo, BunifuAnimatorNS.DecorationType.None);
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(6, 15);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(367, 19);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // gboNombre
            // 
            this.gboNombre.Controls.Add(this.txtNombre);
            this.bunifuTransition1.SetDecoration(this.gboNombre, BunifuAnimatorNS.DecorationType.None);
            this.gboNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(34)))));
            this.gboNombre.Location = new System.Drawing.Point(70, 105);
            this.gboNombre.Name = "gboNombre";
            this.gboNombre.Size = new System.Drawing.Size(177, 42);
            this.gboNombre.TabIndex = 31;
            this.gboNombre.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(6, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 19);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(94)))), ((int)(((byte)(21)))));
            this.panelTitle.Controls.Add(this.btnMinimizar);
            this.panelTitle.Controls.Add(this.btnCerrar);
            this.bunifuTransition1.SetDecoration(this.panelTitle, BunifuAnimatorNS.DecorationType.None);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(502, 20);
            this.panelTitle.TabIndex = 41;
            // 
            // btnMinimizar
            // 
            this.bunifuTransition1.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(442, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 22;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.bunifuTransition1.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(472, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MoveForm
            // 
            this.MoveForm.Fixed = true;
            this.MoveForm.Horizontal = true;
            this.MoveForm.TargetControl = this.panelTitle;
            this.MoveForm.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 1400;
            // 
            // txtidusuario
            // 
            this.bunifuTransition1.SetDecoration(this.txtidusuario, BunifuAnimatorNS.DecorationType.None);
            this.txtidusuario.Location = new System.Drawing.Point(442, 26);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(34, 20);
            this.txtidusuario.TabIndex = 42;
            this.txtidusuario.Text = "0";
            this.txtidusuario.Visible = false;
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 417);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnInicar_Sesion);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboContraseña);
            this.Controls.Add(this.gboConfimación);
            this.Controls.Add(this.gboUsuario);
            this.Controls.Add(this.gboCorreo);
            this.Controls.Add(this.gboNombre);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboContraseña.ResumeLayout(false);
            this.gboContraseña.PerformLayout();
            this.gboConfimación.ResumeLayout(false);
            this.gboConfimación.PerformLayout();
            this.gboUsuario.ResumeLayout(false);
            this.gboUsuario.PerformLayout();
            this.gboCorreo.ResumeLayout(false);
            this.gboCorreo.PerformLayout();
            this.gboNombre.ResumeLayout(false);
            this.gboNombre.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse RoundedCorners;
        private RJCodeAdvance.RJControls.RJButton btnCrear;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicar_Sesion;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.GroupBox gboConfimación;
        private System.Windows.Forms.TextBox txtConfirmar_Pass;
        private System.Windows.Forms.GroupBox gboUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gboCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox gboNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl MoveForm;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.TextBox txtidusuario;
    }
}