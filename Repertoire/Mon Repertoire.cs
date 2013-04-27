using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Repertoire
{
    public partial class MonRepertoire : Form
    {
        private Repertoire leRepertoire;
        private int num_cour = -1;

        public MonRepertoire()
        {
            InitializeComponent();
            leRepertoire = new Repertoire();
           
            
        }

        private void MonRepertoire_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.labelTelPro = new System.Windows.Forms.Label();
            this.labelSkype = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelVile = new System.Windows.Forms.Label();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxTelPro = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmailPro = new System.Windows.Forms.TextBox();
            this.textBoxSkype = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmailPro = new System.Windows.Forms.LinkLabel();
            this.linkLabelSkype = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(64, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(261, 9);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom";
            this.labelPrenom.Click += new System.EventHandler(this.labelPrenom_Click);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(71, 62);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(22, 13);
            this.v.TabIndex = 2;
            this.v.Text = "Tél";
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // labelTelPro
            // 
            this.labelTelPro.AutoSize = true;
            this.labelTelPro.Location = new System.Drawing.Point(64, 116);
            this.labelTelPro.Name = "labelTelPro";
            this.labelTelPro.Size = new System.Drawing.Size(40, 13);
            this.labelTelPro.TabIndex = 3;
            this.labelTelPro.Text = "Tél pro";
            this.labelTelPro.Click += new System.EventHandler(this.labelTelPro_Click);
            // 
            // labelSkype
            // 
            this.labelSkype.AutoSize = true;
            this.labelSkype.Location = new System.Drawing.Point(64, 164);
            this.labelSkype.Name = "labelSkype";
            this.labelSkype.Size = new System.Drawing.Size(37, 13);
            this.labelSkype.TabIndex = 6;
            this.labelSkype.Text = "Skype";
            this.labelSkype.Click += new System.EventHandler(this.labelSkype_Click);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(56, 215);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse";
            this.labelAdresse.Click += new System.EventHandler(this.labelAdresse_Click);
            // 
            // labelVile
            // 
            this.labelVile.AutoSize = true;
            this.labelVile.Location = new System.Drawing.Point(71, 265);
            this.labelVile.Name = "labelVile";
            this.labelVile.Size = new System.Drawing.Size(26, 13);
            this.labelVile.TabIndex = 8;
            this.labelVile.Text = "Ville";
            this.labelVile.Click += new System.EventHandler(this.labelVile_Click);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(49, 308);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(63, 13);
            this.labelCodePostal.TabIndex = 9;
            this.labelCodePostal.Text = "Code postal";
            this.labelCodePostal.Click += new System.EventHandler(this.labelCodePostal_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(261, 164);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 10;
            this.labelNote.Text = "Note";
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(12, 25);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(139, 20);
            this.textBoxNom.TabIndex = 11;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(204, 25);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(143, 20);
            this.textBoxPrenom.TabIndex = 12;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(12, 78);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(139, 20);
            this.textBoxTel.TabIndex = 13;
            this.textBoxTel.TextChanged += new System.EventHandler(this.textBoxTel_TextChanged);
            // 
            // textBoxTelPro
            // 
            this.textBoxTelPro.Location = new System.Drawing.Point(12, 132);
            this.textBoxTelPro.Name = "textBoxTelPro";
            this.textBoxTelPro.Size = new System.Drawing.Size(139, 20);
            this.textBoxTelPro.TabIndex = 14;
            this.textBoxTelPro.TextChanged += new System.EventHandler(this.textBoxTelPro_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(204, 78);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 20);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxEmailPro
            // 
            this.textBoxEmailPro.Location = new System.Drawing.Point(204, 132);
            this.textBoxEmailPro.Name = "textBoxEmailPro";
            this.textBoxEmailPro.Size = new System.Drawing.Size(143, 20);
            this.textBoxEmailPro.TabIndex = 16;
            this.textBoxEmailPro.TextChanged += new System.EventHandler(this.textBoxEmailPro_TextChanged);
            // 
            // textBoxSkype
            // 
            this.textBoxSkype.Location = new System.Drawing.Point(12, 180);
            this.textBoxSkype.Name = "textBoxSkype";
            this.textBoxSkype.Size = new System.Drawing.Size(139, 20);
            this.textBoxSkype.TabIndex = 17;
            this.textBoxSkype.TextChanged += new System.EventHandler(this.textBoxSkype_TextChanged);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(12, 231);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(139, 20);
            this.textBoxAdresse.TabIndex = 18;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(12, 281);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(139, 20);
            this.textBoxVille.TabIndex = 19;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(12, 324);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(139, 20);
            this.textBoxCodePostal.TabIndex = 20;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(204, 180);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(143, 121);
            this.textBoxNote.TabIndex = 21;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(188, 307);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(74, 23);
            this.buttonPrecedent.TabIndex = 22;
            this.buttonPrecedent.Text = "<< PREC";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(279, 307);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(79, 23);
            this.buttonSuivant.TabIndex = 23;
            this.buttonSuivant.Text = "SUIV >>";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click_1);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(188, 337);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(74, 23);
            this.buttonAjout.TabIndex = 24;
            this.buttonAjout.Text = "AJOUT";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click_1);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(279, 337);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(79, 23);
            this.buttonSupprimer.TabIndex = 25;
            this.buttonSupprimer.Text = "SUPPRIMER";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click_1);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(230, 366);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(74, 23);
            this.buttonModifier.TabIndex = 26;
            this.buttonModifier.Text = "MODIFIER";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click_1);
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.LinkColor = System.Drawing.Color.Black;
            this.linkLabelEmail.Location = new System.Drawing.Point(254, 62);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(32, 13);
            this.linkLabelEmail.TabIndex = 27;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "Email";
            this.linkLabelEmail.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // linkLabelEmailPro
            // 
            this.linkLabelEmailPro.AutoSize = true;
            this.linkLabelEmailPro.LinkColor = System.Drawing.Color.Black;
            this.linkLabelEmailPro.Location = new System.Drawing.Point(254, 116);
            this.linkLabelEmailPro.Name = "linkLabelEmailPro";
            this.linkLabelEmailPro.Size = new System.Drawing.Size(50, 13);
            this.linkLabelEmailPro.TabIndex = 28;
            this.linkLabelEmailPro.TabStop = true;
            this.linkLabelEmailPro.Text = "Email pro";
            this.linkLabelEmailPro.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelEmailPro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmailPro_LinkClicked);
            // 
            // linkLabelSkype
            // 
            this.linkLabelSkype.AutoSize = true;
            this.linkLabelSkype.LinkColor = System.Drawing.Color.Black;
            this.linkLabelSkype.Location = new System.Drawing.Point(107, 164);
            this.linkLabelSkype.Name = "linkLabelSkype";
            this.linkLabelSkype.Size = new System.Drawing.Size(37, 13);
            this.linkLabelSkype.TabIndex = 29;
            this.linkLabelSkype.TabStop = true;
            this.linkLabelSkype.Text = "Skype";
            this.linkLabelSkype.VisitedLinkColor = System.Drawing.Color.Black;
            //this.linkLabelSkype.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSkype_LinkClicked);
            // 
            // MonRepertoire
            // 
            this.ClientSize = new System.Drawing.Size(370, 391);
            this.Controls.Add(this.linkLabelSkype);
            this.Controls.Add(this.linkLabelEmailPro);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxSkype);
            this.Controls.Add(this.textBoxEmailPro);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelPro);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelVile);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelSkype);
            this.Controls.Add(this.labelTelPro);
            this.Controls.Add(this.v);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "MonRepertoire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenom_Click(object sender, EventArgs e)
        {

        }

        private void v_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelTelPro_Click(object sender, EventArgs e)
        {

        }

        private void labelEmailPro_Click(object sender, EventArgs e)
        {

        }

        private void labelSkype_Click(object sender, EventArgs e)
        {

        }

        private void labelNote_Click(object sender, EventArgs e)
        {

        }

        private void labelAdresse_Click(object sender, EventArgs e)
        {

        }

        private void labelVile_Click(object sender, EventArgs e)
        {

        }

        private void labelCodePostal_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmailPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSkype_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            try
            {
                num_cour--;
                textBoxNom.Text = leRepertoire.recherchePersonne(num_cour).getNom();
                textBoxPrenom.Text = leRepertoire.recherchePersonne(num_cour).getPrenom();
                textBoxTel.Text = leRepertoire.recherchePersonne(num_cour).getTelephone();
                textBoxTelPro.Text = leRepertoire.recherchePersonne(num_cour).getTelephonePro();
                textBoxEmail.Text = leRepertoire.recherchePersonne(num_cour).getEmail();
                textBoxEmailPro.Text = leRepertoire.recherchePersonne(num_cour).getEmailPro();
                textBoxSkype.Text = leRepertoire.recherchePersonne(num_cour).getSkype();
                textBoxAdresse.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getRue();
                textBoxVille.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getVille();
                textBoxCodePostal.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getCodePostal();
                textBoxNote.Text = leRepertoire.recherchePersonne(num_cour).getNote();
            }
            catch (System.IndexOutOfRangeException err)
            {
                num_cour++;
                MessageBox.Show("Vous êtes déjà au premier contact.");
                Console.WriteLine(err.ToString());
            }
            catch (ArgumentOutOfRangeException err)
            {
                num_cour++;
                MessageBox.Show("Vous êtes déjà au premier contact.");
                Console.WriteLine(err.ToString());
            }
        }

        private void buttonSuivant_Click_1(object sender, EventArgs e)
        {
            try
            {
                num_cour++;
                textBoxNom.Text = leRepertoire.recherchePersonne(num_cour).getNom();
                textBoxPrenom.Text = leRepertoire.recherchePersonne(num_cour).getPrenom();
                textBoxTel.Text = leRepertoire.recherchePersonne(num_cour).getTelephone();
                textBoxTelPro.Text = leRepertoire.recherchePersonne(num_cour).getTelephonePro();
                textBoxEmail.Text = leRepertoire.recherchePersonne(num_cour).getEmail();
                textBoxEmailPro.Text = leRepertoire.recherchePersonne(num_cour).getEmailPro();
                textBoxSkype.Text = leRepertoire.recherchePersonne(num_cour).getSkype();
                textBoxAdresse.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getRue();
                textBoxVille.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getVille();
                textBoxCodePostal.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getCodePostal();
                textBoxNote.Text = leRepertoire.recherchePersonne(num_cour).getNote();
            }
            catch (System.IndexOutOfRangeException err)
            {
                MessageBox.Show("Vous êtes déjà au dernier contact.");
                Console.WriteLine(err.ToString());
                num_cour--;
            }
            catch (ArgumentOutOfRangeException err)
            {
                num_cour--;
                MessageBox.Show("Vous êtes déjà au dernier contact.");
                Console.WriteLine(err.ToString());
            }
        }

        private void buttonAjout_Click_1(object sender, EventArgs e)
        {
            if (textBoxNom.Text == String.Empty && textBoxPrenom.Text == String.Empty)
            {
                MessageBox.Show("Vous devez au moins remplir le champs nom ou prénom");
            }
            else
            {
                Adresse uneAdresse = new Adresse(textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text);
                uneAdresse.afficheAdresse();

                leRepertoire.ajouterPersonne(textBoxNom.Text, textBoxPrenom.Text, uneAdresse, textBoxTel.Text,
                        textBoxTelPro.Text, textBoxEmail.Text, textBoxEmailPro.Text, textBoxSkype.Text, textBoxNote.Text);

                MessageBox.Show(textBoxNom.Text + " " + textBoxPrenom.Text + " à bien été ajouté");

                textBoxNom.Text = null; textBoxPrenom.Text = null; textBoxTel.Text = null; textBoxTelPro.Text = null;
                textBoxEmail.Text = null; textBoxEmailPro.Text = null; textBoxSkype.Text = null; textBoxNote.Text = null;
                textBoxAdresse.Text = null; textBoxCodePostal.Text = null; textBoxVille.Text = null;
                num_cour = -1;
                Fichier.ecriture(leRepertoire.getListe());
            }
        }

        private void buttonSupprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                String nom, prenom;
                nom = textBoxNom.Text; prenom = textBoxPrenom.Text;

                leRepertoire.supprPersonne(leRepertoire.recherchePersonne(num_cour));

                textBoxNom.Text = null; textBoxPrenom.Text = null; textBoxTel.Text = null; textBoxTelPro.Text = null;
                textBoxEmail.Text = null; textBoxEmailPro.Text = null; textBoxSkype.Text = null; textBoxNote.Text = null;
                textBoxAdresse.Text = null; textBoxCodePostal.Text = null; textBoxVille.Text = null;
                MessageBox.Show(nom + " " + prenom + " a bien été éffacé");

                num_cour = 0;
                nom = null; prenom = null;
                textBoxNom.Text = leRepertoire.recherchePersonne(num_cour).getNom();
                textBoxPrenom.Text = leRepertoire.recherchePersonne(num_cour).getPrenom();
                textBoxTel.Text = leRepertoire.recherchePersonne(num_cour).getTelephone();
                textBoxTelPro.Text = leRepertoire.recherchePersonne(num_cour).getTelephonePro();
                textBoxEmail.Text = leRepertoire.recherchePersonne(num_cour).getEmail();
                textBoxEmailPro.Text = leRepertoire.recherchePersonne(num_cour).getEmailPro();
                textBoxSkype.Text = leRepertoire.recherchePersonne(num_cour).getSkype();
                textBoxAdresse.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getRue();
                textBoxVille.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getVille();
                textBoxCodePostal.Text = leRepertoire.recherchePersonne(num_cour).getAdresse().getCodePostal();
                textBoxNote.Text = leRepertoire.recherchePersonne(num_cour).getNote();
                Fichier.ecriture(leRepertoire.getListe());
            }
            catch (System.IndexOutOfRangeException err)
            {
                MessageBox.Show("Il n'y à personne à supprimer");
                Console.WriteLine(err.ToString());
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Il n'y à personne à supprimer");
                Console.WriteLine(err.ToString());
            }
        }

        private void buttonModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                String nom, prenom;
                nom = textBoxNom.Text; prenom = textBoxPrenom.Text;

                Adresse uneAdresse = new Adresse(textBoxAdresse.Text, textBoxCodePostal.Text, textBoxVille.Text);
                uneAdresse.afficheAdresse();

                leRepertoire.recherchePersonne(num_cour).setNom(textBoxNom.Text);
                leRepertoire.recherchePersonne(num_cour).setPrenom(textBoxPrenom.Text);
                leRepertoire.recherchePersonne(num_cour).setAdresse(uneAdresse);
                leRepertoire.recherchePersonne(num_cour).setTelephone(textBoxTel.Text);
                leRepertoire.recherchePersonne(num_cour).setTelephonePro(textBoxTelPro.Text);
                leRepertoire.recherchePersonne(num_cour).setEmail(textBoxEmail.Text);
                leRepertoire.recherchePersonne(num_cour).setEmailPro(textBoxEmailPro.Text);
                leRepertoire.recherchePersonne(num_cour).setSkype(textBoxSkype.Text);
                leRepertoire.recherchePersonne(num_cour).setNote(textBoxNote.Text);
                Fichier.ecriture(leRepertoire.getListe());
                MessageBox.Show(nom + " " + prenom + " a bien été modifier");
            }
            catch (System.IndexOutOfRangeException err)
            {
                MessageBox.Show("Il n'y à personne à modifier");
                Console.WriteLine(err.ToString());
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Il n'y à personne à modifier");
                Console.WriteLine(err.ToString());
            }
        }

        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Mailto:" + textBoxEmail.Text);
        }

        private void linkLabelEmailPro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Mailto:" + textBoxEmailPro.Text);
        }

        
    }
}