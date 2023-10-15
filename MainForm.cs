﻿using BusinessManager.ViewModels;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{
    partial class MainForm : Form
    {
        ClientViewModel ListOfClients { get; set; }
        ServicesViewModel ListOfServices { get; set; }

        //SYNCFUSION TEST
        private Button btnCreate;
        System.Windows.Forms.Label label;

        public MainForm()
        {
            InitializeComponent();

            ListOfServices = new ServicesViewModel();
            ListOfClients = new ClientViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ListOfClients.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;

            clientsDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in clientsDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            //======================================================= SYNCFUSION TEST =====================================

            btnCreate = new Button();
            label = new System.Windows.Forms.Label();

            //Label
            label.Location = new System.Drawing.Point(0, 40);
            label.Size = new System.Drawing.Size(426, 35);
            label.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please note that MS Excel Viewer or MS Excel is required to view the resultant document.";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //Button
            btnCreate.Location = new System.Drawing.Point(180, 110);
            btnCreate.Size = new System.Drawing.Size(85, 26);
            btnCreate.Text = "Create Document";
            btnCreate.Click += new EventHandler(btnCreate_Click);

            //Create Spreadsheet
            //ClientSize = new System.Drawing.Size(450, 150);
            tabPage3.Controls.Add(label);
            tabPage3.Controls.Add(btnCreate);
            Text = "Create Spreadsheet";
        }
    }
}
