import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISLogistika2024БаржиLForm from './forms/i-i-s-logistika2024-баржи-l';
import IISLogistika2024ГрузLForm from './forms/i-i-s-logistika2024-груз-l';
import IISLogistika2024ДокумПоставLForm from './forms/i-i-s-logistika2024-докум-постав-l';
import IISLogistika2024ДокумРезультПLForm from './forms/i-i-s-logistika2024-докум-результ-п-l';
import IISLogistika2024ЗагрузКонтейнLForm from './forms/i-i-s-logistika2024-загруз-контейн-l';
import IISLogistika2024ЗагрузкаБаржиLForm from './forms/i-i-s-logistika2024-загрузка-баржи-l';
import IISLogistika2024КлиентыLForm from './forms/i-i-s-logistika2024-клиенты-l';
import IISLogistika2024КонтейнерыLForm from './forms/i-i-s-logistika2024-контейнеры-l';
import IISLogistika2024ОрганизацияLForm from './forms/i-i-s-logistika2024-организация-l';
import IISLogistika2024СотрудникиLForm from './forms/i-i-s-logistika2024-сотрудники-l';
import IISLogistika2024БаржиEForm from './forms/i-i-s-logistika2024-баржи-e';
import IISLogistika2024ГрузEForm from './forms/i-i-s-logistika2024-груз-e';
import IISLogistika2024ДокумПоставEForm from './forms/i-i-s-logistika2024-докум-постав-e';
import IISLogistika2024ДокумРезультПEForm from './forms/i-i-s-logistika2024-докум-результ-п-e';
import IISLogistika2024ЗагрузКонтейнEForm from './forms/i-i-s-logistika2024-загруз-контейн-e';
import IISLogistika2024ЗагрузкаБаржиEForm from './forms/i-i-s-logistika2024-загрузка-баржи-e';
import IISLogistika2024КлиентыEForm from './forms/i-i-s-logistika2024-клиенты-e';
import IISLogistika2024КонтейнерыEForm from './forms/i-i-s-logistika2024-контейнеры-e';
import IISLogistika2024ОрганизацияEForm from './forms/i-i-s-logistika2024-организация-e';
import IISLogistika2024СотрудникиEForm from './forms/i-i-s-logistika2024-сотрудники-e';
import IISLogistika2024БаржиModel from './models/i-i-s-logistika2024-баржи';
import IISLogistika2024ГрузModel from './models/i-i-s-logistika2024-груз';
import IISLogistika2024ДокумПоставModel from './models/i-i-s-logistika2024-докум-постав';
import IISLogistika2024ДокумРезультПModel from './models/i-i-s-logistika2024-докум-результ-п';
import IISLogistika2024ЗагрузКонтейнModel from './models/i-i-s-logistika2024-загруз-контейн';
import IISLogistika2024ЗагрузкаБаржиModel from './models/i-i-s-logistika2024-загрузка-баржи';
import IISLogistika2024КлиентыModel from './models/i-i-s-logistika2024-клиенты';
import IISLogistika2024КонтейнерыModel from './models/i-i-s-logistika2024-контейнеры';
import IISLogistika2024ОрганизацияModel from './models/i-i-s-logistika2024-организация';
import IISLogistika2024СотрудникиModel from './models/i-i-s-logistika2024-сотрудники';
import IISLogistika2024ТЧДостКонModel from './models/i-i-s-logistika2024-т-ч-дост-кон';
import IISLogistika2024ТЧИнфОГрузеModel from './models/i-i-s-logistika2024-т-ч-инф-о-грузе';
import IISLogistika2024ТЧИнфОЗакModel from './models/i-i-s-logistika2024-т-ч-инф-о-зак';
import IISLogistika2024ТЧИнфОКонтModel from './models/i-i-s-logistika2024-т-ч-инф-о-конт';
import IISLogistika2024ТЧРасписаниеModel from './models/i-i-s-logistika2024-т-ч-расписание';
import IISLogistika2024ТЧСвобМестModel from './models/i-i-s-logistika2024-т-ч-своб-мест';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-logistika2024-баржи': IISLogistika2024БаржиModel,
    'i-i-s-logistika2024-груз': IISLogistika2024ГрузModel,
    'i-i-s-logistika2024-докум-постав': IISLogistika2024ДокумПоставModel,
    'i-i-s-logistika2024-докум-результ-п': IISLogistika2024ДокумРезультПModel,
    'i-i-s-logistika2024-загруз-контейн': IISLogistika2024ЗагрузКонтейнModel,
    'i-i-s-logistika2024-загрузка-баржи': IISLogistika2024ЗагрузкаБаржиModel,
    'i-i-s-logistika2024-клиенты': IISLogistika2024КлиентыModel,
    'i-i-s-logistika2024-контейнеры': IISLogistika2024КонтейнерыModel,
    'i-i-s-logistika2024-организация': IISLogistika2024ОрганизацияModel,
    'i-i-s-logistika2024-сотрудники': IISLogistika2024СотрудникиModel,
    'i-i-s-logistika2024-т-ч-дост-кон': IISLogistika2024ТЧДостКонModel,
    'i-i-s-logistika2024-т-ч-инф-о-грузе': IISLogistika2024ТЧИнфОГрузеModel,
    'i-i-s-logistika2024-т-ч-инф-о-зак': IISLogistika2024ТЧИнфОЗакModel,
    'i-i-s-logistika2024-т-ч-инф-о-конт': IISLogistika2024ТЧИнфОКонтModel,
    'i-i-s-logistika2024-т-ч-расписание': IISLogistika2024ТЧРасписаниеModel,
    'i-i-s-logistika2024-т-ч-своб-мест': IISLogistika2024ТЧСвобМестModel
  },

  'application-name': 'Логистика',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Логистика',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Логистика',
          title: 'Логистика'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'данные-об-организации-и-ее-компонентах': {
          caption: 'Данные об организации и ее компонентах',
          title: 'Данные об организации и ее компонентах',
          'i-i-s-logistika2024-контейнеры-l': {
            caption: 'Контейнеры',
            title: 'Контейнеры'
          },
          'i-i-s-logistika2024-сотрудники-l': {
            caption: 'Сотрудники',
            title: 'Сотрудники'
          },
          'i-i-s-logistika2024-организация-l': {
            caption: 'Организация',
            title: 'Организация'
          },
          'i-i-s-logistika2024-баржи-l': {
            caption: 'Баржи',
            title: 'Баржи'
          },
          'i-i-s-logistika2024-клиенты-l': {
            caption: 'Клиенты',
            title: 'Клиенты'
          }
        },
        документация: {
          caption: 'Документация',
          title: 'Документация',
          'i-i-s-logistika2024-докум-постав-l': {
            caption: 'Документ поставки',
            title: 'Докум постав'
          },
          'i-i-s-logistika2024-загруз-контейн-l': {
            caption: 'Загрузка контейнера',
            title: 'Загруз контейн'
          },
          'i-i-s-logistika2024-загрузка-баржи-l': {
            caption: 'Загрузка баржи',
            title: 'Загрузка баржи'
          },
          'i-i-s-logistika2024-докум-результ-п-l': {
            caption: 'Документ результатов поставки',
            title: 'Докум результ П'
          }
        },
        номенклатура: {
          caption: 'Номенклатура',
          title: 'Номенклатура',
          'i-i-s-logistika2024-груз-l': {
            caption: 'Груз',
            title: 'Груз'
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-logistika2024-баржи-l': IISLogistika2024БаржиLForm,
    'i-i-s-logistika2024-груз-l': IISLogistika2024ГрузLForm,
    'i-i-s-logistika2024-докум-постав-l': IISLogistika2024ДокумПоставLForm,
    'i-i-s-logistika2024-докум-результ-п-l': IISLogistika2024ДокумРезультПLForm,
    'i-i-s-logistika2024-загруз-контейн-l': IISLogistika2024ЗагрузКонтейнLForm,
    'i-i-s-logistika2024-загрузка-баржи-l': IISLogistika2024ЗагрузкаБаржиLForm,
    'i-i-s-logistika2024-клиенты-l': IISLogistika2024КлиентыLForm,
    'i-i-s-logistika2024-контейнеры-l': IISLogistika2024КонтейнерыLForm,
    'i-i-s-logistika2024-организация-l': IISLogistika2024ОрганизацияLForm,
    'i-i-s-logistika2024-сотрудники-l': IISLogistika2024СотрудникиLForm,
    'i-i-s-logistika2024-баржи-e': IISLogistika2024БаржиEForm,
    'i-i-s-logistika2024-груз-e': IISLogistika2024ГрузEForm,
    'i-i-s-logistika2024-докум-постав-e': IISLogistika2024ДокумПоставEForm,
    'i-i-s-logistika2024-докум-результ-п-e': IISLogistika2024ДокумРезультПEForm,
    'i-i-s-logistika2024-загруз-контейн-e': IISLogistika2024ЗагрузКонтейнEForm,
    'i-i-s-logistika2024-загрузка-баржи-e': IISLogistika2024ЗагрузкаБаржиEForm,
    'i-i-s-logistika2024-клиенты-e': IISLogistika2024КлиентыEForm,
    'i-i-s-logistika2024-контейнеры-e': IISLogistika2024КонтейнерыEForm,
    'i-i-s-logistika2024-организация-e': IISLogistika2024ОрганизацияEForm,
    'i-i-s-logistika2024-сотрудники-e': IISLogistika2024СотрудникиEForm
  },

});

export default translations;
