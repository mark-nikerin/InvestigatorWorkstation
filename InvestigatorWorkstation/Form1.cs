using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;

        public Form1(ILogger<Form1> logger)
        {
            _logger = logger;
            InitializeComponent();
        } 
    }
}
