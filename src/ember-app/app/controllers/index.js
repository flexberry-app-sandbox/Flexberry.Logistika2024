import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.caption'),
          title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.title'),
          children: [{
            link: 'i-i-s-logistika2024-контейнеры-l',
            caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-контейнеры-l.caption'),
            title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-контейнеры-l.title'),
            icon: 'file',
            children: null
          }, {
            link: 'i-i-s-logistika2024-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-сотрудники-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-logistika2024-организация-l',
            caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-организация-l.caption'),
            title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-организация-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-logistika2024-баржи-l',
            caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-баржи-l.caption'),
            title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-баржи-l.title'),
            icon: 'building',
            children: null
          }, {
            link: 'i-i-s-logistika2024-клиенты-l',
            caption: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-клиенты-l.caption'),
            title: i18n.t('forms.application.sitemap.данные-об-организации-и-ее-компонентах.i-i-s-logistika2024-клиенты-l.title'),
            icon: 'building',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.документация.caption'),
          title: i18n.t('forms.application.sitemap.документация.title'),
          children: [{
            link: 'i-i-s-logistika2024-докум-постав-l',
            caption: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-докум-постав-l.caption'),
            title: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-докум-постав-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-logistika2024-загруз-контейн-l',
            caption: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-загруз-контейн-l.caption'),
            title: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-загруз-контейн-l.title'),
            icon: 'folder',
            children: null
          }, {
            link: 'i-i-s-logistika2024-загрузка-баржи-l',
            caption: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-загрузка-баржи-l.caption'),
            title: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-загрузка-баржи-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-logistika2024-докум-результ-п-l',
            caption: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-докум-результ-п-l.caption'),
            title: i18n.t('forms.application.sitemap.документация.i-i-s-logistika2024-докум-результ-п-l.title'),
            icon: 'suitcase',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.номенклатура.caption'),
          title: i18n.t('forms.application.sitemap.номенклатура.title'),
          children: [{
            link: 'i-i-s-logistika2024-груз-l',
            caption: i18n.t('forms.application.sitemap.номенклатура.i-i-s-logistika2024-груз-l.caption'),
            title: i18n.t('forms.application.sitemap.номенклатура.i-i-s-logistika2024-груз-l.title'),
            icon: 'briefcase',
            children: null
          }]
        }
      ]
    };
  }),
})