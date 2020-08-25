using System.Windows.Forms;

namespace BeOpen.iiko.Back.Temperature.View
{
    partial class TemperatureView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmboBoxStores = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblAvrgTemp = new System.Windows.Forms.Label();
            this.lblAvrgTempVal = new System.Windows.Forms.Label();
            this.lblStoreNameVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmboBoxStores
            // 
            this.cmboBoxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxStores.FormattingEnabled = true;
            this.cmboBoxStores.Location = new System.Drawing.Point(45, 39);
            this.cmboBoxStores.Name = "cmboBoxStores";
            this.cmboBoxStores.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxStores.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 12;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(42, 90);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(71, 13);
            this.lblStoreName.TabIndex = 4;
            this.lblStoreName.Text = "Store name";
            // 
            // lblAvrgTemp
            // 
            this.lblAvrgTemp.AutoSize = true;
            this.lblAvrgTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvrgTemp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvrgTemp.Location = new System.Drawing.Point(42, 135);
            this.lblAvrgTemp.Name = "lblAvrgTemp";
            this.lblAvrgTemp.Size = new System.Drawing.Size(125, 13);
            this.lblAvrgTemp.TabIndex = 6;
            this.lblAvrgTemp.Text = "Avarage temperature";
            // 
            // lblAvrgTempVal
            // 
            this.lblAvrgTempVal.AutoSize = true;
            this.lblAvrgTempVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvrgTempVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvrgTempVal.Location = new System.Drawing.Point(215, 135);
            this.lblAvrgTempVal.Name = "lblAvrgTempVal";
            this.lblAvrgTempVal.Size = new System.Drawing.Size(0, 13);
            this.lblAvrgTempVal.TabIndex = 10;
            // 
            // lblStoreNameVal
            // 
            this.lblStoreNameVal.AutoSize = true;
            this.lblStoreNameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreNameVal.Location = new System.Drawing.Point(215, 90);
            this.lblStoreNameVal.Name = "lblStoreNameVal";
            this.lblStoreNameVal.Size = new System.Drawing.Size(0, 13);
            this.lblStoreNameVal.TabIndex = 8;
            // 
            // TemperatureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAvrgTempVal);
            this.Controls.Add(this.lblStoreNameVal);
            this.Controls.Add(this.lblAvrgTemp);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmboBoxStores);
            this.Controls.Add(this.btnRefresh);
            this.Name = "TemperatureView";
            this.Size = new System.Drawing.Size(863, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmboBoxStores;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblAvrgTemp;
        private System.Windows.Forms.Label lblAvrgTempVal;
        private System.Windows.Forms.Label lblStoreNameVal;
    }
}
