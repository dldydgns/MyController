using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyController
{
    public class FileIO
    {
        private CGameManager gameManager = CGameManager.Instance();
        private String FileName = "MiniDB.txt";
        public void Write()
        {
            StreamWriter writer = new StreamWriter(new FileStream(FileName, FileMode.Create));
            for(int i=0; i<CGameManager.btnlength; i++)
            {
                writer.WriteLine(i.ToString() + "#" + gameManager.GetURL(i));
            }
            writer.Close();
        }

        public void Read()
        {
            var filePath = FileName;
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath, Encoding.UTF8);
                foreach (var line in lines)
                {
                    gameManager.SetElements(int.Parse(line.Split('#')[0]), line.Split('#')[1]);
                }
            }
            else
            {
                Write();
                Read();
            }
        }
    }
}
