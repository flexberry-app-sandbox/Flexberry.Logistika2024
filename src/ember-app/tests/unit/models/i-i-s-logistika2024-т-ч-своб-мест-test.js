import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-logistika2024-т-ч-своб-мест', 'Unit | Model | i-i-s-logistika2024-т-ч-своб-мест', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-logistika2024-баржи',
    'model:i-i-s-logistika2024-груз',
    'model:i-i-s-logistika2024-докум-постав',
    'model:i-i-s-logistika2024-докум-результ-п',
    'model:i-i-s-logistika2024-загруз-контейн',
    'model:i-i-s-logistika2024-загрузка-баржи',
    'model:i-i-s-logistika2024-клиенты',
    'model:i-i-s-logistika2024-контейнеры',
    'model:i-i-s-logistika2024-организация',
    'model:i-i-s-logistika2024-сотрудники',
    'model:i-i-s-logistika2024-т-ч-дост-кон',
    'model:i-i-s-logistika2024-т-ч-инф-о-грузе',
    'model:i-i-s-logistika2024-т-ч-инф-о-зак',
    'model:i-i-s-logistika2024-т-ч-инф-о-конт',
    'model:i-i-s-logistika2024-т-ч-расписание',
    'model:i-i-s-logistika2024-т-ч-своб-мест',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
