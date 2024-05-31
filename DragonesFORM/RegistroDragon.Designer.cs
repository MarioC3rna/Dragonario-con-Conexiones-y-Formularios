namespace DragonesFORM
{
    partial class RegistroDragon
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
            this.bttonTabla = new System.Windows.Forms.Button();
            this.bttonInsert = new System.Windows.Forms.Button();
            this.bttonLimpiar = new System.Windows.Forms.Button();
            this.bttonUpdate = new System.Windows.Forms.Button();
            this.bttonDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.bttonSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtAgilidad = new System.Windows.Forms.TextBox();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtInteligencia = new System.Windows.Forms.TextBox();
            this.txtCarisma = new System.Windows.Forms.TextBox();
            this.txtDefensa = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttonTabla
            // 
            this.bttonTabla.BackColor = System.Drawing.Color.Transparent;
            this.bttonTabla.BackgroundImage = global::DragonesFORM.Properties.Resources.tabla12;
            this.bttonTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonTabla.Location = new System.Drawing.Point(20, 19);
            this.bttonTabla.Name = "bttonTabla";
            this.bttonTabla.Size = new System.Drawing.Size(182, 84);
            this.bttonTabla.TabIndex = 0;
            this.bttonTabla.UseVisualStyleBackColor = false;
            this.bttonTabla.Click += new System.EventHandler(this.bttonTabla_Click);
            // 
            // bttonInsert
            // 
            this.bttonInsert.BackgroundImage = global::DragonesFORM.Properties.Resources.insertpe;
            this.bttonInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonInsert.Location = new System.Drawing.Point(20, 114);
            this.bttonInsert.Name = "bttonInsert";
            this.bttonInsert.Size = new System.Drawing.Size(160, 87);
            this.bttonInsert.TabIndex = 1;
            this.bttonInsert.UseVisualStyleBackColor = true;
            this.bttonInsert.Click += new System.EventHandler(this.bttonInsert_Click);
            // 
            // bttonLimpiar
            // 
            this.bttonLimpiar.BackgroundImage = global::DragonesFORM.Properties.Resources.tablape;
            this.bttonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonLimpiar.Location = new System.Drawing.Point(16, 218);
            this.bttonLimpiar.Name = "bttonLimpiar";
            this.bttonLimpiar.Size = new System.Drawing.Size(164, 84);
            this.bttonLimpiar.TabIndex = 2;
            this.bttonLimpiar.UseVisualStyleBackColor = true;
            this.bttonLimpiar.Click += new System.EventHandler(this.bttonLimpiar_Click);
            // 
            // bttonUpdate
            // 
            this.bttonUpdate.BackgroundImage = global::DragonesFORM.Properties.Resources.updatepe;
            this.bttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonUpdate.Location = new System.Drawing.Point(222, 17);
            this.bttonUpdate.Name = "bttonUpdate";
            this.bttonUpdate.Size = new System.Drawing.Size(166, 88);
            this.bttonUpdate.TabIndex = 3;
            this.bttonUpdate.UseVisualStyleBackColor = true;
            this.bttonUpdate.Click += new System.EventHandler(this.bttonUpdate_Click_1);
            // 
            // bttonDelete
            // 
            this.bttonDelete.BackgroundImage = global::DragonesFORM.Properties.Resources.deletepe;
            this.bttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonDelete.Location = new System.Drawing.Point(222, 117);
            this.bttonDelete.Name = "bttonDelete";
            this.bttonDelete.Size = new System.Drawing.Size(166, 84);
            this.bttonDelete.TabIndex = 4;
            this.bttonDelete.UseVisualStyleBackColor = true;
            this.bttonDelete.Click += new System.EventHandler(this.bttonDelete_Click_1);
            // 
            // gbox1
            // 
            this.gbox1.BackgroundImage = global::DragonesFORM.Properties.Resources.lirbcrfds;
            this.gbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbox1.Controls.Add(this.bttonSiguiente);
            this.gbox1.Controls.Add(this.bttonTabla);
            this.gbox1.Controls.Add(this.bttonLimpiar);
            this.gbox1.Controls.Add(this.bttonDelete);
            this.gbox1.Controls.Add(this.bttonInsert);
            this.gbox1.Controls.Add(this.bttonUpdate);
            this.gbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbox1.Location = new System.Drawing.Point(12, 12);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(412, 322);
            this.gbox1.TabIndex = 5;
            this.gbox1.TabStop = false;
            this.gbox1.Enter += new System.EventHandler(this.gbox1_Enter);
            // 
            // bttonSiguiente
            // 
            this.bttonSiguiente.BackgroundImage = global::DragonesFORM.Properties.Resources.siguientepe;
            this.bttonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttonSiguiente.Location = new System.Drawing.Point(222, 218);
            this.bttonSiguiente.Name = "bttonSiguiente";
            this.bttonSiguiente.Size = new System.Drawing.Size(177, 83);
            this.bttonSiguiente.TabIndex = 5;
            this.bttonSiguiente.UseVisualStyleBackColor = true;
            this.bttonSiguiente.Click += new System.EventHandler(this.bttonSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Habitat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fuerza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(738, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agilidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resistencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Velocidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "Inteligencia ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(692, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 33);
            this.label10.TabIndex = 16;
            this.label10.Text = "Carisma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(703, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 33);
            this.label11.TabIndex = 17;
            this.label11.Text = "Defensa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(709, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 33);
            this.label12.TabIndex = 18;
            this.label12.Text = "Experiencia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(500, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 33);
            this.label13.TabIndex = 19;
            this.label13.Text = "Descripcion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(506, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 38);
            this.label14.TabIndex = 20;
            this.label14.Text = "No";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(554, 20);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(116, 31);
            this.txtNo.TabIndex = 21;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNombre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(775, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 31);
            this.txtNombre.TabIndex = 22;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTipo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(554, 57);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(158, 31);
            this.txtTipo.TabIndex = 23;
            // 
            // txtHabitat
            // 
            this.txtHabitat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtHabitat.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitat.Location = new System.Drawing.Point(794, 57);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(149, 31);
            this.txtHabitat.TabIndex = 24;
            // 
            // txtActivo
            // 
            this.txtActivo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtActivo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.Location = new System.Drawing.Point(660, 95);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(168, 31);
            this.txtActivo.TabIndex = 25;
            // 
            // txtFuerza
            // 
            this.txtFuerza.BackColor = System.Drawing.Color.Moccasin;
            this.txtFuerza.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuerza.Location = new System.Drawing.Point(588, 148);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(82, 31);
            this.txtFuerza.TabIndex = 26;
            // 
            // txtAgilidad
            // 
            this.txtAgilidad.BackColor = System.Drawing.Color.Moccasin;
            this.txtAgilidad.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgilidad.Location = new System.Drawing.Point(841, 270);
            this.txtAgilidad.Name = "txtAgilidad";
            this.txtAgilidad.Size = new System.Drawing.Size(68, 27);
            this.txtAgilidad.TabIndex = 27;
            // 
            // txtResistencia
            // 
            this.txtResistencia.BackColor = System.Drawing.Color.Moccasin;
            this.txtResistencia.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResistencia.Location = new System.Drawing.Point(608, 185);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(82, 31);
            this.txtResistencia.TabIndex = 28;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.BackColor = System.Drawing.Color.Moccasin;
            this.txtVelocidad.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidad.Location = new System.Drawing.Point(621, 230);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(82, 27);
            this.txtVelocidad.TabIndex = 29;
            // 
            // txtInteligencia
            // 
            this.txtInteligencia.BackColor = System.Drawing.Color.Moccasin;
            this.txtInteligencia.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteligencia.Location = new System.Drawing.Point(638, 274);
            this.txtInteligencia.Name = "txtInteligencia";
            this.txtInteligencia.Size = new System.Drawing.Size(82, 27);
            this.txtInteligencia.TabIndex = 30;
            // 
            // txtCarisma
            // 
            this.txtCarisma.BackColor = System.Drawing.Color.Moccasin;
            this.txtCarisma.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarisma.Location = new System.Drawing.Point(794, 141);
            this.txtCarisma.Name = "txtCarisma";
            this.txtCarisma.Size = new System.Drawing.Size(66, 27);
            this.txtCarisma.TabIndex = 31;
            this.txtCarisma.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtDefensa
            // 
            this.txtDefensa.BackColor = System.Drawing.Color.Moccasin;
            this.txtDefensa.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefensa.Location = new System.Drawing.Point(794, 182);
            this.txtDefensa.Name = "txtDefensa";
            this.txtDefensa.Size = new System.Drawing.Size(66, 27);
            this.txtDefensa.TabIndex = 32;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.BackColor = System.Drawing.Color.Moccasin;
            this.txtExperiencia.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExperiencia.Location = new System.Drawing.Point(841, 230);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(68, 27);
            this.txtExperiencia.TabIndex = 33;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Moccasin;
            this.txtDescripcion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(502, 350);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(460, 20);
            this.txtDescripcion.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 396);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(450, 241);
            this.dataGridView1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DragonesFORM.Properties.Resources.chillidocolor;
            this.pictureBox1.Location = new System.Drawing.Point(32, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 263);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroDragon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonesFORM.Properties.Resources.lirbcrfds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(974, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtDefensa);
            this.Controls.Add(this.txtCarisma);
            this.Controls.Add(this.txtInteligencia);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtResistencia);
            this.Controls.Add(this.txtAgilidad);
            this.Controls.Add(this.txtFuerza);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbox1);
            this.Name = "RegistroDragon";
            this.Text = "RegistroDragon";
            this.Load += new System.EventHandler(this.RegistroDragon_Load);
            this.gbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonTabla;
        private System.Windows.Forms.Button bttonInsert;
        private System.Windows.Forms.Button bttonLimpiar;
        private System.Windows.Forms.Button bttonUpdate;
        private System.Windows.Forms.Button bttonDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button bttonSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtAgilidad;
        private System.Windows.Forms.TextBox txtResistencia;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtInteligencia;
        private System.Windows.Forms.TextBox txtCarisma;
        private System.Windows.Forms.TextBox txtDefensa;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}