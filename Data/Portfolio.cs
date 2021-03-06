﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace DavinSys.StockReader.Data {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/Portfolio.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/Portfolio.xsd", IsNullable=false)]
    public partial class PortFolio {
        
        private Holding[] positionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Positions")]
        public Holding[] Positions {
            get {
                return this.positionsField;
            }
            set {
                this.positionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Portfolio.xsd")]
    public partial class Holding {
        
        private string tickerTextField;
        
        private TransactionType[] transactionListField;
        
        /// <remarks/>
        public string TickerText {
            get {
                return this.tickerTextField;
            }
            set {
                this.tickerTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionList")]
        public TransactionType[] TransactionList {
            get {
                return this.transactionListField;
            }
            set {
                this.transactionListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Portfolio.xsd")]
    public partial class TransactionType {
        
        private double shareCountField;
        
        private double sharePriceField;
        
        private TransactionMode actionField;
        
        private System.DateTime transactionDateField;
        
        /// <remarks/>
        public double ShareCount {
            get {
                return this.shareCountField;
            }
            set {
                this.shareCountField = value;
            }
        }
        
        /// <remarks/>
        public double SharePrice {
            get {
                return this.sharePriceField;
            }
            set {
                this.sharePriceField = value;
            }
        }
        
        /// <remarks/>
        public TransactionMode Action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/Portfolio.xsd")]
    public enum TransactionMode {
        
        /// <remarks/>
        Purchase,
        
        /// <remarks/>
        Sale,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dividend ReInv")]
        DividendReInv,
    }
}
