import { Serializer as БаржиSerializer } from
  '../mixins/regenerated/serializers/i-i-s-logistika2024-баржи';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(БаржиSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
