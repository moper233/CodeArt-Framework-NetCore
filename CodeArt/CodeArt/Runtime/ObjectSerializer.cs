﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
 
using CodeArt.Util;

namespace CodeArt.Runtime
{
    /// <summary>
    /// 克隆对象
    /// </summary>
    public static class ObjectSerializer
    {
        public static object Clone(object obj)
        {
            if (obj == null) return null;
            var objType = obj.GetType();
            if (objType.IsValueType) return obj;//值类型直接复制
            var typeCode = Type.GetTypeCode(objType);
            if (typeCode == TypeCode.Object)
            {
                ////对象类型克隆
                //using (MemoryStream buffer = new MemoryStream())
                //{
                //    BinaryFormatter formatter = new BinaryFormatter();
                //    formatter.Serialize(buffer, obj);
                //    buffer.Position = 0;
                //    return formatter.Deserialize(buffer);
                //}

#pragma warning disable SYSLIB0011 // 类型或成员已过时
                var bf = new BinaryFormatter();
                using (var ms = new MemoryStream())
                {
#pragma warning disable SYSLIB0011 // 类型或成员已过时
                    bf.Serialize(ms, obj);//todo
#pragma warning restore SYSLIB0011 // 类型或成员已过时
                    ms.Flush();
                    return ms.ToArray();
                }
            }
            return obj;//值类型直接复制
        }
    }
}