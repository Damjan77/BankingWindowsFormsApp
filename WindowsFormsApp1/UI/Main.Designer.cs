using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSOperationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.officialRatesToolStripMenuItem,
            this.exchangeRatesToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.cLSCurrencyToolStripMenuItem,
            this.cLSOperationTypeToolStripMenuItem,
            this.tDAToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2427, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AccessibleName = "UsersPanel";
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // officialRatesToolStripMenuItem
            // 
            this.officialRatesToolStripMenuItem.AccessibleName = "OfficialRatesPanel";
            this.officialRatesToolStripMenuItem.Name = "officialRatesToolStripMenuItem";
            this.officialRatesToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.officialRatesToolStripMenuItem.Text = "Official Rates";
            this.officialRatesToolStripMenuItem.Click += new System.EventHandler(this.officialRatesToolStripMenuItem_Click);
            // 
            // exchangeRatesToolStripMenuItem
            // 
            this.exchangeRatesToolStripMenuItem.AccessibleName = "ExchangeRatesPanel";
            this.exchangeRatesToolStripMenuItem.Name = "exchangeRatesToolStripMenuItem";
            this.exchangeRatesToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.exchangeRatesToolStripMenuItem.Text = "Exchange Rates";
            this.exchangeRatesToolStripMenuItem.Click += new System.EventHandler(this.exchangeRatesToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.AccessibleName = "OperationsPanel";
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.operationsToolStripMenuItem.Text = "Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // cLSCurrencyToolStripMenuItem
            // 
            this.cLSCurrencyToolStripMenuItem.AccessibleName = "CLS_CurrencyPanel";
            this.cLSCurrencyToolStripMenuItem.Name = "cLSCurrencyToolStripMenuItem";
            this.cLSCurrencyToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.cLSCurrencyToolStripMenuItem.Text = "CLS_Currency";
            this.cLSCurrencyToolStripMenuItem.Click += new System.EventHandler(this.cLSCurrencyToolStripMenuItem_Click);
            // 
            // cLSOperationTypeToolStripMenuItem
            // 
            this.cLSOperationTypeToolStripMenuItem.AccessibleName = "CLS_OperationTypePanel";
            this.cLSOperationTypeToolStripMenuItem.Name = "cLSOperationTypeToolStripMenuItem";
            this.cLSOperationTypeToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.cLSOperationTypeToolStripMenuItem.Text = "CLS_Operation_Type";
            this.cLSOperationTypeToolStripMenuItem.Click += new System.EventHandler(this.cLSOperationTypeToolStripMenuItem_Click);
            // 
            // tDAToolStripMenuItem
            // 
            this.tDAToolStripMenuItem.Name = "tDAToolStripMenuItem";
            this.tDAToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.tDAToolStripMenuItem.Text = "TDA";
            this.tDAToolStripMenuItem.Click += new System.EventHandler(this.tDAToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1120);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSOperationTypeToolStripMenuItem;
        private ToolStripMenuItem tDAToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}