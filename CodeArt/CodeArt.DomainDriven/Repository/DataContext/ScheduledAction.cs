using CodeArt.Concurrent;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeArt.DomainDriven
{
    /// <summary>
    /// 
    /// </summary>
    internal class ScheduledAction
    {
        public IAggregateRoot Target
        {
            get;
            private set;
        }

        public ScheduledActionType Type
        {
            get;
            private set;
        }

        /// <summary>
        /// ��ʾָ��target��ӳ������
        /// ����̳���ɵ�Ӱ��
        /// </summary>
        public IPersistRepository Repository
        {
            get;
            private set;
        }

        public bool Expired
        {
            get;
            private set;
        }

        private ScheduledAction()
        {

        }

        /// <summary>
        /// ��ʾ����Ϊ�ѹ��ڣ�Ҳ������ִ�й���
        /// </summary>
        public void MarkExpired(bool expired = true)
        {
            this.Expired = expired;
        }

        /// <summary>
        /// �̶�������֤
        /// </summary>
        /// <returns></returns>
        public ValidationResult Validate()
        {
            return this.Target.Validate();
        }


        #region �����

        private static PoolWrapper<ScheduledAction> _pool;


        public static ScheduledAction Borrow(IAggregateRoot target, IPersistRepository repository, ScheduledActionType type)
        {
            var action = _pool.Borrow();
            action.Target = target;
            action.Repository = repository;
            action.Type = type;
            action.Expired = false;
            return action;
        }

        public static void Return(ScheduledAction action)
        {
            _pool.Return(action);
        }

        static ScheduledAction()
        {
            _pool = new PoolWrapper<ScheduledAction>(() =>
            {
                return new ScheduledAction();
            }, (sa, phase) =>
            {
                return true;
            }, new PoolConfig()
            {
                MaxRemainTime = 300 //5����֮��δ��ʹ�ã����Ƴ�
            });
        }

        #endregion
    }

    public enum ScheduledActionType : byte
    {
        Create = 1,
        Delete = 2,
        Update = 3,
    }
}
