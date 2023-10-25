using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

using CodeArt;
using CodeArt.Runtime;
using CodeArt.AppSetting;

namespace CodeArt.DomainDriven
{
    /// <summary>
    /// ״̬�¼�������
    /// </summary>
    public enum StatusEventType : byte
    {
        /// <summary>
        /// �����������֮��
        /// </summary>
        Constructed = 1,

        /// <summary>
        /// ������󱻸ı��
        /// </summary>
        Changed = 2,

        /// <summary>
        /// �ύ�����������ִ�֮ǰ
        /// </summary>
        PreAdd = 3,

        /// <summary>
        /// �ύ�����������ִ�֮��
        /// ע�⣬���¼�ֻ����������ύҪ���棬����������ѱ��棬�п������ڹ�����Ԫ
        /// ��ʱ��δ�������浽�ִ���Ҫ�������Ǳ��浽�ִ�֮����¼�����Committed�汾
        /// </summary>
        Added = 4,

        /// <summary>
        /// �ύ�޸Ĳ������ִ�֮ǰ
        /// </summary>
        PreUpdate = 5,
        /// <summary>
        /// �ύ�޸Ĳ������ִ�֮��
        /// ע�⣬���¼�ֻ����������ύҪ���棬����������ѱ��棬�п������ڹ�����Ԫ
        /// ��ʱ��δ�������浽�ִ���Ҫ�������Ǳ��浽�ִ�֮����¼�����Committed�汾
        /// </summary>
        Updated = 6,

        /// <summary>
        /// �ύɾ���������ִ�֮ǰ
        /// </summary>
        PreDelete = 7,
        /// <summary>
        /// �ύɾ���������ִ�֮��
        /// ע�⣬���¼�ֻ����������ύҪ���棬����������ѱ��棬�п������ڹ�����Ԫ
        /// ��ʱ��δ�������浽�ִ���Ҫ�������Ǳ��浽�ִ�֮����¼�����Committed�汾
        /// </summary>
        Deleted = 8,


        /// <summary>
        /// ������ʵ�ύ��ǰһ��
        /// </summary>
        AddPreCommit = 9,

        /// <summary>
        /// ������ʵ�ύ���ִ������
        /// </summary>
        AddCommitted = 10,

        /// <summary>
        /// ������ʵ�ύ���ִ��޸ĵ�ǰһ��
        /// </summary>
        UpdatePreCommit = 11,

        /// <summary>
        /// ������ʵ�ύ���ִ��޸ĺ�
        /// </summary>
        UpdateCommitted = 12,

        /// <summary>
        /// ������ʵ�ύ���ִ�ɾ����
        /// </summary>
        DeletePreCommit = 13,

        /// <summary>
        /// ������ʵ�ύ���ִ�ɾ����
        /// </summary>
        DeleteCommitted = 14,

        /// <summary>
        /// ͨ�õ�״̬�¼�
        /// </summary>
        Any = 99,
    }
}