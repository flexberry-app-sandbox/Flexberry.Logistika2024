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
    /// Т ч инф о грузе.
    /// </summary>
    // *** Start programmer edit section *** (ТЧИнфОГрузе CustomAttributes)

    // *** End programmer edit section *** (ТЧИнфОГрузе CustomAttributes)
    [AutoAltered()]
    [Caption("Информация о грузе")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТЧИнфОГрузеE", new string[] {
            "Груз as \'Код груза\'",
            "Груз.КодГруза as \'Код груза\'",
            "Груз.КатегорияГр as \'Категория груза\'",
            "Груз.Объем as \'Объем груза\'",
            "Груз.Масса as \'Масса груза\'"}, Hidden=new string[] {
            "Груз.КодГруза"})]
    [MasterViewDefineAttribute("ТЧИнфОГрузеE", "Груз", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "КодГруза")]
    public class ТЧИнфОГрузе : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Logistika2024.Груз fГруз;
        
        private IIS.Logistika2024.ЗагрузКонтейн fЗагрузКонтейн;
        
        // *** Start programmer edit section *** (ТЧИнфОГрузе CustomMembers)

        // *** End programmer edit section *** (ТЧИнфОГрузе CustomMembers)

        
        /// <summary>
        /// Т ч инф о грузе.
        /// </summary>
        // *** Start programmer edit section *** (ТЧИнфОГрузе.Груз CustomAttributes)

        // *** End programmer edit section *** (ТЧИнфОГрузе.Груз CustomAttributes)
        [PropertyStorage(new string[] {
                "Груз"})]
        [NotNull()]
        public virtual IIS.Logistika2024.Груз Груз
        {
            get
            {
                // *** Start programmer edit section *** (ТЧИнфОГрузе.Груз Get start)

                // *** End programmer edit section *** (ТЧИнфОГрузе.Груз Get start)
                IIS.Logistika2024.Груз result = this.fГруз;
                // *** Start programmer edit section *** (ТЧИнфОГрузе.Груз Get end)

                // *** End programmer edit section *** (ТЧИнфОГрузе.Груз Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧИнфОГрузе.Груз Set start)

                // *** End programmer edit section *** (ТЧИнфОГрузе.Груз Set start)
                this.fГруз = value;
                // *** Start programmer edit section *** (ТЧИнфОГрузе.Груз Set end)

                // *** End programmer edit section *** (ТЧИнфОГрузе.Груз Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Logistika2024.ЗагрузКонтейн.
        /// </summary>
        // *** Start programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн CustomAttributes)

        // *** End programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ЗагрузКонтейн"})]
        public virtual IIS.Logistika2024.ЗагрузКонтейн ЗагрузКонтейн
        {
            get
            {
                // *** Start programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Get start)

                // *** End programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Get start)
                IIS.Logistika2024.ЗагрузКонтейн result = this.fЗагрузКонтейн;
                // *** Start programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Get end)

                // *** End programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Set start)

                // *** End programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Set start)
                this.fЗагрузКонтейн = value;
                // *** Start programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Set end)

                // *** End programmer edit section *** (ТЧИнфОГрузе.ЗагрузКонтейн Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТЧИнфОГрузеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТЧИнфОГрузеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТЧИнфОГрузеE", typeof(IIS.Logistika2024.ТЧИнфОГрузе));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ТЧИнфОГрузе.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТЧИнфОГрузе CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТЧИнфОГрузе CustomAttributes)
    public class DetailArrayOfТЧИнфОГрузе : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе members)

        // *** End programmer edit section *** (IIS.Logistika2024.DetailArrayOfТЧИнфОГрузе members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ТЧИнфОГрузе by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ТЧИнфОГрузе.
        /// </summary>
        public DetailArrayOfТЧИнфОГрузе(IIS.Logistika2024.ЗагрузКонтейн fЗагрузКонтейн) : 
                base(typeof(ТЧИнфОГрузе), ((ICSSoft.STORMNET.DataObject)(fЗагрузКонтейн)))
        {
        }
        
        public IIS.Logistika2024.ТЧИнфОГрузе this[int index]
        {
            get
            {
                return ((IIS.Logistika2024.ТЧИнфОГрузе)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Logistika2024.ТЧИнфОГрузе dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
