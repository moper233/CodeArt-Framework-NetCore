using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Threading;

using CodeArt.DTO;
using CodeArt.Concurrent.Pattern;

namespace CodeArt.Concurrent.Pattern
{
    /// <summary>
    /// �ܵ���Ϊ�����ڵ������߳��У�����ִ��ÿ����Ϊ
    /// </summary>
    public class ActionPipeline : IDisposable
    {
        private AutoResetPipeline _pipeline;
        private ConcurrentQueue<Action> _syncActions = new ConcurrentQueue<Action>();

        public int ActionLength
        {
            get
            {
                return _syncActions.Count;
            }
        }

        public ActionPipeline()
        {
            _pipeline = new AutoResetPipeline(EventThread);
        }


        private void EventThread()
        {
            while (_syncActions.Count > 0)
            {
                Action action = null;
                if (_syncActions.TryDequeue(out action))
                {
                    action();
                }
            }
        }


        /// <summary>
        /// ���������뵽�������Ŷ�ִ��
        /// </summary>
        /// <param name="action"></param>
        public void Queue(Action action)
        {
            _syncActions.Enqueue(action);
            _pipeline.AllowOne();
        }

        public void Dispose()
        {
            try
            {
                _pipeline.Dispose();
            }
            finally
            {
                _syncActions.Clear();
            }
        }


        private static object _syncObject = new object();

        private static ActionPipeline _default = null;

        /// <summary>
        /// Ĭ�ϵĹ��ùܵ���Ϊ
        /// </summary>
        public static ActionPipeline Default
        {
            get
            {
                if(_default == null)
                {
                    lock(_syncObject)
                    {
                        if(_default == null)
                        {
                            _default = new ActionPipeline();
                        }
                    }
                }
                return _default;
            }
        }

    }
}