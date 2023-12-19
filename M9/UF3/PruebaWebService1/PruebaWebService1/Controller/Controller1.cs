using PruebaWebService1.Model;
using PruebaWebService1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWebService1.Controller
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
            f.dgvBooks.DataSource = r.GetBooks();

            f.dgvCharacters.DataSource = r.GetCharacters();

            f.dgvHouses.DataSource = r.GetHouses();
        }

        void InitListeners()
        {
            f.dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            Book book = f.dgvBooks.CurrentRow.DataBoundItem as Book;

            f.cbBooks.DataSource = book.authors.ToList();
            f.cbCharacters.DataSource = book.characters.ToList();
        }
    }
}
