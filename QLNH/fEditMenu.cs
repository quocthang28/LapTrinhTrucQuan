using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using QLNH.Components;
namespace QLNH
{
    public partial class fEditMenu : Form
    {
        Food food = new Food();
        Category category = new Category();
        public fEditMenu()
        {
            InitializeComponent();
            LoadCategory();
            btnShow.PerformClick();
        }
        bool ValidateData()
        {
            if (String.IsNullOrEmpty(tbFoodName.Text) || String.IsNullOrEmpty(tbFoodPrice.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return false;
            }
            return true;
        }
        bool CheckEmptyTables()
        {
            string query = "SELECT * FROM dbo.TableFood WHERE status = N'Có người'";
            DataTable data = DP.DataProvider.ExeQuery(query);
            return data.Rows.Count == 0;
        }
        void LoadFood()
        {
            List<Food> list = new List<Food>();
            DataTable data = DP.DataProvider.ExeQuery("SELECT * FROM dbo.Food");
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            dgvFood.DataSource = list;
        }

        void LoadCategory()
        {
            List<Category> listCategory = category.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
            dgvCategory.DataSource = listCategory;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadFood();
        }
        private void btnAddFood_Click_1(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                string name = tbFoodName.Text;
                int categoryId = (cbCategory.SelectedItem as Category).ID;
                float price = (float)Double.Parse(tbFoodPrice.Text);
                if (food.InsertFood(name, categoryId, price))
                {
                    MessageBox.Show("Thêm món thành công");
                    LoadFood();
                }
            }
        }

        private void btnEditFood_Click_1(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                string name = tbFoodName.Text;
                int categoryId = (cbCategory.SelectedItem as Category).ID;
                float price = (float)Double.Parse(tbFoodPrice.Text);
                int foodID = Convert.ToInt32(tbFoodID.Text);
                if (food.EditFood(foodID, name, categoryId, price))
                {
                    MessageBox.Show("Sửa món thành công");
                    LoadFood();
                }
            }
        }

        private void btnDeleteFood_Click_1(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (CheckEmptyTables())
                {
                    int foodID = Convert.ToInt32(tbFoodID.Text);
                    if (food.DeleteFood(foodID))
                    {
                        MessageBox.Show("Xóa món thành công");
                        LoadFood();
                    }
                }
                else
                {
                    MessageBox.Show("Tất cả bàn phải trống trước khi xóa thức ăn");
                }
            }
        }

        private void dgvFood_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbFoodID.Text = dgvFood.SelectedRows[0].Cells["ID"].Value.ToString();
            tbFoodName.Text = dgvFood.SelectedRows[0].Cells["Name"].Value.ToString();
            cbCategory.Text = category.GetCategoryNameByID((int)dgvFood.SelectedRows[0].Cells["categoryID"].Value);
            tbFoodPrice.Text = dgvFood.SelectedRows[0].Cells["Price"].Value.ToString();
        }

        //------------------------CATEGORY-------------------------
        bool CheckEmptyCategory(int cID) 
        {
            string query = "SELECT * FROM dbo.Food WHERE idCategory = " + cID;
            DataTable data = DP.DataProvider.ExeQuery(query);
            return data.Rows.Count == 0;
        }
        bool ValidateDataTable()
        {
            if (String.IsNullOrEmpty(tbNameCategory.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return false;
            }
            return true;
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDcategory.Text = dgvCategory.SelectedRows[0].Cells["ID"].Value.ToString();
            tbNameCategory.Text = dgvCategory.SelectedRows[0].Cells["Name"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e) // add category
        {
            if (ValidateDataTable())
            {
                string categoryName = tbNameCategory.Text;
                if (category.InsertCategory(categoryName))
                {
                    MessageBox.Show("Thêm danh mục thành công");
                    LoadCategory();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // update category
        {
            if (ValidateDataTable())
            {
                string categoryName = tbNameCategory.Text;
                int categoryID = Convert.ToInt32(tbIDcategory.Text);
                if (category.EditCategory(categoryName, categoryID))
                {
                    MessageBox.Show("Sửa danh mục thành công");
                    LoadCategory();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //delete category
        {
            if (ValidateDataTable())
            {
                if (CheckEmptyCategory(Convert.ToInt32(tbIDcategory.Text)))
                {
                    if (category.DeleteCategory(Convert.ToInt32(tbIDcategory.Text)))
                    {
                        MessageBox.Show("Xóa danh mục thành công");
                        LoadCategory();
                    }
                }
                else
                {
                    MessageBox.Show("Danh mục phải trống mới được phép xóa");
                }
            }
        }
    }
}
