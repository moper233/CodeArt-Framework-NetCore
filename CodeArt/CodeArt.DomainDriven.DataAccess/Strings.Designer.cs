﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeArt.DomainDriven.DataAccess {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeArt.DomainDriven.DataAccess.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Can not delete non-AggregateRoot objects 的本地化字符串。
        /// </summary>
        internal static string CanNotDeleteNonAggregateRoot {
            get {
                return ResourceManager.GetString("CanNotDeleteNonAggregateRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The data for the {0} construct parameter {1} was not found,Please consider whether you need a custom load method 的本地化字符串。
        /// </summary>
        internal static string ConstructionParameterError {
            get {
                return ResourceManager.GetString("ConstructionParameterError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Did not find the attribute {1} definition corresponding to the constructor {0}. Please check whether the property has been marked PropertyRepositoryAttribute or how the custom constructor is loaded 的本地化字符串。
        /// </summary>
        internal static string ConstructionParameterNoProperty {
            get {
                return ResourceManager.GetString("ConstructionParameterNoProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CreateChildTable error,master {0},FieldType {1},objectType{2} 的本地化字符串。
        /// </summary>
        internal static string CreateChildTable {
            get {
                return ResourceManager.GetString("CreateChildTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CreateInheritedTable error, type {0} table type {1} 的本地化字符串。
        /// </summary>
        internal static string CreateInheritedTableError {
            get {
                return ResourceManager.GetString("CreateInheritedTableError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 When you create a member of type {0}, you must specify the object in which the attribute is located, and it is possible to construct a constructor with a constructor parameter of type {0}, resulting in a two-way construct reference 的本地化字符串。
        /// </summary>
        internal static string CreateObjectCollectionError {
            get {
                return ResourceManager.GetString("CreateObjectCollectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 In the domain design, in addition to the basic numerical type and emptyable type, all objects should inherit from the value of the object, the root object, the reference object (entity object),remote root 的本地化字符串。
        /// </summary>
        internal static string DomainObjectTypeWrong {
            get {
                return ResourceManager.GetString("DomainObjectTypeWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The data for the property {0} was not successfully loaded. Please consider whether you need custom loading 的本地化字符串。
        /// </summary>
        internal static string LoadPropertyError {
            get {
                return ResourceManager.GetString("LoadPropertyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The members of the collection are also of the collection type, and it is not recommended to develop such a complex object relationship in the domain design 的本地化字符串。
        /// </summary>
        internal static string NestedCollection {
            get {
                return ResourceManager.GetString("NestedCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No registered database agent 的本地化字符串。
        /// </summary>
        internal static string NoDatabaseAgent {
            get {
                return ResourceManager.GetString("NoDatabaseAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There is no {0} corresponding database type 的本地化字符串。
        /// </summary>
        internal static string NoDbType {
            get {
                return ResourceManager.GetString("NoDbType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No persistent operation for domain type {0} {1} 的本地化字符串。
        /// </summary>
        internal static string NoPersistentOperation {
            get {
                return ResourceManager.GetString("NoPersistentOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No query {0} 的本地化字符串。
        /// </summary>
        internal static string NoQuery {
            get {
                return ResourceManager.GetString("NoQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} is not the correct sql select query 的本地化字符串。
        /// </summary>
        internal static string NotCorrectSqlSelect {
            get {
                return ResourceManager.GetString("NotCorrectSqlSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not find DbField for type {0} 的本地化字符串。
        /// </summary>
        internal static string NotFoundDbField {
            get {
                return ResourceManager.GetString("NotFoundDbField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Did not find the {0} domain of the derived class type corresponding to the data table 的本地化字符串。
        /// </summary>
        internal static string NotFoundDerivedType {
            get {
                return ResourceManager.GetString("NotFoundDerivedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type {0} query {1} database{1} did not find the method to fill the parameters 的本地化字符串。
        /// </summary>
        internal static string NotFoundFillArguments {
            get {
                return ResourceManager.GetString("NotFoundFillArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type {0} query {1} database{1} did not find the query expression 的本地化字符串。
        /// </summary>
        internal static string NotFoundQueryExpression {
            get {
                return ResourceManager.GetString("NotFoundQueryExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Table {0} no fields {1} 的本地化字符串。
        /// </summary>
        internal static string NotFoundTableField {
            get {
                return ResourceManager.GetString("NotFoundTableField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} does not support database {1} 的本地化字符串。
        /// </summary>
        internal static string NotSupportDatabase {
            get {
                return ResourceManager.GetString("NotSupportDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Data access does not support type {0} 的本地化字符串。
        /// </summary>
        internal static string NotSupportDbType {
            get {
                return ResourceManager.GetString("NotSupportDbType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} error, does not support querying multiple properties 的本地化字符串。
        /// </summary>
        internal static string NotSupportMultipleProperties {
            get {
                return ResourceManager.GetString("NotSupportMultipleProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The page query needs to specify a sorting statement 的本地化字符串。
        /// </summary>
        internal static string PageNeedOrder {
            get {
                return ResourceManager.GetString("PageNeedOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type {0} error,Direct persistence of the object type must be IAggregateRoot or IEntityObjectPro 的本地化字符串。
        /// </summary>
        internal static string PersistentObjectError {
            get {
                return ResourceManager.GetString("PersistentObjectError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 property {0} value {1} repeated 的本地化字符串。
        /// </summary>
        internal static string PropertyValueRepeated {
            get {
                return ResourceManager.GetString("PropertyValueRepeated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Query expression &apos;{0}&apos; is malformed 的本地化字符串。
        /// </summary>
        internal static string QueryExpressionMalformed {
            get {
                return ResourceManager.GetString("QueryExpressionMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Query parameter {0} type error 的本地化字符串。
        /// </summary>
        internal static string QueryParamTypeError {
            get {
                return ResourceManager.GetString("QueryParamTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to get the id of object {0} 的本地化字符串。
        /// </summary>
        internal static string UnableGetId {
            get {
                return ResourceManager.GetString("UnableGetId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Can not load external images other than cohesive models, please customize the loading method, data path {0} 的本地化字符串。
        /// </summary>
        internal static string UnableLoadExternalObject {
            get {
                return ResourceManager.GetString("UnableLoadExternalObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unrecognized sql function {0} 的本地化字符串。
        /// </summary>
        internal static string UnrecognizedSqlFunction {
            get {
                return ResourceManager.GetString("UnrecognizedSqlFunction", resourceCulture);
            }
        }
    }
}
