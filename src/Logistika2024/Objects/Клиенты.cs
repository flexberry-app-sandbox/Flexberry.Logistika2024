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
    /// Клиенты.
    /// </summary>
    // *** Start programmer edit section *** (Клиенты CustomAttributes)

    // *** End programmer edit section *** (Клиенты CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КлиентыE", new string[] {
            "Заказчик as \'Заказчик\'",
            "Телефон as \'Телефон\'",
            "АдресПоставки as \'Адрес поставки\'"})]
    [View("КлиентыL", new string[] {
            "Заказчик as \'Заказчик\'",
            "Телефон as \'Телефон\'",
            "АдресПоставки as \'Адрес поставки\'"})]
    public class Клиенты : ICSSoft.STORMNET.DataObject
    {
        
        private string fЗаказчик;
        
        private int fТелефон;
        
        private string fАдресПоставки;
        
        // *** Start programmer edit section *** (Клиенты CustomMembers)

        // *** End programmer edit section *** (Клиенты CustomMembers)

        
        /// <summary>
        /// АдресПоставки.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.АдресПоставки CustomAttributes)

        // *** End programmer edit section *** (Клиенты.АдресПоставки CustomAttributes)
        [StrLen(255)]
        public virtual string АдресПоставки
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.АдресПоставки Get start)

                // *** End programmer edit section *** (Клиенты.АдресПоставки Get start)
                string result = this.fАдресПоставки;
                // *** Start programmer edit section *** (Клиенты.АдресПоставки Get end)

                // *** End programmer edit section *** (Клиенты.АдресПоставки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.АдресПоставки Set start)

                // *** End programmer edit section *** (Клиенты.АдресПоставки Set start)
                this.fАдресПоставки = value;
                // *** Start programmer edit section *** (Клиенты.АдресПоставки Set end)

                // *** End programmer edit section *** (Клиенты.АдресПоставки Set end)
            }
        }
        
        /// <summary>
        /// Заказчик.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Заказчик CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Заказчик CustomAttributes)
        [StrLen(255)]
        public virtual string Заказчик
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Заказчик Get start)

                // *** End programmer edit section *** (Клиенты.Заказчик Get start)
                string result = this.fЗаказчик;
                // *** Start programmer edit section *** (Клиенты.Заказчик Get end)

                // *** End programmer edit section *** (Клиенты.Заказчик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Заказчик Set start)

                // *** End programmer edit section *** (Клиенты.Заказчик Set start)
                this.fЗаказчик = value;
                // *** Start programmer edit section *** (Клиенты.Заказчик Set end)

                // *** End programmer edit section *** (Клиенты.Заказчик Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Телефон CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Телефон CustomAttributes)
        public virtual int Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Get start)

                // *** End programmer edit section *** (Клиенты.Телефон Get start)
                int result = this.fТелефон;
                // *** Start programmer edit section *** (Клиенты.Телефон Get end)

                // *** End programmer edit section *** (Клиенты.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Set start)

                // *** End programmer edit section *** (Клиенты.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Клиенты.Телефон Set end)

                // *** End programmer edit section *** (Клиенты.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КлиентыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыE", typeof(IIS.Logistika2024.Клиенты));
                }
            }
            
            /// <summary>
            /// "КлиентыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыL", typeof(IIS.Logistika2024.Клиенты));
                }
            }
        }
    }
}
