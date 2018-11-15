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
        /// ��ʼ��������
        /// PathName ��MarkEzd.dll���ڵ�Ŀ¼
        /// </summary>     
        [DllImport("MarkEzd", EntryPoint = "lmc1_Initial2", CharSet= CharSet.Unicode,CallingConvention = CallingConvention.StdCall)]
        public static extern int Initialize(string PathName,bool bTestMode);

        /// <summary>
        /// �ͷź�����
        /// </summary>     
        [DllImport("MarkEzd", EntryPoint = "lmc1_Close",CharSet= CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Close();

        /// <summary>
        /// �õ��豸�������öԻ���  
        /// </summary> 
        [DllImport("MarkEzd", EntryPoint = "lmc1_SetDevCfg", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDevCfg();

        /// <summary>
        /// ����ezd�ļ�����ǰ���ݿ�����,������ɵ����ݿ�
        /// </summary>   
        [DllImport("MarkEzd", EntryPoint = "lmc1_LoadEzdFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadEzdFile(string FileName);


        /// <summary>
        /// ǿ��ֹͣ���  
        /// </summary>   
        [DllImport("MarkEzd", EntryPoint = "lmc1_StopMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int StopMark();

        #region ����

        /// <summary>
        /// �����������
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferClear", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferClear();


        /// <summary>
        /// ��ȡ�ӹ���������������
        /// </summary>
        /// <param name="nTotalMarkCount"></param>
        /// <param name="nBufferLeftCount"></param>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferFlyGetParam", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferFlyGetParam(ref int nTotalMarkCount, ref int nBufferLeftCount);

        /// <summary>
        /// ������ɱ�־
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferPartFinish", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferPartFinish();

        /// <summary>
        /// ���ӻ���
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
        /// ���û����������
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
        /// ��������ӹ�
        /// </summary>
        /// <returns></returns>
        [DllImport("MarkEzd", EntryPoint = "lmc1_ContinueBufferFlyStart", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ContinueBufferFlyStart();


        #endregion

        #region Ԥ��

         [DllImport("gdi32.dll")]
        internal static extern bool DeleteObject(IntPtr hObject);

        [DllImport("MarkEzd", EntryPoint = "lmc1_GetPrevBitmap2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurPrevBitmap(int bmpwidth, int bmpheight);

        /// <summary>
        /// �õ���ǰ���ݿ��������ݵ�Ԥ��ͼƬ
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
