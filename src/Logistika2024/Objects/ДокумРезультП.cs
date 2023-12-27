﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Logistika2024
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Докум результ П.
    /// </summary>
    // *** Start programmer edit section *** (ДокумРезультП CustomAttributes)

    // *** End programmer edit section *** (ДокумРезультП CustomAttributes)
    [AutoAltered()]
    [Caption("Документ результатов поставки")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокумРезультПE", new string[] {
            "Дата as \'Дата документа результатов поставки\'",
            "ДатаПриб as \'Дата прибытия\'",
            "ДокумПостав as \'Номер документа поставки\'",
            "ДокумПостав.НомДокПостав as \'Номер документа поставки\'",
            "ДокумПостав.Клиенты.Заказчик as \'Наименование заказчика\'",
            "ДокумПостав.Клиенты.АдресПоставки as \'Адрес поставки\'"}, Hidden=new string[] {
            "ДокумПостав.НомДокПостав"})]
    [AssociatedDetailViewAttribute("ДокумРезультПE", "ТЧДостКонт", "ТЧДостКонE", true, "", "Доставленные контейнеры", true, new string[] {
            ""})]
    [AssociatedDetailViewAttribute("ДокумРезультПE", "ТЧСвобМест", "ТЧСвобМестE", true, "", "Свободное место в контейнерах", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ДокумРезультПE", "ДокумПостав", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НомДокПостав")]
    [View("ДокумРезультПL", new string[] {
            "Дата as \'Дата документа результатов поставки\'",
            "ДатаПриб as \'Дата прибытия\'",
            "ДокумПостав.НомДокПостав as \'Номер документа поставки\'",
            "ДокумПостав.Клиенты.Заказчик as \'Наименование заказчика\'",
            "ДокумПостав.Клиенты.АдресПоставки as \'Адрес поставки\'"})]
    public class ДокумРезультП : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private System.DateTime fДатаПриб;
        
        private IIS.Logistika2024.ДокумПостав fДокумПостав;
        
        private IIS.Logistika2024.DetailArrayOfТЧДостКон fТЧДостКонт;
        
        private IIS.Logistika2024.DetailArrayOfТЧСвобМест fТЧСвобМест;
        
        // *** Start programmer edit section *** (ДокумРезультП CustomMembers)

        // *** End programmer edit section *** (ДокумРезультП CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ДокумРезультП.Дата CustomAttributes)

        // *** End programmer edit section *** (ДокумРезультП.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ДокумРезультП.Дата Get start)

                // *** End programmer edit section *** (ДокумРезультП.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ДокумРезультП.Дата Get end)

                // *** End programmer edit section *** (ДокумРезультП.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумРезультП.Дата Set start)

                // *** End programmer edit section *** (ДокумРезультП.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ДокумРезультП.Дата Set end)

                // *** End programmer edit section *** (ДокумРезультП.Дата Set end)
            }
        }
        
        /// <summary>
        /// ДатаПриб.
        /// </summary>
        // *** Start programmer edit section *** (ДокумРезультП.ДатаПриб CustomAttributes)

        // *** End programmer edit section *** (ДокумРезультП.ДатаПриб CustomAttributes)
        public virtual System.DateTime ДатаПриб
        {
            get
            {
                // *** Start programmer edit section *** (ДокумРезультП.ДатаПриб Get start)

                // *** End programmer edit section *** (ДокумРезультП.ДатаПриб Get start)
                System.DateTime result = this.fДатаПриб;
                // *** Start programmer edit section *** (ДокумРезультП.ДатаПриб Get end)

                // *** End programmer edit section *** (ДокумРезультП.ДатаПриб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумРезультП.ДатаПриб Set start)

                // *** End programmer edit section *** (ДокумРезультП.ДатаПриб Set start)
                this.fДатаПриб = value;
                // *** Start programmer edit section *** (ДокумРезультП.ДатаПриб Set end)

                // *** End programmer edit section *** (ДокумРезультП.ДатаПриб Set end)
            }
        }
        
        /// <summary>
        /// Докум результ П.
        /// </summary>
        // *** Start programmer edit section *** (ДокумРезультП.ДокумПостав CustomAttributes)

        // *** End programmer edit section *** (ДокумРезультП.ДокумПостав CustomAttributes)
        [PropertyStorage(new string[] {
                "ДокумПостав"})]
        [NotNull()]
        public virtual IIS.Logistika2024.ДокумПостав ДокумПостав
        {
            get
            {
                // *** Start programmer edit section *** (ДокумРезультП.ДокумПостав Get start)

                // *** End programmer edit section *** (ДокумРезультП.ДокумПостав Get start)
                IIS.Logistika2024.ДокумПостав result = this.fДокумПостав;
                // *** Start programmer edit section *** (ДокумРезультП.ДокумПостав Get end)

                // *** End programmer edit section *** (ДокумРезультП.ДокумПостав Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумРезультП.ДокумПостав Set start)

                // *** End programmer edit section *** (ДокумРезультП.ДокумПостав Set start)
                this.fДокумПостав = value;
                // *** Start programmer edit section *** (ДокумРезультП.ДокумПостав Set end)

                // *** End programmer edit section *** (ДокумРезультП.ДокумПостав Set end)
            }
        }
        
        /// <summary>
        /// Докум результ П.
        /// </summary>
        // *** Start programmer edit section *** (ДокумРезультП.ТЧДостКонт CustomAttributes)

        // *** End programmer edit section *** (ДокумРезультП.ТЧДостКонт CustomAttributes)
        public virtual IIS.Logistika2024.DetailArrayOfТЧДостКон ТЧДостКонт
        {
            get
            {
                // *** Start programmer edit section *** (ДокумРезультП.ТЧДостКонт Get start)

                // *** End programmer edit section *** (ДокумРезультП.ТЧДостКонт Get start)
                if ((this.fТЧДостКонт == null))
                {
                    this.fТЧДостКонт = new IIS.Logistika2024.DetailArrayOfТЧДостКон(this);
                }
                IIS.Logistika2024.DetailArrayOfТЧДостКон result = this.fТЧДостКонт;
                // *** Start programmer edit section *** (ДокумРезультП.ТЧДостКонт Get end)

                // *** End programmer edit section *** (ДокумРезультП.ТЧДостКонт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумРезультП.ТЧДостКонт Set start)

                // *** End programmer edit section *** (ДокумРезультП.ТЧДостКонт Set start)
                this.fТЧДостКонт = value;
                // *** Start programmer edit section *** (ДокумРезультП.ТЧДостКонт Set end)

                // *** End programmer edit section *** (ДокумРезультП.ТЧДостКонт Set end)
            }
        }
        
        /// <summary>
        /// Докум результ П.
        /// </summary>
        // *** Start programmer edit section *** (ДокумРезультП.ТЧСвобМест CustomAttributes)

        // *** End programmer edit section *** (ДокумРезультП.ТЧСвобМест CustomAttributes)
        public virtual IIS.Logistika2024.DetailArrayOfТЧСвобМест ТЧСвобМест
        {
            get
            {
                // *** Start programmer edit section *** (ДокумРезультП.ТЧСвобМест Get start)

                // *** End programmer edit section *** (ДокумРезультП.ТЧСвобМест Get start)
                if ((this.fТЧСвобМест == null))
                {
                    this.fТЧСвобМест = new IIS.Logistika2024.DetailArrayOfТЧСвобМест(this);
                }
                IIS.Logistika2024.DetailArrayOfТЧСвобМест result = this.fТЧСвобМест;
                // *** Start programmer edit section *** (ДокумРезультП.ТЧСвобМест Get end)

                // *** End programmer edit section *** (ДокумРезультП.ТЧСвобМест Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумРезультП.ТЧСвобМест Set start)

                // *** End programmer edit section *** (ДокумРезультП.ТЧСвобМест Set start)
                this.fТЧСвобМест = value;
                // *** Start programmer edit section *** (ДокумРезультП.ТЧСвобМест Set end)

                // *** End programmer edit section *** (ДокумРезультП.ТЧСвобМест Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокумРезультПE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокумРезультПE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокумРезультПE", typeof(IIS.Logistika2024.ДокумРезультП));
                }
            }
            
            /// <summary>
            /// "ДокумРезультПL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокумРезультПL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокумРезультПL", typeof(IIS.Logistika2024.ДокумРезультП));
                }
            }
        }
    }
}
