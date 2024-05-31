namespace DragonesFORM
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
            this.bttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttonEnter
            // 
            this.bttonEnter.BackgroundImage = global::DragonesFORM.Properties.Resources.Enter;
            this.bttonEnter.Location = new System.Drawing.Point(26, 263);
            this.bttonEnter.Name = "bttonEnter";
            this.bttonEnter.Size = new System.Drawing.Size(542, 175);
            this.bttonEnter.TabIndex = 0;
            this.bttonEnter.UseVisualStyleBackColor = true;
            this.bttonEnter.Click += new System.EventHandler(this.bttonEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonesFORM.Properties.Resources.portada_cortada;
            this.ClientSize = new System.Drawing.Size(592, 456);
            this.Controls.Add(this.bttonEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttonEnter;
    }
}

