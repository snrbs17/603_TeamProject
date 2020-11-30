using EF.Data.Dao;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TheProject
{
    public partial class Release : Form
    {
        // 로그인한 사용자의 id값에 맞는 정보를 가지고 와야함
        // 조인을 쓰는데 

        List<ReleaseEntity> releaseList = new List<ReleaseEntity>();
        
        // test용
        List<MemberEntity> mem = new List<MemberEntity>();


        public Release()
        {
            InitializeComponent();
        }
        public Release(List<MemberEntity> member) : base()
        {
            releaseList = Dao.Release.GetList(/*테스트용*/mem);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // test용
            MemberEntity member = new MemberEntity();
            member.MemberId = 1;
            member.MemberTest = 2;
            mem.Add(member);
            // 여기까지

            releaseList = Dao.Release.GetList(mem);

            dgvList.DataSource = releaseList;
            int listCount = releaseList.Count;
            if (listCount == 0)
            {
                releaseBtn.Text = $"맡기신 물건이 없습니다.";
            }
            else
            {
                releaseBtn.Text = $"총 {listCount} 건이 존재합니다.";
            }
        }

        private void releaseBtn_Click(object sender, EventArgs e)
        {
            if(releaseBtn.Text == $"맡기신 물건이 없습니다.")
            {
                Close();
            }
            else
            {
                // 결제폼으로
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
