namespace Warehouse_System.Interface
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Warehouse_System.Properties.Resources.nana_smirnova_IEiAmhXehwE_unsplash1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliersStripMenuItem,
            this.permissionsStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 452);
            this.menuStrip1.MdiWindowListItem = this.warehouseToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1104, 80);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.AutoSize = false;
            this.warehouseToolStripMenuItem.AutoToolTip = true;
            this.warehouseToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWarehouse,
            this.UpdateWarehouse});
            this.warehouseToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.warehouseToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_warehouse_50;
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(147, 76);
            this.warehouseToolStripMenuItem.Text = "Warehouses";
            this.warehouseToolStripMenuItem.ToolTipText = "Warehouse Control";
            // 
            // NewWarehouse
            // 
            this.NewWarehouse.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.NewWarehouse.Name = "NewWarehouse";
            this.NewWarehouse.Size = new System.Drawing.Size(239, 42);
            this.NewWarehouse.Text = "New";
            this.NewWarehouse.Click += new System.EventHandler(this.NewWarehouse_Click);
            // 
            // UpdateWarehouse
            // 
            this.UpdateWarehouse.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.UpdateWarehouse.Name = "UpdateWarehouse";
            this.UpdateWarehouse.Size = new System.Drawing.Size(239, 42);
            this.UpdateWarehouse.Text = "Update";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.AutoSize = false;
            this.itemsToolStripMenuItem.AutoToolTip = true;
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.itemsToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemsToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_product_50;
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(152, 60);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(239, 42);
            this.newToolStripMenuItem.Text = "New";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(239, 42);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.AutoSize = false;
            this.customersToolStripMenuItem.AutoToolTip = true;
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.updateToolStripMenuItem1});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customersToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_customer_50;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(170, 60);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(239, 42);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(239, 42);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // suppliersStripMenuItem
            // 
            this.suppliersStripMenuItem.AutoSize = false;
            this.suppliersStripMenuItem.AutoToolTip = true;
            this.suppliersStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.suppliersStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.suppliersStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_supplier_64;
            this.suppliersStripMenuItem.Name = "suppliersStripMenuItem";
            this.suppliersStripMenuItem.Size = new System.Drawing.Size(170, 60);
            this.suppliersStripMenuItem.Text = "Suppliers";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(239, 42);
            this.toolStripMenuItem9.Text = "New";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(239, 42);
            this.toolStripMenuItem10.Text = "Update";
            // 
            // permissionsStripMenuItem
            // 
            this.permissionsStripMenuItem.AutoSize = false;
            this.permissionsStripMenuItem.AutoToolTip = true;
            this.permissionsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.permissionsStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionsStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.permissionsStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_supply_chain_96;
            this.permissionsStripMenuItem.Name = "permissionsStripMenuItem";
            this.permissionsStripMenuItem.Size = new System.Drawing.Size(170, 60);
            this.permissionsStripMenuItem.Text = "Permissions";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Image = global::Warehouse_System.Properties.Resources.icons8_supplies_64;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(261, 42);
            this.toolStripMenuItem2.Text = "Suppling Permission";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 34);
            this.toolStripMenuItem3.Text = "New";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 34);
            this.toolStripMenuItem4.Text = "Update";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(261, 42);
            this.toolStripMenuItem5.Text = "Transfer Permission";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Warehouse_System.Properties.Resources.icons8_add_50;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(148, 34);
            this.toolStripMenuItem6.Text = "New";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Warehouse_System.Properties.Resources.icons8_edit_50;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(148, 34);
            this.toolStripMenuItem7.Text = "Update";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.AutoSize = false;
            this.reportsToolStripMenuItem.AutoToolTip = true;
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Image = global::Warehouse_System.Properties.Resources.icons8_combo_chart_50;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(170, 60);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 532);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWarehouse;
        private System.Windows.Forms.ToolStripMenuItem UpdateWarehouse;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppliersStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem permissionsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}