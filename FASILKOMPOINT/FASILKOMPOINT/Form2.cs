//using fasilkompoint.app.context;
//using system;
//using system.collections.generic;
//using system.componentmodel;
//using system.data;
//using system.diagnostics.eventing.reader;
//using system.drawing;
//using system.linq;
//using system.text;
//using system.threading.tasks;
//using system.windows.forms;

//namespace fasilkompoint
//{
//    public partial class form2 : form
//    {
//        public string username;
//        public form2()
//        {
//            initializecomponent();
//            tabeldataskpimahasiswa.datasource = mahasiswacontext.showdataskpimahasiswa();
//            ///tabeldataskpimahasiswa.datasource = aktivitaskeikutsertaancontext.showkeikutsertaan("222410101002", 601);
//        }

//        private void form1_load(object sender, eventargs e)
//        {

//        }
//        private void tabeldataskpimahasiswa_cellcontentclick(object sender, datagridviewcelleventargs e)
//        {

//        }
//        private void searchnama_keypress(object sender, keypresseventargs e)
//        {
//            if (e.keychar == (char)keys.enter)
//            {
//                executesearch();
//                e.handled = true;
//            }
//        }
//        private void executesearch()
//        {
//            string nama = searchnama.text;
//            try
//            {
//                if (string.isnullorwhitespace(nama))
//                {
//                    tabeldataskpimahasiswa.datasource = mahasiswacontext.showdataskpimahasiswa();
//                }
//                else
//                {
//                    tabeldataskpimahasiswa.datasource = mahasiswacontext.showsearchdataskpimahasiswa(nama);
//                }
//            }
//            catch (exception ex)
//            {
//                messagebox.show("error: " + ex, "kesalahan", messageboxbuttons.ok, messageboxicon.error);
//            }
//        }
//        private void searchnama_textchanged(object sender, eventargs e)
//        {
//            if (string.isnullorwhitespace(searchnama.text))
//            {
//                tabeldataskpimahasiswa.datasource = mahasiswacontext.showdataskpimahasiswa();
//            }
//        }

//        private void buttonsearch_click(object sender, eventargs e)
//        {
//            executesearch();
//        }
//    }
//}