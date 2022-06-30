using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOISTFINAL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.database1DataSet.Events);

        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);


            this.Close();
            Form2 form2 = new Form2();
            form2.Update();
            form2.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Update();
            form2.Show();

        }

        private void alarmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        public void playsound()
        {
            
        }
    }
}
