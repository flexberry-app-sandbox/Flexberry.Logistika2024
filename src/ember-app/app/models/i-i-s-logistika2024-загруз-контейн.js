import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ЗагрузКонтейнMixin
} from '../mixins/regenerated/models/i-i-s-logistika2024-загруз-контейн';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ЗагрузКонтейнMixin, Validations, {
});

defineProjections(Model);

export default Model;
