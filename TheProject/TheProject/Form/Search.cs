using EF.Data.Dao;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Search : Form
    {
        List<SearchEntity> searchList = new List<SearchEntity>();

        // test용
        List<MemberEntity> mem = new List<MemberEntity>();
        // 여기서부턴 가져온거
        //private int CurrentPage = 1;
        //int PagesCount = 1;
        //int PageRows = 20;

        //List<SearchEntity> Baselist = null;
        //BindingList<SearchEntity> Templist = null;
        // 여기까지 가져온거

        public Search()
        {
            InitializeComponent();
        }

        private List<Button> _btns = new List<Button>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNumberButtons();

            // test용
            MemberEntity member = new MemberEntity();
            member.MemberId = 1;
            member.MemberTest = 2;
            mem.Add(member);
            // 여기까지
            searchList = Dao.Search.GetList(mem);

            dgvSearchInfo.DataSource = searchList;

            // 여기 가져온거
            /*
             * Baselist = searchList;
            PagesCount = Convert.ToInt32(Math.Ceiling(Baselist.Count * 1.0 / PageRows));

            CurrentPage = 1;
            RefreshPagination();
            RebindGridForPageChange();
            */
            // 여기까지
        }
       
        // 여기는 가져온거
        /*
            /// <summary>
            /// ToolstripButton(처음으로, 앞으로, 1, 2, 3, 4, 5, 뒤로, 마지막으로)
            /// </summary>
            /// <param name="sender">
            /// <param name="e">
            private void ToolStripButtonClick(object sender, EventArgs e)
            {
                try
                {
                    ToolStripButton ToolStripButton = ((ToolStripButton)sender);

                    //Determining the current page
                    if (ToolStripButton == btnBackward)
                        CurrentPage--;
                    else if (ToolStripButton == btnForward)
                        CurrentPage++;
                    else if (ToolStripButton == btnLast)
                        CurrentPage = PagesCount;
                    else if (ToolStripButton == btnFirst)
                        CurrentPage = 1;
                    else
                        CurrentPage = Convert.ToInt32(ToolStripButton.Text, CultureInfo.InvariantCulture);

                    if (CurrentPage < 1)
                        CurrentPage = 1;
                    else if (CurrentPage > PagesCount)
                        CurrentPage = PagesCount;

                    //Rebind the Datagridview with the data.
                    RebindGridForPageChange();

                    //Change the pagiantions buttons according to page number
                    RefreshPagination();
                }
                catch (Exception) { }
            }
            

            #region Page setting
            private void RefreshPagination()
            {
                ToolStripButton[] items = new ToolStripButton[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 };

                //pageStartIndex contains the first button number of pagination.
                int pageStartIndex = 1;

                if (PagesCount > 5 && CurrentPage > 2)
                    pageStartIndex = CurrentPage - 2;

                if (PagesCount > 5 && CurrentPage > PagesCount - 2)
                    pageStartIndex = PagesCount - 4;

                for (int i = pageStartIndex; i < pageStartIndex + 5; i++)
                {
                    if (i > PagesCount)
                    {
                        items[i - pageStartIndex].Visible = false;
                    }
                    else
                    {
                        //Changing the page numbers
                        items[i - pageStartIndex].Text = i.ToString(CultureInfo.InvariantCulture);

                        //Setting the Appearance of the page number buttons
                        if (i == CurrentPage)
                        {
                            items[i - pageStartIndex].BackColor = Color.Black;
                            items[i - pageStartIndex].ForeColor = Color.White;
                        }
                        else
                        {
                            items[i - pageStartIndex].BackColor = Color.White;
                            items[i - pageStartIndex].ForeColor = Color.Black;
                        }
                    }
                }

                //Enabling or Disalbing pagination first, last, previous , next buttons
                if (CurrentPage == 1)
                    btnBackward.Enabled = btnFirst.Enabled = false;
                else
                    btnBackward.Enabled = btnFirst.Enabled = true;

                if (CurrentPage == PagesCount)
                    btnForward.Enabled = btnLast.Enabled = false;

                else
                    btnForward.Enabled = btnLast.Enabled = true;
            }
            #endregion

            #region Get data in current page
            private void RebindGridForPageChange()
            {
                //Rebinding the Datagridview with data
                int datasourcestartIndex = (CurrentPage - 1) * PageRows;
                Templist = new BindingList<contacts>();
                for (int i = datasourcestartIndex; i < datasourcestartIndex + PageRows; i++)
                {
                    if (i >= Baselist.Count)
                        break;

                    Templist.Add(Baselist[i]);
                }

                dataGridView1.DataSource = Templist;
                dataGridView1.Refresh();
            }
            
        }
        */
        // 여기까지



        // 이건 나중에 DB에서 집어넣어야함
        int MaxNum = 7;

        private void TestBtn(object sender, EventArgs e)
        {
            Button selectBtn = (Button)sender;
            int selectNum = Convert.ToInt32(selectBtn.Text);

            if (selectNum > 1 && selectBtn.Name == "firstPageBtn")
            {
                foreach (Button button in _btns)
                {
                    if (button.Name == "btn1" || button.Name == "btn2" || button.Name == "btn3")
                    {
                        button.BackColor = SystemColors.Control;
                        continue;
                    }
                    else if (button.Name == "centerPageBtn")
                    {
                        button.Text = Convert.ToString(selectNum);
                        button.BackColor = Color.DeepSkyBlue;
                    }
                    else if (button.Name == "lastPageBtn")
                    {
                        button.BackColor = SystemColors.Control;
                        button.Text = Convert.ToString(selectNum + 1);
                    }
                    selectBtn.Text = Convert.ToString(selectNum - 1);

                }
            }
            else if (selectNum > 1 && selectBtn.Name == "centerPageBtn")
            {
                foreach (Button button in _btns)
                {
                    button.BackColor = SystemColors.Control;
                }
                selectBtn.BackColor = Color.DeepSkyBlue;
            }
            else if (selectNum > 2 && selectBtn.Name == "lastPageBtn")
            {
                if (selectNum == MaxNum)
                {
                    foreach (Button button in _btns)
                    {
                        button.BackColor = SystemColors.Control;
                    }
                    selectBtn.BackColor = Color.DeepSkyBlue;
                }
                else if (selectNum < MaxNum)
                {
                    foreach (Button button in _btns)
                    {
                        if (button.Name == "btn1" || button.Name == "btn2" || button.Name == "btn3")
                        {
                            button.BackColor = SystemColors.Control;
                            continue;
                        }
                        else if (button.Name == "centerPageBtn")
                        {
                            button.Text = Convert.ToString(selectNum);
                            button.BackColor = Color.DeepSkyBlue;
                        }
                        else if (button.Name == "firstPageBtn")
                        {
                            button.BackColor = SystemColors.Control;
                            button.Text = Convert.ToString(selectNum - 1);
                        }
                        selectBtn.Text = Convert.ToString(selectNum + 1);

                    }
                }
            }
            else if (selectNum == 1)
            {
                foreach (Button button in _btns)
                {
                    button.BackColor = SystemColors.Control;
                }
                selectBtn.BackColor = Color.DeepSkyBlue;
            }
        }


        private void LoadNumberButtons()
        {
            Type type = GetType();
            FieldInfo[] fieldInfos =
            type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var info in fieldInfos)
            {
                Button button = info.GetValue(this) as Button;
                if (button == null)
                    continue;

                _btns.Add(button);
            }
        }


    }
}
