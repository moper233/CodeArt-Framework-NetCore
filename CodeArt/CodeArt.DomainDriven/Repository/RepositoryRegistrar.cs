using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Transactions;

using CodeArt.Util;
using CodeArt.Runtime;
using CodeArt.Concurrent;

namespace CodeArt.DomainDriven
{
    /// <summary>
    /// ע��ִ�Ա
    /// </summary>
    internal static class RepositoryRegistrar
    {
        #region ��ȡ�ִ�ʵ�ֵ�����

        public static Type GetRepositoryType(Type repositoryInterfaceType)
        {
            return _getGetRepositoryType(repositoryInterfaceType);
        }

        private static Func<Type, Type> _getGetRepositoryType = LazyIndexer.Init<Type, Type>((repositoryInterfaceType) =>
        {
            var instance = GetRepository(repositoryInterfaceType);
            if (instance == null) return null;
            return instance.GetType();
        });

        #endregion

        public static object GetRepository(Type repositoryInterfaceType)
        {
            object instance = null;
            if (_singletons.TryGetValue(repositoryInterfaceType, out instance)) return instance;
            return null;
        }

        private static Dictionary<Type, object> _singletons = new Dictionary<Type, object>();

        private static object _syncObject = new object();

        /// <summary>
        /// ע�ᵥ���ִ�����ȷ��<paramref name="repository"/>�ǵ�����
        /// </summary>
        /// <typeparam name="TRepository"></typeparam>
        /// <param name="repository"></param>
        public static void Register<TRepository>(object repository)
        {
            var interfaceType = typeof(TRepository);
            if (_singletons.ContainsKey(interfaceType)) throw new DomainDrivenException("�ظ�ע��ִ�" + interfaceType.FullName);
            lock (_syncObject)
            {
                if (_singletons.ContainsKey(interfaceType)) throw new DomainDrivenException("�ظ�ע��ִ�" + interfaceType.FullName);
                if (!(repository is TRepository)) throw new TypeMismatchException(repository.GetType(), interfaceType);
                SafeAccessAttribute.CheckUp(repository);
                _singletons.Add(interfaceType, repository);
            }
        }

        /// <summary>
        /// ע���ִ�
        /// </summary>
        /// <typeparam name="TRepository"></typeparam>
        public static void Deregister<TRepository>()
        {
            var interfaceType = typeof(TRepository);
            lock (_syncObject)
            {
                _singletons.Remove(interfaceType);
            }
        }

    }
}