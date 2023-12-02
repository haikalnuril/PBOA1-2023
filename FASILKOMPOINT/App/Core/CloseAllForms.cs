using FASILKOMPOINT.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FASILKOMPOINT.App.Core
{
    internal class CloseAllForms
    {
        public static void CloseHiddenForms()
        {
            Halaman halamanInstance = new Halaman();

            if (halamanInstance != null)
            {
                halamanInstance.Close();
            }
        }
    }
}
