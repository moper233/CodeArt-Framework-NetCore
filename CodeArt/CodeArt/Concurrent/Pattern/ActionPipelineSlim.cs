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
    /// �򵥵Ĺܵ���Ϊ�����ᵥ�������̣߳��ڵ����س�������ִ��ÿ����Ϊ
    /// </summary>
    public class ActionPipelineSlim
    {
        private ConcurrentQueue<Action<Action>> _actions = new ConcurrentQueue<Action<Action>>();

        /// <summary>
        /// ͬ���������ܶ�����£��п��ܶ�����������첽������Ϻ����������ִ����ϣ����Ҫʹ��ͬ������
        /// </summary>
        private int _syncCount;

        public int ActionLength
        {
            get
            {
                return _actions.Count;
            }
        }

        public ActionPipelineSlim()
        {
            _syncCount = 0;
        }

        private volatile bool _locked = false;
        private object _syncObject = new object();

        /// <summary>
        /// ������<paramref name="action"/>���������ִ�У�<paramref name="action"/>��һ��������ִ�У����Ƿ������������أ�����ȴ�
        /// ����actionִ����Ϻ��������ô��ݵ�complete����
        /// </summary>
        /// <param name="action"></param>
        public void Queue(Action<Action> action)
        {
            _actions.Enqueue(action);
            TryContinue();
        }

        private void TryContinue()
        {
            if (_locked) return;
            if (_actions.TryDequeue(out var action))
            {
                _locked = true;
                action(Complete);
            }
        }

        /// <summary>
        /// �ۼ��첽���������ж���첽����ʱ����ʹ�ø÷���
        /// </summary>
        public void IncrementAsync()
        {
            Interlocked.Increment(ref _syncCount);
        }


        private void Complete()
        {
            if (_syncCount > 0)
            {
                Interlocked.Decrement(ref _syncCount);
            }

            if (_syncCount == 0)
            {
                _locked = false;
                TryContinue();
            }
        }
    }
}