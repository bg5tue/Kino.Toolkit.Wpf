﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kino.Toolkit.Wpf {
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
    internal class DomainServicesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DomainServicesResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kino.Toolkit.Wpf.DomainServices.DomainServicesResources", typeof(DomainServicesResources).Assembly);
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
        ///   查找类似 Load cannot be invoked when &apos;CanLoad&apos; is false. 的本地化字符串。
        /// </summary>
        internal static string CannotLoad {
            get {
                return ResourceManager.GetString("CannotLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This ICollectionView operation is not supported. 的本地化字符串。
        /// </summary>
        internal static string IcvNotSupported {
            get {
                return ResourceManager.GetString("IcvNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This IEditableCollectionView operation is not supported. 的本地化字符串。
        /// </summary>
        internal static string IecvNotSupported {
            get {
                return ResourceManager.GetString("IecvNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This IPagedCollectionView operation is not supported. 的本地化字符串。
        /// </summary>
        internal static string IpcvNotSupported {
            get {
                return ResourceManager.GetString("IpcvNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The source collection view must implement IEditableCollectionView. 的本地化字符串。
        /// </summary>
        internal static string MustImplementIecv {
            get {
                return ResourceManager.GetString("MustImplementIecv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The view must implement IPagedCollectionView. 的本地化字符串。
        /// </summary>
        internal static string MustImplementIpcv {
            get {
                return ResourceManager.GetString("MustImplementIpcv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 EntitySet and EntityCollection are already observable and should be bound to directly. 的本地化字符串。
        /// </summary>
        internal static string NoESorEC {
            get {
                return ResourceManager.GetString("NoESorEC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Property {0} not found on type {1}. 的本地化字符串。
        /// </summary>
        internal static string PropertyNotFound {
            get {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }
    }
}