using System.Collections;

namespace _31.Words_Concatinate
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adding a new item

            string word = txtWord.Text;
            var leftComboBoxItems = cbxLeft.Items;
            var rightComboBoxItems = cbxRigth.Items;
            var newWords = new ArrayList();
            //TODO 1 : check if the textbox is empty
            if (word.Length == 0)
            {
                MessageBox.Show("The input must not be empty: Add a word");
            }
            //TODO 2 :check if word is already added
            else if (leftComboBoxItems.Contains(word) && rightComboBoxItems.Contains(word))
            {
                MessageBox.Show("The word is already added!");
                txtWord.Text = "";
            }
             
            else
            {
                // add the item to both of the boxes
                leftComboBoxItems.Add(word);
                rightComboBoxItems.Add(word);

                newWords.Add(word);
                MessageBox.Show("The item is Added in a comboBoxes and Collection!");
            }





      
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {

            var concateWords = new ArrayList();
           // List<String> concateWords = new List<String>();
            
         
          
            if(btnConcatenate.Text== "Concatenate")
            {
                //TODO 1 : check if all comboboxes are selected
                if (cbxLeft.SelectedItem == null || cbxRigth.SelectedItem == null)
                {
                    MessageBox.Show("Please select word in both comboboxes!");
                }

                //TODO 2 :check if the combo boxes    have same words
                else if (cbxRigth.SelectedItem == cbxLeft.SelectedItem)
                {
                    MessageBox.Show("Please select different words!");
                }
                //TODO 3 :Display the results 
                else 
                {
                    lblResult.Text = $"{cbxLeft.Text}{cbxRigth.Text}";
                    concateWords.Add(lblResult.Text);
                    MessageBox.Show("The word is added Collection!");

                }
            }
            //starting the remove operations
            else
            {
                if (rdLeft.Checked)
                {
                    cbxLeft.Items.Remove(cbxLeft.SelectedItem);
                    MessageBox.Show($"The word is removed from the left ComboBox!");
                    cbxLeft.Text = "";
                }
                if (rdRight.Checked)
                {
                    cbxLeft.Items.Remove(cbxLeft.SelectedItem);
                    MessageBox.Show("The word is removed from the right ComboBox!");
                    cbxRigth.Text = "";
                }

            }

        }

        private void rdLeft_CheckedChanged(object sender, EventArgs e)
        {

            btnConcatenate.Text = "Remove Item";

        }

        private void rdRight_CheckedChanged(object sender, EventArgs e)
        {

            btnConcatenate.Text = "Remove Item";

        }
    }
}