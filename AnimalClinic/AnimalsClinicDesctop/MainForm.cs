using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AnimalClinicClientNamespace;

namespace AnimalsClinicDesctop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoadClient_Click(object sender, EventArgs e)
        {
            AnimalClinicClient animalClinicClient = new AnimalClinicClient("http://localhost:5234/",
            new System.Net.Http.HttpClient());  
            
            ICollection<Client> clients = animalClinicClient.GetAllAllAsync().Result;

            listViewClient.Items.Clear();

            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();

                ListViewItem.ListViewSubItem surNameItem = new ListViewItem.ListViewSubItem();
                surNameItem.Text = client.SurName;

                item.SubItems.Add(surNameItem);

                ListViewItem.ListViewSubItem nameItem = new ListViewItem.ListViewSubItem();
                nameItem.Text = client.FirstName;

                item.SubItems.Add(nameItem);

                ListViewItem.ListViewSubItem patronymicItem = new ListViewItem.ListViewSubItem();
                patronymicItem.Text = client.Patronymic;

                item.SubItems.Add(patronymicItem);


                listViewClient.Items.Add(item);
            }
           
        }
    }
}
