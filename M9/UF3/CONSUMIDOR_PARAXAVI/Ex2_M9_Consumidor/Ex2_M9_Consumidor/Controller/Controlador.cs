using Ex2_M9_Consumidor.Model;
using Ex2_M9_Consumidor.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_M9_Consumidor.Controller
{
    internal class Controlador
    {

        Form1 f;
        Repository rd;
        int cont = 0;

        public Controlador()
        {

            f = new Form1();
            rd = new Repository();
            LoadData();
            initListeners();
            Application.Run(f);
        }

        private void LoadData()
        {
            f.dgvBeers.DataSource = rd.GetBeers();
            esconderColumns();
       
          //  ponerImagenTitulo("https://www.pngarts.com/files/4/Oktoberfest-PNG-Picture.png");
            //https://static.vecteezy.com/system/resources/previews/011/570/125/original/delicate-oktoberfest-elements-png.png

        }

        private void initListeners()
        {
            f.dgvBeers.SelectionChanged += DgvBeers_SelectionChanged;
          
            f.btnFiltrar.Click += BtnFiltrar_Click;
            f.btnFiltrarComida.Click += BtnFiltrarComida_Click;
            f.btnPagina.Click += BtnPagina_Click;
            f.dgvIngredients.SelectionChanged += DgvIngredients_SelectionChanged;
           
           
        }

        private void BtnFiltrarComida_Click(object sender, EventArgs e)
        {
            try
            {

                f.btnPagina.Visible = false;
                f.lblPagina.Visible = false;

                string filtro = f.txtComida.Text;
                if (filtro != "")
                {
                    DadesFiltreComida(filtro);
                   // DadesFiltre(filtro);

                }
                else
                {
                    f.btnPagina.Visible = true;
                    f.lblPagina.Visible = true;
                    LoadData();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("KLK RETRASAO ERROR");
            }

        }

        private void DgvIngredients_SelectionChanged(object sender, EventArgs e)
        {
            Malt i = f.dgvIngredients.CurrentRow.DataBoundItem as Malt;

            
            
           


            if (i != null)
            {


                f.txtValue.Text = i.amount.value.ToString();
                f.txtUnit.Text = i.amount.unit.ToString();

            }
            else
            {
                f.txtValue.Text = "null";
                f.txtUnit.Text = "null";
            }
           




        }

        private void BtnPagina_Click(object sender, EventArgs e)
        {
            

            switch (cont)
            {
                case 0:
                    f.lblPagina.Text = "Página 2/5";
                    dadesPage2();
                    
                    break;
                case 1:
                    f.lblPagina.Text = "Página 3/5";
                    dadesPage3();
                   
                    break;
                case 2:
                    f.lblPagina.Text = "Página 4/5";
                    dadesPage4();
                    
                    break;
                case 3:
                    f.lblPagina.Text = "Página 5/5";
                    dadesPage5();
                   
                    break;
                case 4:
                    f.lblPagina.Text = "Página 1/5";
                    LoadData();
                    
                    break;

            }
            if (cont == 4)
            {
                cont = 0;
            }
            else
            {
 cont++;
            }
           
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {

                f.btnPagina.Visible = false;
                f.lblPagina.Visible = false;
      
                    string filtro = f.txtFiltro.Text;
                    if (filtro != "")
                    {
                    DadesFiltre(filtro);
                
                    }
                    else
                    {
                    f.btnPagina.Visible = true;
                    f.lblPagina.Visible = true;
                    LoadData();
                }
                
             

            }
            catch(Exception ex)
            {
                MessageBox.Show("KLK RETRASAO ERROR");
            }
           
           

            
        }

      

        private void DgvBeers_SelectionChanged(object sender, EventArgs e)
        {

            Beer b = f.dgvBeers.CurrentRow.DataBoundItem as Beer;
          
            
            f.txtId.Text = b.id.ToString();
            f.txtName.Text = b.name.ToString();
            f.txtDescription.Text = b.description.ToString();
            if(b.ph == null)
            {
                f.txtPh.Text = "null";
            }
            else
            {
               f.txtPh.Text = b.ph.ToString();
            }
            f.lblContribuir.Text = "Contributed by: " + b.contributed_by.ToString();
            f.txtTips.Text = b.brewers_tips.ToString();
            f.txtLema.Text = b.tagline.ToString();
            f.txtBrewed.Text = b.first_brewed.ToString();
            if (b.attenuation_level == null)
            {
                f.txtAtenuacion.Text = "No disponible";
            }
            else
            {
                f.txtAtenuacion.Text = b.attenuation_level.ToString();
            }
          
            
            f.txtValueVol.Text = b.volume.value.ToString();
            f.txtUnitVol.Text = b.volume.unit.ToString();

            List<string> comida = b.food_pairing.ToList();
            f.cmbFood.DataSource = comida;
           // f.cmbFood.Items.Add(comida.ToString());


            if (b.image_url == null )
            {
                string url = "https://ih1.redbubble.net/image.810331421.7493/flat,750x,075,f-pad,750x1000,f8f8f8.u1.jpg";
                Console.WriteLine("NULO");
                ponerImagen(url);
            }
            else
            {
                string url = b.image_url.ToString();
                ponerImagen(url);
            }

            f.dgvIngredients.DataSource = b.ingredients.malt;
            f.dgvIngredients.Columns["amount"].Visible = false;
           
            //List<Amount> amounts = new List<Amount>();
            //foreach (var i in b.ingredients.malt)
            //{
            //    amounts.Add(i.amount);
            //}

            //f.dgvAmount.DataSource = amounts;







        }

        public void ponerImagen(string url)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);

            MemoryStream ms = new MemoryStream(bytes);
            f.pbFoto.Image = Image.FromStream(ms);
        }
        public void ponerImagenTitulo(string url)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);

            MemoryStream ms = new MemoryStream(bytes);
            f.pbTitulo.Image = Image.FromStream(ms);
        }

        public void DadesFiltre(string filtro)
        {
            f.dgvBeers.DataSource = rd.GetBeersName(filtro);
            if (rd.GetBeersName(filtro).Count == 0)
            {
                f.dgvIngredients.DataSource = null;
                if (f.dgvIngredients.DataSource == null)
                {
                    f.txtUnit.Text = "";
                    f.txtValue.Text = "";
                }
                f.cmbFood.Text = "";
                f.cmbFood.Enabled = false;
                f.txtTips.Text = "";
                f.txtAtenuacion.Text = "";
                f.txtBrewed.Text = "";
                f.txtDescription.Text = "";
                f.txtId.Text = "";
                f.txtLema.Text = "";
                f.txtName.Text = "";
                f.txtValueVol.Text = "";
                f.txtUnitVol.Text="";
                f.txtPh.Text = "";
              
                

            }
           
            esconderColumns();


        }
        public void DadesFiltreComida(string filtro)
        {
            f.dgvBeers.DataSource = rd.GetBeersFiltreFood(filtro);
            if (rd.GetBeersFiltreFood(filtro).Count == 0)
            {
                f.dgvIngredients.DataSource = null;
                if (f.dgvIngredients.DataSource == null)
                {
                    f.txtUnit.Text = "";
                    f.txtValue.Text = "";
                }
                f.cmbFood.Text = "";
                f.cmbFood.Enabled = false;
                f.txtTips.Text = "";
                f.txtAtenuacion.Text = "";
                f.txtBrewed.Text = "";
                f.txtDescription.Text = "";
                f.txtId.Text = "";
                f.txtLema.Text = "";
                f.txtName.Text = "";
                f.txtPh.Text = "";
                f.txtValueVol.Text = "";
                f.txtUnitVol.Text = "";



            }

            esconderColumns();


        }

        public void dadesPage2()
        {
            f.dgvBeers.DataSource = rd.GetBeersPage2();
            esconderColumns();
        }
        public void dadesPage3()
        {
            f.dgvBeers.DataSource = rd.GetBeersPage3();
            esconderColumns();
        }
        public void dadesPage4()
        {
            f.dgvBeers.DataSource = rd.GetBeersPage4();
            esconderColumns();
        }
        public void dadesPage5()
        {
            f.dgvBeers.DataSource = rd.GetBeersPage5();
            esconderColumns();
        }

        public void esconderColumns()
        {
            f.dgvBeers.Columns["id"].Visible = false;
            f.dgvBeers.Columns["description"].Visible = false;
            f.dgvBeers.Columns["ph"].Visible = false;
            f.dgvBeers.Columns["tagline"].Visible = false;
            f.dgvBeers.Columns["image_url"].Visible = false;
            f.dgvBeers.Columns["first_brewed"].Visible = false;
            f.dgvBeers.Columns["attenuation_level"].Visible = false;
            f.dgvBeers.Columns["ingredients"].Visible = false;
            f.dgvBeers.Columns["brewers_tips"].Visible = false;
            f.dgvBeers.Columns["contributed_by"].Visible = false;
            f.dgvBeers.Columns["volume"].Visible = false;
            //  f.dgvBeers.Columns["food_pairing"].Visible = false;
        }

    }
}
