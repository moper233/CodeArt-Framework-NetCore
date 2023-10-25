using System;
using System.Threading;

namespace CodeArt.AppSetting
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppSession : IDisposable
    {
        /// <summary>
        /// ָʾ�ػ��Ƿ��ʼ��
        /// </summary>
        bool Initialized { get; }

        /// <summary>
        /// ��ʼ��Ӧ�ûػ���������.net framework�ײ㼼������Լ�����ǲ��ò���ʹ�ûػ�֮ǰ��ʼ��һ�Σ�
        /// </summary>
        void Initialize();

        object GetItem(string name);

        void SetItem(string name, object value);

        bool ContainsItem(string name);
    }
}
