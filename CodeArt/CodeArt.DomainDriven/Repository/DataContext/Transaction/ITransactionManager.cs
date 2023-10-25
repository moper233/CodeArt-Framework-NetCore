using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeArt.DomainDriven
{
    public interface ITransactionManager : IDisposable
    {
        /// <summary>
        /// ��ʼ����
        /// </summary>
        void Begin();

        /// <summary>
        /// �ع�����
        /// </summary>
        void RollBack();

        /// <summary>
        /// �ύ����
        /// </summary>
        void Commit();
    }
}
