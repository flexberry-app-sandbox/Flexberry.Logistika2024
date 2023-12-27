import {
  defineNamespace,
  defineProjections,
  Model as ЗагрузкаБаржиMixin
} from '../mixins/regenerated/models/i-i-s-logistika2024-загрузка-баржи';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ЗагрузкаБаржиMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
