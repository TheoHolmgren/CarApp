using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {
        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
            InitListView();
            txtRegNr.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegNr.Text))
            {
                txtRegNr.Text = txtRegNr.Text.ToUpper();
                PrintData(txtRegNr.Text);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registreringsnummer",
                    "Inmatning Saknas", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Kontrollera att alla fält är ifyllda
            if (string.IsNullOrEmpty(txtRegNr.Text) || string.IsNullOrEmpty(txtMake.Text))
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else
            //Om alla fält är ifyllda så lägg till dessa i listvyn
            {
                //Lägg till bilen i listan
                Car car = new Car(txtRegNr.Text, txtMake.Text, txtModel.Text,
                    Convert.ToInt32(txtYear.Text), cbxForSale.Checked);
                AddCarToListView(car);

                //Lägg till bilen i databasen
                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till " + Convert.ToString(result)
                    + " antal bilar");

                ClearTextboxes();
                btnClear.Enabled = true;
            }
        }
         private void AddCarToListView(Car car)
        {
            ListViewItem item = CreateListViewItem(car);
            lsvCars.Items.Add(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int res = dbObject.RemoveCarRowByRegNr(lsvCars.SelectedItems[0].Text);
            MessageBox.Show("Du har tagit bort " + Convert.ToString(res) + " antal bilar från databasen");
            if (res > 0)
            {
                RemoveCarFromListView(lsvCars.SelectedItems[0]);
            }
   
        }

        private void RemoveCarFromListView(ListViewItem listViewItem)
        {
            if (lsvCars.SelectedItems.Count > 0)
            {
                var item = lsvCars.SelectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("Bilen med registreringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
            }
            btnClear.Enabled = (lsvCars.Items.Count > 0);
        }
        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lsvCars.SelectedItems.Count > 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int res = dbObject.RemoveAllCars();
            if ( res == lsvCars.Items.Count)
            {
                lsvCars.Items.Clear();
            }
            else
            {
                lsvCars.Items.Clear();
                InitListView();
            }
            txtRegNr.Focus();
        }
        /// <summary>
        /// PrintData - Hämtar data om regNr från bilregistret och fyller i de textbox:arna för Märke, Model och År
        /// </summary>
        /// <param name="regNr"> Bilens registreringsnummer med stora bokstäver (Ex "HKM788")</param>
        private void PrintData(string regNr) //gamla Printdata
        {
            // Exempel https://api.biluppgifter.se/api/v1/vehicle/regno/XNF905?api_token=ZYdERdMQ1BLgQ9DP6hwZpO7ScLeXcJUm



            string token = "ZYdERdMQ1BLgQ9DP6hwZpO7ScLeXcJUm";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");



            try
            {
                // Skapa objekt för att skicka en fråga till bilregistret
                WebRequest request = HttpWebRequest.Create(call);



                // Skapa ett svarsobjekt
                WebResponse response = request.GetResponse();



                // Läs av "the stream" som är i responsen
                StreamReader reader = new StreamReader(response.GetResponseStream());



                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);



                txtMake.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();
                txtModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();
                txtYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();



            }
            catch (Exception e)
            {
                MessageBox.Show($"Bil med registreringsnummer {regNr} kunde inte hittas\n\nMeddelande: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ListViewItem CreateListViewItem(Car car)
        {
            ListViewItem item = new ListViewItem(car.GetRegNr());
            item.SubItems.Add(car.GetMake());
            item.SubItems.Add(car.GetModel());
            item.SubItems.Add(car.GetYear().ToString());
            item.SubItems.Add(car.GetForSale() ? "Yes" : "No");
            return item;
            
        }
        private void ClearTextboxes()
        {
            txtRegNr.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            cbxForSale.Checked = false;
            txtRegNr.Focus();
        }

        private void InitListView()
        {
            List<Car> listOfCars = dbObject.GetRowsFromCars();
            foreach (var item in listOfCars)
            {
                AddCarToListView(item);
            }
        }

    }
}
