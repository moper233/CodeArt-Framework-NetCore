using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeArt.DomainDriven
{
    public interface ILockManager
    {
        /// <summary>
        /// �Բ��������������ʽ����ָ���ľۺϸ�����
        /// </summary>
        /// <param name="roots"></param>
        void Lock(IEnumerable<IAggregateRoot> roots);
    }
}
