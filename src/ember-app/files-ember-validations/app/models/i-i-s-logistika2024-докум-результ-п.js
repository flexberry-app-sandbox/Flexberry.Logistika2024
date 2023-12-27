import {
  defineNamespace,
  defineProjections,
  Model as ДокумРезультПMixin
} from '../mixins/regenerated/models/i-i-s-logistika2024-докум-результ-п';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ДокумРезультПMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
