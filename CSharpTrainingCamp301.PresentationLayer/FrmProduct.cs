using CSharpTrainingCamp301.BusinessLayer.Abstract;
using CSharpTrainingCamp301.BusinessLayer.Concrete;
using CSharpTrainingCamp301.DataAccessLayer.EntityFramework;
using System;
using System.Windows.Forms;

namespace CSharpTrainingCamp301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }
    }
}
