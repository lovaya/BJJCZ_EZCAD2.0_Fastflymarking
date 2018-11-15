using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Ports;

namespace BJJCZ_Ezcad2_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 基础参数
        /// <summary>
        /// 函数返回值
        /// </summary>
        int m_nErr = 0;
        /// <summary>
        /// 是否初始化
        /// </summary>
        bool m_bIsInitial = false;
        /// <summary>
        /// 用户停止
        /// </summary>
        bool m_bUserStop = false;
        /// <summary>
        /// 本轮已经完成数量
        /// </summary>
        int m_nNowFinish = 0;
        /// <summary>
        /// 上轮加工完成累计总量
        /// </summary>
        int m_nLastTotalFinish;
        /// <summary>
        /// 加工累计完成总量，
        /// </summary>
        int m_nTotalFinish = 0;
        /// <summary>
        /// 数据库内容总量
        /// </summary>
        int m_nNeedMarkTotal = 0;
        /// <summary>
        /// 加工内容下一个更新序号
        /// </summary>
        int m_nUpdataToDLCBoardIndex = 0;
        /// <summary>
        /// 加工内容
        /// </summary>
        string[,] m_strMarkDataList = new string[100, 6];
        /// <summary>
        /// 加工记数
        /// </summary>
        int m_ntempFinish1 = 0;
        /// <summary>
        /// 连续打标中
        /// </summary>
        bool m_bFlyMarking = false;
        #endregion

        #region 窗体事件
        private void btnInitial_Click(object sender, EventArgs e)
        {
            InitialBoard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UnInitialBoard();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "Ezd files (*.ezd)|*.ezd";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (LmcDll.LoadEzdFile(dlg.FileName) != 0)
                {
                    MessageBox.Show("打开Ezd文件" + dlg.FileName + "失败!");
                }
                else
                {
                    ShowPreviewBmp();
                }
            }
        }

        private void btnSetcfg_Click(object sender, EventArgs e)
        {
            m_nErr = LmcDll.SetDevCfg();
            if(m_nErr!=0)
            {
                MessageBox.Show(m_nErr.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            m_nNeedMarkTotal = 100;//模拟100个加工数据
            for (int i = 0; i < 100; i++)
            {
                m_strMarkDataList[i, 0] = "AAAAA" + i.ToString();
                m_strMarkDataList[i, 1] = "BBBBB" + i.ToString();
                m_strMarkDataList[i, 2] = "CCCCC" + i.ToString();
                m_strMarkDataList[i, 3] = "DDDDD" + i.ToString();
                m_strMarkDataList[i, 4] = "EEEEE" + i.ToString();
                m_strMarkDataList[i, 5] = "FFFFF" + i.ToString();
            }
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnSetcfg.Enabled = false;
            timer1.Enabled = true;
            m_bUserStop = false;
            if (backgroundWorkerMark.IsBusy)
            {
                return;
            }
            backgroundWorkerMark.RunWorkerAsync();
            m_bFlyMarking = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerMark.IsBusy)
            {
                m_nErr = LmcDll.StopMark();
                if(m_nErr!=0)
                {
                    MessageBox.Show(m_nErr.ToString());
                }
            }
            btnStart.Enabled = true;
            btnSetcfg.Enabled = true;
        }
        #endregion

        #region 后台线程
        private void backgroundWorkerMark_DoWork(object sender, DoWorkEventArgs e)
        {
            m_bFlyMarking = true;
            //设置需要更新的文本对象名称
            LmcDll.ContinueBufferSetTextName("T0", "T1", "T2", "T3", "T4", "T5");
            //清除缓存
            LmcDll.ContinueBufferClear();
            //启动数据更新
            backgroundWorkerUpDataMarkData.RunWorkerAsync();
            //执行连续加工
            m_nErr= LmcDll.ContinueBufferFlyStart();
            if (m_nErr != 0)
            {
                MessageBox.Show(m_nErr.ToString());
            }
            if (m_nTotalFinish == m_nNeedMarkTotal)
            {
                btnStart.Enabled = true;
                btnSetcfg.Enabled = true;
                MessageBox.Show("加工完成");
            }
            m_bUserStop = true;
        }

        private void backgroundWorkerMark_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            m_nNowFinish = 0;
            m_nUpdataToDLCBoardIndex = m_nLastTotalFinish;
            m_bFlyMarking = false;
            m_bUserStop = true;
        }

        private void backgroundWorkerUpDataMarkData_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdataToBoard(m_strMarkDataList);
            m_nLastTotalFinish += m_nNowFinish;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //当前加工完成数量 = 上一轮完成总数+本轮已经完成数量
            m_nTotalFinish = m_nLastTotalFinish + m_nNowFinish;
            //界面显示生产总计
            textBoxNowFinishCount.Text = m_nTotalFinish.ToString();
            //界面显示打标内容
            if (m_nTotalFinish < m_nNeedMarkTotal)
            {
                textBoxT0.Text = m_strMarkDataList[m_nTotalFinish, 0];
                textBoxT1.Text = m_strMarkDataList[m_nTotalFinish, 1];
                textBoxT2.Text = m_strMarkDataList[m_nTotalFinish, 2];
                textBoxT3.Text = m_strMarkDataList[m_nTotalFinish, 3];
                textBoxT4.Text = m_strMarkDataList[m_nTotalFinish, 4];
                textBoxT5.Text = m_strMarkDataList[m_nTotalFinish, 5];
            }
        }

        #endregion

        /// <summary>
        /// 更新数据到控制卡
        /// </summary>
        /// <param name="MarkData"></param>
        private void UpdataToBoard(string[,] MarkData)
        {
            int m_nBufferCount = -1;
            int m_nTotalDataCount = MarkData.GetLength(0);
            bool m_bAddFinished = false;

            while (true)
            {
                if (m_bUserStop)
                {
                    break;
                }
                m_nErr = LmcDll.ContinueBufferFlyGetParam(ref m_ntempFinish1, ref m_nBufferCount);//得到一次加工过程中，已经完成的加工数量
                if (m_nErr != 0)
                {
                    MessageBox.Show(m_nErr.ToString());
                    break;
                }
                if (m_ntempFinish1 > m_nNowFinish)
                {
                    m_nNowFinish = m_ntempFinish1;
                }

                if (m_nNowFinish == m_nTotalDataCount)
                {//全部完成
                    break;
                }
                if (m_nBufferCount < 8)
                {   //有空间
                    if (m_nUpdataToDLCBoardIndex < m_nTotalDataCount)
                    {
                        m_nErr = LmcDll.ContinueBufferFlyAdd(6, MarkData[m_nUpdataToDLCBoardIndex, 0], MarkData[m_nUpdataToDLCBoardIndex, 1], MarkData[m_nUpdataToDLCBoardIndex, 2], MarkData[m_nUpdataToDLCBoardIndex, 3], MarkData[m_nUpdataToDLCBoardIndex, 4], MarkData[m_nUpdataToDLCBoardIndex, 5]);
                        if (m_nErr != 0)
                        {
                            MessageBox.Show(m_nErr.ToString());
                        }
                        m_nUpdataToDLCBoardIndex++;
                    }
                    else
                    {//全部填充完毕
                        if (m_bAddFinished)
                        {
                            continue;
                        }
                        else
                        {
                            m_nErr = LmcDll.ContinueBufferPartFinish();
                            if (m_nErr != 0)
                            {
                                MessageBox.Show(m_nErr.ToString());
                            }
                            m_bAddFinished = true;
                        }
                    }
                }
                System.Threading.Thread.Sleep(1);
            }
            m_ntempFinish1 = 0;
        }

        /// <summary>
        /// 刷新模板预览图
        /// </summary>
        public void ShowPreviewBmp()
        {
            int w = pictureBox1.Size.Width;
            int h = pictureBox1.Size.Height;
            if (w > h)
            {
                w = h;
            }
            else
            {
                h = w;
            }
            pictureBox1.Image = LmcDll.GetCurPreviewImage(w, h);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitialBoard()
        {
            m_nErr = LmcDll.Initialize(Application.StartupPath, false);
            if (m_nErr != 0)
            {
                MessageBox.Show("初始化失败" + m_nErr);
            }
            else
            {
                m_bIsInitial = true;
            }
        }

        /// <summary>
        /// 释放板卡，对象管理器，开发库
        /// </summary>
        private void UnInitialBoard()
        {
            m_nErr = LmcDll.Close();
            if (m_nErr != 0)
            {
                MessageBox.Show("初始化失败" + m_nErr);
            }
            else
            {
                m_bIsInitial = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
