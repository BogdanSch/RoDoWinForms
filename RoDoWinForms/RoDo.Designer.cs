using System.Windows.Forms;

namespace RoDo
{
    partial class RoDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoDo));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.bCreate = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.pnlGreetings = new System.Windows.Forms.Panel();
            this.lInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.pnlGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.75F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.25F));
            this.tableLayoutPanel.Controls.Add(this.pnlCreate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pnlTasks, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pnlGreetings, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(885, 467);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCreate.Controls.Add(this.bCreate);
            this.pnlCreate.Controls.Add(this.tbInput);
            this.pnlCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreate.Location = new System.Drawing.Point(3, 3);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(266, 73);
            this.pnlCreate.TabIndex = 0;
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCreate.Location = new System.Drawing.Point(185, 20);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(58, 29);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Add";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.Location = new System.Drawing.Point(9, 20);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(170, 29);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "Enter your task here...";
            this.tbInput.GotFocus += new System.EventHandler(this.RemoveText);
            this.tbInput.LostFocus += new System.EventHandler(this.AddText);
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTasks.BackgroundImage")));
            this.pnlTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.Location = new System.Drawing.Point(275, 82);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(607, 382);
            this.pnlTasks.TabIndex = 1;
            // 
            // pnlGreetings
            // 
            this.pnlGreetings.Controls.Add(this.lInfo);
            this.pnlGreetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGreetings.Location = new System.Drawing.Point(275, 3);
            this.pnlGreetings.Name = "pnlGreetings";
            this.pnlGreetings.Size = new System.Drawing.Size(607, 73);
            this.pnlGreetings.TabIndex = 2;
            // 
            // lInfo
            // 
            this.lInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lInfo.ForeColor = System.Drawing.Color.White;
            this.lInfo.Location = new System.Drawing.Point(0, 0);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(607, 73);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "My day";
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoDo
            // 
            this.ClientSize = new System.Drawing.Size(885, 467);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RoDo";
            this.Text = "RoDo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoDo_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pnlGreetings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.Panel pnlGreetings;
        private System.Windows.Forms.Label lInfo;
    }
}