using ConsumidorDeWebService.Model;
using ConsumidorDeWebService.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSerCons0.Model;

namespace ConsumidorDeWebService.Controller
{
    class Controller1
    {
        Form1 f;
        Repository r;
        Artist artista = new Artist();

        public Controller1()
        {
            f = new Form1();
            r = new Repository();
            InitListeners();
            LoadData();
            Application.Run(f);
        }

        void LoadData()
        {
            LoadDGVArtistes();
        }

        void LoadDGVArtistes()
        {
            
            f.dgvArtistes.DataSource = r.GetArtists();
            
        }       
       

        void InitListeners()
        {
            f.bFiltrar.Click += BFiltrar_Click;
            f.dgvArtistes.SelectionChanged += DgvArtistes_SelectionChanged;
            f.bAfegir.Click += BAfegir_Click;
            f.bModificar.Click += BModificar_Click;
            f.bEsborrar.Click += BEsborrar_Click;
        }

        private void BEsborrar_Click(object sender, EventArgs e)
        {
            artista = f.dgvArtistes.CurrentRow.DataBoundItem as Artist;
            r.DelArtist(artista.ArtistId);
            LoadData();
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            artista = f.dgvArtistes.CurrentRow.DataBoundItem as Artist;
            artista.Name = f.tbNom.Text.ToString();
            r.UpdArtist(artista, artista.ArtistId);
            LoadData();
        }

        private void BAfegir_Click(object sender, EventArgs e)
        {
            String nom = f.tbNom.Text.ToString();
            //artista.Name = nom;
            Artist a = new Artist(nom);         // Para inserir es mejor crear un artista nuevo y meterlo por el constructor de esta manera
            r.InsArtist(a);
            LoadData();
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
            String nom = f.tbFiltre.Text.ToString();
            f.dgvArtistes.DataSource = r.GetArtists(nom);
        }

        private void DgvArtistes_SelectionChanged(object sender, EventArgs e)
        {
            artista = f.dgvArtistes.CurrentRow.DataBoundItem as Artist;
            f.tbNom.Text = artista.Name.ToString();
        }
    }
}
