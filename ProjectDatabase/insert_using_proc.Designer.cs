﻿namespace ProjectDatabase
{
    partial class insert_using_proc
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
            this.Save_add_prison_using_proc = new System.Windows.Forms.Button();
            this.Crime_box_insert_using_proc = new System.Windows.Forms.TextBox();
            this.Case_No_box_insert_using_proc = new System.Windows.Forms.TextBox();
            this.penalty_box_insert_using_proc = new System.Windows.Forms.TextBox();
            this.Case_Type_box_insert_using_proc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_add_prison_using_proc
            // 
            this.Save_add_prison_using_proc.Location = new System.Drawing.Point(357, 229);
            this.Save_add_prison_using_proc.Name = "Save_add_prison_using_proc";
            this.Save_add_prison_using_proc.Size = new System.Drawing.Size(87, 39);
            this.Save_add_prison_using_proc.TabIndex = 34;
            this.Save_add_prison_using_proc.Text = "Save";
            this.Save_add_prison_using_proc.UseVisualStyleBackColor = true;
            this.Save_add_prison_using_proc.Click += new System.EventHandler(this.Save_add_prison_using_proc_Click);
            // 
            // Crime_box_insert_using_proc
            // 
            this.Crime_box_insert_using_proc.Location = new System.Drawing.Point(227, 181);
            this.Crime_box_insert_using_proc.Name = "Crime_box_insert_using_proc";
            this.Crime_box_insert_using_proc.Size = new System.Drawing.Size(100, 22);
            this.Crime_box_insert_using_proc.TabIndex = 33;
            // 
            // Case_No_box_insert_using_proc
            // 
            this.Case_No_box_insert_using_proc.Location = new System.Drawing.Point(227, 35);
            this.Case_No_box_insert_using_proc.Name = "Case_No_box_insert_using_proc";
            this.Case_No_box_insert_using_proc.Size = new System.Drawing.Size(100, 22);
            this.Case_No_box_insert_using_proc.TabIndex = 32;
            // 
            // penalty_box_insert_using_proc
            // 
            this.penalty_box_insert_using_proc.Location = new System.Drawing.Point(227, 131);
            this.penalty_box_insert_using_proc.Name = "penalty_box_insert_using_proc";
            this.penalty_box_insert_using_proc.Size = new System.Drawing.Size(100, 22);
            this.penalty_box_insert_using_proc.TabIndex = 31;
            // 
            // Case_Type_box_insert_using_proc
            // 
            this.Case_Type_box_insert_using_proc.Location = new System.Drawing.Point(227, 86);
            this.Case_Type_box_insert_using_proc.Name = "Case_Type_box_insert_using_proc";
            this.Case_Type_box_insert_using_proc.Size = new System.Drawing.Size(100, 22);
            this.Case_Type_box_insert_using_proc.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Case_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Crime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Penalty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Case_Type :";
            // 
            // insert_using_proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.Save_add_prison_using_proc);
            this.Controls.Add(this.Crime_box_insert_using_proc);
            this.Controls.Add(this.Case_No_box_insert_using_proc);
            this.Controls.Add(this.penalty_box_insert_using_proc);
            this.Controls.Add(this.Case_Type_box_insert_using_proc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert_using_proc";
            this.Text = "insert_using_proc";
            this.Load += new System.EventHandler(this.insert_using_proc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_add_prison_using_proc;
        private System.Windows.Forms.TextBox Crime_box_insert_using_proc;
        private System.Windows.Forms.TextBox Case_No_box_insert_using_proc;
        private System.Windows.Forms.TextBox penalty_box_insert_using_proc;
        private System.Windows.Forms.TextBox Case_Type_box_insert_using_proc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}