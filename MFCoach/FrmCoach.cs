﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MFCoach.Entities;

namespace MFCoach
{
    public partial class FrmCoach : MetroFramework.Forms.MetroForm
    {
        public FrmCoach()
        {
            InitializeComponent();
        }

        private void FrmCoach_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coachBindingSource.DataSource = dataContext.Coaches.ToList();
            }

            pnlDatos.Enabled = false;

            Coach coach = coachBindingSource.Current as Coach;

            if (coach != null && coach.Photo != null)
            {
                pctPhoto.Image = Image.FromFile(coach.Photo);
            }
            else
            {
                pctPhoto.Image = null;
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
            {
                pctPhoto.Image = Image.FromFile(coach.Photo);
            }
            else
            {
                pctPhoto.Image = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);

                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        coach.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            coachBindingSource.Add(new Coach());
            coachBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coach coach = coachBindingSource.Current as Coach;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "quieres eliminar el entrenador?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                            dataContext.Set<Coach>().Attach(coach);



                        dataContext.Entry<Coach>(coach).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "entrenador eliminado");
                        coachBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlDatos.Enabled = false;


                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            coachBindingSource.ResetBindings(false);
            FrmCoach_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coach coach = coachBindingSource.Current as Coach;
                if (coach != null)
                {
                    if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                        dataContext.Set<Coach>().Attach(coach);
                    if (coach.Id == 0)

                    {
                        dataContext.Entry<Coach>(coach).State = EntityState.Added;

                    }
                    else
                    {
                        dataContext.Entry<Coach>(coach).State = EntityState.Modified;
                    }
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "entrenador guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }
    }
}
