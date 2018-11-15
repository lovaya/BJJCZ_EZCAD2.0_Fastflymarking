using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;


namespace BJJCZ_Ezcad2_Demo
{    
    public class LmcDll
    {
        /// <summary>
        /// 初始化函数库
        /// PathName 是MarkEzd.dll所在的目录
        /// </summary>     
        [DllImport("MarkEzd", EntryPoint = "lmc1_Initial2", CharSet= CharSet.Unicode,CallingConvention = CallingConvention.StdCall)]
        public static extern int Initialize(string PathName,bool bTestMode);

        /// <summary>
        /// 释放函数库
        /// </summary>     
        [DllImport("MarkEzd", EntryPoint = "lmc1_Close",CharSet= CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Close();

        /// <summary>
        /// 得到设备参数配置对话框  
        /// </summary> 
        [DllImport("MarkEzd", EntryPoint = "lmc1_SetDevCfg", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDevCfg();

        /// <summary>
        /// 载入ezd文件到当前数据库里面,并清除旧的数据库
        /// </summary>   
        [DllImport("MarkEzd", EntryPoint = "lmc1_LoadEzdFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadEzdFile(string FileName);


        /// <summary>
        /// 强制停止标刻  
        /// </summary>   
        [DllImport("MarkEzd", EntryPoint = "lmc1_StopMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int StopMark();

        #region 飞行

        /// <summary>
        /// 清除连续缓存
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferClear", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferClear();


        /// <summary>
        /// 获取加工数量，缓存数量
        /// </summary>
        /// <param name="nTotalMarkCount"></param>
        /// <param name="nBufferLeftCount"></param>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferFlyGetParam", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferFlyGetParam(ref int nTotalMarkCount, ref int nBufferLeftCount);

        /// <summary>
        /// 数据完成标志
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferPartFinish", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferPartFinish();

        /// <summary>
        /// 增加缓存
        /// </summary>
        /// <param name="nNum"></param>
        /// <param name="Text1"></param>
        /// <param name="Text2"></param>
        /// <param name="Text3"></param>
        /// <param name="Text4"></param>
        /// <param name="Text5"></param>
        /// <param name="Text6"></param>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferFlyAdd", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferFlyAdd(int nNum, string Text1, string Text2, string Text3, string Text4, string Text5, string Text6);


        /// <summary>
        /// 设置缓存对象名称
        /// </summary>
        /// <param name="Name1"></param>
        /// <param name="Name2"></param>
        /// <param name="Name3"></param>
        /// <param name="Name4"></param>
        /// <param name="Name5"></param>
        /// <param name="Name6"></param>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferSetTextName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferSetTextName(string Name1, string Name2, string Name3, string Name4, string Name5, string Name6);


        /// <summary>
        /// 启动缓存加工
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferFlyStart", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferFlyStart();


        #endregion

        #region 预览

         [DllImport("gdi32.dll")]
        internal static extern bool DeleteObject(IntPtr hObject);

        [DllImport("MarkEzd", EntryPoint = "lmc1_GetPrevBitmap2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurPrevBitmap(int bmpwidth, int bmpheight);

        /// <summary>
        /// 得到当前数据库里面数据的预览图片
        /// </summary>  
        public static Image GetCurPreviewImage(int bmpwidth, int bmpheight)
        {
            IntPtr pBmp = GetCurPrevBitmap(bmpwidth, bmpheight);
            Image img = Image.FromHbitmap(pBmp);
            LmcDll.DeleteObject(pBmp);
            return img;
        }

        #endregion
    }
}
