﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DAO;

namespace AppQuanlyKho_PM1
{
    public partial class FormSupply : Form
    {
        BindingSource pList = new BindingSource();
        public FormSupply()
        {

            InitializeComponent();

            LoadSupply();
        }

        void LoadSupply()
        {
            string query = "select * from Supply";

            dtgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvSupplier.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }
    }
}
