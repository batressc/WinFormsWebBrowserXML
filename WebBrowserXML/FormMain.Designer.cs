namespace WebBrowserXML {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.webBrowserXml = new System.Windows.Forms.WebBrowser();
            this.propertyGridResult = new System.Windows.Forms.PropertyGrid();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonUTF8BOM = new System.Windows.Forms.Button();
            this.buttonUTF8 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserXml
            // 
            this.webBrowserXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserXml.Location = new System.Drawing.Point(0, 0);
            this.webBrowserXml.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserXml.Name = "webBrowserXml";
            this.webBrowserXml.Size = new System.Drawing.Size(822, 641);
            this.webBrowserXml.TabIndex = 0;
            // 
            // propertyGridResult
            // 
            this.propertyGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridResult.Location = new System.Drawing.Point(0, 0);
            this.propertyGridResult.Name = "propertyGridResult";
            this.propertyGridResult.Size = new System.Drawing.Size(379, 599);
            this.propertyGridResult.TabIndex = 0;
            this.propertyGridResult.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridResult_PropertyValueChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonLoadXml);
            this.panelButtons.Controls.Add(this.buttonUTF8BOM);
            this.panelButtons.Controls.Add(this.buttonUTF8);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 599);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(379, 42);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(253, 10);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(116, 23);
            this.buttonLoadXml.TabIndex = 2;
            this.buttonLoadXml.Text = "Load XML...";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonUTF8BOM
            // 
            this.buttonUTF8BOM.Location = new System.Drawing.Point(131, 10);
            this.buttonUTF8BOM.Name = "buttonUTF8BOM";
            this.buttonUTF8BOM.Size = new System.Drawing.Size(116, 23);
            this.buttonUTF8BOM.TabIndex = 1;
            this.buttonUTF8BOM.Text = "UTF-8 with BOM";
            this.buttonUTF8BOM.UseVisualStyleBackColor = true;
            this.buttonUTF8BOM.Click += new System.EventHandler(this.buttonUTF8BOM_Click);
            // 
            // buttonUTF8
            // 
            this.buttonUTF8.Location = new System.Drawing.Point(9, 10);
            this.buttonUTF8.Name = "buttonUTF8";
            this.buttonUTF8.Size = new System.Drawing.Size(116, 23);
            this.buttonUTF8.TabIndex = 0;
            this.buttonUTF8.Text = "UTF-8";
            this.buttonUTF8.UseVisualStyleBackColor = true;
            this.buttonUTF8.Click += new System.EventHandler(this.buttonUTF8_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.propertyGridResult);
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(822, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(379, 641);
            this.panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 641);
            this.Controls.Add(this.webBrowserXml);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "Web Browser & XML";
            this.panelButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserXml;
        private System.Windows.Forms.PropertyGrid propertyGridResult;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonUTF8BOM;
        private System.Windows.Forms.Button buttonUTF8;
        private System.Windows.Forms.Panel panelMain;
    }
}

