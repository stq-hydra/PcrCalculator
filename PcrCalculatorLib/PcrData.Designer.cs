﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcrCalculatorLib {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PcrData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PcrData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PcrCalculatorLib.PcrData", typeof(PcrData).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 国家,机场,名,时区,提前,状态
        ///埃塞俄比亚,ADD,亚的斯亚贝巴,E. Africa Standard Time,3,Y
        ///墨西哥,MEX,墨西哥城,Central Standard Time (Mexico),3,Y
        ///韩国,ICN,首尔,Korea Standard Time,3,Y
        ///韩国,CJU,济州,Korea Standard Time,3,Y
        ///马来西亚,KUL,吉隆坡,Singapore Standard Time,3,Y
        ///阿联酋,DXB,迪拜,Arabian Standard Time,3,Y
        ///阿联酋,AUH,阿布扎比,Arabian Standard Time,3,Y
        ///新加坡,SIN,新加坡,Singapore Standard Time,3,Y
        ///卡塔尔,DOH,卡塔尔,Arab Standard Time,3,Y
        ///菲律宾,MNL,马尼拉,Singapore Standard Time,3,Y
        ///伊朗,IKA,伊朗,Iran Standard Time,3,Y
        ///柬埔寨,PNH,金边,SE Asia Standard Time,3,Y
        ///柬埔寨,KOS,西哈努克,SE Asi [rest of string was truncated]&quot;;.
        /// </summary>
        public static string PCR {
            get {
                return ResourceManager.GetString("PCR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 阿联酋
        ///乌兹别克斯坦
        ///尼日利亚
        ///菲律宾
        ///新加坡
        ///沙特阿拉伯
        ///印度尼西亚
        ///塔吉克斯坦
        ///埃塞俄比亚.
        /// </summary>
        public static string UseSampleData {
            get {
                return ResourceManager.GetString("UseSampleData", resourceCulture);
            }
        }
    }
}
