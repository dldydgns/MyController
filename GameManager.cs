using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyController
{
    struct Elements
    {
        public String URL;
        public PictureBox btn;
    }

    public class CGameManager
    {
        #region 싱글톤 패턴, Instance()로 접근
        private CGameManager() { }
        private static CGameManager GameManager;
        public static CGameManager Instance()
        {
            if(GameManager == null)
            {
                GameManager = new CGameManager();
            }
            return GameManager;
        }
        #endregion
        public static int btnlength = 20;
        private Elements[] elements = new Elements[btnlength];

        #region 엘레멘트 셋팅
        public void SetElements(int _idx, PictureBox _btn, String _url)
        {
            elements[_idx].btn = _btn;
            elements[_idx].URL = _url; 
        }
        public void SetElements(int _idx, PictureBox _btn)
        {
            elements[_idx].btn = _btn;
        }

        public void SetElements(int _idx, String _url)
        {
            elements[_idx].URL = _url;
        }
        #endregion

        public String GetURL(int _idx)
        {
            return elements[_idx].URL;
        }
        public void SetURL(int _idx, String url)
        {
            elements[_idx].URL = url;
        }

        public PictureBox GetBtn(int _idx)
        {
            return elements[_idx].btn;
        }

    }
}
