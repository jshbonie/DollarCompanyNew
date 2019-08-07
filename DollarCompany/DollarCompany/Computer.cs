﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarCompany
{
    enum ComputerField
    {
        PRODUCTID,
        COST,
        MANUFACTURER,
        MODEL,
        RAM_TYPE,
        RAM_SIZE,
        DISPLAYTYPE,
        SCREENSIZE,
        RESOLUTION,
        CPU_CLASS,
        CPU_BRAND,
        CPU_TYPE,
        CPU_SPEED,
        CPU_NUMBER,
        CONDITION,
        OS,
        PLATFORM,
        HDD_SIZE,
        HDD_SPEED,
        GPU_TYPE,
        OPTICAL_DRIVE,
        AUDIO_TYPE,
        LAN,
        WIFI,
        WIDTH,
        HEIGHT,
        DEPTH,
        WEIGHT,
        MOUST_TYPE,
        POWER,
        WEBCAM
    }
    public class Computer
    {
        public int productID { get; set; }
        public int cost { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string RAM_type { get; set; }
        public string RAM_size { get; set; }
        public string displaytype { get; set; }
        public string screensize { get; set; }
        public string resolution { get; set; }
        public string CPU_Class { get; set; }
        public string CPU_brand { get; set; }
        public string CPU_type { get; set; }
        public string CPU_speed { get; set; }
        public string CPU_number { get; set; }
        public string condition { get; set; }
        public string OS { get; set; }
        public string platform { get; set; }
        public string HDD_size { get; set; }
        public string HDD_speed { get; set; }
        public string GPU_type { get; set; }
        public string optical_drive { get; set; }
        public string Audio_type { get; set; }
        public string LAN { get; set; }
        public string WIFI { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string depth { get; set; }
        public string weight { get; set; }
        public string moust_type { get; set; }
        public string power { get; set; }
        public string webcam { get; set; }

    }
}
