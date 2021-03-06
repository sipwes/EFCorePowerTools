﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFCorePowerTools {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EFCorePowerTools.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die SQLite/SQL Server Compact Toolbox ähnelt.
        /// </summary>
        internal static string App {
            get {
                return ResourceManager.GetString("App", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Integer (whole number) data from –2^63 (–9,223,372,036,854,775,808) through 2^63–1 (9,223,372,036,854,775,807).
        ///Storage size is 8 bytes. ähnelt.
        /// </summary>
        internal static string bigint {
            get {
                return ResourceManager.GetString("bigint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Fixed-length binary data with a maximum length of 8000 bytes. Default length = 1.
        ///Storage size is fixed, which is the length in bytes declared in the type. ähnelt.
        /// </summary>
        internal static string binary {
            get {
                return ResourceManager.GetString("binary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Integer data with a value of either 1 or 0.
        ///Storage size is 1 bit. ähnelt.
        /// </summary>
        internal static string bit {
            get {
                return ResourceManager.GetString("bit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Can not create tool window. ähnelt.
        /// </summary>
        internal static string CanNotCreateWindow {
            get {
                return ResourceManager.GetString("CanNotCreateWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die using System;
        ///using System.Data.SqlServerCe;
        ///using System.Text;
        ///
        ///public class MergeReplication
        ///{
        ///    public static void Synchronize()
        ///    {
        ///        SqlCeReplication repl = new SqlCeReplication();  
        ///
        ///#ReplParams#
        ///        try
        ///        {
        ///            repl.AddSubscription(AddOption.ExistingDatabase);
        ///            repl.Synchronize();
        ///        }
        ///        catch (SqlCeException e)
        ///        {
        ///            Console.WriteLine(ShowErrors(e));
        ///        }
        ///    }
        ///
        ///    private static string ShowErrors(SqlCeExce [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string ClassTemplateCsharp {
            get {
                return ResourceManager.GetString("ClassTemplateCsharp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Date and time data from January 1, 1753, to December 31, 9999, with an accuracy of one three-hundredth second, or 3.33 milliseconds. Values are rounded to increments of .000, .003, or .007 milliseconds. 
        ///Stored as two 4-byte integers. 
        ///The first 4 bytes store the number of days before or after the base date , January 1, 1900. The base date is the system&apos;s reference date. 
        ///Values for datetime earlier than January 1, 1753, are not permitted. The other 4 bytes store the time of day represented as the number [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string datetime {
            get {
                return ResourceManager.GetString("datetime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Floating point number data from –1.79E +308 through 1.79E+308.
        ///Storage size is 8 bytes. ähnelt.
        /// </summary>
        internal static string floating {
            get {
                return ResourceManager.GetString("floating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Variable-length binary data with a maximum length of 2^30–1 (1,073,741,823) bytes.
        ///Storage is the length of the value in bytes. ähnelt.
        /// </summary>
        internal static string image {
            get {
                return ResourceManager.GetString("image", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Integer (whole number) data from –2^31 (–2,147,483,648) through 2^31–1 (2,147,483,647).
        ///Storage size is 4 bytes. ähnelt.
        /// </summary>
        internal static string integer {
            get {
                return ResourceManager.GetString("integer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Monetary data values from (–2^63/10000) (–922,337,203,685,477.5808) through 2^63–1 (922,337,203,685,477.5807), with accuracy to a ten-thousandth of a monetary unit.
        ///Storage size is 8 bytes ähnelt.
        /// </summary>
        internal static string money {
            get {
                return ResourceManager.GetString("money", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Fixed-length Unicode data with a maximum length of 4000 characters. Default length = 1.
        ///Storage size, in bytes, is two times the number of characters entered. ähnelt.
        /// </summary>
        internal static string nchar {
            get {
                return ResourceManager.GetString("nchar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 70ba90f8-3027-4aF1-9b15-37abbd48744c ähnelt.
        /// </summary>
        internal static string NpgsqlProvider {
            get {
                return ResourceManager.GetString("NpgsqlProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Variable-length Unicode data with a maximum length of (2^30–2)/2 (536,870,911) characters.
        ///Storage size, in bytes, is two times the number of characters entered. ähnelt.
        /// </summary>
        internal static string ntext {
            get {
                return ResourceManager.GetString("ntext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Fixed-precision and scale-numeric data from –10^38+1 through 10^38–1. The p variable specifies precision and can vary between 1 and 38. The s variable specifies scale and can vary between 0 and p.
        ///Storage size is 19 bytes. ähnelt.
        /// </summary>
        internal static string numeric {
            get {
                return ResourceManager.GetString("numeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Variable-length Unicode data with a length of 1 to 4000 characters. Default length = 1.
        ///Storage size, in bytes, is two times the number of characters entered. ähnelt.
        /// </summary>
        internal static string nvarchar {
            get {
                return ResourceManager.GetString("nvarchar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Floating precision number data from –3.40E+38 through 3.40E+38.
        ///Storage size is 4 bytes. ähnelt.
        /// </summary>
        internal static string real {
            get {
                return ResourceManager.GetString("real", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die This is an automatically generated unique binary number.*
        ///Storage size is 8 bytes. ähnelt.
        /// </summary>
        internal static string rowversion {
            get {
                return ResourceManager.GetString("rowversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Integer data from –32,768 to 32,767.
        ///Storage size is 2 bytes. ähnelt.
        /// </summary>
        internal static string smallint {
            get {
                return ResourceManager.GetString("smallint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die System.Data.SqlServerCe.3.5 ähnelt.
        /// </summary>
        internal static string SqlCompact35InvariantName {
            get {
                return ResourceManager.GetString("SqlCompact35InvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 7c602b5b-accb-4acd-9dc0-ca66388c1533 ähnelt.
        /// </summary>
        internal static string SqlCompact35Provider {
            get {
                return ResourceManager.GetString("SqlCompact35Provider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die System.Data.SQLite.EF6 ähnelt.
        /// </summary>
        internal static string SQLiteEF6InvariantName {
            get {
                return ResourceManager.GetString("SQLiteEF6InvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die System.Data.SQLite ähnelt.
        /// </summary>
        internal static string SQLiteInvariantName {
            get {
                return ResourceManager.GetString("SQLiteInvariantName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die 91510608-8809-4020-8897-fba057e22d54 ähnelt.
        /// </summary>
        internal static string SqlServerDotNetProvider {
            get {
                return ResourceManager.GetString("SqlServerDotNetProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Integer data from 0 to 255. 
        ///Storage size is 1 byte. ähnelt.
        /// </summary>
        internal static string tinyint {
            get {
                return ResourceManager.GetString("tinyint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SQLite/SQL Server Compact Toolbox ähnelt.
        /// </summary>
        internal static string ToolWindowTitle {
            get {
                return ResourceManager.GetString("ToolWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die A globally unique identifier (GUID).
        ///Storage size is 16 bytes. ähnelt.
        /// </summary>
        internal static string uniqueidentifier {
            get {
                return ResourceManager.GetString("uniqueidentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Variable-length binary data with a maximum length of 8000 bytes. Default length = 1. 
        ///Storage size varies. It is the length of the value in bytes. ähnelt.
        /// </summary>
        internal static string varbinary {
            get {
                return ResourceManager.GetString("varbinary", resourceCulture);
            }
        }
    }
}
