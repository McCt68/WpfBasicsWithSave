﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfBasicsWithSave.Models // not sure if its Model

    // Save data to a file
{
    public class SaveDataModel
    {
        // Auto probertys
        // public string FullPath { get; set; } = @"C:\First Name List.txt";
       
        public string FullPath { get; set; } = @"C:\Users\mcct\OneDrive\Skrivebord\First Name.txt";

        public string FirstNameData { get; set; }


    }
}
