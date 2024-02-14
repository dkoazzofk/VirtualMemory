using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class CreateArray
    {
        public int[] array { get; set; }
        public Page[] pages { get; set; } = new Page[21];
        string path = "C:\\Users\\satal\\source\\repos\\laba1\\laba1\\prog.txt";
        string signature = "VM";
        public CreateArray()
        {
            SizeArray();
        }

        public void SizeArray()
        {
            Random rand = new Random();
            if(!File.Exists(path))
            {
                StreamWriter filepath = new StreamWriter(path,false);
                filepath.WriteLine(signature);
                for(int i = 0; i < 10239 ; i++)
                {
                    filepath.WriteLine("0");
                }
                filepath.Close();
            }
            else
            {
                StreamReader filepath = new StreamReader(path, true);
                for (int j = 0; j < 20; j++)
                {
                    string[] page = new string[513];
                    for (int i = 0; i < 513; i++)
                    {
                        page[i] = filepath.ReadLine();
                    }
                    Page pageTmp = new Page(page);
                    pageTmp.rw = rand.Next(0, 1);
                    pageTmp.time = DateTime.Now;
                    pageTmp.number = j;
                    pages[j] = pageTmp;
                }
            }
        }
        public void IndexDefinition(int index)
        {
            Page page;
            foreach (Page tmp in pages)
            {
                if (tmp.number == index)
                {
                    page = tmp; break;
                }
            }
            if(page == null)
            {

            }
        }
    }
}

