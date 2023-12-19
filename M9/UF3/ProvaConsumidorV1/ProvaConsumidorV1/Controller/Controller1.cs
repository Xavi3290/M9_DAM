using ProvaConsumidorV1.Model;
using ProvaConsumidorV1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaConsumidorV1.Controller
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
            f.dgvCategories.DataSource = r.GetCategories();
        }


        void InitListeners()
        {
            f.buttonFiltrar.Click += ButtonFiltrar_Click;
            f.dgvCategories.SelectionChanged += DgvCategories_SelectionChanged;
            f.buttonAfegir.Click += ButtonAfegir_Click;
            f.buttonModificar.Click += ButtonModificar_Click;
            f.buttonEliminar.Click += ButtonEliminar_Click;
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category = f.dgvCategories.CurrentRow.DataBoundItem as Category;
            r.DelCategories(category.CategoryId);
            LoadData();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category = f.dgvCategories.CurrentRow.DataBoundItem as Category;
            category.CategoryName = f.textBoxNom.Text.ToString();
            r.UpdCategories(category,category.CategoryId);
            LoadData();

        }

        private void ButtonAfegir_Click(object sender, EventArgs e)
        {
            String nom = f.textBoxNom.Text.ToString();
            Category category = new Category(nom);
            r.InsCategories(category);
            LoadData();
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            Category category = new Category();
            category = f.dgvCategories.CurrentRow.DataBoundItem as Category;
            f.textBoxNom.Text = category.CategoryName;
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            String nom = f.textBoxFiltre.Text.ToString();
            f.dgvCategories.DataSource = r.GetCategories(nom);
        }
    }
}
