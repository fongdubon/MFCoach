using MFCoach.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFCoach
{
    public partial class frmCompany : MetroFramework.Forms.MetroForm

    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            using(DataContext dataContext = new DataContext())
            {
                companyBindingSource.DataSource = dataContext.Companies.ToList();
            }
            pnlDatos.Enabled = false;
            Company company = companyBindingSource.Current as Company;
            if (company != null && company.Photo != null)
                pctPhoto.Image = Image.FromFile(company.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            companyBindingSource.Add(new Company());
            companyBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Company company = companyBindingSource.Current as Company;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            companyBindingSource.ResetBindings(false);
            frmCompany_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Company company = companyBindingSource.Current as Company;
                if (company != null)
                {
                    if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                        dataContext.Set<Company>().Attach(company);
                    if (company.Id == 0)
                        dataContext.Entry<Company>(company).State = EntityState.Added;
                    else
                        dataContext.Entry<Company>(company).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this,"Los datos de la compañia guardados");
                    grdDato.Refresh();
                    pnlDatos.Enabled = false;
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar a esta empresa?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Company company = companyBindingSource.Current as Company;
                    if (company != null)
                    {
                        if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                            dataContext.Set<Company>().Attach(company); 
                        dataContext.Entry<Company>(company).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminada");
                        companyBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void grdDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Company company = companyBindingSource.Current as Company;
            if (company != null && company.Photo != null)
                pctPhoto.Image = Image.FromFile(company.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {Filter = "archivos JPG|*.jpg|todos los archivos|*.*" 
            })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);
                    Company company = companyBindingSource.Current as Company;
                    if (company != null)
                        company.Photo = ofd.FileName;
                }
            }
            
               
           

            
        }
    }
}
