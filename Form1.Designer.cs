namespace GSB
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_stockDispo = new System.Windows.Forms.Label();
            this.cb_article = new System.Windows.Forms.ComboBox();
            this.bt_article = new System.Windows.Forms.Button();
            this.lb_commande = new System.Windows.Forms.Label();
            this.dgv_commande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_stockDispo
            // 
            this.lb_stockDispo.AutoSize = true;
            this.lb_stockDispo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lb_stockDispo.Location = new System.Drawing.Point(35, 59);
            this.lb_stockDispo.Name = "lb_stockDispo";
            this.lb_stockDispo.Size = new System.Drawing.Size(94, 13);
            this.lb_stockDispo.TabIndex = 0;
            this.lb_stockDispo.Text = "Stock disponible : ";
            // 
            // cb_article
            // 
            this.cb_article.FormattingEnabled = true;
            this.cb_article.Location = new System.Drawing.Point(587, 59);
            this.cb_article.Name = "cb_article";
            this.cb_article.Size = new System.Drawing.Size(121, 21);
            this.cb_article.TabIndex = 1;
            this.cb_article.Text = "Liste des articles :";
            this.cb_article.SelectedIndexChanged += new System.EventHandler(this.Cb_article_SelectedIndexChanged);
            // 
            // bt_article
            // 
            this.bt_article.Location = new System.Drawing.Point(750, 59);
            this.bt_article.Name = "bt_article";
            this.bt_article.Size = new System.Drawing.Size(75, 23);
            this.bt_article.TabIndex = 2;
            this.bt_article.Text = "Commander";
            this.bt_article.UseVisualStyleBackColor = true;
            // 
            // lb_commande
            // 
            this.lb_commande.AutoSize = true;
            this.lb_commande.Location = new System.Drawing.Point(626, 333);
            this.lb_commande.Name = "lb_commande";
            this.lb_commande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_commande.Size = new System.Drawing.Size(163, 13);
            this.lb_commande.TabIndex = 4;
            this.lb_commande.Text = "Récapitulatif de votre commande";
            // 
            // dgv_commande
            // 
            this.dgv_commande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commande.Location = new System.Drawing.Point(587, 367);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.Size = new System.Drawing.Size(275, 98);
            this.dgv_commande.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 477);
            this.Controls.Add(this.dgv_commande);
            this.Controls.Add(this.lb_commande);
            this.Controls.Add(this.bt_article);
            this.Controls.Add(this.cb_article);
            this.Controls.Add(this.lb_stockDispo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_stockDispo;
        private System.Windows.Forms.ComboBox cb_article;
        private System.Windows.Forms.Button bt_article;
        private System.Windows.Forms.Label lb_commande;
        private System.Windows.Forms.DataGridView dgv_commande;
    }
}

