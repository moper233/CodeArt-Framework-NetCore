using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Text;


namespace CodeArt.DomainDriven
{
    /// <summary>
    /// �ع��б�
    /// </summary>
    internal class RollbackCollection
    {
        private List<RepositoryRollbackEventArgs> _items = null;

        public RollbackCollection()
        {
            _items = new List<RepositoryRollbackEventArgs>();
        }

        public void Add(RepositoryRollbackEventArgs e)
        {
            _items.Add(e);
        }

        /// <summary>
        /// ִ�лع�
        /// </summary>
        public void Execute(IDataContext sender)
        {
            if (_items.Count == 0) return;
            foreach (var e in _items)
            {
                e.Target.OnRollback(sender, e);
                e.Repository.OnRollback(sender, e);
            }
            this.Clear();//ִ����Ϻ�����
        }

        /// <summary>
        /// ����ع��б�
        /// </summary>
        public void Clear()
        {
            _items.Clear();
        }
    }
}
