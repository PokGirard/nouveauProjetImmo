namespace EcranAccueil
{
    partial class FenetreChoix
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
            this.button_ajouter_client = new System.Windows.Forms.Button();
            this.button_rechercher_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ajouter_client
            // 
            this.button_ajouter_client.Location = new System.Drawing.Point(79, 49);
            this.button_ajouter_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ajouter_client.Name = "button_ajouter_client";
            this.button_ajouter_client.Size = new System.Drawing.Size(160, 28);
            this.button_ajouter_client.TabIndex = 0;
            this.button_ajouter_client.Text = "Ajouter un client";
            this.button_ajouter_client.UseVisualStyleBackColor = true;
            this.button_ajouter_client.Click += new System.EventHandler(this.button_ajouter_client_Click);
            // 
            // button_rechercher_client
            // 
            this.button_rechercher_client.Location = new System.Drawing.Point(79, 122);
            this.button_rechercher_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_rechercher_client.Name = "button_rechercher_client";
            this.button_rechercher_client.Size = new System.Drawing.Size(160, 28);
            this.button_rechercher_client.TabIndex = 1;
            this.button_rechercher_client.Text = "Rechercher un client";
            this.button_rechercher_client.UseVisualStyleBackColor = true;
            this.button_rechercher_client.Click += new System.EventHandler(this.button_rechercher_client_Click);
            // 
            // FenetreChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 213);
            this.Controls.Add(this.button_rechercher_client);
            this.Controls.Add(this.button_ajouter_client);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FenetreChoix";
            this.Text = "FenetreChoix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ajouter_client;
        private System.Windows.Forms.Button button_rechercher_client;
    }
}