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
    /// Загруз контейн.
    /// </summary>
    // *** Start programmer edit section *** (ЗагрузКонтейн CustomAttributes)

    // *** End programmer edit section *** (ЗагрузКонтейн CustomAttributes)
    [AutoAltered()]
    [Caption("Загрузка контейнеров")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗагрузКонтейнE", new string[] {
            "Дата as \'Дата загрузки контейнеров\'",
            "НомерДокЗагк as \'Номер документа загрузки контейнеров\'",
            "Сотрудники as \'Ответственный\'",
            "Сотрудники.ФИОСотруд as \'Ответственный\'",
            "Контейнеры as \'Номер контейнера\'",
            "Контейнеры.НомерКонтей as \'Номер контейнера\'",
            "Контейнеры.Объем as \'Объем контейнера\'",
            "ОбъемСвобод as \'Свободный объем контейнера\'",
            "Контейнеры.МаксВес as \'Максимальный вес контейнера\'",
            "ОстатокПоВесу as \'Остаток по весу контейнера\'"}, Hidden=new string[] {
            "Сотрудники.ФИОСотруд",
            "Контейнеры.НомерКонтей"})]
    [AssociatedDetailViewAttribute("ЗагрузКонтейнE", "ТЧИнфОГрузе", "ТЧИнфОГрузеE", true, "", "Информация о грузе", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЗагрузКонтейнE", "Сотрудники", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИОСотруд")]
    [MasterViewDefineAttribute("ЗагрузКонтейнE", "Контейнеры", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НомерКонтей")]
    [View("ЗагрузКонтейнL", new string[] {
            "Дата as \'Дата загрузки контейнеров\'",
            "НомерДокЗагк as \'Номер документа загрузки контейнеров\'",
            "Сотрудники.ФИОСотруд as \'Ответственный\'",
            "Контейнеры.НомерКонтей as \'Номер контейнера\'",
            "Контейнеры.Объем as \'Объем контейнера\'",
            "ОбъемСвобод as \'Свободный объем контейнера\'",
            "Контейнеры.МаксВес as \'Максимальный вес\'",
            "ОстатокПоВесу as \'Остаток по весу контейнера\'"})]
    public class ЗагрузКонтейн : ICSSoft.STORMNET.DataObject
    {
        
        private double fОбъемСвобод;
        
        private double fОстатокПоВесу;
        
        private System.DateTime fДата;
        
        private int fНомерДокЗагк;
        
        private IIS.Logistika2024.Контейнеры fКонтейнеры;
        
        private IIS.Logistika2024.Сотрудники fСотрудники;
        
        private IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе fТЧИнфОГрузе;
        
        // *** Start programmer edit section *** (ЗагрузКонтейн CustomMembers)

        // *** End programmer edit section *** (ЗагрузКонтейн CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.Дата CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Дата Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Дата Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Дата Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Дата Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Дата Set end)
            }
        }
        
        /// <summary>
        /// НомерДокЗагк.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк CustomAttributes)
        public virtual int НомерДокЗагк
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Get start)
                int result = this.fНомерДокЗагк;
                // *** Start programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Set start)
                this.fНомерДокЗагк = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.НомерДокЗагк Set end)
            }
        }
        
        /// <summary>
        /// ОбъемСвобод.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод CustomAttributes)
        public virtual double ОбъемСвобод
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Get start)
                double result = this.fОбъемСвобод;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Set start)
                this.fОбъемСвобод = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОбъемСвобод Set end)
            }
        }
        
        /// <summary>
        /// ОстатокПоВесу.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу CustomAttributes)
        public virtual double ОстатокПоВесу
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Get start)
                double result = this.fОстатокПоВесу;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Set start)
                this.fОстатокПоВесу = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ОстатокПоВесу Set end)
            }
        }
        
        /// <summary>
        /// Загруз контейн.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.Контейнеры CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.Контейнеры CustomAttributes)
        [PropertyStorage(new string[] {
                "Контейнеры"})]
        [NotNull()]
        public virtual IIS.Logistika2024.Контейнеры Контейнеры
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Контейнеры Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Контейнеры Get start)
                IIS.Logistika2024.Контейнеры result = this.fКонтейнеры;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Контейнеры Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Контейнеры Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Контейнеры Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Контейнеры Set start)
                this.fКонтейнеры = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Контейнеры Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Контейнеры Set end)
            }
        }
        
        /// <summary>
        /// Загруз контейн.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.Сотрудники CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.Сотрудники CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудники"})]
        [NotNull()]
        public virtual IIS.Logistika2024.Сотрудники Сотрудники
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Сотрудники Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Сотрудники Get start)
                IIS.Logistika2024.Сотрудники result = this.fСотрудники;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Сотрудники Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Сотрудники Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.Сотрудники Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.Сотрудники Set start)
                this.fСотрудники = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.Сотрудники Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.Сотрудники Set end)
            }
        }
        
        /// <summary>
        /// Загруз контейн.
        /// </summary>
        // *** Start programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе CustomAttributes)

        // *** End programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе CustomAttributes)
        public virtual IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе ТЧИнфОГрузе
        {
            get
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Get start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Get start)
                if ((this.fТЧИнфОГрузе == null))
                {
                    this.fТЧИнфОГрузе = new IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе(this);
                }
                IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе result = this.fТЧИнфОГрузе;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Get end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Set start)

                // *** End programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Set start)
                this.fТЧИнфОГрузе = value;
                // *** Start programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Set end)

                // *** End programmer edit section *** (ЗагрузКонтейн.ТЧИнфОГрузе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗагрузКонтейнE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗагрузКонтейнE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗагрузКонтейнE", typeof(IIS.Logistika2024.ЗагрузКонтейн));
                }
            }
            
            /// <summary>
            /// "ЗагрузКонтейнL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗагрузКонтейнL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗагрузКонтейнL", typeof(IIS.Logistika2024.ЗагрузКонтейн));
                }
            }
        }
    }
}
