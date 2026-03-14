using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WINFORMS_FOOD_ORDER__POS_.Class1;
using static WINFORMS_FOOD_ORDER__POS_.Class1.auth;

namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_admindashboard : Form
    {
        auth admin = new auth();
        string adminuser { get; set; }
        public frm_admindashboard(string username)
        {
            InitializeComponent();
            adminuser = username;
            txt_username.Text = username;
            LoadProducts();
            Loadaddsom();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }

        private void btn_addimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Product Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = ofd.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Check if image is selected
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if product name and price are entered
            if (string.IsNullOrWhiteSpace(txt_productname.Text) || string.IsNullOrWhiteSpace(txt_productprice.Text))
            {
                MessageBox.Show("Please enter product name and price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ✅ Check product limit first
            if (admin.GetProductCountByAdmin(txt_username.Text) >= 10)
            {
                MessageBox.Show("You can only add up to 10 products.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop here
            }

            // Insert the product
            bool success = admin.InsertProduct(
                txt_username.Text,
                pictureBox1.Tag.ToString(), // image path
                txt_productname.Text,
                txt_productprice.Text
            );

            if (success)
            {
                MessageBox.Show("Product saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();

                // Clear fields
                pictureBox1.Image = null;
                pictureBox1.Tag = null;
                txt_productname.Clear();
                txt_productprice.Clear();
            }
            else
            {
                MessageBox.Show("Failed to save product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadProducts()
        {
            dgv_product.DataSource = null;
            dgv_product.AutoGenerateColumns = false;
            dgv_product.Columns.Clear();

            // 1. Product Number
            DataGridViewTextBoxColumn numberCol = new DataGridViewTextBoxColumn();
            numberCol.HeaderText = "No.";
            numberCol.DataPropertyName = "ProductNumber";
            dgv_product.Columns.Add(numberCol);

            // 2. Image
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.DataPropertyName = "ProductImage";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_product.Columns.Add(imgCol);

            // 3. Product Name
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Product Name";
            nameCol.DataPropertyName = "ProductName";
            dgv_product.Columns.Add(nameCol);

            // 4. Price
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.HeaderText = "Price";
            priceCol.DataPropertyName = "Productprice";
            dgv_product.Columns.Add(priceCol);

            // --- ADDING ACTION BUTTONS HERE ---

            // 5. EDIT BUTTON
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "📝";
            btnEdit.UseColumnTextForButtonValue = true;
            dgv_product.Columns.Add(btnEdit);

            // 6. DELETE BUTTON
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "🗑️";
            btnDelete.UseColumnTextForButtonValue = true;
            dgv_product.Columns.Add(btnDelete);

            // Bind Data
            dgv_product.DataSource = admin.loadproducts(adminuser);

            // Styling
            dgv_product.RowTemplate.Height = 80;
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_product.ReadOnly = true;
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on headers or invalid rows
            if (e.RowIndex < 0) return;

            // Get the product object from the clicked row
            var product = (produtlist)dgv_product.Rows[e.RowIndex].DataBoundItem;

            // 🗑️ DELETE LOGIC
            if (dgv_product.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {product.ProductName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (admin.DeleteProduct(product.ProductID, adminuser))
                    {
                        MessageBox.Show("Product removed successfully.", "Success");
                        LoadProducts(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // 📝 EDIT LOGIC
            if (dgv_product.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                string newName = Interaction.InputBox("Edit Product Name:", "Update Name", product.ProductName);
                if (string.IsNullOrWhiteSpace(newName)) return;

                string newPrice = Interaction.InputBox("Edit Product Price:", "Update Price", product.Productprice);
                if (string.IsNullOrWhiteSpace(newPrice)) return;

                string imagePath = null;

                // Ask the admin if they want to edit the product image
                DialogResult askImage = MessageBox.Show(
                    "Would you like to edit the product image?",
                    "Edit Image",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (askImage == DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Title = "Select New Product Image";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = ofd.FileName;
                    }
                }

                if (admin.UpdateProduct(product.ProductID, adminuser, newName, newPrice, imagePath))
                {
                    MessageBox.Show("Product updated successfully!", "Success");
                    LoadProducts(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgv_product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_product.Columns[e.ColumnIndex].Name == "ProductImage"
        && e.Value != null)
            {
                byte[] bytes = (byte[])e.Value;

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    e.Value = Image.FromStream(ms);
                }
            }
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            frm_managecashieraccount f = new frm_managecashieraccount(txt_username.Text);
            f.Show();
            this.Hide();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            frm_montlysales f = new frm_montlysales(txt_username.Text);

            this.Hide();      // Hide the dashboard (data stays safe)
            f.ShowDialog();   // Open Sales and wait here
            this.Show();      // When Sales is closed, Dashboard reappears with all data intact
        }

        private void frm_admindashboard_Load(object sender, EventArgs e)
        {

        }
        void Loadaddsom()
        {
            dgv_addson.DataSource = null;
            dgv_addson.AutoGenerateColumns = false;
            dgv_addson.Columns.Clear();

            // 1. Add-on Number
            DataGridViewTextBoxColumn numberCol = new DataGridViewTextBoxColumn();
            numberCol.HeaderText = "No.";
            numberCol.DataPropertyName = "AddsonNumber"; // must match your model property
            dgv_addson.Columns.Add(numberCol);

            // 2. Image
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.DataPropertyName = "AddsonImage"; // must match your model property
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_addson.Columns.Add(imgCol);

            // 3. Add-on Name
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Name";
            nameCol.DataPropertyName = "addsonName"; // must match your model property
            dgv_addson.Columns.Add(nameCol);

            // 4. Price
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.HeaderText = "Price";
            priceCol.DataPropertyName = "addsonprice"; // must match your model property
            dgv_addson.Columns.Add(priceCol);

            // 5. EDIT BUTTON
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEditAddon";
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "📝";
            btnEdit.UseColumnTextForButtonValue = true;
            dgv_addson.Columns.Add(btnEdit);

            // 6. DELETE BUTTON
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDeleteAddon";
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "🗑️";
            btnDelete.UseColumnTextForButtonValue = true;
            dgv_addson.Columns.Add(btnDelete);

            // Bind Data
            dgv_addson.DataSource = admin.loadaddson(adminuser);

            // Styling
            dgv_addson.RowTemplate.Height = 100;
            dgv_addson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_addson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_addson.ReadOnly = true;

        }

        private void dgv_addson_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_addson.Columns[e.ColumnIndex].Name == "AddsonImage"
       && e.Value != null)
            {
                byte[] bytes = (byte[])e.Value;

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    e.Value = Image.FromStream(ms);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if image is selected
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if product name and price are entered
            if (string.IsNullOrWhiteSpace(txt_productname.Text) || string.IsNullOrWhiteSpace(txt_productprice.Text))
            {
                MessageBox.Show("Please enter adds-on name and price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // ✅ Check product limit first
            if (admin.GetaddsonCountByAdmin(txt_username.Text) >= 6)
            {
                MessageBox.Show("You can only add up to 6 adds-on.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop here
            }

            // Insert the product
            bool success = admin.Insertaddson(
                txt_username.Text,
                pictureBox1.Tag.ToString(), // image path
                txt_productname.Text,
                txt_productprice.Text
            );

            if (success)
            {
                MessageBox.Show("Product saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadaddsom();

                // Clear fields
                pictureBox1.Image = null;
                pictureBox1.Tag = null;
                txt_productname.Clear();
                txt_productprice.Clear();
            }
            else
            {
                MessageBox.Show("Failed to save adds-on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_addson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on headers or invalid rows
            if (e.RowIndex < 0) return;

            // Get the add-on object from the clicked row
            var addon = (addsonlist)dgv_addson.Rows[e.RowIndex].DataBoundItem;

            // 🗑️ DELETE LOGIC
            if (dgv_addson.Columns[e.ColumnIndex].Name == "btnDeleteAddon")
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {addon.addsonName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (admin.DeleteAddson(addon.addsonID, adminuser))
                    {
                        MessageBox.Show("Add-on removed successfully.", "Success");
                        Loadaddsom(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete add-on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // 📝 EDIT LOGIC
            if (dgv_addson.Columns[e.ColumnIndex].Name == "btnEditAddon")
            {
                string newName = Interaction.InputBox("Edit Add-on Name:", "Update Name", addon.addsonName);
                if (string.IsNullOrWhiteSpace(newName)) return;

                string newPrice = Interaction.InputBox("Edit Add-on Price:", "Update Price", addon.addsonprice);
                if (string.IsNullOrWhiteSpace(newPrice)) return;

                string imagePath = null;

                // Ask the admin if they want to edit the image
                DialogResult askImage = MessageBox.Show(
                    "Would you like to edit the add-on image?",
                    "Edit Image",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (askImage == DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Title = "Select New Add-on Image";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = ofd.FileName;
                    }
                }

                if (admin.UpdateAddson(addon.addsonID, adminuser, newName, newPrice, imagePath))
                {
                    MessageBox.Show("Add-on updated successfully!", "Success");
                    Loadaddsom();
                }
                else
                {
                    MessageBox.Show("Failed to update add-on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btn_systeminfo_Click(object sender, EventArgs e)
        {
        }
    }

}
