using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Core
{
    internal class CloseAllForms
    {
        public static void CloseHiddenForms(Form currentForm)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != currentForm && !form.Visible)
                {
                    formsToClose.Add(form);
                }
            }
            foreach (Form formToClose in formsToClose)
            {
                formToClose.Close();
            }
        }
    }
}
