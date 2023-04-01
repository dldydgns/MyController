using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyController
{
    public partial class Form_Games : Form
    {
        private FileIO fileIO = new FileIO();
        public Form_Games()
        {
            InitializeComponent();

            #region GameManager에 버튼 할당
            {
                CGameManager.Instance().SetElements(0, btn1);
                CGameManager.Instance().SetElements(1, btn2);
                CGameManager.Instance().SetElements(2, btn3);
                CGameManager.Instance().SetElements(3, btn4);
                CGameManager.Instance().SetElements(4, btn5);
                CGameManager.Instance().SetElements(5, btn6);
                CGameManager.Instance().SetElements(6, btn7);
                CGameManager.Instance().SetElements(7, btn8);
                CGameManager.Instance().SetElements(8, btn9);
                CGameManager.Instance().SetElements(9, btn10);
                CGameManager.Instance().SetElements(10, btn11);
                CGameManager.Instance().SetElements(11, btn12);
                CGameManager.Instance().SetElements(12, btn13);
                CGameManager.Instance().SetElements(13, btn14);
                CGameManager.Instance().SetElements(14, btn15);
                CGameManager.Instance().SetElements(15, btn16);
                CGameManager.Instance().SetElements(16, btn17);
                CGameManager.Instance().SetElements(17, btn18);
                CGameManager.Instance().SetElements(18, btn19);
                CGameManager.Instance().SetElements(19, btn20);
            }
            #endregion

            //CGameManager 이벤트
            for (int i = 0; i < CGameManager.btnlength; i++)
            {
                //공통 버튼 이벤트 추가
                CGameManager.Instance().GetBtn(i).MouseUp += Btns_Click;
            }
            
            //Loading Url
            fileIO.Read();

            //Load Image
            for (int i = 0; i < CGameManager.btnlength; i++)
            {
                String url = CGameManager.Instance().GetURL(i);
                if (url != "")
                {
                    //get icon image from URL
                    Icon ico = Icon.ExtractAssociatedIcon(url);
                    Bitmap bitmap = ico.ToBitmap();
                    Image image = new Bitmap(bitmap, new Size(50, 50));

                    CGameManager.Instance().GetBtn(i).Image = image;
                }
            }
        }

        private void Btns_Click(object sender, MouseEventArgs e)
        {
            PictureBox clickedBtn = sender as PictureBox;

            //인덱스 구하기 위한 문자열 파싱 (btnXX)
            int _idx = int.Parse(clickedBtn.Name.Substring(3)) - 1;

            String url = CGameManager.Instance().GetURL(_idx);

            //좌클릭시
            if (e.Button == MouseButtons.Left)
            {
                if (url != "")
                {
                    Process.Start(url);
                }
                else
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            CGameManager.Instance().SetURL(_idx, openFileDialog.FileName);

                            //icon to image(resized)
                            Icon ico = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                            Bitmap bitmap = ico.ToBitmap();
                            Image image = new Bitmap(bitmap, new Size(50, 50));

                            CGameManager.Instance().GetBtn(_idx).Image = image;
                            fileIO.Write();
                        }
                    }
                }
            }
            //우클릭시
            if(e.Button == MouseButtons.Right)
            {
                CGameManager.Instance().SetURL(_idx, "");
                CGameManager.Instance().GetBtn(_idx).Image = Properties.Resources.Games_DefaultImg;
                fileIO.Write();
            }
        }
    }
}
