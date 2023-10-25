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
using CodeArt.Concurrent.Sync;

namespace CodeArt.Concurrent.Pattern
{
    /// <summary>
    /// ���ظ����ӳ���Ϊ����ָ����ʱ�����ظ�������ΪҲֻ�������Ϊִ��һ�Σ�����ִ�е�ʱ�������һ�ε���Raise�������ʱ��+�ӳٵ�ʱ��
    /// </summary>
    public class NotRepeatDelayAction : IDisposable
    {
        private TimeoutMonitor _monitor;
        private int _delayMilliseconds;
        private Action _action;
        private bool _needRaise = false;

        public NotRepeatDelayAction(int delayMilliseconds, Action action)
        {
            _action = action;
            _monitor = new TimeoutMonitor(_Raise);
            _delayMilliseconds = delayMilliseconds;
        }

        public void Dispose()
        {
            _monitor.Dispose();
        }

        private void _Raise()
        {
            _needRaise = false;
            _monitor.Reset();
            _action();
        }

        /// <summary>
        /// ÿ�δ�����Ϊ���ᵼ���ڲ����¼���ʱ�䣬��ʱ�䵽�˺���Ϊ�Żᱻ����
        /// </summary>
        public void Raise()
        {
            _monitor.Reset();
            _monitor.Start(_delayMilliseconds);
            _needRaise = true;
        }

        /// <summary>
        /// ���ã�����Ҫ�������¼���������
        /// </summary>
        public void Reset()
        {
            if (_needRaise)
            {
                _needRaise = false;
                _Raise();
            }
        }

    }
}