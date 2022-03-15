using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form7a : Form
    {
        public static Form7a instance;
        public Form7a()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
