﻿using EF.Data.Dao;
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

        // GetList에서 써야하는데 query문에서 그냥 entity로는 안됐는데
        // List로 하니깐 먹혀서 우선은 이걸로
        List<MemberEntity> memList = new List<MemberEntity>();
        List<SearchEntity> onBtnClickViewList = new List<SearchEntity>();


        public Search()
        {
            InitializeComponent();
        }
        // todo 메인이랑 연결되면 풀어줘야함
        //public Search(MemberEntity memberInfo) : base()
        //{
        //    memList.Add(memberInfo);
        //}

        private List<Button> _btns = new List<Button>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNumberButtons();

            // test용
            MemberEntity member = new MemberEntity();
            member.MemberId = 1;
            member.MemberTest = 2;
            memList.Add(member);
            // 여기까지

            searchList = Dao.Search.GetPresentList(memList);
            if (searchList.Count <5)
            {
                onBtnClickViewList = searchList.GetRange(0, searchList.Count);

            }
            else
            {
                onBtnClickViewList = searchList.GetRange(0, 5);
            }

            dgvSearchInfo.DataSource = onBtnClickViewList;

        }


        // 이건 나중에 DB에서 집어넣어야함


        private void TestBtn(object sender, EventArgs e)
        {
            Button selectBtn = (Button)sender;
            int selectNum = Convert.ToInt32(selectBtn.Text);

            int startNum = (selectNum - 1) * 5;
            int maxNum = searchList.Count / 5;

            onBtnClickViewList = null;
            onBtnClickViewList = searchList.GetRange(startNum, 5);

            dgvSearchInfo.DataSource = onBtnClickViewList;


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
                if (selectNum == maxNum)
                {
                    foreach (Button button in _btns)
                    {
                        button.BackColor = SystemColors.Control;
                    }
                    selectBtn.BackColor = Color.DeepSkyBlue;
                }
                else if (selectNum < maxNum)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        // todo Search
        // 1. 남은시간
        // 2. 5개씩 보여지고 버튼에 맞춰서 넘어갈 수 있게
    }
}
