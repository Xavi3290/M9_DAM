using ConsumidorWebService2.Model;
using ConsumidorWebService2.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumidorWebService2.Controller
{
    internal class Controller1
    {
        Form1 f;
        Repository r;        

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
            LoadMaquillaje();
            LoadMarca();
        }

        void LoadMaquillaje()
        {
            f.dgvMaquillaje.DataSource = r.GetMaquillajes();
            f.dgvMaquillaje.Columns["brand"].Visible = false;
            f.dgvMaquillaje.Columns["image_link"].Visible = false;
            f.dgvMaquillaje.Columns["product_type"].Visible = false;
            f.dgvMaquillaje.Columns["price"].Visible = false;
            //f.dgvMaquillaje.Columns["lag_list"].Visible = true;
        }

        void LoadMarca()
        {
            f.cbMarca.DataSource = r.GetMaquillajesBrand();
            f.cbMarca.DisplayMember = "brand";
            //f.dgvMarca.DataSource = r.GetMaquillajesBrand();
        }

        void InitListeners()
        {
            f.dgvMaquillaje.SelectionChanged += DgvMaquillaje_SelectionChanged;
            f.cbMarca.SelectedIndexChanged += CbMarca_SelectedIndexChanged;
            f.bFiltrar.Click += BFiltrar_Click;
        }

        private void CbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            String marca = f.cbMarca.SelectedItem as String;
            f.dgvGenteMarca.DataSource = r.GetMaquillajeBrandGente(marca);
            f.dgvGenteMarca.Columns["image_link"].Visible = false;
            f.dgvGenteMarca.Columns["product_type"].Visible = false;
            f.dgvGenteMarca.Columns["product_type"].Visible = false;
            f.dgvGenteMarca.Columns["price"].Visible = false;

            f.tbPrecio.Text = "";
            f.tbMarca.Text = marca;

            ProductColors pc = new ProductColors("", "");
            List<ProductColors> lisPro = new List<ProductColors>();
            lisPro.Add(pc);
            maquillaje ma = new maquillaje("", "", "", "", "", lisPro);

            f.dgvMarcaProducto.DataSource = ma;
            f.dgvCaracteristicas.DataSource = pc;            

        }

        void LoadFiltrarMaquillaje(String nom)
        {
            f.dgvMaquillaje.DataSource = r.GetMaquillajeFiltrarNom2(nom);
            f.dgvMaquillaje.Columns["brand"].Visible = false;
            f.dgvMaquillaje.Columns["image_link"].Visible = false;
            f.dgvMaquillaje.Columns["product_type"].Visible = false;
            f.dgvMaquillaje.Columns["price"].Visible = false;
        }

        void LoadMaquillajeMarcaGente(maquillaje m)
        {
            f.dgvGenteMarca.DataSource = r.GetMaquillajeBrandGente(m.brand);
            f.dgvGenteMarca.Columns["image_link"].Visible = false;
            f.dgvGenteMarca.Columns["product_type"].Visible = false;
            f.dgvGenteMarca.Columns["product_type"].Visible = false;
            f.dgvGenteMarca.Columns["price"].Visible = false;
        }

        void LoadMaquillajeConMarcaYProducto(maquillaje m)
        {
            f.dgvMarcaProducto.DataSource = r.GetMaquillajesConMarcaYProducto(m.brand, m.product_type);
            f.dgvMarcaProducto.Columns["image_link"].Visible = false;
            f.dgvMarcaProducto.Columns["price"].Visible = false;
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
            String nom = f.tbFiltrar.Text.ToString();
            //List<maquillaje> m = r.GetMaquillajes();
            // f.dgvMaquillaje.DataSource = r.GetMaquillajeFiltrarNom(m,nom);
            LoadFiltrarMaquillaje(nom);
           
        }

        private void DgvMaquillaje_SelectionChanged(object sender, EventArgs e)
        {
            maquillaje m = new maquillaje();
            m = f.dgvMaquillaje.CurrentRow.DataBoundItem as maquillaje;    
            
            f.tbMarca.Text = m.brand.ToString();
            f.tbPrecio.Text = m.price.ToString();
            LoadMaquillajeMarcaGente(m);         
            LoadMaquillajeConMarcaYProducto(m);          
            f.dgvCaracteristicas.DataSource = m.product_colors);

            //try
            //{
            //   // WebClient wc = new WebClient();
            //  //  byte[] bytes = wc.DownloadData(m.image_link);
            //  //  MemoryStream ms = new MemoryStream(bytes);
            //    if (m.image_link != null)
            //    {
            //        // byte[] bytes = wc.DownloadData(m.image_link);
            //        // MemoryStream ms = new MemoryStream(bytes);
            //        //f.pbImagen.Image = Image.FromStream(ms);
            //        LoadImg(m.image_link);

            //    }
            //    else
            //    {

            //        // byte[] bytes = wc.DownloadData("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled.png");
            //        //MemoryStream ms = new MemoryStream(bytes);
            //        //   bytes = wc.DownloadData("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled.png");
            //        //    ms = new MemoryStream(bytes);
            //        // f.pbImagen.Image = Image.FromStream(ms);
            //        LoadImg("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled.png");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    WebClient wc = new WebClient();
            //    byte[] bytes = wc.DownloadData("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled.png");
            //    MemoryStream ms = new MemoryStream(bytes);
            //    f.pbImagen.Image = Image.FromStream(ms);                
            //}


        }

        //void LoadImg(String url)
        //{
        //    WebClient wc = new WebClient();
        //    byte[] bytes = wc.DownloadData(url);
        //    MemoryStream ms = new MemoryStream(bytes);
        //    f.pbImagen.Image = Image.FromStream(ms);
        //}
       

       
    }
}
